Option Strict On
Option Explicit On
Friend Class SortGroups
	Inherits System.Windows.Forms.Form
	Private Sub btn_ab_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btn_ab.Click
		If GruppenListe.SelectedIndex = GruppenListe.Items.Count Or GruppenListe.SelectedIndex = -1 Then
			Beep()
			Exit Sub
		End If
        Dim txt As Object
        Dim data, idx As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		idx = GruppenListe.SelectedIndex
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = VB6.GetItemString(GruppenListe, idx)
		'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		data = VB6.GetItemData(GruppenListe, idx)
		GruppenListe.Items.RemoveAt((idx))
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GruppenListe.Items.Insert(idx + 1, (txt))
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		VB6.SetItemData(GruppenListe, idx + 1, data)
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GruppenListe.SelectedIndex = idx + 1
		
	End Sub
	
	Private Sub btn_auf_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btn_auf.Click
		If GruppenListe.SelectedIndex < 1 Then
			Beep()
			Exit Sub
		End If
        Dim txt As Object
        Dim data, idx As Integer
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		idx = GruppenListe.SelectedIndex
		'UPGRADE_WARNING: Couldn't resolve default property of object txt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txt = VB6.GetItemString(GruppenListe, idx)
		'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		data = VB6.GetItemData(GruppenListe, idx)
		GruppenListe.Items.RemoveAt((idx))
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GruppenListe.Items.Insert(idx - 1, (txt))
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object data. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		VB6.SetItemData(GruppenListe, idx - 1, data)
		'UPGRADE_WARNING: Couldn't resolve default property of object idx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		GruppenListe.SelectedIndex = idx - 1
		
	End Sub
	
	Private Sub btn_fertig_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btn_fertig.Click
        Dim found As Boolean = False
        Dim i As Integer
		For i = 0 To GruppenListe.Items.Count - 1
			'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			found = False
			dy.MoveFirst()
			Do 
                If dy.Fields("Hoofdgroep").Value.ToString() = VB6.GetItemString(GruppenListe, i) Then
                    dy.Edit()
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    dy.Fields("SortOrder").Value = i
                    dy.Update()
                    'UPGRADE_WARNING: Couldn't resolve default property of object found. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    found = True
                End If
				dy.MoveNext()
			Loop Until found Or dy.EOF
		Next i
		dy.Close()
		Me.Close()
		'Me.Hide
	End Sub
	
	Private Sub SortGroups_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
		dy = db.CreateDynaset("Select Hoofdgroep, SortOrder from Hoofdgroep order by SortOrder")
		dy.MoveLast()
		dy.MoveFirst()
		GruppenListe.Items.Clear()
		For i = 0 To dy.RecordCount - 1
			GruppenListe.Items.Insert(i, (dy.Fields("Hoofdgroep").Value))
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If dy.Fields("SortOrder").Value Is System.DBNull.Value Then
                VB6.SetItemData(GruppenListe, i, CType(dy.Fields("SortOrder").Value, Integer))
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				VB6.SetItemData(GruppenListe, i, i)
			End If
			dy.MoveNext()
		Next i
		GruppenListe.SelectedIndex = 0
		dy.MoveFirst()
		
	End Sub
	
	'UPGRADE_WARNING: Event GruppenListe.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub GruppenListe_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles GruppenListe.SelectedIndexChanged
		If GruppenListe.SelectedIndex > 0 Then
			btn_auf.Enabled = True
		Else
			btn_auf.Enabled = False
		End If
		If GruppenListe.SelectedIndex < GruppenListe.Items.Count - 1 Then
			btn_ab.Enabled = True
		Else
			btn_ab.Enabled = False
		End If
		
	End Sub
End Class