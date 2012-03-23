<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class TextEdit
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
	Public WithEvents btn_Standard As System.Windows.Forms.Button
	Public WithEvents btn_Cancel As System.Windows.Forms.Button
	Public WithEvents btn_OK As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TextEdit))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.btn_Standard = New System.Windows.Forms.Button
		Me.btn_Cancel = New System.Windows.Forms.Button
		Me.btn_OK = New System.Windows.Forms.Button
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Text bearbeiten"
		Me.ClientSize = New System.Drawing.Size(312, 213)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "TextEdit"
		Me.btn_Standard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btn_Standard.Text = "Standardtext"
		Me.btn_Standard.Size = New System.Drawing.Size(89, 17)
		Me.btn_Standard.Location = New System.Drawing.Point(8, 184)
		Me.btn_Standard.TabIndex = 3
		Me.btn_Standard.BackColor = System.Drawing.SystemColors.Control
		Me.btn_Standard.CausesValidation = True
		Me.btn_Standard.Enabled = True
		Me.btn_Standard.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btn_Standard.Cursor = System.Windows.Forms.Cursors.Default
		Me.btn_Standard.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btn_Standard.TabStop = True
		Me.btn_Standard.Name = "btn_Standard"
		Me.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btn_Cancel.Text = "Abbruch"
		Me.btn_Cancel.Size = New System.Drawing.Size(65, 17)
		Me.btn_Cancel.Location = New System.Drawing.Point(160, 184)
		Me.btn_Cancel.TabIndex = 2
		Me.btn_Cancel.BackColor = System.Drawing.SystemColors.Control
		Me.btn_Cancel.CausesValidation = True
		Me.btn_Cancel.Enabled = True
		Me.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.btn_Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btn_Cancel.TabStop = True
		Me.btn_Cancel.Name = "btn_Cancel"
		Me.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btn_OK.Text = "OK"
		Me.btn_OK.Size = New System.Drawing.Size(65, 17)
		Me.btn_OK.Location = New System.Drawing.Point(240, 184)
		Me.btn_OK.TabIndex = 1
		Me.btn_OK.BackColor = System.Drawing.SystemColors.Control
		Me.btn_OK.CausesValidation = True
		Me.btn_OK.Enabled = True
		Me.btn_OK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btn_OK.Cursor = System.Windows.Forms.Cursors.Default
		Me.btn_OK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btn_OK.TabStop = True
		Me.btn_OK.Name = "btn_OK"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(297, 113)
		Me.Text1.Location = New System.Drawing.Point(8, 56)
		Me.Text1.MultiLine = True
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.Text1.WordWrap = False
		Me.Text1.TabIndex = 0
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
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.Label1.Text = "Text normal bearbeiten. Zeilenschaltungen werden durch <br>, Absatzschaltungen durch <p> erreicht. Vorsicht mit Sonderzeichen, es handelt sich um HTML Text!"
		Me.Label1.Size = New System.Drawing.Size(297, 41)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 4
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label1.Name = "Label1"
		Me.Controls.Add(btn_Standard)
		Me.Controls.Add(btn_Cancel)
		Me.Controls.Add(btn_OK)
		Me.Controls.Add(Text1)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class