Option Strict On
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frm_suchen
	Inherits System.Windows.Forms.Form
	
	Private Sub bt_schliessen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_schliessen.Click
		bt_weitersuchen.Enabled = False
		Me.Close() 'frm_suchen.Hide
	End Sub
	
	Private Sub bt_suchen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_suchen.Click
        Dim SuchString As String
		'UPGRADE_WARNING: Couldn't resolve default property of object SuchString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SuchString = text1.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object SuchString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If VB.Right(SuchString, 1) <> "*" Then SuchString = SuchString + "*"
		'UPGRADE_WARNING: Couldn't resolve default property of object SuchString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If SuchString <> "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object SuchString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dy.FindFirst("ArtNr Like " & ii + SuchString + ii)
			If Not dy.NoMatch Then
				BIEDER.darstellen()
				bt_weitersuchen.Enabled = True
				VB6.SetDefault(bt_weitersuchen, True)
			Else
				MsgBox("Kein Artikel gefunden!", MsgBoxStyle.OKOnly, "Suchen")
				bt_weitersuchen.Enabled = False
				Exit Sub
			End If
		End If
		'MsgBox "noch nicht verfügbar", 16, "Hinweis"
		
	End Sub
	
	Private Sub bt_weitersuchen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_weitersuchen.Click
        Dim SuchString As String
		'UPGRADE_WARNING: Couldn't resolve default property of object SuchString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SuchString = text1.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object SuchString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If SuchString <> "" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object SuchString. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dy.FindNext("ArtNr >= " & ii + SuchString + ii)
			If Not dy.NoMatch Then
				BIEDER.darstellen()
				bt_weitersuchen.Enabled = True
			Else
				MsgBox("Kein weiterer Artikel gefunden!", MsgBoxStyle.OKOnly, "Suchen")
				bt_weitersuchen.Enabled = False
				Exit Sub
			End If
		End If
		'MsgBox "noch nicht verfügbar", 16, "Hinweis"
	End Sub
	
    Private Sub frm_suchen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'HGO
        ''UPGRADE_ISSUE: Form property BIEDER.ScaleLeft was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.Left = VB6.TwipsToPixelsX(BIEDER.ScaleLeft + VB6.PixelsToTwipsX(BIEDER.ClientRectangle.Width) - VB6.PixelsToTwipsX(Me.ClientRectangle.Width))
        ''UPGRADE_ISSUE: Form property BIEDER.ScaleTop was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'Me.Top = VB6.TwipsToPixelsY(BIEDER.ScaleTop) '+ BIEDER.ScaleHeight - Me.ScaleHeight
    End Sub
End Class