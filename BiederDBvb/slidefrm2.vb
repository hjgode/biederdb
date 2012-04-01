Option Strict On
Option Explicit On
Friend Class bildschirm
	Inherits System.Windows.Forms.Form
	Private Sub bildschirm_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'KPD-Team 1998
		'URL: http://kpdweb.cjb.net/
		'E-Mail: KPD_Team@Hotmail.com
		'Set the window position to topmost
		'SetWindowPos Me.hwnd, HWND_TOPMOST, 0, 0, 0, 0, SWP_SHOWWINDOW Or SWP_NOMOVE Or SWP_NOSIZE
		'slide.WindowState = vbMinimized
		LoginSucceeded = False
		If existfile(AppPath & "\diastart.jpg") Then
			Ziel.Image = System.Drawing.Image.FromFile(AppPath & "\diastart.jpg")
			Ziel.Refresh()
		End If
	End Sub
	
	Private Sub Ziel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Ziel.Click
		If PasswortSchutzEin = 1 Then
			frmPassword.txtPassword.Text = ""
			frmPassword.ShowDialog()
			If LoginSucceeded Then dia_exit()
		Else
			dia_exit()
		End If
	End Sub
End Class