Option Strict On
Option Explicit On
Friend Class Hauptform
	Inherits System.Windows.Forms.Form
	
	Private Sub BT_bearbeiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BT_bearbeiten.Click
		BIEDER.ShowDialog()
	End Sub
	
	Private Sub bt_diashow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_diashow.Click
		slide.Show()
	End Sub
	
	Private Sub bt_zip_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_zip.Click
		If MsgBox("Das Programm BiederZip wird nun gestartet und dieses hier beendet!", MsgBoxStyle.OKCancel Or MsgBoxStyle.Exclamation) = MsgBoxResult.OK Then
			If Shell(AppPath & "\biederzip.exe", AppWinStyle.NormalFocus) > 0 Then End
		End If
		'zip_frm.Show 1
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		db2web.ShowDialog()
	End Sub
	
	Private Sub Hauptform_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		'write_ini
		m_ende_Click(m_ende, New System.EventArgs())
	End Sub
	
	Public Sub m_clean4web_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_clean4web.Click
        Dim foto1 As String
        Dim dAnzahl As Integer
		If MsgBox("Alle Datensätze, bei denen das Foto nicht gefunden werden kann auf Besteld=0 setzen? Sie werden dann nicht mehr im WEB publiziert.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Frage") = MsgBoxResult.No Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		db = DAODBEngine_definst.OpenDatabase(datenbank, False, False)
		dy = db.CreateDynaset("SELECT * FROM Artikel where Besteld>0 order By ArtNr")
		If dy.RecordCount > 0 Then
			dy.MoveLast()
		Else
			MsgBox("Es wurden keine Daten mit Besteld>0 gefunden! Verarbeitung wird abgebrochen.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Exclamation, "FEHLER")
			dy.Close()
			Exit Sub
		End If
		dy.MoveFirst()
		'UPGRADE_WARNING: Couldn't resolve default property of object dAnzahl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dAnzahl = 0
		While Not dy.EOF
			'UPGRADE_WARNING: Couldn't resolve default property of object foto1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            foto1 = dy.Fields("Foto").Value.ToString()
			'UPGRADE_WARNING: Couldn't resolve default property of object foto1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not existfile(foto1) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object dAnzahl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dAnzahl = dAnzahl + 1
				dy.Edit()
				dy.Fields("Besteld").Value = 0
				dy.Update()
			End If
			dy.MoveNext()
		End While
		dy.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object dAnzahl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Es wurden " & dAnzahl & " Datensätze geändert.", MsgBoxStyle.OKOnly, "Daten bereiningt")
	End Sub
	
	
	Public Sub m_colors_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_colors.Click
		MsgBox("Die Darstellung ist auch von den Hintergrundbildern (_mainback.gif, _artback.gif, _topback.gif und _lftback.gif) abhängig. Eventuell sehen Sie Farbänderungen des Hintergrunds erst, wenn Sie andere Hintergrundbilder verwenden!", MsgBoxStyle.Exclamation Or MsgBoxStyle.OKOnly, "ACHTUNG")
		VB6.ShowForm(frmColors, (VB6.FormShowConstants.Modal))
	End Sub
	
	Public Sub m_delete_group_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_delete_group.Click
		VB6.ShowForm(frm_delete_group, (1))
	End Sub
	
	Public Sub m_Doppelte_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_Doppelte.Click
        Dim bm2, bm1 As System.Array
        Dim memo As String
        Dim ErstesDoppel As Boolean
        Dim i, dAnzahl As Integer
        Dim foto1, foto2 As String
        Dim BackupVorhanden As Boolean
		Dim besteld1, besteld2 As Object
        Dim LetzterDatensatz As Boolean
        Dim Gruppierte As Integer
        Dim Doppelte As Integer = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		db = DAODBEngine_definst.OpenDatabase(datenbank, False, False)
		'Backup?
		'UPGRADE_WARNING: Couldn't resolve default property of object BackupVorhanden. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BackupVorhanden = False
		For i = 0 To db.TableDefs.Count - 1
			If db.TableDefs(i).name = "Artikel_Backup" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object BackupVorhanden. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				BackupVorhanden = True
			End If
		Next i
        Dim antw As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object BackupVorhanden. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If BackupVorhanden Then
			'UPGRADE_WARNING: Couldn't resolve default property of object antw. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			antw = MsgBox("Backup vorhanden. Soll ich das Backup überschreiben?", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Exclamation, "Datenbereinigung - Doppelte konsoliedieren")
			Select Case antw
                Case Is = MsgBoxResult.Cancel
                    Exit Sub
                Case Is = MsgBoxResult.Yes
                    db.Execute(("Drop table Artikel_Backup"))
                    db.Execute(("Select * INTO Artikel_Backup from Artikel"))
            End Select
		Else
			db.Execute(("Select * INTO Artikel_Backup from Artikel"))
		End If
		BIEDER.Enabled = False
		dy = db.CreateDynaset("SELECT * FROM Artikel where besteld>0 order by Foto ASC, ArtNr ASC")
		dy.MoveLast()
		'UPGRADE_WARNING: Couldn't resolve default property of object dAnzahl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dAnzahl = dy.RecordCount
		dy.MoveFirst()
		'Ersten Satz lesen
		'UPGRADE_WARNING: Couldn't resolve default property of object foto1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        foto1 = dy.Fields("Foto").Value.ToString() 'Foto merken
		'UPGRADE_WARNING: Couldn't resolve default property of object memo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        memo = dy.Fields("Omschrijving").Value.ToString() 'Neuer Satz: Beschreibung merken
		'UPGRADE_WARNING: Couldn't resolve default property of object bm1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bm1 = VB6.CopyArray(dy.Bookmark) 'Aktuellen Satz merken
		'UPGRADE_WARNING: Couldn't resolve default property of object ErstesDoppel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ErstesDoppel = True 'Ist nicht ErstesDoppel
		'UPGRADE_WARNING: Couldn't resolve default property of object Doppelte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Doppelte = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Gruppierte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Gruppierte = 0
		BIEDER.Cursor = System.Windows.Forms.Cursors.WaitCursor
		'UPGRADE_WARNING: Couldn't resolve default property of object LetzterDatensatz. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		LetzterDatensatz = False
		Do Until dy.EOF
			dy.MoveNext() 'Ein Datensatz weiter
			If dy.EOF Then 'Wenn letzter Satz
				'UPGRADE_WARNING: Couldn't resolve default property of object foto2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				foto2 = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object LetzterDatensatz. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				LetzterDatensatz = True
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object foto2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                foto2 = dy.Fields("Foto").Value.ToString() 'Foto des neuen Satzes in Foto2 lesen
			End If
			'Foto2 = Foto1 , wie vorheriger Datensatz?
			'UPGRADE_WARNING: Couldn't resolve default property of object foto1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object foto2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If foto2 = foto1 Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Doppelte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Doppelte = Doppelte + 1
				'Besteld=0 des aktuelle Satzes, damit er nicht im WEB erscheint
				dy.Edit()
				dy.Fields("Besteld").Value = 0
				dy.Update()
				'UPGRADE_WARNING: Couldn't resolve default property of object ErstesDoppel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ErstesDoppel Then 'Wenn dies nicht erstesDoppel
					dy.MovePrevious() 'eins zurück, um den Datensatz zu merken
					'UPGRADE_WARNING: Couldn't resolve default property of object bm1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bm1 = VB6.CopyArray(dy.Bookmark) 'Erster Datensatz der Doppelt-Gruppe, Lesezeichen setzen
					'UPGRADE_WARNING: Couldn't resolve default property of object besteld1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					besteld1 = dy.Fields("Besteld").Value
					dy.MoveNext()
					'UPGRADE_WARNING: Couldn't resolve default property of object ErstesDoppel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ErstesDoppel = False
					'UPGRADE_WARNING: Couldn't resolve default property of object Gruppierte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Gruppierte = Gruppierte + 1
				End If
				'Memo um ArtNr und Beschreibung ergänzen
				'UPGRADE_WARNING: Couldn't resolve default property of object memo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                memo = memo + cr + dy.Fields("ArtNr").Value.ToString() + ": " + dy.Fields("Omschrijving").Value.ToString()
			Else
				'Daten des akt. Satzes nicht gleich vorherigem Satz
				If Not ErstesDoppel Then
					'Wenn Datensatz ein Doppel war, dann Daten des ersten Satzes der Gruppe aktualisieren
					If Not LetzterDatensatz Then
						'UPGRADE_WARNING: Couldn't resolve default property of object bm2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						bm2 = VB6.CopyArray(dy.Bookmark) 'Satz merken
						'UPGRADE_WARNING: Couldn't resolve default property of object besteld2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						besteld2 = dy.Fields("Besteld").Value
						'UPGRADE_WARNING: Couldn't resolve default property of object bm1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        dy.Bookmark = bm1 'Zum ersten Satz der Doppel-Gruppe springen
						dy.Edit()
						'UPGRADE_WARNING: Couldn't resolve default property of object memo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        dy.Fields("Omschrijving").Value = dy.Fields("Omschrijving").Value.ToString() + memo
						'UPGRADE_WARNING: Couldn't resolve default property of object besteld1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dy.Fields("Besteld").Value = besteld1
						dy.Update()
						'UPGRADE_WARNING: Couldn't resolve default property of object bm2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dy.Bookmark = bm2 'zurück zum Alten Satz
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object bm1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dy.Bookmark = bm1
						dy.Edit()
						'UPGRADE_WARNING: Couldn't resolve default property of object memo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        dy.Fields("Omschrijving").Value = dy.Fields("Omschrijving").Value.ToString() + memo
						'UPGRADE_WARNING: Couldn't resolve default property of object besteld1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dy.Fields("Besteld").Value = besteld1
						dy.Update()
						Exit Do
					End If
					'Es beginnt ein neuer Block
					'UPGRADE_WARNING: Couldn't resolve default property of object memo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					memo = ""
					'UPGRADE_WARNING: Couldn't resolve default property of object foto1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    foto1 = dy.Fields("Foto").Value.ToString()
					'UPGRADE_WARNING: Couldn't resolve default property of object besteld1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					besteld1 = dy.Fields("Besteld").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object ErstesDoppel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					ErstesDoppel = True
					'UPGRADE_WARNING: Couldn't resolve default property of object bm1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bm1 = VB6.CopyArray(dy.Bookmark)
				End If
				'dy.Fields ("ArtNr") + ": " + dy.Fields("Omschrijving") 'ArtNr und Beschreibung merken
				'UPGRADE_WARNING: Couldn't resolve default property of object memo. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				memo = ""
				If Not dy.EOF Then
					'UPGRADE_WARNING: Couldn't resolve default property of object foto1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    foto1 = dy.Fields("Foto").Value.ToString()
					'UPGRADE_WARNING: Couldn't resolve default property of object besteld1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					besteld1 = dy.Fields("Besteld").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object bm1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					bm1 = VB6.CopyArray(dy.Bookmark)
				End If
			End If
		Loop 
		dy.Close()
		BIEDER.Cursor = System.Windows.Forms.Cursors.Default
		'UPGRADE_WARNING: Couldn't resolve default property of object Gruppierte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Doppelte. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Es wurden insgesamt " & Doppelte & " mehrfach verwendete Fotos gefunden. Diese wurden nun zu " & Gruppierte & " Artikeln reduziert.", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information, "Doppelte bereinigt")
		BIEDER.Enabled = True
	End Sub
	
	Public Sub m_edit_gruppentexte_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_edit_gruppentexte.Click
		VB6.ShowForm(Produktgruppentexte, (1))
	End Sub
	
	Public Sub m_einstellungen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_einstellungen.Click
		frmOptions.ShowDialog()
	End Sub
	
	Public Sub m_ende_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_ende.Click
		write_ini()
		write_colors()
		End
	End Sub
	
	Public Sub m_info_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_info.Click
		frmAbout.ShowDialog()
	End Sub
	
	Public Sub m_rename_group_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_rename_group.Click
		frm_rename_group.ShowDialog()
	End Sub
	
	Public Sub m_SortGroups_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles m_SortGroups.Click
		SortGroups.ShowDialog()
	End Sub
End Class