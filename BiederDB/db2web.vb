Option Strict On
Option Explicit On
Friend Class db2web
	Inherits System.Windows.Forms.Form
	
	'Dim cr, ii
    Dim Status_file As Integer
	Dim ListChanged As Boolean
    Function ArrayHatDuplikate(ByVal aArray As Array) As Boolean
        Dim i, k As Integer
        For i = 1 To UBound(aArray)
            For k = i + 1 To UBound(aArray)
                'UPGRADE_WARNING: Couldn't resolve default property of object aArray(k). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object aArray(i). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If aArray.GetValue(i).ToString() = aArray.GetValue(k).ToString() Then
                    ArrayHatDuplikate = True
                    Exit Function
                End If
            Next k
        Next i
    End Function
    Sub sRemoveDoubleEntries(ByRef ctlCompare As ListBox, ByRef ctlResult As ListBox)

        Dim lRet As Integer
        Dim lFindDoubleItem As Integer
        Dim lRemoveToCompare As Integer

        lFindDoubleItem = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object ctlResult.ListCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For lRemoveToCompare = 0 To ctlResult.Items.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object ctlCompare.ListCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            For lFindDoubleItem = lRemoveToCompare To ctlCompare.Items.Count - 1
                'ctlCompare.ListIndex = lFindDoubleItem
                System.Windows.Forms.Application.DoEvents()
                'UPGRADE_WARNING: Couldn't resolve default property of object ctlResult.List. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object ctlCompare.List. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lRet = StrComp(ctlCompare.Items(lFindDoubleItem).ToString(), ctlResult.Items(lRemoveToCompare).ToString(), CompareMethod.Text)
                Select Case lRet
                    Case 0
                        'UPGRADE_WARNING: Couldn't resolve default property of object ctlResult.RemoveItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        ctlResult.Items.RemoveAt(lRemoveToCompare)
                        lRemoveToCompare = lRemoveToCompare - 1
                        Exit For
                    Case 1
                        Exit For
                End Select
            Next lFindDoubleItem
        Next lRemoveToCompare
    End Sub
	Sub CleanWebDir()
		On Error GoTo 0
        Dim i As Integer ' Object
		filesList.Items.Clear()
		If status("Erstelle Dateiliste WebRoot...") = False Then Exit Sub
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
		For i = 0 To File1.Items.Count - 1
			filesList.Items.Add((File1.Items(i)))
			'filesList.ListIndex = i
		Next i
		'If status("Erstelle Dateiliste WebRoot..." & File1.ListCount - 1 + " Dateien") = False Then Exit Sub
		Me.Refresh()
		'If status("Suche überzählige Dateien...") = False Then Exit Sub
		Me.Refresh()
		System.Windows.Forms.Application.DoEvents()
		sRemoveDoubleEntries(weblist, filesList)
		'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
		If filesList.Items.Count = 0 Then
			MsgBox("Es wurden keine überzähligen Dateien gefunden!", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
			Exit Sub
		End If
        If MsgBox("Es wurden " & filesList.Items.Count & " überzählige Dateien gefunden." & vbCrLf & "Sollen diese jetzt aus dem Webverzeichnis gelöscht werden?", MsgBoxStyle.YesNo, "Webverzeichnis bereinigen") = MsgBoxResult.Yes Then
            If (MsgBox("Wollen Sie die Dateien wirklich löschen?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Überzählige Dateien löschen") = MsgBoxResult.Yes) Then
                'On Error Resume Next
                For i = 0 To filesList.Items.Count - 1
                    System.Windows.Forms.Application.DoEvents()
                    'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    Kill((webroot.ToString() + "\" + VB6.GetItemString(filesList, i)))
                    'filesList.RemoveItem (i)
                    If status("Lösche " & VB6.GetItemString(filesList, i)) = False Then Exit Sub
                Next i
                On Error GoTo 0
            End If
        End If

    End Sub
    Sub savelist()
        Dim f1 As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        f1 = FreeFile()
        'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileOpen(f1, AppPath & "\_publist.ini", OpenMode.Output)
        Dim x As Integer
        For x = 0 To List2.Items.Count - 1
            'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(f1, VB6.GetItemString(List2, x))
            'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            PrintLine(f1, VB6.GetItemData(List2, x))
        Next x
        'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileClose(f1)
    End Sub
    Function status(ByRef s As String) As Boolean
        System.Windows.Forms.Application.DoEvents()
        If Abbruch = True Then
            txt_status.Text = "Abbruch durch User!"
            status = False
            Exit Function
        End If
        txt_status.Text = s
        'UPGRADE_WARNING: Couldn't resolve default property of object Status_file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        PrintLine(Status_file, s)
        status = True
    End Function
    Sub KategorienLesen()
        Dim i, max As Integer
        dyKat = db.CreateDynaset("select * from Hoofdgroep order by SortOrder")
        dyKat.MoveLast()
        'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        max = dyKat.RecordCount
        dyKat.MoveFirst()
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        i = 0
        ReDim kategorie(max)
        'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For i = 0 To max - 1
            'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
            If Not IsDBNull(dyKat.Fields("Hoofdgroep").Value) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                kategorie(i).text = dyKat.Fields("Hoofdgroep").Value.ToString()
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                kategorie(i).ID = Convert.ToUInt16(dyKat.Fields("Hgr_ID").Value)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                List1.Items.Add(kategorie(i).text)
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                VB6.SetItemData(List1, i, kategorie(i).ID)
            Else
                List1.Items.Add("Nicht vorhanden")
                VB6.SetItemData(List1, i, 9999)
            End If
            dyKat.MoveNext()
        Next i
        dyKat.Close()
    End Sub

    Private Sub bt_ab_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_ab.Click
        If List2.SelectedIndex = List2.Items.Count Or List2.SelectedIndex = -1 Then
            Beep()
            Exit Sub
        End If
        Dim txt As Object
        Dim data, idx As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        idx = List2.SelectedIndex
        'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txt = VB6.GetItemString(List2, idx)
        'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        data = VB6.GetItemData(List2, idx)
        List2.Items.RemoveAt((idx))
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        List2.Items.Insert(idx + 1, (txt))
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VB6.SetItemData(List2, idx + 1, data)
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        List2.SelectedIndex = idx + 1

    End Sub

    Private Sub bt_AktuellBearbeiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_AktuellBearbeiten.Click
        Const SW_SHOWMAXIMIZED As Short = 3
        'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Dim ant As Integer
        If existfile(webroot + "\aktuell.htm") Then
            'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object ant. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ant = MsgBox("Vorhandene aktuell.htm bearbeiten (J) oder überschreiben (N)?", MsgBoxStyle.YesNoCancel, webroot + "\aktuell.htm vorhanden")
            If ant = MsgBoxResult.Cancel Then Exit Sub
            If ant = MsgBoxResult.Yes Then
                'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ShellExecute(Me.Handle.ToInt32, "Edit", webroot + "\aktuell.htm", CStr(0), CStr(0), SW_SHOWMAXIMIZED)
            End If
            If ant = MsgBoxResult.No Then
                'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                FileCopy(AppPath & "\aktuell.htm", webroot + "\aktuell.htm")
                'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                ShellExecute(Me.Handle.ToInt32, "Edit", webroot + "\aktuell.htm", CStr(0), CStr(0), SW_SHOWMAXIMIZED)
            End If
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            FileCopy(AppPath & "\aktuell.htm", webroot + "\aktuell.htm")
            'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ShellExecute(Me.Handle.ToInt32, "Edit", webroot + "\aktuell.htm", CStr(0), CStr(0), SW_SHOWMAXIMIZED)
        End If
    End Sub

    Private Sub bt_auf_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_auf.Click
        If List2.SelectedIndex < 1 Then
            Beep()
            Exit Sub
        End If
        Dim txt As Object
        Dim data, idx As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        idx = List2.SelectedIndex
        'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        txt = VB6.GetItemString(List2, idx)
        'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        data = VB6.GetItemData(List2, idx)
        List2.Items.RemoveAt((idx))
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        List2.Items.Insert(idx - 1, (txt))
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        VB6.SetItemData(List2, idx - 1, data)
        'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        List2.SelectedIndex = idx - 1
    End Sub

    Private Sub bt_cancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_cancel.Click
        Abbruch = True
    End Sub

    Private Sub bt_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_close.Click
        Me.Close()
    End Sub
    Sub DateiKopie(ByRef q As String, ByRef z As String)
        If Not IsReadOnly(z) Then
            FileCopy(q, z)
            If status("Kopiere " & q & " nach " & z) = False Then
            End If
        Else
            If status("Zieldatei " & z & " ist schreibgeschützt!") = False Then
            End If
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object GetExtension(z). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        weblist.Items.Add((GetFilename(z) + "." + GetExtension(z)))

    End Sub

    Private Sub bt_copy_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_copy.Click
        If List1.SelectedIndex = -1 Then Exit Sub
        List2.Items.Add((VB6.GetItemString(List1, List1.SelectedIndex)))
        VB6.SetItemData(List2, List2.Items.Count - 1, VB6.GetItemData(List1, List1.SelectedIndex))

    End Sub

    Private Sub bt_savelist_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_savelist.Click
        savelist()
    End Sub

    Private Sub bt_start_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_start.Click
        'List2 enthält die zu publizierenden Kategorien
        'UPGRADE_WARNING: Arrays in structure snap may need to be initialized before they can be used. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="814DF224-76BD-4BB4-BFFB-EA359CB9FC48"'
        Dim snap As dao.Recordset 'Snapshot
        Dim NumLoops, MaxArtikel, ArtikelProSeite, LeftOver As Integer
        Dim SeiteZahl, beschreibung, foto, ArtNr, foto_th, masse As String
        Dim s, AnzahlSeiten, Rest, Seite, Artikel As Integer
        Dim nur1Gruppe As Boolean
        Dim KategorieHtml As String
        Dim i, file_kategorie, file_Artikel, file_left As Integer
        Dim ArtikelHtml, LeftHtml As String
        Dim nCount As Integer
        bt_view.Enabled = False
        bt_AktuellBearbeiten.Enabled = False
        weblist.Items.Clear()
        If List2.Items.Count = 0 Then
            MsgBox("Keine Gruppen gewählt")
            Exit Sub
        End If
        If chk_nur1Gruppe.CheckState = 1 Then
            nur1Gruppe = True
        Else
            nur1Gruppe = False
        End If
        If nur1Gruppe And List2.SelectedIndex = -1 Then
            MsgBox("Sie haben nur 1 Gruppe gewählt aber keine Gruppe ist markiert!")
            Exit Sub
        Else
        End If
        'UPGRADE_WARNING: Dir has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If Dir(Text2.Text, FileAttribute.Directory) = "" Then
            MsgBox("Fehler: Kann Verzeichnis: " & ii & Text2.Text & ii & " nicht finden!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        txt_status.Text = ""
        Abbruch = False
        'UPGRADE_WARNING: Couldn't resolve default property of object Status_file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Status_file = FreeFile()
        'UPGRADE_WARNING: Couldn't resolve default property of object Status_file. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileOpen(Status_file, AppPath & "\_status.log", OpenMode.Output)
        If status("Weberstellung, " & Today & TimeOfDay) = False Then GoTo abort
        If nur1Gruppe Then
            If status("Erstelle nur Dateien für die Gruppe: '" & VB6.GetItemString(List2, List2.SelectedIndex) & "' neu") = False Then GoTo abort
        End If
        bt_start.Enabled = False
        bt_close.Enabled = False
        bt_cancel.Enabled = True
        Dim p As Integer
        Dim PortalHtml As String
        Dim PortalTexte() As String
        Dim StandardText As String
        Dim f As Integer
        Dim tmp As String
        If nur1Gruppe = False Then
            'Index-, Main- und Top-Datei kopieren
            DateiKopie(AppPath & "\_topback.gif", Text2.Text & "\_topback.gif")
            DateiKopie(AppPath & "\_lftback.gif", Text2.Text & "\_lftback.gif")
            DateiKopie(AppPath & "\_mainback.gif", Text2.Text & "\_mainback.gif")
            DateiKopie(AppPath & "\_artback.gif", Text2.Text & "\_artback.gif")
            DateiKopie(AppPath & "\_weg.gif", Text2.Text & "\_weg.gif")
            'DateiKopie AppPath + "\logo-falk.gif", Text2.text + "\logo-falk.gif"
            DateiKopie(AppPath & "\_index.htm", Text2.Text & StartSeite)
            DateiKopie((Text3.Text), Text2.Text & "\_main.htm")
            DateiKopie((Text1.Text), Text2.Text & "\_top.htm")
            DateiKopie(AppPath & "\_weg.htm", Text2.Text & "\_weg.htm")
            'DateiKopie AppPath + "\aktuell.htm", Text2.text + "\aktuell.htm"
            'Left Frame
            'Die linke Seite sollte mit dem Start-Link anfangen
            'danach alle Kategorien listen. Das bedeutet eine index.htm, eine left.htm,
            'eine main.htm, eine top.htm,
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = ""
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = "<html>" & cr & "<head>" & cr & "<title>" & "Der Biedermann - Landhausmöbel in Wuppertal" & "</title>" & cr
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "<meta http-equiv=" + ii + "Content-Type" + ii + " content=" + ii + "text/html; charset=ISO-8859-1" + ii + ">" + cr
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "<meta name=" + ii + "GENERATOR" + ii + " content=" + ii + "bieder.db (c)HJ Gode" + ii + ">" + cr
            'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + keywords_htm + cr + "</head>"
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "<body bgcolor=" + ii + farben(left_bgcolor).html + ii + " text=" + ii + farben(left_txtcolor).html + ii
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If bg_left = 1 Then LeftHtml = LeftHtml + " background=" + ii + "_lftback.gif" + ii
            'link="#FFFFFF" vlink="#00FF00" alink="#FF00FF"
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + " link=" + ii + farben(left_link).html + ii
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + " vlink=" + ii + farben(left_vlink).html + ii
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + " alink=" + ii + farben(left_alink).html + ii + ">" + cr
            'Start-Link
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "<table bgcolor=" + ii + farben(left_tbl_bgcolor).html + ii
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + " bordercolor=" + ii + farben(left_tbl_bordercolor).html + ii
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + " border=" + htmValue("2")
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + " bordercolorlight=" + ii + farben(left_bordercolorlight).html + ii
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + " bordercolordark=" + ii + farben(left_bordercolordark).html + ii + ">" + cr
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "<tr><td align=" + htmValue("center") + "><a href=" + htmValue(StartSeite) + " target=" + htmValue("_parent") + ">" + "START" + "</a><br></td></tr>" + cr + "<tr><td align=" + htmValue("center") + "><a href=" + htmValue("aktuell.htm") + " target=" + htmValue("main") + ">" + "Aktuelles" + "</a><br></td></tr>" + cr
            'Standard Portaltext lesen
            If existfile(AppPath & "\stdgrp.txt") Then
                'UPGRADE_WARNING: Couldn't resolve default property of object StandardText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                StandardText = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                f = FreeFile()
                'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                FileOpen(f, AppPath & "\stdgrp.txt", OpenMode.Input)
                'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                While Not EOF(f)
                    'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    tmp = LineInput(f)
                    'UPGRADE_WARNING: Couldn't resolve default property of object StandardText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    StandardText = Text2.Text & tmp & vbCrLf
                End While
                'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                FileClose(f)
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object StandardText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                StandardText = "Auf den Produktübersichtseiten finden Sie im oberen Bereich Zahlen für die einzelnen Seiten." & vbCrLf & "Klicken Sie auf die Seitenzahlen, um zwischen den Seiten zu wechseln." & vbCrLf & "Die Produktübersichtseiten enthalten kleine Abbildungen und Texte dazu." & vbCrLf & "Klicken Sie auf eine Abbildung, um das Produktbild zu vergrössern."
            End If

            'Portal-Texte lesen
            ReDim PortalTexte(List2.Items.Count - 1)
            For i = 0 To List2.Items.Count - 1
                snap = db.CreateSnapshot("select Produkttext from HoofdGroep where hgr_id = " & VB6.GetItemData(List2, i))
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If (IsDBNull(snap.Fields("Produkttext").Value)) Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object StandardText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    PortalTexte(i) = text2htm(StandardText)
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    PortalTexte(i) = text2htm(snap.Fields("Produkttext").Value.ToString())
                End If
            Next i
            snap.Close()
            'Portal-Texte lesen ENDE

            For i = 0 To List2.Items.Count - 1
                If status("Lefthtm: Erstelle Link für: " & VB6.GetItemString(List2, i)) = False Then GoTo abort
                'Jeweils Link auf erste Artikelseite (zB betten00.htm) erstellen
                'NEU: Jetzt auf die Portalseiten gelinkt
                'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                LeftHtml = LeftHtml + "<tr><td align=" + ii + "center" + ii + "><a href=" + ii + EscapeLink(VB6.GetItemString(List2, i)) + ".htm" + ii + " target=" + ii + "main" + ii + ">" + text2htm(VB6.GetItemString(List2, i)) + "</a><br></td></tr>" + cr
                'Portalseiten für Produktgruppen (betten.htm etc.) erstellen
                If status("PortalHtml: Erstelle Portalseite für: " & VB6.GetItemString(List2, i)) = False Then GoTo abort
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = "<html>" & cr & "<head>" & cr & "<title>" & text2htm(VB6.GetItemString(List2, i)) & " - Der Biedermann - Landhausmöbel in Wuppertal" & "</title>" & cr
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + "<meta http-equiv=" + ii + "Content-Type" + ii + " content=" + ii + "text/html; charset=ISO-8859-1" + ii + ">" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + "<meta name=" + ii + "GENERATOR" + ii + " content=" + ii + "bieder.db (c)HJ Gode" + ii + ">" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + keywords_htm + "</head>" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + "<body bgcolor=" + htmValue(farben(portal_bgcolor).html) + " text=" + htmValue(farben(portal_txtcolor).html)
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If bg_main = 1 Then PortalHtml = PortalHtml + " background=" + htmValue("_mainback.gif")
                'link="#FFFFFF" vlink="#00FF00" alink="#FF00FF"
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + " link=" + ii + farben(portal_link).html + ii
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + " vlink=" + ii + farben(portal_vlink).html + ii
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + " alink=" + ii + farben(portal_alink).html + ii + ">" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + "<h2>" + "Produktgruppe: " + text2htm(VB6.GetItemString(List2, i)) + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + "<small>[<a href=" + ii + EscapeLink(VB6.GetItemString(List2, i)) + "00.htm" + ii + " target=" + ii + "main" + ii + ">" + "Weiter zu den Produkten</a>]</small>" + "</h2>"
                'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + "<b>" + PortalTexte(i) + "</b>" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object LoadFrameSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + LoadFrameSet + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object PortalHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PortalHtml = PortalHtml + "</body>" + cr + "</html>"
                If Not IsReadOnly(Text2.Text & "\" & VB6.GetItemString(List2, i) & ".htm") Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    p = FreeFile()
                    'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    FileOpen(p, Text2.Text & "\" & VB6.GetItemString(List2, i) & ".htm", OpenMode.Output)
                    weblist.Items.Add((VB6.GetItemString(List2, i) & ".htm"))
                    'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    PrintLine(p, PortalHtml)
                    'UPGRADE_WARNING: Couldn't resolve default property of object p. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    FileClose(p)
                Else
                    If status("PortalHtml: Portalseite für: " & VB6.GetItemString(List2, i) & " ist schreibgeschützt!") = False Then GoTo abort
                End If
            Next i
            'Nun der Link für die Wegbeschreibung
            If status("Lefthtm: Erstelle Link für: Wegbeschreibung") = False Then GoTo abort
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "<tr><td align=" + ii + "center" + ii + "><a href=" + ii + "_weg.htm" + ii + " target=" + ii + "main" + ii + ">" + "Wegbeschreibung" + "</a><br></td></tr>" + cr
            'Nun der Link für Infos und Webmaster
            If status("Lefthtm: Erstelle Link für: Info") = False Then GoTo abort
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "<tr><td align=" + htmValue("center") + "><a href=" + ii + Info_anfordern + ii + " target=" + ii + "main" + ii + ">" + "Infos anfordern" + "<br></a></td></tr>" + cr + "<tr><td align=" + htmValue("center") + "><small><a href=" + ii + "mailto:webmaster@derbiedermann.de" + ii + "><i>Mail an Webmaster</i></a></small></td></tr>" + cr
            'Counter und ENDE Lefthtml
            If status("Lefthtm: Erstelle Link für: Counter") = False Then GoTo abort
            'UPGRADE_WARNING: Couldn't resolve default property of object Counter_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + "</table><br>" + Counter_htm + "<br><small>Letze &Auml;nderung: " & Today & "</small>"
            'UPGRADE_WARNING: Couldn't resolve default property of object LoadFrameSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object LeftHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            LeftHtml = LeftHtml + LoadFrameSet + cr + "</body>" + cr + "</html>"
            If Not IsReadOnly(Text2.Text & "\_left.htm") Then
                'UPGRADE_WARNING: Couldn't resolve default property of object file_left. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                file_left = FreeFile()
                'UPGRADE_WARNING: Couldn't resolve default property of object file_left. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                FileOpen(file_left, Text2.Text & "\_left.htm", OpenMode.Output)
                weblist.Items.Add(("_left.htm"))
                'UPGRADE_WARNING: Couldn't resolve default property of object file_left. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                PrintLine(file_left, LeftHtml)
                'UPGRADE_WARNING: Couldn't resolve default property of object file_left. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                FileClose(file_left)
            Else
                If status("Datei: " & Text2.Text & "\_left.htm ist schreibgeschützt!") = False Then GoTo abort
            End If
        End If 'nur1Gruppe = False
        'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelProSeite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ArtikelProSeite = 12
        'UPGRADE_WARNING: Couldn't resolve default property of object SeiteZahl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        SeiteZahl = VB6.Format(0, "00")
        Dim seitenliste As String
        For i = 0 To List2.Items.Count - 1
            'Wenn nur1Gruppe und i nicht der gewählte Eintrag ist, überspringe alles
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If nur1Gruppe And List2.SelectedIndex <> i Then GoTo ExitFor_i
            snap = db.CreateSnapshot("select * from artikel where hgr_id=" & VB6.GetItemData(List2, i) & " AND Besteld > 0 order by ArtNr")
            If snap.RecordCount > 0 Then
                snap.MoveLast()
                snap.MoveFirst()
            End If
            If ((snap.BOF) And (snap.EOF)) Or (snap.RecordCount = 0) Then 'Kein Artikel gefunden
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxArtikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxArtikel = 0
            Else
                snap.MoveLast()
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxArtikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                MaxArtikel = snap.RecordCount
                snap.MoveFirst()
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object MaxArtikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If MaxArtikel = 0 Then
                If status("Kein Artikel vorhanden, überspringe Kategorie: " & VB6.GetItemString(List2, i)) = False Then GoTo abort
                GoTo ExitFor_i
            End If
            'Wieviele Übersichtseiten brauchen wir
            'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelProSeite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object MaxArtikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object AnzahlSeiten. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            AnzahlSeiten = MaxArtikel \ ArtikelProSeite
            'Gibt es einen Rest?
            'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelProSeite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object MaxArtikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Rest. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Rest = MaxArtikel Mod ArtikelProSeite
            'UPGRADE_WARNING: Couldn't resolve default property of object Rest. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object AnzahlSeiten. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Rest > 0 Then AnzahlSeiten = AnzahlSeiten + 1
            'UPGRADE_WARNING: Couldn't resolve default property of object AnzahlSeiten. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            For Seite = 0 To AnzahlSeiten - 1
                'For n=0 to MaxArtikel
                'KategorieHtml enthält Artikel-Übersicht
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = "<html>" & cr & "<head>" & cr & "<title>" & "Der Biedermann - Landhausmöbel in Wuppertal" & "</title>" & cr
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + "<meta http-equiv=" + ii + "Content-Type" + ii + " content=" + ii + "text/html; charset=ISO-8859-1" + ii + ">" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + "<meta name=" + ii + "GENERATOR" + ii + " content=" + ii + "bieder.db (c)HJ Gode" + ii + ">" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object keywords_htm. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + keywords_htm + "</head>" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + "<body bgcolor=" + htmValue(farben(kategorie_bgcolor).html) + " text=" + htmValue(farben(kategorie_txtcolor).html)
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If bg_main = 1 Then KategorieHtml = KategorieHtml + " background=" + htmValue("_mainback.gif")
                'link="#FFFFFF" vlink="#00FF00" alink="#FF00FF"
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + " link=" + ii + farben(kategorie_link).html + ii
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + " vlink=" + ii + farben(kategorie_vlink).html + ii
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + " alink=" + ii + farben(kategorie_alink).html + ii + ">" + cr
                'UPGRADE_WARNING: Couldn't resolve default property of object MaxArtikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + "<h2>" + text2htm(VB6.GetItemString(List2, i)) + "</h2>" + cr + "<p align=" + htmValue("right") + "<small>Gesamtartikel " & MaxArtikel & ", " & Today & "</small></p>"
                'Seiten Link-Listenzeile
                'UPGRADE_WARNING: Couldn't resolve default property of object seitenliste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                seitenliste = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object AnzahlSeiten. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                For s = 0 To AnzahlSeiten - 1
                    'UPGRADE_WARNING: Couldn't resolve default property of object Seite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If s = Seite Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object seitenliste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        seitenliste = seitenliste + "Seite " + VB6.Format(s, "00") + " - "
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object s. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object seitenliste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        seitenliste = seitenliste + "<a href=" + ii + EscapeLink(VB6.GetItemString(List2, i)) + VB6.Format(s, "00") + ".htm" + ii + ">Seite " + VB6.Format(s, "00") + "</a> - "
                    End If
                Next s
                'UPGRADE_WARNING: Couldn't resolve default property of object seitenliste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + seitenliste
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + "<br><hr>" + cr + "<Table>" + cr 'Tabelle
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + "<TR valign=" + ii + "top" + ii + ">" + cr 'Neue Zeile
                'Jeweils x Artikel pro Seite
                'UPGRADE_WARNING: Couldn't resolve default property of object nCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                nCount = 1
                'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelProSeite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                For Artikel = 1 To ArtikelProSeite
                    'UPGRADE_WARNING: Couldn't resolve default property of object Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelProSeite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Seite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Seite * ArtikelProSeite + Artikel > MaxArtikel Then GoTo ExitFor_Artikel
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If Not IsDBNull(snap.Fields("Omschrijving").Value) Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object beschreibung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        beschreibung = text2htm(snap.Fields("Omschrijving").Value.ToString())
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object beschreibung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        beschreibung = "-"
                    End If
                    'If Not IsNull(snap.Fields("Maat")) Then
                    '    masse = text2htm("Maße: ") + text2htm(snap.Fields("Maat"))
                    'Else
                    '    masse = text2htm("Maße: -")
                    'End If
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    If Not IsDBNull(snap.Fields("ArtNr").Value) Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        ArtNr = text2htm(snap.Fields("ArtNr").Value.ToString())
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        ArtNr = "-"
                    End If
                    'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Not IsDBNull(snap.Fields("foto").Value) Then foto = snap.Fields("Foto").Value.ToString()
                    'Foto im Zielverzeichnis nicht vorhanden?
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetExtension(foto). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Not (existfile(Text2.Text & "\" + GetFilename(foto) + "." + GetExtension(foto))) Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If existfile(foto) Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            If status("Kopiere " + foto) = False Then GoTo abort
                            'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object GetExtension(foto). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            FileCopy(foto, Text2.Text & "\" + GetFilename(foto) + "." + GetExtension(foto))
                        Else
                            'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            If status("Foto-Datei nicht gefunden: " + foto) = False Then GoTo abort
                        End If
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If status("Foto-Datei schon im Zielverzeichnis: " + foto) = False Then GoTo abort

                    End If
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetExtension(foto). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    foto = GetFilename(foto) + "." + GetExtension(foto)
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object GetFilename(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto_th. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    foto_th = GetFilename(foto) + "_th.jpg"
                    weblist.Items.Add((foto))
                    weblist.Items.Add((foto_th))
                    'Thumbnail schon da? sonst erstellen
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto_th. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Not existfile(Text2.Text & "\" + foto_th) Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object foto_th. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If status("Erstelle Thumbnail: " + foto_th) = False Then GoTo abort
                        'UPGRADE_WARNING: Couldn't resolve default property of object foto_th. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If Not createThumbnail(foto, foto_th, Text2.Text) Then
                            'UPGRADE_WARNING: Couldn't resolve default property of object foto_th. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                            If status("Thumbnail Erstellung fehlgeschlagen: " + foto_th) = False Then GoTo abort
                        End If
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object foto_th. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If status("Thumbnail schon vorhanden: " + foto_th) = False Then GoTo abort
                    End If
                    'Pro Artikel eine Datei mit Grossbild anlegen
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
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If bg_artikel = 1 Then ArtikelHtml = ArtikelHtml + " background=" + htmValue("_artback.gif") + cr
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ArtikelHtml = ArtikelHtml + " link=" + ii + farben(artikel_link).html + ii + " vlink=" + ii + farben(artikel_vlink).html + ii + " alink=" + ii + farben(artikel_alink).html + ii + ">" + cr
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
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ArtikelHtml = ArtikelHtml + "<h2>" + VB6.GetItemString(List2, i) + "</h2><h3>ArtNr: " + ArtNr + "</h3>"
                    'UPGRADE_WARNING: Couldn't resolve default property of object beschreibung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ArtikelHtml = ArtikelHtml + beschreibung + "<br>" + cr
                    'ArtikelHtml = ArtikelHtml + masse + "<br><hr>" + cr
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ArtikelHtml = ArtikelHtml + "<hr>" + cr
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ArtikelHtml = ArtikelHtml + "<img src=" + ii + EscapeLink(foto) + ii + " width=640 height=480>"
                    '<img border="0" src="bedden/bed601-bed606+bed674.jpg" width="640" height="480">
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtikelHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    ArtikelHtml = ArtikelHtml + "</body>" + cr + "</html>"
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If Not IsReadOnly(Text2.Text & "\" + ArtNr + ".htm") Then
                        'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        file_Artikel = FreeFile()
                        'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        FileOpen(file_Artikel, Text2.Text & "\" + ArtNr + ".htm", OpenMode.Output)
                        'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If status("Schreibe Html für: " + ArtNr) = False Then GoTo abort
                        'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        PrintLine(file_Artikel, ArtikelHtml)
                        'UPGRADE_WARNING: Couldn't resolve default property of object file_Artikel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        FileClose(file_Artikel)
                    Else
                        'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        If status("Html für: " + ArtNr + " ist schreibgeschützt!") = False Then GoTo abort
                    End If
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    weblist.Items.Add((ArtNr + ".htm"))
                    'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    KategorieHtml = KategorieHtml + "<TD width=" + htmValue("25%") + ">" + cr
                    'UPGRADE_WARNING: Couldn't resolve default property of object ArtNr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    KategorieHtml = KategorieHtml + "<a href=" + ii + EscapeLink(ArtNr) + ".htm" + ii + " target=" + ii + "ZOOM" + ii + ">" + ArtNr + "<br>"
                    'UPGRADE_WARNING: Couldn't resolve default property of object foto_th. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    KategorieHtml = KategorieHtml + "<img src=" + ii + EscapeLink(foto_th) + ii + " width=160 height=120></a><br>"
                    'UPGRADE_WARNING: Couldn't resolve default property of object beschreibung. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    KategorieHtml = KategorieHtml + beschreibung + "<br>" + cr
                    'KategorieHtml = KategorieHtml + masse + "<br>" + cr
                    'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    KategorieHtml = KategorieHtml + "</TD>" + cr
                    'Neue Tabellenzeile alle 4 spalten
                    'UPGRADE_WARNING: Mod has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If (nCount) Mod 4 = 0 Then KategorieHtml = KategorieHtml + "</TR>" + cr + "<TR valign=" + ii + "top" + ii + ">" + cr
                    'UPGRADE_WARNING: Couldn't resolve default property of object nCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    nCount = nCount + 1
                    snap.MoveNext()
                Next Artikel
ExitFor_Artikel:
                'UPGRADE_WARNING: Couldn't resolve default property of object LoadFrameSet. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object seitenliste. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object KategorieHtml. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                KategorieHtml = KategorieHtml + "</TR></Table>" + "<hr>" + seitenliste + "<br>" + LoadFrameSet + cr + "</body>" + cr + "</html>"
                'Datei schreibgeschützt?
                'UPGRADE_WARNING: Couldn't resolve default property of object Seite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Not IsReadOnly(Text2.Text & "\" & VB6.GetItemString(List2, i) & VB6.Format(Seite, "00") & ".htm") Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object file_kategorie. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    file_kategorie = FreeFile()
                    'UPGRADE_WARNING: Couldn't resolve default property of object Seite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If status("Schreibe Webseite " & Text2.Text & "\" & VB6.GetItemString(List2, i) & VB6.Format(Seite, "00") & ".htm") = False Then GoTo abort
                    'UPGRADE_WARNING: Couldn't resolve default property of object file_kategorie. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'UPGRADE_WARNING: Couldn't resolve default property of object Seite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    FileOpen(file_kategorie, Text2.Text & "\" & VB6.GetItemString(List2, i) & VB6.Format(Seite, "00") & ".htm", OpenMode.Output)
                    'UPGRADE_WARNING: Couldn't resolve default property of object file_kategorie. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    PrintLine(file_kategorie, KategorieHtml)
                    'UPGRADE_WARNING: Couldn't resolve default property of object file_kategorie. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    FileClose(file_kategorie)
                Else
                    'UPGRADE_WARNING: Couldn't resolve default property of object Seite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    If status("Webseite " & Text2.Text & "\" & VB6.GetItemString(List2, i) & VB6.Format(Seite, "00") & ".htm ist schreibgeschützt!") = False Then GoTo abort
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object Seite. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                weblist.Items.Add((VB6.GetItemString(List2, i) & VB6.Format(Seite, "00") & ".htm"))
            Next Seite
            'NumLoops = MaxArtikel \ ArtikelProSeite   'Anzahl Durchläufe
            'LeftOver = MaxArtikel Mod ArtikelProSeite 'Rest - Artikel
            'For n = 1 To NumLoops 'Für jede Seite je 12 Artikel
ExitFor_i:
        Next i
        If status("FERTIG, " & Today & ", " & TimeOfDay) = False Then GoTo abort
        'je eine kategorie_x.htm und zu jedem Artikel eine artikel_x.htm
        'mit Grossbild und Text
        'Für jede Kategorie muss eine Indexdatei mit den Thumbnails erstellt werden
        'Alle Quelldateien müssen nach WebRoot kopiert werden
        'Für jedes Bild muss das Thumbnail ermittelt werden
        'Für jedes Thumbnail muss eine HTM-Datei mit dem Grossbild und dem Text generiert werden
abort:
        'On Error Resume Next
        FileClose((file_kategorie))
        FileClose((file_Artikel))
        If chk_cleanwebdir.Enabled And chk_cleanwebdir.CheckState = System.Windows.Forms.CheckState.Checked Then
            CleanWebDir()
        End If
        FileClose((Status_file))
        bt_start.Enabled = True
        bt_close.Enabled = True
        bt_cancel.Enabled = False
        bt_view.Enabled = True
        bt_AktuellBearbeiten.Enabled = True
    End Sub
	
	Private Sub bt_view_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_view.Click
		Const SW_SHOWMAXIMIZED As Short = 3
		'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ShellExecute(Me.Handle.ToInt32, "Open", webroot + "\" + StartSeite, CStr(0), CStr(0), SW_SHOWMAXIMIZED)
	End Sub
	
	'UPGRADE_WARNING: Event chk_nur1Gruppe.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chk_nur1Gruppe_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chk_nur1Gruppe.CheckStateChanged
		If chk_nur1Gruppe.CheckState = System.Windows.Forms.CheckState.Checked Then
			chk_cleanwebdir.Enabled = False
		Else
			chk_cleanwebdir.Enabled = True
		End If
	End Sub
	
	Private Sub Command1_Click()
		
	End Sub
	
	Private Sub db2web_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		bt_view.Enabled = True
		cr = Chr(13) & Chr(10)
		ii = Chr(34)
		ListChanged = False
		Abbruch = False
		KategorienLesen()
		'UPGRADE_WARNING: Couldn't resolve default property of object webkopf. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text1.Text = webkopf
		'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text2.Text = webroot
		'UPGRADE_WARNING: Couldn't resolve default property of object startpage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text3.Text = startpage
		'UPGRADE_WARNING: Couldn't resolve default property of object webroot. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		File1.path = webroot
        Dim f1 As Integer
        Dim x, tmp As Integer
		If existfile(AppPath & "\_publist.ini") Then
			'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			f1 = FreeFile
			'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileOpen(f1, AppPath & "\_publist.ini", OpenMode.Input)
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = 0
			'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			While Not EOF(f1)
				'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Input(f1, tmp)
				List2.Items.Add((tmp))
				'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Input(f1, tmp)
				'UPGRADE_WARNING: Couldn't resolve default property of object tmp. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				VB6.SetItemData(List2, x, tmp)
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = x + 1
			End While
			'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			FileClose(f1)
		End If
		txt_StartSeite.Text = StartSeite
		If StartSeite <> "index.htm" Then frmOptions.StartSeitenWarnung()
	End Sub
	
	Private Sub db2web_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If ListChanged Then
			If MsgBox("Aktuelle Liste speichern?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "FRAGE") = MsgBoxResult.Yes Then savelist()
		End If
	End Sub
	
	Private Sub List1_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.DoubleClick
		List2.Items.Add((VB6.GetItemString(List1, List1.SelectedIndex)))
		VB6.SetItemData(List2, List2.Items.Count - 1, VB6.GetItemData(List1, List1.SelectedIndex))
		ListChanged = True
	End Sub
	
	Private Sub List2_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List2.DoubleClick
		List2.Items.RemoveAt((List2.SelectedIndex))
		ListChanged = True
	End Sub
End Class