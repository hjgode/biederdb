<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class bildschirm
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
	Public WithEvents Ziel As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(bildschirm))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Ziel = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(312, 213)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Visible = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.Name = "bildschirm"
		Me.Ziel.BackColor = System.Drawing.Color.FromARGB(0, 0, 192)
		Me.Ziel.ForeColor = System.Drawing.SystemColors.Window
		Me.Ziel.Size = New System.Drawing.Size(81, 33)
		Me.Ziel.Location = New System.Drawing.Point(0, 0)
		Me.Ziel.TabIndex = 0
		Me.Ziel.Dock = System.Windows.Forms.DockStyle.None
		Me.Ziel.CausesValidation = True
		Me.Ziel.Enabled = True
		Me.Ziel.Cursor = System.Windows.Forms.Cursors.Default
		Me.Ziel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Ziel.TabStop = True
		Me.Ziel.Visible = True
		Me.Ziel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.Ziel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Ziel.Name = "Ziel"
		Me.Controls.Add(Ziel)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class