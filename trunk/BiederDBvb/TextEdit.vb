Option Strict On
Option Explicit On
Friend Class TextEdit
	Inherits System.Windows.Forms.Form
	Private Sub btn_Cancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btn_Cancel.Click
		Me.Hide()
	End Sub
	
	Private Sub btn_OK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btn_OK.Click
        Dim fdb As Integer
		fdb = FreeFile
		FileOpen(fdb, My.Application.Info.DirectoryPath & "\Der_Biedermann.txt", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Der_Biedermann = Me.Text1.Text
		Print(fdb, Der_Biedermann)
		FileClose(fdb)
		MsgBox("Text gespeichert", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information, "Der_Biedermann.txt")
		Me.Hide()
	End Sub
	
	Private Sub btn_Standard_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btn_Standard.Click
		'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Der_Biedermann = "<blockquote><p>Der Biedermann, Landhausm&ouml;bel in vielen Varianten, Grünstr. 6, 42103 Wuppertal, Telefon: 0202-470068, Fax: 0202/6980567<br>&Ouml;ffnungszeiten: Mo-Fr 11-18:30 Uhr, Sa 10-16 Uhr</p></blockquote>"
		'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Me.Text1.Text = Der_Biedermann
	End Sub
End Class