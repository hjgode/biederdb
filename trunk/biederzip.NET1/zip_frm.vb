Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class zip_frm
	Inherits System.Windows.Forms.Form
	
	Private Sub bt_add_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_add.Click
		If Text1.Text = "" Then Exit Sub
		If List1.SelectedIndex = -1 Then
			List1.Items.Add(Text1.Text)
		Else
			List1.Items.Insert(List1.SelectedIndex + 1, Text1.Text)
			List1.SelectedIndex = List1.SelectedIndex + 1
		End If
	End Sub
	
	Private Sub bt_autofill_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_autofill.Click
		'Dim db As Database
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		List1.Items.Clear()
		List1.Items.Add((datenbank))
		'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		List1.Items.Add((webroot + "\*.*"))
		List1.Items.Add((My.Application.Info.DirectoryPath & "\*.*"))
		'UPGRADE_WARNING: Arrays in structure VList may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
		Dim VList As DAO.Dynaset
		'Set db = OpenDatabase(datenbank, False, False)
		On Error Resume Next
		db.Execute(("Drop table VList;"))
		On Error GoTo 0
		db.Execute(("SELECT DISTINCT FOTO INTO VList FROM Artikel where Besteld>0"))
		VList = db.CreateDynaset("SELECT FOTO FROM VList order by FOTO")
		VList.MoveLast()
		VList.MoveFirst()
		Dim i, t As Object
		For i = 0 To VList.RecordCount - 1
			If Len(VList.Fields("Foto").Value) > 0 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object t. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = GetPfad(VList.Fields("Foto").Value)
				VList.Edit()
				'UPGRADE_WARNING: Couldn't resolve default property of object t. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				VList.Fields("FOTO").Value = t
				VList.Update()
			End If
			VList.MoveNext()
		Next i
		VList = db.CreateDynaset("SELECT DISTINCT FOTO FROM VList order by FOTO")
		VList.MoveLast()
		VList.MoveFirst()
		For i = 0 To VList.RecordCount - 1
			If Len(VList.Fields("Foto").Value) > 0 Then List1.Items.Add(VList.Fields("Foto").Value + "*.*")
			VList.MoveNext()
		Next i
		VList.Close()
		Cursor = System.Windows.Forms.Cursors.Default
		db.Close()
	End Sub
	
	Private Sub bt_back_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_back.Click
		If MsgBox("BiderZip wird nun beendet und BiederDB gestartet!", MsgBoxStyle.OKCancel Or MsgBoxStyle.Exclamation) = MsgBoxResult.OK Then
			Shell(AppPath & "\biederdb.exe", AppWinStyle.NormalFocus)
			End
		End If
	End Sub
	
	Private Sub bt_change_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_change.Click
		Dim old As Object
		If List1.SelectedIndex = -1 Then
			Beep()
			Exit Sub
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object old. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		old = List1.SelectedIndex
		Text1.Text = VB6.GetItemString(List1, List1.SelectedIndex)
		List1.Items.RemoveAt((List1.SelectedIndex))
		'UPGRADE_WARNING: Couldn't resolve default property of object old. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If List1.Items.Count > 0 Then List1.SelectedIndex = old - 1
	End Sub
	
	Private Sub bt_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_close.Click
		Me.Close()
	End Sub
	
	Private Sub bt_remove_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_remove.Click
		If List1.SelectedIndex = -1 Or List1.Items.Count = 0 Then
			Beep()
			Exit Sub
		End If
		Dim old As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object old. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		old = List1.SelectedIndex
		List1.Items.RemoveAt((old))
		'UPGRADE_WARNING: Couldn't resolve default property of object old. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If List1.Items.Count > 0 Then List1.SelectedIndex = old - 1
	End Sub
	
	Private Sub bt_restore_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_restore.Click
		Dim ant As Short
		ant = MsgBox("Alle neueren Dateien/Verzeichnisse aus der Sicherungsdatei " & Text3.Text & " jetzt wiederherstellen?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Dateien wiederherstellen")
		If ant = MsgBoxResult.No Then Exit Sub
		' Set up unzipping object
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		Me.Enabled = False
		System.Windows.Forms.Application.DoEvents()
		Dim Files As New Collection
		Dim path As String
		Dim r As Integer
		'Extract the files
		'Add all files
		Files.Add("*.*")
		
		'Check extract dir exists
		'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(txtExtractTo.Text, FileAttribute.Directory) = "" Then
			MsgBox(txtExtractTo.Text & " existiert nicht!", MsgBoxStyle.Critical, "Zielverzeichnis existiert nicht!")
			Exit Sub
		End If
		
		path = txtExtractTo.Text
		'Now extract all the files
		'opt_onlynewer will be 1 for zipFreshen, 0 for zipDefault
		
		r = vbzip.Extract(Files, opt_onlynewer.CheckState, CBool(-1), CBool(-opt_overwrite.CheckState), path)
		Cursor = System.Windows.Forms.Cursors.Default
		Me.Enabled = True
		Me.Activate()
	End Sub
	
	Private Sub bt_search_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_search.Click
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With CommonDialog1
			'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Open.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.CheckFileExists = True
			.CheckPathExists = True
			.CheckPathExists = True
			'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "Alle Dateien (*.*)|*.*"
			.FileName = My.Application.Info.DirectoryPath & "\*.*"
			'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(Text1.Text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.InitialDirectory = GetPfad(Text1.Text)
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			On Error GoTo FileError
		End With
		CommonDialog1Open.ShowDialog()
		CommonDialog1Save.FileName = CommonDialog1Open.FileName
		Text1.Text = CommonDialog1Open.FileName
		Exit Sub
FileError: 
		On Error GoTo 0
	End Sub
	
	Private Sub bt_suchdir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_suchdir.Click
		Dim temp As String
		Dim startpfad As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		startpfad = Text1.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		temp = BrowseForFolder(Me, "Verzeichnis auswählen", startpfad)
		If Len(temp) > 0 Then
			If VB.Right(temp, 1) <> "\" Then temp = temp & "\"
			Text1.Text = temp & "*.*"
		End If
	End Sub
	
	Private Sub bt_targetdir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_targetdir.Click
		txtExtractTo_DoubleClick(txtExtractTo, New System.EventArgs())
	End Sub
	Private Sub bt_zip_start_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_zip_start.Click
		Dim ant As Short
		ant = MsgBox("Alle in der Liste aufgeführten Dateien/Verzeichnisse jetzt sichern?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Backup erstellen")
		If ant = MsgBoxResult.No Then Exit Sub
		Me.Enabled = False
		System.Windows.Forms.Application.DoEvents()
		Cursor = System.Windows.Forms.Cursors.WaitCursor
		Dim Files As New Collection
		Dim i As Integer
		Dim UsePathInfo As Boolean
		Dim Use83Format As Boolean
		
		vbzip.Filename = Text2.Text
		'Start the process
		'First check if there is something to do
		If List1.Items.Count < 1 Then
			MsgBox("There is nothing to do!", MsgBoxStyle.Information, My.Application.Info.ProductName)
			Exit Sub
		End If
		
		'Set the files to process
		For i = 0 To List1.Items.Count - 1
			Files.Add(VB6.GetItemString(List1, i))
		Next i
		
		UsePathInfo = True
		Use83Format = False
		
		'Start the processing
		vbzip.add(Files, biederzip_mod.ZipAction.zipDefault, UsePathInfo, False, Use83Format, biederzip_mod.ZipLevel.zipFast)
		Cursor = System.Windows.Forms.Cursors.Default
		MsgBox("Alle Dateien gesichert. Die Backup-Datei >" & Text2.Text & "< nun auf eine CD brennen und diese dann auf dem Zielsystem zum Wiederherstellen benutzen.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Exclamation, "Hinweis")
		Me.Enabled = True
		Me.Activate()
	End Sub
	
	Private Sub bt_zipfilename_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_zipfilename.Click
		Text2_DoubleClick(Text2, New System.EventArgs())
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Text3_DoubleClick(Text3, New System.EventArgs())
	End Sub
	
	Private Sub zip_frm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		read_zoptions()
		List1.Items.Clear()
		Dim f As Object
		Dim temp As String
		If existfile(My.Application.Info.DirectoryPath & "\ziplist.txt") Then
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			f = FreeFile
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileOpen(f, My.Application.Info.DirectoryPath & "\ziplist.txt", OpenMode.Input)
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			While Not EOF(f)
				'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				temp = LineInput(f)
				List1.Items.Add((temp))
			End While
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileClose(f)
		End If
		vbzip.Filename = Text2.Text
	End Sub
	
	Private Sub zip_frm_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		Dim f As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, My.Application.Info.DirectoryPath & "\ziplist.txt", OpenMode.Output)
		Dim i As Object
		For i = 0 To List1.Items.Count - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			PrintLine(f, VB6.GetItemString(List1, i))
		Next i
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(f)
		write_zoptions()
	End Sub
	
	Private Sub lvwArchive_ColumnClick(ByVal eventSender As System.Object, ByVal eventArgs As AxComctlLib.ListViewEvents_ColumnClickEvent) Handles lvwArchive.ColumnClick
		'Sort by the column clicked
		lvwArchive.Sorted = True
		lvwArchive.SortKey = eventArgs.ColumnHeader.Index - 1
		
	End Sub
	
	Private Sub Text2_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text2.DoubleClick
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With CommonDialog1
			'UPGRADE_ISSUE: Constant cdlOFNNoReadOnlyReturn was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.Flags = MSComDlg.FileOpenConstants.cdlOFNNoReadOnlyReturn
			'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Save.OverwritePrompt which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.OverwritePrompt = True
			.CheckPathExists = True
			.CheckPathExists = True
			'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "ZIP-Dateien (*.zip)|*.zip|Alle Dateien (*.*)|*.*"
			.FileName = Text2.Text
			'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(Text2.Text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.InitialDirectory = GetPfad(Text2.Text)
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			On Error GoTo FileError1
		End With
		CommonDialog1Save.ShowDialog()
		CommonDialog1Open.FileName = CommonDialog1Save.FileName
		Text2.Text = CommonDialog1Open.FileName
		Exit Sub
FileError1: 
		On Error GoTo 0
	End Sub
	
	Private Sub Text3_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text3.DoubleClick
		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
		With CommonDialog1
			'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Open.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
			.CheckFileExists = True
			.CheckPathExists = True
			.CheckPathExists = True
			'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
			'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
			.Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
			'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			.Filter = "ZIP-Dateien (*.zip)|*.zip|Alle Dateien (*.*)|*.*"
			.FileName = Text3.Text
			'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(Text3.Text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			.InitialDirectory = GetPfad(Text3.Text)
			'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
			.CancelError = True
			On Error GoTo FileError3
		End With
		CommonDialog1Open.ShowDialog()
		CommonDialog1Save.FileName = CommonDialog1Open.FileName
		Text3.Text = CommonDialog1Open.FileName
		Exit Sub
FileError3: 
		On Error GoTo 0
		
	End Sub
	
	Private Sub txtExtractTo_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtExtractTo.DoubleClick
		Dim temp As String
		Dim startpfad As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		startpfad = txtExtractTo.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		temp = BrowseForFolder(Me, "Verzeichnis auswählen", startpfad)
		If Len(temp) > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			startpfad = temp
			txtExtractTo.Text = temp
		End If
	End Sub
	Sub read_zoptions()
		Dim f, opt As Object
		If existfile(My.Application.Info.DirectoryPath & "\zoptions.txt") Then
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			f = FreeFile
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileOpen(f, My.Application.Info.DirectoryPath & "\zoptions.txt", OpenMode.Input)
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			opt = LineInput(f)
			'UPGRADE_WARNING: Couldn't resolve default property of object opt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Text2.Text = opt
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			opt = LineInput(f)
			'UPGRADE_WARNING: Couldn't resolve default property of object opt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Text3.Text = opt
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			opt = LineInput(f)
			'UPGRADE_WARNING: Couldn't resolve default property of object opt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtExtractTo.Text = opt
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			opt = LineInput(f)
			'UPGRADE_WARNING: Couldn't resolve default property of object opt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			opt_onlynewer.CheckState = Val(opt)
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			opt = LineInput(f)
			'UPGRADE_WARNING: Couldn't resolve default property of object opt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			opt_overwrite.CheckState = Val(opt)
			'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileClose(f)
		Else
			write_zoptions()
		End If
	End Sub
	Sub write_zoptions()
		Dim f, opt As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, My.Application.Info.DirectoryPath & "\zoptions.txt", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, Text2.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, Text3.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, txtExtractTo.Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, opt_onlynewer.CheckState)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, opt_overwrite.CheckState)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(f)
	End Sub
	
	Private Sub VBZip_OnArchiveUpdate(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles VBZip.OnArchiveUpdate
		Exit Sub
		'Fill the listview with the archives contents
		Dim itmX As ComctlLib.ListItem
		Dim i As Integer
		Dim Entry As VBZip_Control.ZipFileEntry
		Dim TotalSize As Integer
		
		'Clear the list
		lvwArchive.ListItems.Clear()
		lvwArchive.ListItems.add()
		'Loop thought the entries, updating the listview
		'missing any blank entries
		With vbzip
			For i = 1 To .GetEntryNum
				Entry = .GetEntry(i)
				If Entry.Filename <> "" Then
					itmX = lvwArchive.ListItems.add( ,  , .ParseFilename(Entry.Filename),  , 1)
					itmX.SubItems(1) = Entry.FileDateTime
					itmX.SubItems(2) = VB6.Format(Entry.UncompressedSize, "###,###")
					itmX.SubItems(3) = VB6.Format(Entry.CompressedSize, "###,###")
					'Trap division by zero
					If Entry.UncompressedSize <> 0 Then
						itmX.SubItems(4) = VB6.Format(CShort((1 - (Entry.CompressedSize / Entry.UncompressedSize)) * 100)) & "%"
					Else
						itmX.SubItems(4) = "0%"
					End If
					itmX.SubItems(5) = .ParsePath((Entry.Filename))
					'Save the item number for other operations
					itmX.Tag = i
					TotalSize = TotalSize + Entry.UncompressedSize
				End If
			Next i
			
			lblFiles.Text = CStr(lvwArchive.ListItems.Count) & " file(s), " & vbzip.ConvertBytesToString(TotalSize)
		End With
	End Sub
	
	
	
	Private Sub VBZip_OnDeleteComplete(ByVal eventSender As System.Object, ByVal eventArgs As AxVBZip_Control.__RichsoftVBZip_OnDeleteCompleteEvent) Handles VBZip.OnDeleteComplete
		frmProgress.Close()
	End Sub
	
	
	Private Sub VBZip_OnDeleteProgress(ByVal eventSender As System.Object, ByVal eventArgs As AxVBZip_Control.__RichsoftVBZip_OnDeleteProgressEvent) Handles VBZip.OnDeleteProgress
		With frmProgress
			VB6.ShowForm(frmProgress,  , Me)
			.pbrProgress.Value = eventArgs.Percentage
			.lblWorking.Text = "Deleting " & eventArgs.Filename & "..."
		End With
	End Sub
	
	
	Private Sub VBZip_OnUnzipComplete(ByVal eventSender As System.Object, ByVal eventArgs As AxVBZip_Control.__RichsoftVBZip_OnUnzipCompleteEvent) Handles VBZip.OnUnzipComplete
		frmProgress.Close()
	End Sub
	
	Private Sub VBZip_OnUnzipProgress(ByVal eventSender As System.Object, ByVal eventArgs As AxVBZip_Control.__RichsoftVBZip_OnUnzipProgressEvent) Handles VBZip.OnUnzipProgress
		With frmProgress
			VB6.ShowForm(frmProgress,  , Me)
			.pbrProgress.Value = eventArgs.Percentage
			.lblWorking.Text = "Auspacken " & eventArgs.Filename & "..."
		End With
	End Sub
	
	
	Private Sub VBZip_OnZipComplete(ByVal eventSender As System.Object, ByVal eventArgs As AxVBZip_Control.__RichsoftVBZip_OnZipCompleteEvent) Handles VBZip.OnZipComplete
		frmProgress.Close()
	End Sub
	
	Private Sub VBZip_OnZipProgress(ByVal eventSender As System.Object, ByVal eventArgs As AxVBZip_Control.__RichsoftVBZip_OnZipProgressEvent) Handles VBZip.OnZipProgress
		With frmProgress
			VB6.ShowForm(frmProgress,  , Me)
			.pbrProgress.Value = eventArgs.Percentage
			.lblWorking.Text = "Hinzufügen " & eventArgs.Filename & "..."
		End With
	End Sub
End Class