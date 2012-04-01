<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_delete_group
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents bt_close As System.Windows.Forms.Button
	Public WithEvents bt_del_data As System.Windows.Forms.Button
	Public WithEvents bt_del_group As System.Windows.Forms.Button
	Public WithEvents Datensaetze As System.Windows.Forms.TextBox
	Public WithEvents List1 As System.Windows.Forms.ComboBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_delete_group))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.bt_close = New System.Windows.Forms.Button
		Me.bt_del_data = New System.Windows.Forms.Button
		Me.bt_del_group = New System.Windows.Forms.Button
		Me.Datensaetze = New System.Windows.Forms.TextBox
		Me.List1 = New System.Windows.Forms.ComboBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Gruppen löschen"
		Me.ClientSize = New System.Drawing.Size(312, 183)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frm_delete_group"
		Me.bt_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_close.Text = "Schliessen"
		Me.bt_close.Size = New System.Drawing.Size(89, 25)
		Me.bt_close.Location = New System.Drawing.Point(216, 152)
		Me.bt_close.TabIndex = 6
		Me.bt_close.BackColor = System.Drawing.SystemColors.Control
		Me.bt_close.CausesValidation = True
		Me.bt_close.Enabled = True
		Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_close.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_close.TabStop = True
		Me.bt_close.Name = "bt_close"
		Me.bt_del_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_del_data.Text = "Daten löschen"
		Me.bt_del_data.Size = New System.Drawing.Size(89, 25)
		Me.bt_del_data.Location = New System.Drawing.Point(8, 112)
		Me.bt_del_data.TabIndex = 5
		Me.bt_del_data.BackColor = System.Drawing.SystemColors.Control
		Me.bt_del_data.CausesValidation = True
		Me.bt_del_data.Enabled = True
		Me.bt_del_data.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_del_data.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_del_data.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_del_data.TabStop = True
		Me.bt_del_data.Name = "bt_del_data"
		Me.bt_del_group.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_del_group.Text = "Gruppe löschen"
		Me.bt_del_group.Size = New System.Drawing.Size(89, 25)
		Me.bt_del_group.Location = New System.Drawing.Point(8, 152)
		Me.bt_del_group.TabIndex = 4
		Me.bt_del_group.BackColor = System.Drawing.SystemColors.Control
		Me.bt_del_group.CausesValidation = True
		Me.bt_del_group.Enabled = True
		Me.bt_del_group.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_del_group.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_del_group.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_del_group.TabStop = True
		Me.bt_del_group.Name = "bt_del_group"
		Me.Datensaetze.AutoSize = False
		Me.Datensaetze.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.Datensaetze.Enabled = False
		Me.Datensaetze.Size = New System.Drawing.Size(89, 19)
		Me.Datensaetze.Location = New System.Drawing.Point(8, 72)
		Me.Datensaetze.TabIndex = 3
		Me.Datensaetze.Text = "0"
		Me.Datensaetze.AcceptsReturn = True
		Me.Datensaetze.BackColor = System.Drawing.SystemColors.Window
		Me.Datensaetze.CausesValidation = True
		Me.Datensaetze.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Datensaetze.HideSelection = True
		Me.Datensaetze.ReadOnly = False
		Me.Datensaetze.Maxlength = 0
		Me.Datensaetze.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Datensaetze.MultiLine = False
		Me.Datensaetze.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Datensaetze.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Datensaetze.TabStop = True
		Me.Datensaetze.Visible = True
		Me.Datensaetze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Datensaetze.Name = "Datensaetze"
		Me.List1.Size = New System.Drawing.Size(297, 21)
		Me.List1.Location = New System.Drawing.Point(8, 24)
		Me.List1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.List1.TabIndex = 0
		Me.List1.BackColor = System.Drawing.SystemColors.Window
		Me.List1.CausesValidation = True
		Me.List1.Enabled = True
		Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.List1.IntegralHeight = True
		Me.List1.Cursor = System.Windows.Forms.Cursors.Default
		Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.List1.Sorted = False
		Me.List1.TabStop = True
		Me.List1.Visible = True
		Me.List1.Name = "List1"
		Me.Label2.Text = "Anzahl der Daten mit dieser Gruppe:"
		Me.Label2.Size = New System.Drawing.Size(201, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 56)
		Me.Label2.TabIndex = 2
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Gruppe auswählen:"
		Me.Label1.Size = New System.Drawing.Size(201, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 1
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(bt_close)
		Me.Controls.Add(bt_del_data)
		Me.Controls.Add(bt_del_group)
		Me.Controls.Add(Datensaetze)
		Me.Controls.Add(List1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class