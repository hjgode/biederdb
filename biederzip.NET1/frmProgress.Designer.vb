<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmProgress
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
	Public WithEvents pbrProgress As AxComctlLib.AxProgressBar
	Public WithEvents lblWorking As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProgress))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.pbrProgress = New AxComctlLib.AxProgressBar
		Me.lblWorking = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.pbrProgress, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Verarbeitung..."
		Me.ClientSize = New System.Drawing.Size(248, 87)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmProgress"
		pbrProgress.OcxState = CType(resources.GetObject("pbrProgress.OcxState"), System.Windows.Forms.AxHost.State)
		Me.pbrProgress.Size = New System.Drawing.Size(233, 17)
		Me.pbrProgress.Location = New System.Drawing.Point(8, 16)
		Me.pbrProgress.TabIndex = 0
		Me.pbrProgress.Name = "pbrProgress"
		Me.lblWorking.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblWorking.Text = "Working..."
		Me.lblWorking.Size = New System.Drawing.Size(233, 41)
		Me.lblWorking.Location = New System.Drawing.Point(8, 40)
		Me.lblWorking.TabIndex = 1
		Me.lblWorking.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblWorking.BackColor = System.Drawing.SystemColors.Control
		Me.lblWorking.Enabled = True
		Me.lblWorking.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblWorking.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblWorking.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblWorking.UseMnemonic = True
		Me.lblWorking.Visible = True
		Me.lblWorking.AutoSize = False
		Me.lblWorking.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblWorking.Name = "lblWorking"
		Me.Controls.Add(pbrProgress)
		Me.Controls.Add(lblWorking)
		CType(Me.pbrProgress, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class