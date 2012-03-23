Option Strict On
Option Explicit On
Friend Class frmLogin
	Inherits System.Windows.Forms.Form
	
	Public LoginSucceeded As Boolean
	
	Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
		'Globale Variable auf False setzen,
		'um eine fehlgeschlagene Anmeldung zu kennzeichnen.
		LoginSucceeded = False
		Me.Hide()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		'Auf korrektes Kennwort überprüfen
		If txtPassword.Text = "password" Then
			'Geben Sie hier Code ein, um den Erfolg
			'an die aufrufende Unterroutine weiterzuleiten.
			'Setzen der globalen Variablen ist leicht.
			LoginSucceeded = True
			Me.Hide()
		Else
			MsgBox("Ungültiges Kennwort. Bitte versuchen Sie es noch einmal!",  , "Anmeldung")
			txtPassword.Focus()
			System.Windows.Forms.SendKeys.Send("{Home}+{End}")
		End If
	End Sub
End Class