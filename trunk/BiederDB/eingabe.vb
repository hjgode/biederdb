Option Strict On
Option Explicit On
Friend Class BIEDER
	Inherits System.Windows.Forms.Form
	
	Dim abfrage As String
	Dim old_abfrage As String
	Dim neufrage As String
	Dim FalscheTextEingabe As Boolean
	Dim info() As infotype
	Dim frei As Short
    Dim DataChanged As Boolean
    Dim neusatz As Boolean
    Dim beenden As Boolean
	Sub KategorienLesen()
        Dim i, max As Integer
		dyKat = db.CreateDynaset("select * from Hoofdgroep where not isnull(Hoofdgroep) order by SortOrder")
		dyKat.MoveLast()
		'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		max = dyKat.RecordCount
		dyKat.MoveFirst()
		ReDim kategorie(max)
		'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For i = 0 To max - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            kategorie(i).text = dyKat.Fields("Hoofdgroep").Value.ToString()
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            kategorie(i).ID = CType(dyKat.Fields("Hgr_ID").Value, UShort)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			List1.Items.Add(kategorie(i).text)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VB6.SetItemData(List1, i, kategorie(i).ID)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			List2.Items.Add(kategorie(i).text)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VB6.SetItemData(List2, i, kategorie(i).ID)
			dyKat.MoveNext()
		Next i
		List1.Items.Add("Nicht vorhanden")
		VB6.SetItemData(List1, i, 9999)
		List2.Items.Insert(0, "Alle anzeigen")
		VB6.SetItemData(List2, 0, 0)
        List2.SelectedIndex = 0
	End Sub
	Sub QueryData()
        Dim i As Short
		dy = db.CreateDynaset(abfrage)
		If dy.RecordCount = 0 Then ' keine Datensätze da
            If MsgBox(neufrage, MsgBoxStyle.YesNo, "FRAGE") = MsgBoxResult.Yes Then ' gleich neuen Datensatz anlegen
                neusatz = True
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                i = 0
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                While info(i).feldname <> ""
                    text1(i).Enabled = False
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    i = i + 1S
                End While
                neu.Enabled = False
                sichern.Enabled = False
                löschen.Enabled = False
                suchen.Enabled = False
                kopieren.Enabled = False
                einfügen.Enabled = False
                letzter.Enabled = False
                nächster.Enabled = False
                beenden = True
            End If
		Else
			darstellen()
			DataChanged = False
		End If
		
	End Sub
	Sub KategorieZeigen()
        Dim i As Integer
        Dim such As String
        Dim gefunden As Boolean
		'UPGRADE_WARNING: Couldn't resolve default property of object gefunden. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gefunden = False
		'UPGRADE_WARNING: Couldn't resolve default property of object such. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		such = Text1(4).Text
		For i = 0 To List1.Items.Count - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object such. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If VB6.GetItemData(List1, i) = Val(such) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object gefunden. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				gefunden = True
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				List1.SelectedIndex = i
				Exit For
			End If
		Next i
		'UPGRADE_WARNING: Couldn't resolve default property of object gefunden. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If gefunden Then List1.SelectedIndex = i Else List1.SelectedIndex = -1
	End Sub
	Private Sub UpdatePic()
        '		On Error GoTo BildFehler
        Try
            Picture1.Image = System.Drawing.Image.FromFile(text1(3).Text)
            'Picture1.ImageLocation = text1(3).Text
        Catch ex As Exception
            Picture1.ImageLocation = ""
        End Try
        'Exit Sub
        'BildFehler: 
        '		Picture1.Image = System.Drawing.Image.FromFile("")
        '		On Error GoTo 0
	End Sub
	Public Sub darstellen()
		Dim i As Short
		i = 0
		While info(i).feldname <> ""
			Text1(i).Text = auslesen(dy.Fields(info(i).feldname), info(i).type)
            i = i + 1S
		End While
		If Text1(10).Text = "Falsch" Then
			Check1.CheckState = System.Windows.Forms.CheckState.Unchecked
		Else
			Check1.CheckState = System.Windows.Forms.CheckState.Checked
		End If
		UpdatePic()
		KategorieZeigen()
	End Sub
	
    Private Function datenprüfung() As Boolean
        'UPGRADE_WARNING: Couldn't resolve default property of object datenprüfung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        datenprüfung = False
        Dim i As Short
        i = 0
        While info(i).feldname <> ""
            ' Prüfen auf Leerfelder
            If info(i).not_null And text1(i).Text = "" Then
                MsgBox("Leerfeld nicht zulässig!", MsgBoxStyle.OkOnly, "Problem")
                If i = 4 Then
                    List1.Focus()
                Else
                    text1(i).Focus()
                End If
                Exit Function
            End If
            If info(i).type = DB_DATE Then
                If Not IsDate(text1(i).Text) Then
                    MsgBox("Das Eingabefeld enthält kein Datum!", MsgBoxStyle.OkOnly, "Problem")
                    text1(i).Focus()
                    Exit Function
                End If
            End If
            i = i + 1S
        End While
        'UPGRADE_WARNING: Arrays in structure snap may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
        Dim snap As dao.Recordset 'Snapshot
        If neusatz Then
            'Auf Doppelte prüfen für text1(0) (ArtNr)
            snap = db.CreateSnapshot("select ArtNr from Artikel where ArtNr=" & ii & text1(0).Text & ii)
            If Not (snap.BOF And snap.EOF) Then
                'Doppelt, da snapshot nicht leer
                MsgBox("Doppelte ArtNr nicht zulässig!", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkOnly, "Problem")
                text1(0).Focus()
                snap.Close()
                Exit Function
            End If
            snap.Close()
        End If
        ' Wenn hier angekommen, ist alles ok
        'UPGRADE_WARNING: Couldn't resolve default property of object datenprüfung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        datenprüfung = True
    End Function
	
	Private Sub datenübergabe()
		Dim i As Short
		i = 0
		While info(i).feldname <> ""
			If info(i).type <> DB_Boolean Then
				If Text1(i).Text <> "" Then dy.Fields(info(i).feldname).Value = Text1(i).Text
			Else
				If Text1(i).Text = "Falsch" Then
					dy.Fields(info(i).feldname).Value = False
				Else
					dy.Fields(info(i).feldname).Value = True
				End If
			End If
            i = i + 1S
		End While
	End Sub
	
	Private Sub bt_drucken_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_drucken.Click
        Dim masse As Object
        Dim file_Artikel As Integer
        Dim ArtikelHtml, foto, ArtNr, Gruppe, beschreibung As String
        Dim preis_unbeh, preis_beh As String
		If List1.SelectedIndex > 0 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Gruppe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Gruppe = text2htm(VB6.GetItemString(List1, List1.SelectedIndex))
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Gruppe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Gruppe = ""
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtNr = Text1(0).Text
		'UPGRADE_WARNING: Couldn't resolve default property of object beschreibung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		beschreibung = text2htmList(Text1(1).Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object masse. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		masse = text2htm(Text1(2).Text)
		'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		foto = text2htm(Text1(3).Text)
		Dim MitPreisen As Boolean
		If MsgBox("Mit Preisen drucken?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "HTML-Druck") = MsgBoxResult.Yes Then
			MitPreisen = True
			'Preise
			'UPGRADE_WARNING: Couldn't resolve default property of object preis_unbeh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			preis_unbeh = Text1(8).Text
			'UPGRADE_WARNING: Couldn't resolve default property of object preis_beh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			preis_beh = Text1(9).Text
		Else
			MitPreisen = False
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ""
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = "<html>" & cr & "<head>" & cr & "<title>" & "Der Biedermann - Landhausmöbel in Wuppertal" & "</title>" & cr
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ArtikelHtml + "<meta http-equiv=" + ii + "Content-Type" + ii + " content=" + ii + "text/html; charset=ISO-8859-1" + ii + ">" + cr
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ArtikelHtml + "<meta name=" + ii + "GENERATOR" + ii + " content=" + ii + "bieder.db (c)HJ Gode" + ii + ">" + cr
		'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ArtikelHtml + keywords_htm + "</head>" + cr
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ArtikelHtml + "<body bgcolor=" + htmValue(farben(artikel_bgcolor).html) + " text=" + htmValue(farben(artikel_txtcolor).html)
		If bg_artikel = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ArtikelHtml = ArtikelHtml + " background=" + htmValue("_artback.gif") + ">" + cr
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ArtikelHtml = ArtikelHtml + ">" + cr
		End If
		If bg_top = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Top_Gif. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ArtikelHtml = ArtikelHtml + Top_Gif + Der_Biedermann
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object Der_Biedermann. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ArtikelHtml = ArtikelHtml + "<h1>Der Biedermann</h1><br>" + vbCrLf + Der_Biedermann
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object Gruppe. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Gruppe <> "" Then ArtikelHtml = ArtikelHtml + "<h1>" + Gruppe + "</h1>"
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If ArtNr <> "" Then ArtikelHtml = ArtikelHtml + "<h2>ArtNr: " + ArtNr + "</h2>"
		If MitPreisen Then
			'UPGRADE_WARNING: Couldn't resolve default property of object preis_unbeh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ArtikelHtml = ArtikelHtml + "<table><tr><td><strong>Preis unbehandelt: </td><td align=right>" + preis_unbeh + "&nbsp;&euro;</td></tr>" + cr
			'UPGRADE_WARNING: Couldn't resolve default property of object preis_beh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ArtikelHtml = ArtikelHtml + "<tr><td><strong>Preis behandelt: </td><td align=right>" + preis_beh + "</strong>&nbsp;&euro;</td></tr></table>" + cr
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object beschreibung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ArtikelHtml + beschreibung + "<br>" + cr
		'ArtikelHtml = ArtikelHtml + text2htm("Maße: ") + masse + "<br><hr>" + cr
		'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ArtikelHtml + "<br><hr>" + cr + "<img src=" + ii + foto + ii + " width=640 height=480>"
		'<img border="0" src="bedden/bed601-bed606+bed674.jpg" width="640" height="480">
		'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ArtikelHtml = ArtikelHtml + "</body>" + cr + "</html>"
		'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		file_Artikel = FreeFile
		'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(file_Artikel, AppPath & "\_print.htm", OpenMode.Output)
		'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(file_Artikel, ArtikelHtml)
		'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(file_Artikel)
		ShellExecute(Me.Handle.ToInt32, vbNullString, AppPath & "\_print.htm", vbNullString, "C:\", SW_SHOWNORMAL)
		'Shell ("C:\PROGRA~1\INTERN~1\iexplore.exe " + Apppath + "\_print.htm"), vbMaximizedFocus
		'Dim old
		'    old = Printer.Orientation
		'    Printer.Orientation = vbPRORLandscape
		'    BIEDER.PrintForm
		'    Printer.Orientation = old
	End Sub
	
    Private Sub BT_neufoto_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BT_neufoto.Click
        With OpenFileDialog1
            .Filter = "JPG-Bilder (*.jpg)|*.JPG|JPEG-Bilder (*.jpeg)|*.JPEG|Alle Dateien (*.*)|*.*"
            .FileName = text1(3).Text
            .CheckFileExists = True
            .CheckPathExists = True
            '.CancelError = True
            On Error GoTo FileError
        End With
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            text1(3).Text = OpenFileDialog1.FileName
        End If

        'UPGRADE_WARNING: CommonDialog variable was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="671167DC-EA81-475D-B690-7A40C7BF4A23"'
        'With CommonDialog1
        '    'UPGRADE_WARNING: MSComDlg.CommonDialog property CommonDialog1.Flags was upgraded to CommonDialog1Open.CheckFileExists which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
        '    .CheckFileExists = True
        '    .CheckPathExists = True
        '    'UPGRADE_ISSUE: Constant cdlOFNLongNames was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
        '    'UPGRADE_ISSUE: MSComDlg.CommonDialog property CommonDialog1.Flags was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '    .Flags = MSComDlg.FileOpenConstants.cdlOFNLongNames
        '    'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '    .Filter = "JPG-Bilder (*.jpg)|*.JPG|JPEG-Bilder (*.jpeg)|*.JPEG|Alle Dateien (*.*)|*.*"
        '    .FileName = text1(3).Text
        '    'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(Text1(3).text). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    'UPGRADE_WARNING: Couldn't resolve default property of object GetPfad(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    .InitialDirectory = GetPfad(text1(3).Text)
        '    'UPGRADE_WARNING: The CommonDialog CancelError property is not supported in Visual Basic .NET. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
        '    .CancelError = True
        '    On Error GoTo FileError
        'End With
        'CommonDialog1Open.ShowDialog()
        'text1(3).Text = CommonDialog1Open.FileName
        UpdatePic()
        Exit Sub
FileError:

    End Sub
	Private Sub BT_NeuKateg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BT_NeuKateg.Click
        Dim neu As String
		'UPGRADE_WARNING: Couldn't resolve default property of object neu. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		neu = InputBox("Wie soll die neue Kategorie heissen?", "Neue Kategorie anlegen", "Kategorie")
		'UPGRADE_WARNING: Couldn't resolve default property of object neu. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If neu <> "" And neu <> "Kategorie" Then
			dyKat.AddNew()
			'    dyKat.Edit
			'UPGRADE_WARNING: Couldn't resolve default property of object neu. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dyKat.Fields("Hoofdgroep").Value = neu
			dyKat.Update()
			KategorienLesen()
		End If
	End Sub
	
	Private Sub bt_start_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_start.Click
		neu.Enabled = False
		sichern.Enabled = False
		löschen.Enabled = False
		suchen.Enabled = False
		kopieren.Enabled = False
		einfügen.Enabled = False
		letzter.Enabled = False
		nächster.Enabled = False
		bt_close.Enabled = False
		bt_start.Enabled = False
		bt_stop.Enabled = True
		'UPGRADE_WARNING: Timer property Timer1.Interval cannot have a value of 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
		Timer1.Interval = CShort(ShowTime) * 1000
		Timer1.Enabled = True
	End Sub
	
	Private Sub bt_stop_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_stop.Click
		Timer1.Enabled = False
		neu.Enabled = True
		sichern.Enabled = True
		löschen.Enabled = True
		suchen.Enabled = True
		kopieren.Enabled = True
		einfügen.Enabled = True
		letzter.Enabled = True
		nächster.Enabled = True
		bt_close.Enabled = True
		bt_start.Enabled = True
		bt_stop.Enabled = False
		DataChanged = False
	End Sub
	
	
	'UPGRADE_WARNING: Event Check1.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Check1_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.CheckStateChanged
		If Check1.CheckState = 0 Then
			Text1(10).Text = "Falsch"
		Else
			Text1(10).Text = "Wahr"
		End If
	End Sub
	
	Private Sub einfügen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles einfügen.Click
		insert_clipboard()
	End Sub
	
	'UPGRADE_WARNING: Form event BIEDER.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub BIEDER_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Label1(2).Text = "Abm.:"
		Text1(0).Focus()
		If neusatz Then neu_Click(neu, New System.EventArgs()) 'neu
	End Sub
	
	Private Sub BIEDER_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = CType(eventArgs.KeyCode, Short)
        Dim Shift As Short = CType(eventArgs.KeyData \ &H10000, Short)
		
		Select Case KeyCode
			Case 33 ' PageUp
				letzter_Click(letzter, New System.EventArgs())
			Case 34 ' Pagedown
				nächster_Click(nächster, New System.EventArgs())
		End Select
		
	End Sub
	
	Private Sub BIEDER_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Short
		FalscheTextEingabe = False
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		db = DAODBEngine_definst.OpenDatabase(datenbank, False, False)
		i = 0
		definiere()
		KategorienLesen()
		While info(i).feldname <> ""
			'UPGRADE_WARNING: TextBox property Text1.MaxLength has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
			If info(i).size <> 0 And info(i).type = DB_TEXT Then Text1(i).Maxlength = info(i).size
            i = i + 1S
		End While
		QueryData()
		neusatz = False
		beenden = False
		Me.SetBounds(0, 0, 0, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y)
	End Sub
	'UPGRADE_WARNING: Event BIEDER.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub BIEDER_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		If Me.WindowState = System.Windows.Forms.FormWindowState.Minimized Then Exit Sub
        If VB6.PixelsToTwipsY(Me.Height) < 5000 Then Me.Height = Convert.ToInt16(VB6.TwipsToPixelsY(5000))
        Picture1.Height = Convert.ToInt16(VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) - 3050))
        Picture1.Width = Convert.ToInt16(VB6.TwipsToPixelsX(CShort(VB6.PixelsToTwipsY(Picture1.Height) * 4 / 3)))
	End Sub
	
	Private Sub BIEDER_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If DataChanged Then
			bt_close_Click(bt_close, New System.EventArgs())
		End If
	End Sub
	
	Private Sub kopieren_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles kopieren.Click
		copy_clipboard()
	End Sub
	
	Private Sub letzter_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles letzter.Click
        If DataChanged Then If MsgBox("Der aktuelle Datensatz wurde geändert! Sichern?", MsgBoxStyle.YesNo, "FRAGE") = MsgBoxResult.Yes Then sichern_Click(sichern, New System.EventArgs())
        dy.MovePrevious()
        If dy.BOF Then
            Beep()
            dy.MoveFirst()
        End If
        darstellen()
        DataChanged = False
    End Sub

    'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
        If List1.SelectedIndex = -1 Then
            text1(4).Text = ""
        Else
            text1(4).Text = CStr(VB6.GetItemData(List1, List1.SelectedIndex))
        End If

    End Sub


    'UPGRADE_WARNING: Event List2.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub List2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List2.SelectedIndexChanged
        If VB6.GetItemData(List2, List2.SelectedIndex) <> 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            abfrage = "Select * from artikel where HGR_ID=" & VB6.GetItemData(List2, List2.SelectedIndex) & " ORDER BY " & sortField
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            abfrage = "Select * from artikel ORDER BY " & sortField
        End If
        QueryData()
    End Sub

    Private Sub löschen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles löschen.Click
        If neusatz Then
            If (dy.EOF) And (dy.BOF) Then
                DataChanged = False
                Me.Close()
                Exit Sub
            Else
                darstellen()
            End If
            neusatz = False
            DataChanged = False
            suchen.Enabled = True
            Exit Sub
        End If
        If MsgBox("Datensatz Löschen ?", MsgBoxStyle.YesNo, "FRAGE") <> 6 Then Exit Sub
        dy.Delete()
        If Not dy.EOF Then dy.MoveNext()
        If (dy.EOF) And (dy.RecordCount <> 0) Then
            dy.MovePrevious()
        End If
        If ((dy.BOF) And (dy.EOF)) Or (dy.RecordCount = 0) Then ' Tabelle leer
            MsgBox("Keine weiteren Datensätze vorhanden", MsgBoxStyle.OkOnly, "Hinweis")
            Me.Close()
            Exit Sub
        Else
            darstellen()
            DataChanged = False
        End If
        kopieren.Enabled = True
        einfügen.Enabled = True
        letzter.Enabled = True
        nächster.Enabled = True
    End Sub

    Private Sub nächster_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles nächster.Click
        If DataChanged Then ' ein feld wurde geändert
            If MsgBox("Der aktuelle Datensatz wurde geändert! Sichern?", MsgBoxStyle.YesNo, "FRAGE") = MsgBoxResult.Yes Then sichern_Click(sichern, New System.EventArgs())
        End If
        dy.MoveNext()
        If dy.EOF Then
            Beep()
            dy.MoveLast()
        End If
        darstellen()
        DataChanged = False
    End Sub

    Private Sub neu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles neu.Click
        Dim i As Short
        Dim c As System.Windows.Forms.Control

        If DataChanged Then If MsgBox("Der aktuelle Datensatz wurde geändert! Sichern?", MsgBoxStyle.YesNo, "FRAGE") = MsgBoxResult.Yes Then sichern_Click(sichern, New System.EventArgs())
        neusatz = True
        i = 0
        While info(i).feldname <> ""
            Select Case info(i).type
                Case DB_INTEGER, DB_LONG, DB_CURRENCY, DB_SINGLE, DB_DOUBLE
                    text1(i).Text = "0"
                Case DB_DATE
                    text1(i).Text = VB6.Format(Now, "dd.mm.yyyy")
                Case Else
                    text1(i).Text = ""
            End Select
            i = i + 1S
        End While
        löschen.Enabled = True
        suchen.Enabled = False
        kopieren.Enabled = True
        einfügen.Enabled = True
        List1.SelectedIndex = List1.Items.Count - 1
        text1(0).Focus()
    End Sub

    Private Sub Picture1_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture1.DoubleClick
        BT_neufoto_Click(BT_neufoto, New System.EventArgs())
    End Sub

    Private Sub sichern_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sichern.Click
        If (Not neusatz) And (Not DataChanged) Then Exit Sub
        If Not datenprüfung() Then Exit Sub
        If neusatz Then ' Neu gewählt
            dy.AddNew()
        Else ' normales Ändern
            dy.Edit()
        End If
        datenübergabe()
        dy.Update()
        If neusatz Then dy.MoveLast()
        darstellen()
        DataChanged = False
        neusatz = False

        löschen.Enabled = True
        suchen.Enabled = True
        kopieren.Enabled = True
        einfügen.Enabled = True
        letzter.Enabled = True
        nächster.Enabled = True
    End Sub

    Private Sub suchen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles suchen.Click
        Dim temp As Boolean
        'UPGRADE_WARNING: Couldn't resolve default property of object temp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        temp = DataChanged 'Zustand sichern
        frm_suchen.ShowDialog()
        'UPGRADE_WARNING: Couldn't resolve default property of object temp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        DataChanged = temp 'Daten können nicht während Suchen geändert werden
    End Sub

    'UPGRADE_WARNING: Event text1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub text1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles text1.TextChanged
        Dim Index As Short = text1.GetIndex(CType(eventSender, TextBox))
        On Error GoTo eingabefehler
        Dim x As Object
        DataChanged = True
        Select Case info(Index).type
            Case DB_INTEGER
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = CShort(text1(Index).Text)
            Case DB_LONG
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = CInt(text1(Index).Text)
            Case DB_CURRENCY
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = CDec(text1(Index).Text)
            Case DB_SINGLE
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = CSng(text1(Index).Text)
            Case DB_DOUBLE
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = CDbl(text1(Index).Text)
        End Select
        Exit Sub

eingabefehler:
        Beep()
        System.Windows.Forms.SendKeys.Send("{BS}")
        'Resume Next //WARNING
    End Sub

    Private Sub text1_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles text1.Enter
        Dim Index As Short = text1.GetIndex(CType(eventSender, TextBox))
        text1(Index).SelectionStart = 0
        text1(Index).SelectionLength = Len(text1(Index).Text)
    End Sub

    Private Sub text1_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles text1.KeyDown
        Dim KeyCode As Short = Convert.ToInt16(eventArgs.KeyCode)
        Dim Shift As Short = Convert.ToInt16(eventArgs.KeyData \ &H10000)
        Dim Index As Short = text1.GetIndex(CType(eventSender, TextBox))
        If KeyCode = 40 Or KeyCode = 38 And info(Index).type <> DB_MEMO Then
            If KeyCode = 38 Then 'nach oben
                System.Windows.Forms.SendKeys.Send("+{TAB}")
            End If
            If KeyCode = 40 Then 'nach unten
                System.Windows.Forms.SendKeys.Send("{TAB}")
            End If
        End If
    End Sub

    Private Sub text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles text1.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)
        Dim Index As Short = text1.GetIndex(CType(eventSender, TextBox))
        If Index = 0 Then
            Select Case Chr(KeyAscii)
                'a list of char literals
                Case " "c, "-"c, "_"c, "."c, "+"c, "ä"c, "ö"c, "ü"c, "Ä"c, "Ö"c, "Ü"c, "0"c To "9"c, "A"c To "Z"c, "a"c To "z"c, Chr(0) To Chr(31)
                Case Else
                    KeyAscii = 0
                    Beep()
                    If FalscheTextEingabe = False Then
                        MsgBox("Einige dieser Eingabe werden bei der Generierung der Webseite zu Dateiverknüpfungen. Aus diesem Grund sind nicht alle Zeichen erlaubt." & Chr(13) & "Die folgenden Zeichen sind zulässig: ' ', '-', '_', '.', '+', 'ä', 'ö', 'ü', 'Ä', 'Ö', 'Ü', '0' bis '9', 'A' bis 'Z', 'a' bis 'z'", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "HINWEIS")
                        FalscheTextEingabe = True
                    End If
            End Select
        End If
        If KeyAscii = 13 And info(Index).type <> DB_MEMO Then
            KeyAscii = 0
            System.Windows.Forms.SendKeys.Send("{TAB}")
        End If
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        If Not dy.EOF Then
            dy.MoveNext()
            If dy.EOF Then dy.MoveFirst()
        Else
            dy.MoveFirst()
        End If
        darstellen()
    End Sub

    Private Sub bt_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_close.Click
        If DataChanged Then If MsgBox("Der aktuelle Datensatz wurde geändert! Sichern?", MsgBoxStyle.YesNo, "FRAGE") = MsgBoxResult.Yes Then sichern_Click(sichern, New System.EventArgs())
        DataChanged = False
        Me.Close()
    End Sub
	
	Private Sub definiere()
		Dim anzahl, i As Short
		' Welche Tabelle soll verwendet werden ? SQL-Befehl ...
		'UPGRADE_WARNING: Couldn't resolve default property of object sortField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		abfrage = "SELECT * FROM artikel ORDER BY " & sortField
		' Meldung für das Anlegen der neuen Tabelle
		neufrage = "Keine Daten vorhanden! Neuen Artikel hinzufügen?"
		' wieviele Datenfelder ?
		anzahl = 11
		ReDim info(11)
		'Ändern Sie gegebenenfalls an dieser Stelle ...
		info(0).feldname = "ArtNr"
		info(0).not_null = True
		info(0).type = DB_TEXT
		info(0).size = 30
		info(1).feldname = "Omschrijving"
		info(1).not_null = False
		info(1).type = DB_MEMO
		info(1).size = 0
		info(2).feldname = "Maat"
		info(2).not_null = False
		info(2).type = DB_TEXT
		info(2).size = 25
		info(3).feldname = "Foto"
		info(3).not_null = False
		info(3).type = DB_TEXT
		info(3).size = 80
		info(4).feldname = "Hgr_ID"
		info(4).not_null = True
		info(4).type = DB_LONG
		info(4).size = 4
		info(5).feldname = "Besteld"
		info(5).not_null = True
		info(5).type = DB_SINGLE
		info(5).size = 4
		'Ab hier neu
		info(6).feldname = "H_PrijsOnb"
		info(6).not_null = False
		info(6).type = DB_SINGLE
		info(6).size = 4
		info(7).feldname = "H_PrijsBew"
		info(7).not_null = False
		info(7).type = DB_SINGLE
		info(7).size = 4
		info(8).feldname = "W_PrijsOnb"
		info(8).not_null = True
		info(8).type = DB_SINGLE
		info(8).size = 4
		info(9).feldname = "W_PrijsBew"
		info(9).not_null = True
		info(9).type = DB_SINGLE
		info(9).size = 4
		info(10).feldname = "Bewerkt"
		info(10).not_null = False
		info(10).type = 1
		info(10).size = DB_Boolean
		
	End Sub
End Class