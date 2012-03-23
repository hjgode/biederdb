Option Strict On
Option Explicit On
Friend Class frm_delete_group
	Inherits System.Windows.Forms.Form
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
		List1.SelectedIndex = 0
	End Sub
	
	Private Sub bt_close_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_close.Click
		Me.Hide()
	End Sub
	
	Private Sub bt_del_data_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_del_data.Click
		If List1.SelectedIndex = -1 Then Exit Sub
		If MsgBox("Sind Sie wirklich sicher, dass Sie alle Daten mit der Gruppe '" & VB6.GetItemString(List1, List1.SelectedIndex) & "' und die Gruppe selbst löschen wollen?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "SICHERHEITSFRAGE") = MsgBoxResult.Yes And MsgBox("Bitte nochmal bestätigen!", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "SICHERHEITSFRAGE") = MsgBoxResult.Yes Then
			db.Execute(("delete * from Artikel where hgr_id=" & VB6.GetItemData(List1, List1.SelectedIndex)), DAO.RecordsetOptionEnum.dbFailOnError)
			db.Execute(("delete * from Hoofdgroep where hgr_id=" & VB6.GetItemData(List1, List1.SelectedIndex)), DAO.RecordsetOptionEnum.dbFailOnError)
			MsgBox("Die Daten und die Gruppe wurden gelöscht!", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information, "Information")
			KategorienLesen()
		Else
			MsgBox("Die Daten wurden NICHT gelöscht!", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information)
		End If
	End Sub
	
	Private Sub bt_del_group_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bt_del_group.Click
		If List1.SelectedIndex = -1 Then Exit Sub
		If MsgBox("Sind Sie wirklich sicher, dass Sie die Gruppe '" & VB6.GetItemString(List1, List1.SelectedIndex) & "' löschen wollen?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "SICHERHEITSFRAGE") = MsgBoxResult.Yes And MsgBox("Bitte nochmal bestätigen!", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical, "SICHERHEITSFRAGE") = MsgBoxResult.Yes Then
			db.Execute(("delete * from Hoofdgroep where hgr_id=" & VB6.GetItemData(List1, List1.SelectedIndex)), DAO.RecordsetOptionEnum.dbFailOnError)
			MsgBox("Die Gruppe wurde gelöscht!", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information, "Information")
			KategorienLesen()
		Else
			MsgBox("Die Gruppe wurde NICHT gelöscht", MsgBoxStyle.OKOnly Or MsgBoxStyle.Information, "Information")
		End If
	End Sub
	
	Private Sub frm_delete_group_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		KategorienLesen()
	End Sub
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		dyKat = db.CreateDynaset("select * from Artikel where Hgr_ID=" & VB6.GetItemData(List1, List1.SelectedIndex))
		If dyKat.BOF And dyKat.EOF Then
			Datensaetze.Text = CStr(0)
			bt_del_group.Enabled = True
			bt_del_data.Enabled = False
		Else
			dyKat.MoveLast()
			Datensaetze.Text = Str(dyKat.RecordCount)
			bt_del_group.Enabled = False
			bt_del_data.Enabled = True
		End If
	End Sub
End Class