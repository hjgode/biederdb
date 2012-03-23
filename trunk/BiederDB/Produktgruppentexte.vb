Option Strict On
Option Explicit On
Friend Class Produktgruppentexte
	Inherits System.Windows.Forms.Form
    Dim abfrage As String
	Dim info() As infotype
	Dim DataChanged As Boolean
	Dim neusatz As Boolean
	
	
	Private Sub bt_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_close.Click
		If DataChanged Then ' ein feld wurde geändert
            If MsgBox("Der aktuelle Datensatz wurde geändert! Sichern?", MsgBoxStyle.YesNo, "FRAGE") = MsgBoxResult.Yes Then sichern_Click(sichern, New System.EventArgs())
        End If
        Me.Hide()
    End Sub

    Private Sub bt_insertdefaulttext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_insertdefaulttext.Click
        If MsgBox("Den Standardtext einsetzen? Der vorhandene Text geht verloren.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Produkttext ändern") = MsgBoxResult.Yes Then
            Text1(2).Text = Text2.Text
        End If
    End Sub

    Private Sub Command1_Click()

    End Sub

    Private Sub bt_save_stdtext_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_save_stdtext.Click
        Dim f As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        f = FreeFile()
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileOpen(f, AppPath & "\stdgrp.txt", OpenMode.Output)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        PrintLine(f, Text2.Text)
        'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileClose(f)
    End Sub

    Private Sub Produktgruppentexte_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Short
        Dim f As Integer
        Dim tmp As String
        If existfile(AppPath & "\stdgrp.txt") Then
            Text2.Text = ""
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            f = FreeFile()
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            FileOpen(f, AppPath & "\stdgrp.txt", OpenMode.Input)
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            While Not EOF(f)
                'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                tmp = LineInput(f)
                Text2.Text = Text2.Text & tmp & vbCrLf
            End While
            'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            FileClose(f)
        Else
            Text2.Text = "Auf den Produktübersichtseiten finden Sie im oberen Bereich Zahlen für die einzelnen Seiten." & vbCrLf & "Klicken Sie auf die Seitenzahlen, um zwischen den Seiten zu wechseln." & vbCrLf & "Die Produktübersichtseiten enthalten kleine Abbildungen und Texte dazu." & vbCrLf & "Klicken Sie auf eine Abbildung, um das Produktbild zu vergrössern."
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object datenbank. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        db = DAODBEngine_definst.OpenDatabase(datenbank, False, False)
        definiere_hoofdgroep()
        'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        While info(i).feldname <> ""
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: TextBox property Text1.MaxLength has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
            If info(i).size <> 0 And info(i).type = DB_TEXT Then Text1(i).MaxLength = info(i).size
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Label1(i).Text = info(i).feldname
            Text1(i).Text = ""
            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            i = i + 1S 'add a short 1
        End While
        neusatz = False
        DataChanged = False
        QueryData()
    End Sub
    Private Sub QueryData()
        Dim i As Integer
        'UPGRADE_WARNING: Couldn't resolve default property of object abfrage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        dy = db.CreateDynaset(abfrage)
        dy.MoveLast()
        dy.MoveFirst()
        GruppenListe.Items.Clear()
        For i = 0 To dy.RecordCount - 1
            GruppenListe.Items.Insert(i, (dy.Fields("Hoofdgroep").Value))
            VB6.SetItemData(GruppenListe, i, Convert.ToInt16(dy.Fields("Hgr_ID").Value))
            dy.MoveNext()
        Next i
        GruppenListe.SelectedIndex = 0
        dy.MoveFirst()
        darstellen()
        DataChanged = False

    End Sub
    Public Sub darstellen()
        Dim i As Short
        i = 0
        While info(i).feldname <> ""
            Text1(i).Text = auslesen(dy.Fields(info(i).feldname), info(i).type)
            i = i + 1S
        End While
        DataChanged = False
    End Sub

    Private Sub Produktgruppentexte_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        dy.Close()
    End Sub


    'UPGRADE_WARNING: Event GruppenListe.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub GruppenListe_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GruppenListe.SelectedIndexChanged
        If DataChanged Then If MsgBox("Der aktuelle Datensatz wurde geändert! Sichern?", MsgBoxStyle.YesNo, "FRAGE") = MsgBoxResult.Yes Then sichern_Click(sichern, New System.EventArgs())
        dy.FindFirst(("Hgr_ID=" & Str(VB6.GetItemData(GruppenListe, GruppenListe.SelectedIndex))))
        darstellen()
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

    Private Sub definiere_hoofdgroep()
        Dim anzahl, i As Short
        ' Welche Tabelle soll verwendet werden ? SQL-Befehl ...
        'UPGRADE_WARNING: Couldn't resolve default property of object abfrage. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        abfrage = "SELECT * from hoofdgroep order by SortOrder"
        ' wieviele Datenfelder ?
        anzahl = 2
        ReDim info(3)
        'Ändern Sie gegebenenfalls an dieser Stelle ...
        info(0).feldname = "Hoofdgroep"
        info(0).not_null = True
        info(0).type = DB_TEXT
        info(0).size = 30
        info(1).feldname = "Hgr_Id"
        info(1).not_null = True
        info(1).type = DB_LONG
        info(1).size = 0
        info(2).feldname = "Produkttext"
        info(2).not_null = False
        info(2).type = DB_MEMO
        info(2).size = 0
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
	
	Private Sub sichern_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sichern.Click
		If (Not neusatz) And (Not DataChanged) Then Exit Sub
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
		
	End Sub
	Private Sub datenübergabe()
		If Text1(2).Text <> "" Then dy.Fields(info(2).feldname).Value = Text1(2).Text
	End Sub
	
	'UPGRADE_WARNING: Event text1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub text1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.TextChanged
        Dim tb As TextBox = CType(eventSender, TextBox)
        Dim Index As Short = Text1.GetIndex(tb)
        DataChanged = True
    End Sub
End Class