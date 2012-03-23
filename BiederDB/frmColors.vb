Option Strict On
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmColors
	Inherits System.Windows.Forms.Form
	
	Private Sub bt_cancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_cancel.Click
		read_colors()
		Me.Hide()
	End Sub
	
	Private Sub bt_defaultColors_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_defaultColors.Click
        Dim ant As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object ant. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ant = MsgBox("Alle Farbanpassungen verwerfen und Standardfarben laden?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Sicherheitsfrage")
		If ant = MsgBoxResult.No Then
			Exit Sub
		Else
            'On Error Resume Next
			Kill((AppPath & "\colors.dat"))
			On Error GoTo 0
			read_colors()
			create_sample()
			WebBrowser1.Navigate(New System.URI((AppPath & "\sample\sample.htm")))
		End If
		
	End Sub
	
	Private Sub bt_ok_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_ok.Click
		If MsgBox("Änderungen speichern?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Internet-Farben") = MsgBoxResult.Yes Then write_colors()
		Me.Close()
	End Sub
	
	Private Sub ColorTest_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ColorTest.DoubleClick
        Dim i As Integer
        Dim c As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        i = Combo1.SelectedIndex
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If i = 0 Then Exit Sub
        With ColorDialog1
            .Color = System.Drawing.ColorTranslator.FromOle(Convert.ToInt16(HTML2RGB(farben(i).html)))
            .FullOpen = True
        End With
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            c = System.Drawing.ColorTranslator.ToOle(ColorDialog1.Color)
        End If
        ''UPGRADE_ISSUE: Constant cdlCCRGBInit was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        ''UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'CommonDialog1.Flags = MSComDlg.ColorConstants.cdlCCRGBInit
        ''UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Color.FullOpen which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
        'CommonDialog1Color.FullOpen = True

        ''UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'CommonDialog1Color.Color = System.Drawing.ColorTranslator.FromOle(HTML2RGB(farben(i).html))
        'On Error GoTo Col_error

        ''UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        'CommonDialog1.CancelError = True
        'CommonDialog1Color.ShowDialog()
        'c = System.Drawing.ColorTranslator.ToOle(CommonDialog1Color.Color)
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        farben(i).rgb_Renamed = c

        ColorHex.Text = RGB2HTML(c)
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        farben(i).html = RGB2HTML(c)
        ColorTest.BackColor = System.Drawing.ColorTranslator.FromOle(c)
        'save_arraycolors2names
        On Error GoTo 0
        'vorschau aktualisieren
        create_sample()
        WebBrowser1.Navigate(New System.Uri((AppPath & "\sample\sample.htm")))
        Exit Sub
Col_error:
        On Error GoTo 0
    End Sub
	
	'UPGRADE_WARNING: Event Combo1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
		If Combo1.SelectedIndex <= 0 Then Exit Sub
        ColorTest.BackColor = System.Drawing.ColorTranslator.FromOle(Convert.ToInt16(farben(Combo1.SelectedIndex).rgb_Renamed))
		cname.Text = farben(Combo1.SelectedIndex).name
	End Sub
	
	Private Sub frmColors_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim x, y As Integer
		Combo1.Items.Clear()
		Combo1.Items.Insert(0, "Bitte auswählen")
		'UPGRADE_WARNING: Couldn't resolve default property of object max_colors. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For x = 1 To max_colors
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Combo1.Items.Insert(x, farben(x).name)
		Next x
		Combo1.SelectedIndex = 1
        ColorTest.BackColor = System.Drawing.ColorTranslator.FromOle(Convert.ToInt16(farben(Combo1.SelectedIndex).rgb_Renamed))
		cname.Text = farben(Combo1.SelectedIndex).name
		ColorHex.Text = farben(Combo1.SelectedIndex).html
		'vorschau aktualisieren
		create_sample()
		WebBrowser1.Navigate(New System.URI((AppPath & "\sample\sample.htm")))
		'WebBrowser1.Refresh2
	End Sub
	
    Private Function val1(ByRef s As String) As Double
        If VB.Left(s, 1) = "#" Then s = "&H" & VB.Right(s, Len(s) - 1)
        val1 = Val(s)
    End Function
	
	Sub create_sample()
		write_top_htm() '_top neu erstellen
		FileCopy(AppPath & "\_top.htm", AppPath & "\sample\top.htm")
		FileCopy(AppPath & "\_topback.gif", AppPath & "\sample\_topback.gif")
		FileCopy(AppPath & "\_mainback.gif", AppPath & "\sample\_mainback.gif")
		FileCopy(AppPath & "\_lftback.gif", AppPath & "\sample\_lftback.gif")
		FileCopy(AppPath & "\_artback.gif", AppPath & "\sample\_artback.gif")
        Dim f As Integer
        Dim txt As String
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'Kategorie Datei erstellen
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, AppPath & "\sample\kategorie.htm", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<html><head><title>Testpage</title></head>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<body bgcolor=" + ii + farben(kategorie_bgcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " text=" + ii + farben(kategorie_txtcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " link=" + ii + farben(kategorie_link).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " vlink=" + ii + farben(kategorie_vlink).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " alink=" + ii + farben(kategorie_alink).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If bg_main = 1 Then txt = txt + " background=" + htmValue("_mainback.gif")
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + ">" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<h4>Kategorie Beispieltext</h4>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(kategorie_txtcolor).html + ii + ">Textfarbe</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(kategorie_link).html + ii + ">Textfarbe Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(kategorie_vlink).html + ii + ">Textfarbe besuchter Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(kategorie_alink).html + ii + ">Textfarbe aktiver Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "</body></html>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, txt)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(f)
		'Artikel Datei erstellen
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, AppPath & "\sample\artikel.htm", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<html><head><title>Testpage</title></head>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<body bgcolor=" + ii + farben(artikel_bgcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " text=" + ii + farben(artikel_txtcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If bg_artikel = 1 Then txt = txt + " background=" + htmValue("_artback.gif") + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " link=" + ii + farben(artikel_link).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " vlink=" + ii + farben(artikel_vlink).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " alink=" + ii + farben(artikel_alink).html + ii + ">" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<h4>Artikel Beispieltext</h4>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(artikel_txtcolor).html + ii + ">Textfarbe</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(artikel_link).html + ii + ">Textfarbe Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(artikel_vlink).html + ii + ">Textfarbe besuchter Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(artikel_alink).html + ii + ">Textfarbe aktiver Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "</body></html>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, txt)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(f)
		'Portal Datei erstellen
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, AppPath & "\sample\portal.htm", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<html><head><title>Testpage</title></head>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<body bgcolor=" + ii + farben(portal_bgcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " text=" + ii + farben(portal_txtcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " link=" + ii + farben(portal_link).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " vlink=" + ii + farben(portal_vlink).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " alink=" + ii + farben(portal_alink).html + ii '+ ">" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If bg_main = 1 Then txt = txt + " background=" + htmValue("_mainback.gif")
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + ">" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<h4>Portal Beispieltext</h4>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(portal_txtcolor).html + ii + ">Textfarbe</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(portal_link).html + ii + ">Textfarbe Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(portal_vlink).html + ii + ">Textfarbe besuchter Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(portal_alink).html + ii + ">Textfarbe aktiver Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "</body></html>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, txt)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(f)
		'Left Datei erstellen
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(f, AppPath & "\sample\left.htm", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<html><head><title>Testpage</title></head>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<body bgcolor=" + ii + farben(left_bgcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " text=" + ii + farben(left_txtcolor).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " link=" + ii + farben(left_link).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " vlink=" + ii + farben(left_vlink).html + ii
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " alink=" + ii + farben(left_alink).html + ii '+ ">" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If bg_left = 1 Then txt = txt + " background=" + htmValue("_lftback.gif")
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + ">" + vbCrLf
		
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<h4>Left Beispieltext</h4>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(left_txtcolor).html + ii + ">Textfarbe</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(left_link).html + ii + ">Textfarbe Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(left_vlink).html + ii + ">Textfarbe besuchter Link</font><br>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<font color=" + ii + farben(left_alink).html + ii + ">Textfarbe aktiver Link</font><br>" + vbCrLf
		'tabellenfarben
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "<table bgcolor=" + ii + farben(left_tbl_bgcolor).html + ii + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " bordercolor=" + ii + farben(left_tbl_bordercolor).html + ii + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " border=" + ii + "2" + ii + " + vbcrlf"
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " bordercolorlight=" + ii + farben(left_bordercolorlight).html + ii + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " bordercolordark=" + ii + farben(left_bordercolordark).html + ii + ">"
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + " <tr><td>Tabellentext<br>Rahmenfarbe normal,<br>hell und dunkel</td></tr>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = txt + "</body></html>" + vbCrLf
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(f, txt)
		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(f)
	End Sub
	
	Sub save_arraycolors2names()
	End Sub
End Class