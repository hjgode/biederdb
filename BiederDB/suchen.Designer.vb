<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_suchen
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
	Public WithEvents bt_schliessen As System.Windows.Forms.Button
	Public WithEvents bt_weitersuchen As System.Windows.Forms.Button
	Public WithEvents bt_suchen As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frm_suchen))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.bt_schliessen = New System.Windows.Forms.Button
		Me.bt_weitersuchen = New System.Windows.Forms.Button
		Me.bt_suchen = New System.Windows.Forms.Button
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Text = "Suchen"
		Me.ClientSize = New System.Drawing.Size(272, 56)
		Me.Location = New System.Drawing.Point(3, 19)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frm_suchen"
		Me.bt_schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_schliessen.Text = "Schli&essen"
		Me.bt_schliessen.Size = New System.Drawing.Size(81, 17)
		Me.bt_schliessen.Location = New System.Drawing.Point(8, 32)
		Me.bt_schliessen.TabIndex = 4
		Me.bt_schliessen.BackColor = System.Drawing.SystemColors.Control
		Me.bt_schliessen.CausesValidation = True
		Me.bt_schliessen.Enabled = True
		Me.bt_schliessen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_schliessen.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_schliessen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_schliessen.TabStop = True
		Me.bt_schliessen.Name = "bt_schliessen"
		Me.bt_weitersuchen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_weitersuchen.Text = "&Weitersuchen"
		Me.bt_weitersuchen.Enabled = False
		Me.bt_weitersuchen.Size = New System.Drawing.Size(81, 17)
		Me.bt_weitersuchen.Location = New System.Drawing.Point(184, 32)
		Me.bt_weitersuchen.TabIndex = 3
		Me.bt_weitersuchen.BackColor = System.Drawing.SystemColors.Control
		Me.bt_weitersuchen.CausesValidation = True
		Me.bt_weitersuchen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_weitersuchen.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_weitersuchen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_weitersuchen.TabStop = True
		Me.bt_weitersuchen.Name = "bt_weitersuchen"
		Me.bt_suchen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_suchen.Text = "&Suchen"
		Me.AcceptButton = Me.bt_suchen
		Me.bt_suchen.Size = New System.Drawing.Size(81, 17)
		Me.bt_suchen.Location = New System.Drawing.Point(96, 32)
		Me.bt_suchen.TabIndex = 2
		Me.bt_suchen.BackColor = System.Drawing.SystemColors.Control
		Me.bt_suchen.CausesValidation = True
		Me.bt_suchen.Enabled = True
		Me.bt_suchen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_suchen.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_suchen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_suchen.TabStop = True
		Me.bt_suchen.Name = "bt_suchen"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(193, 19)
		Me.Text1.Location = New System.Drawing.Point(72, 8)
		Me.Text1.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.Text1, "Geben Sie hier einen Suchbegriff an. Sie können auch * (alle weiteren Zeichen) und ? (ein weiteres Zeichen) benutzen. 'me*' findet alle Einträge die mit me beginnen. 'me?er' findet 'meier', 'meyer' etc.")
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.Label1.Text = "Artikel-Nr.:"
		Me.Label1.Size = New System.Drawing.Size(57, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 0
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
		Me.Controls.Add(bt_schliessen)
		Me.Controls.Add(bt_weitersuchen)
		Me.Controls.Add(bt_suchen)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class