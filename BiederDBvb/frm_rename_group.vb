Option Strict On
Option Explicit On
Friend Class frm_rename_group
	Inherits System.Windows.Forms.Form
	Dim FalscheTextEingabe As Boolean
	
	Sub KategorienLesen()
        Dim i, max As Integer
		dyKat = db.CreateDynaset("select * from Hoofdgroep where not isnull(Hoofdgroep) order by SortOrder")
		dyKat.MoveLast()
		'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		max = dyKat.RecordCount
		dyKat.MoveFirst()
		ReDim kategorie(max)
		List1.Items.Clear()
		'UPGRADE_WARNING: Couldn't resolve default property of object max. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For i = 0 To max - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            kategorie(i).text = dyKat.Fields("Hoofdgroep").Value.ToString
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            kategorie(i).ID = Convert.ToUInt16(dyKat.Fields("Hgr_ID").Value)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			List1.Items.Add(kategorie(i).text)
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			VB6.SetItemData(List1, i, kategorie(i).ID)
			dyKat.MoveNext()
		Next i
		bt_rename.Enabled = False
		List1.SelectedIndex = 0
	End Sub
	
	Private Sub bt_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_close.Click
		Me.Hide()
	End Sub
	
	Private Sub bt_rename_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_rename.Click
		If MsgBox("Name wirklich ändern?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Sicherheitsfrage") = MsgBoxResult.Yes Then
			db.Execute(("update hoofdgroep set Hoofdgroep='" & NeuName.Text & "' where HGR_ID=" & VB6.GetItemData(List1, List1.SelectedIndex)), DAO.RecordsetOptionEnum.dbFailOnError)
			MsgBox("Name wurde geändert!", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information, "Information")
			KategorienLesen()
			bt_rename.Enabled = False
		End If
	End Sub
	
	Private Sub frm_rename_group_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		FalscheTextEingabe = False
		KategorienLesen()
	End Sub
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		NeuName.Text = VB6.GetItemString(List1, List1.SelectedIndex)
		bt_rename.Enabled = False
	End Sub
	
	'UPGRADE_WARNING: Event NeuName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub NeuName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles NeuName.TextChanged
		bt_rename.Enabled = True
	End Sub
	
	Private Sub NeuName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles NeuName.KeyPress
        Dim KeyAscii As Integer = Asc(eventArgs.KeyChar)

		Select Case Chr(KeyAscii)
            Case " "c, "-"c, "_"c, "."c, "+"c, "ä"c, "ö"c, "ü"c, "Ä"c, "Ö"c, "Ü"c, "0"c To "9"c, "A"c To "Z"c, "a"c To "z"c, Chr(0) To Chr(31)
            Case Else
                KeyAscii = 0
                Beep()
                If FalscheTextEingabe = False Then
                    MsgBox("Einige dieser Eingabe werden bei der Generierung der Webseite zu Dateiverknüpfungen. Aus diesem Grund sind nicht alle Zeichen erlaubt." & Chr(13) & "Die folgenden Zeichen sind zulässig: ' ', '-', '_', '.', '+', 'ä', 'ö', 'ü', 'Ä', 'Ö', 'Ü', '0' bis '9', 'A' bis 'Z', 'a' bis 'z'", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "HINWEIS")
                    FalscheTextEingabe = True
                End If
        End Select
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
End Class