Option Strict On
Option Explicit On
Friend Class frmOptions
	Inherits System.Windows.Forms.Form
	
	Public Sub FelderLesen()
        Dim i, max As Integer
		'UPGRADE_WARNING: Arrays in structure felder may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
        Dim felder As dao.Recordset 'Dynaset
		'Set db = OpenDatabase(datenbank, False, False)
		felder = db.CreateDynaset("select * from Artikel")
		'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		max = felder.Fields.Count
		'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		i = 0
		ReDim kategorie(max)
		'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For i = 0 To max - 1
			List1.Items.Add(felder.Fields(i).name)
		Next i
		felder.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text2.Text = sortField
		For i = 0 To List1.Items.Count - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If VB6.GetItemString(List1, i) = sortField Then
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				List1.SelectedIndex = i
				Exit For
			End If
		Next i
	End Sub
	
    Private Sub bt_iview_suchen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_iview_suchen.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Irfan View Programm (i_view32.exe)|i_view32.exe|Irfan View Programm (i_view32.exe)|i_view32.exe"
            .FileName = GetFilename(iview_path.Text) + "." + GetExtension(iview_path.Text)
            .InitialDirectory = GetPfad(iview_path.Text)

        End With
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            iview_path.Text = dlg.FileName
        End If
        dlg.Dispose()
        'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With CommonDialog1
        '    'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Open.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
        '    .CheckFileExists = True
        '    .CheckPathExists = True
        '    'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        '    'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    .Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
        '    'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '    .Filter = "Irfan View Programm (i_view32.exe)|i_view32.exe|Irfan View Programm (i_view32.exe)|i_view32.exe"
        '    'UPGRADE_WARNING: Couldn't resolve default property of object GetExtension(iview_path.text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename(iview_path.text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    .FileName = GetFilename(iview_path.Text) + "." + GetExtension(iview_path.Text)
        '    'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(iview_path.text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    .InitialDirectory = GetPfad(iview_path.Text)
        '    'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '    .CancelError = True
        '    On Error GoTo FileError
        'End With
        'CommonDialog1Open.ShowDialog()
        'iview_path.Text = CommonDialog1Open.FileName
        Exit Sub
FileError:
        On Error GoTo 0
    End Sub
	
	Private Sub bt_suchen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_suchen.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Text1.Text = datenbank
        Dim dlg As New OpenFileDialog
        With dlg
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Access CD Datenbank (*.mdb)|*.mdb|Access CD Datenbank (*.mdb)|*.mdb|Alle Dateien (*.*)|*.*"
            .FileName = datenbank
            .InitialDirectory = GetPfad(Text1.Text)

        End With
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Text1.Text = dlg.FileName
        End If
        dlg.Dispose()

		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With CommonDialog1
        '	'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Open.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
        '	.CheckFileExists = True
        '	.CheckPathExists = True
        '	'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        '	'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '	.Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
        '	'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '	.Filter = "Access CD Datenbank (*.mdb)|*.mdb|Access CD Datenbank (*.mdb)|*.mdb|Alle Dateien (*.*)|*.*"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	.FileName = datenbank
        '	'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(Text1.text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	.InitialDirectory = GetPfad(Text1.Text)
        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	.CancelError = True
        '	On Error GoTo FileError
        'End With
        'CommonDialog1Open.ShowDialog()
        'Text1.Text = CommonDialog1Open.FileName
		
		Exit Sub
FileError: 
		On Error GoTo 0
	End Sub
	
	Private Sub bt_suchenweb_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_suchenweb.Click
		Dim temp As String
        Dim startpfad As String
		'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		startpfad = Text3.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'temp = BrowseForFolder(Me, "Verzeichnis auswählen", startpfad)
        FolderBrowserDialog1.SelectedPath = startpfad
        FolderBrowserDialog1.ShowNewFolderButton = False
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK And FolderBrowserDialog1.SelectedPath.Length > 0 Then
            '            If Len(temp) > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object startpfad. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            startpfad = FolderBrowserDialog1.SelectedPath
            Text3.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
	
	Private Sub bt_webkopfsuchen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_webkopfsuchen.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object webkopf. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Text4.Text = webkopf
        Dim dlg As New OpenFileDialog
        With dlg
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Webseite (*.htm)|*.htm|Webseite (*.htm)|*.htm|Alle Dateien (*.*)|*.*"
            .FileName = Text4.Text
            .InitialDirectory = GetPfad(Text4.Text)

        End With
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Text4.Text = dlg.FileName
        End If
        dlg.Dispose()

		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With CommonDialog1
        '	'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Open.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
        '	.CheckFileExists = True
        '	.CheckPathExists = True
        '	'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        '	'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '	.Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
        '	'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '	.Filter = "Webseite (*.htm)|*.htm|Webseite (*.htm)|*.htm|Alle Dateien (*.*)|*.*"
        '	.FileName = Text4.Text
        '	'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(Text4.text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	.InitialDirectory = GetPfad(Text4.Text)
        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	.CancelError = True
        '	On Error GoTo FileError
        'End With
        'CommonDialog1Open.ShowDialog()
        'Text4.Text = CommonDialog1Open.FileName
		
		Exit Sub
FileError: 
		
	End Sub
	
	Private Sub bt_webstartsuchen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_webstartsuchen.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object startpage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Text5.Text = startpage
        Dim dlg As New OpenFileDialog
        With dlg
            .CheckFileExists = True
            .CheckPathExists = True
            .Filter = "Webseite (*.htm)|*.htm|Webseite (*.htm)|*.htm|Alle Dateien (*.*)|*.*"
            .FileName = Text5.Text
            .InitialDirectory = GetPfad(Text5.Text)

        End With
        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Text5.Text = dlg.FileName
        End If
        dlg.Dispose()

		'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With CommonDialog1
        '	'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Open.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
        '	.CheckFileExists = True
        '	.CheckPathExists = True
        '	'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        '	'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '	.Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
        '	'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '	.Filter = "Webseite (*.htm)|*.htm|Webseite (*.htm)|*.htm|Alle Dateien (*.*)|*.*"
        '	.FileName = Text5.Text
        '	'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(Text5.text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	.InitialDirectory = GetPfad(Text5.Text)
        '	'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '	.CancelError = True
        '	On Error GoTo FileError
        'End With
        'CommonDialog1Open.ShowDialog()
        'Text5.Text = CommonDialog1Open.FileName
		
		Exit Sub
FileError: 
		
	End Sub
	
	Private Sub btn_ArtikelKopfText_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btn_ArtikelKopfText.Click
        Dim fdb As Integer
		Dim zeile As String
		If existfile(My.Application.Info.DirectoryPath & "\Der_Biedermann.txt") Then
			fdb = FreeFile
			FileOpen(fdb, My.Application.Info.DirectoryPath & "\Der_Biedermann.txt", OpenMode.Input)
			'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Der_Biedermann = ""
			While Not EOF(fdb)
				zeile = LineInput(fdb)
				'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Der_Biedermann = Der_Biedermann + zeile
			End While
			FileClose(fdb)
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Der_Biedermann = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Grünstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>"
		End If
		'UPGRADE_ISSUE: Load statement is not supported. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
        Dim f As New TextEdit
		'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        f.Text1.Text = Der_Biedermann
        VB6.ShowForm(f, (VB6.FormShowConstants.Modal))
	End Sub
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		Me.Close()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		datenbank = Text1.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		sortField = Text2.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		webroot = Text3.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object webkopf. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		webkopf = Text4.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object startpage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		startpage = Text5.Text
		iview = iview_path.Text
		ShowTime = Str(HScroll1.Value)
		bg_top = bgbild_top.CheckState
		bg_left = bgbild_left.CheckState
		bg_main = bgbild_main.CheckState
		bg_artikel = bgbild_artikel.CheckState
		write_ini()
		write_top_htm() 'Schreibe aktuelle _top.htm
		Me.Close()
	End Sub
	
	Private Sub Command1_Click()
		
	End Sub
	
	Private Sub frmOptions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		read_ini()
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text1.Text = datenbank
		'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text3.Text = webroot
		'UPGRADE_WARNING: Couldn't resolve default property of object webkopf. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text4.Text = webkopf
		'UPGRADE_WARNING: Couldn't resolve default property of object startpage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text5.Text = startpage
		If StartSeite = "index.htm" Then
			Option1.Checked = True
			Option2.Checked = False
		Else
			Option1.Checked = False
			Option2.Checked = True
		End If
		Text7.Text = StartSeite
		iview_path.Text = iview
		HScroll1.Value = CShort(ShowTime)
		FelderLesen()
        bgbild_top.CheckState = CType(bg_top, CheckState)
        bgbild_left.CheckState = CType(bg_left, CheckState)
        bgbild_main.CheckState = CType(bg_main, CheckState)
        bgbild_artikel.CheckState = CType(bg_artikel, CheckState)
		'Formular zentrieren
        Me.SetBounds(Convert.ToInt32(VB6.TwipsToPixelsX((VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) - VB6.PixelsToTwipsX(Me.Width)) / 2)), _
                     Convert.ToInt32(VB6.TwipsToPixelsY((VB6.PixelsToTwipsY(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height) - VB6.PixelsToTwipsY(Me.Height)) / 2)), _
                     0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
	End Sub
	
	'UPGRADE_NOTE: HScroll1.Change was changed from an event to a procedure. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar event HScroll1.Change has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub HScroll1_Change(ByVal newScrollValue As Integer)
		Text6.Text = CStr(newScrollValue)
	End Sub
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		Text2.Text = VB6.GetItemString(List1, List1.SelectedIndex)
	End Sub
	
	'UPGRADE_WARNING: Event Option1.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Option1_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option1.CheckedChanged
        If CType(eventSender, CheckBox).Checked Then
            If Option1.Checked = True Then
                StartSeite = "index.htm"
            Else
                StartSeite = "index1.htm"
                StartSeitenWarnung()
            End If
            Text7.Text = StartSeite
        End If
	End Sub
	
	'UPGRADE_WARNING: Event Option2.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Option2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Option2.CheckedChanged
        If CType(eventSender, CheckBox).Checked Then
            If Option2.Checked = False Then
                StartSeite = "index.htm"
            Else
                StartSeite = "index1.htm"
                StartSeitenWarnung()
            End If
            Text7.Text = StartSeite

        End If
	End Sub
	Public Sub StartSeitenWarnung()
		MsgBox("Wenn Sie eine externe Datei als Hauptseite angeben, müssen Sie in diese einen Link auf die Datei 'index1.htm' einfügen, damit die generierten Webseiten erreichbar sind!", MsgBoxStyle.OKOnly Or MsgBoxStyle.Exclamation, "ACHTUNG")
	End Sub
	Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				HScroll1_Change(eventArgs.newValue)
		End Select
	End Sub
End Class