<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_rename_group
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
	Public WithEvents bt_rename As System.Windows.Forms.Button
	Public WithEvents NeuName As System.Windows.Forms.TextBox
	Public WithEvents List1 As System.Windows.Forms.ComboBox
	Public WithEvents bt_close As System.Windows.Forms.Button
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_rename_group))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.bt_rename = New System.Windows.Forms.Button
		Me.NeuName = New System.Windows.Forms.TextBox
		Me.List1 = New System.Windows.Forms.ComboBox
		Me.bt_close = New System.Windows.Forms.Button
		Me._Label1_1 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Gruppe umbenennen"
		Me.ClientSize = New System.Drawing.Size(312, 175)
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
		Me.Name = "frm_rename_group"
		Me.bt_rename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_rename.Text = "Umbenennen"
		Me.bt_rename.Size = New System.Drawing.Size(89, 25)
		Me.bt_rename.Location = New System.Drawing.Point(8, 112)
		Me.bt_rename.TabIndex = 5
		Me.bt_rename.BackColor = System.Drawing.SystemColors.Control
		Me.bt_rename.CausesValidation = True
		Me.bt_rename.Enabled = True
		Me.bt_rename.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_rename.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_rename.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_rename.TabStop = True
		Me.bt_rename.Name = "bt_rename"
		Me.NeuName.AutoSize = False
		Me.NeuName.Size = New System.Drawing.Size(297, 19)
		Me.NeuName.Location = New System.Drawing.Point(8, 80)
		Me.NeuName.Maxlength = 30
		Me.NeuName.TabIndex = 4
		Me.NeuName.AcceptsReturn = True
		Me.NeuName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.NeuName.BackColor = System.Drawing.SystemColors.Window
		Me.NeuName.CausesValidation = True
		Me.NeuName.Enabled = True
		Me.NeuName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.NeuName.HideSelection = True
		Me.NeuName.ReadOnly = False
		Me.NeuName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.NeuName.MultiLine = False
		Me.NeuName.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.NeuName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.NeuName.TabStop = True
		Me.NeuName.Visible = True
		Me.NeuName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.NeuName.Name = "NeuName"
		Me.List1.Size = New System.Drawing.Size(297, 21)
		Me.List1.Location = New System.Drawing.Point(8, 24)
		Me.List1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.List1.TabIndex = 1
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
		Me.bt_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_close.Text = "Schliessen"
		Me.bt_close.Size = New System.Drawing.Size(89, 25)
		Me.bt_close.Location = New System.Drawing.Point(216, 144)
		Me.bt_close.TabIndex = 0
		Me.bt_close.BackColor = System.Drawing.SystemColors.Control
		Me.bt_close.CausesValidation = True
		Me.bt_close.Enabled = True
		Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_close.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_close.TabStop = True
		Me.bt_close.Name = "bt_close"
		Me._Label1_1.Text = "Neuer Name:"
		Me._Label1_1.Size = New System.Drawing.Size(201, 17)
		Me._Label1_1.Location = New System.Drawing.Point(8, 64)
		Me._Label1_1.TabIndex = 3
		Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_1.Enabled = True
		Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_1.UseMnemonic = True
		Me._Label1_1.Visible = True
		Me._Label1_1.AutoSize = False
		Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_1.Name = "_Label1_1"
		Me._Label1_0.Text = "Gruppe auswählen:"
		Me._Label1_0.Size = New System.Drawing.Size(201, 17)
		Me._Label1_0.Location = New System.Drawing.Point(8, 8)
		Me._Label1_0.TabIndex = 2
		Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_0.Enabled = True
		Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_0.UseMnemonic = True
		Me._Label1_0.Visible = True
		Me._Label1_0.AutoSize = False
		Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_0.Name = "_Label1_0"
		Me.Controls.Add(bt_rename)
		Me.Controls.Add(NeuName)
		Me.Controls.Add(List1)
		Me.Controls.Add(bt_close)
		Me.Controls.Add(_Label1_1)
		Me.Controls.Add(_Label1_0)
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class