<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class SortGroups
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
	Public WithEvents btn_fertig As System.Windows.Forms.Button
	Public WithEvents btn_ab As System.Windows.Forms.Button
	Public WithEvents btn_auf As System.Windows.Forms.Button
	Public WithEvents GruppenListe As System.Windows.Forms.ListBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SortGroups))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.btn_fertig = New System.Windows.Forms.Button
		Me.btn_ab = New System.Windows.Forms.Button
		Me.btn_auf = New System.Windows.Forms.Button
		Me.GruppenListe = New System.Windows.Forms.ListBox
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Produktgruppen sortieren"
		Me.ClientSize = New System.Drawing.Size(291, 195)
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
		Me.Name = "SortGroups"
		Me.btn_fertig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btn_fertig.Text = "Fertig"
		Me.btn_fertig.Size = New System.Drawing.Size(81, 25)
		Me.btn_fertig.Location = New System.Drawing.Point(200, 160)
		Me.btn_fertig.TabIndex = 4
		Me.btn_fertig.BackColor = System.Drawing.SystemColors.Control
		Me.btn_fertig.CausesValidation = True
		Me.btn_fertig.Enabled = True
		Me.btn_fertig.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btn_fertig.Cursor = System.Windows.Forms.Cursors.Default
		Me.btn_fertig.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btn_fertig.TabStop = True
		Me.btn_fertig.Name = "btn_fertig"
		Me.btn_ab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btn_ab.Text = "AB"
		Me.btn_ab.Enabled = False
		Me.btn_ab.Size = New System.Drawing.Size(81, 25)
		Me.btn_ab.Location = New System.Drawing.Point(200, 56)
		Me.btn_ab.TabIndex = 3
		Me.btn_ab.BackColor = System.Drawing.SystemColors.Control
		Me.btn_ab.CausesValidation = True
		Me.btn_ab.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btn_ab.Cursor = System.Windows.Forms.Cursors.Default
		Me.btn_ab.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btn_ab.TabStop = True
		Me.btn_ab.Name = "btn_ab"
		Me.btn_auf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.btn_auf.Text = "AUF"
		Me.btn_auf.Enabled = False
		Me.btn_auf.Size = New System.Drawing.Size(81, 25)
		Me.btn_auf.Location = New System.Drawing.Point(200, 24)
		Me.btn_auf.TabIndex = 2
		Me.btn_auf.BackColor = System.Drawing.SystemColors.Control
		Me.btn_auf.CausesValidation = True
		Me.btn_auf.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btn_auf.Cursor = System.Windows.Forms.Cursors.Default
		Me.btn_auf.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.btn_auf.TabStop = True
		Me.btn_auf.Name = "btn_auf"
		Me.GruppenListe.Size = New System.Drawing.Size(185, 163)
		Me.GruppenListe.Location = New System.Drawing.Point(8, 24)
		Me.GruppenListe.TabIndex = 0
		Me.ToolTip1.SetToolTip(Me.GruppenListe, "Produktgruppe anklicken und danm mit AUF und AB verschieben")
		Me.GruppenListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.GruppenListe.BackColor = System.Drawing.SystemColors.Window
		Me.GruppenListe.CausesValidation = True
		Me.GruppenListe.Enabled = True
		Me.GruppenListe.ForeColor = System.Drawing.SystemColors.WindowText
		Me.GruppenListe.IntegralHeight = True
		Me.GruppenListe.Cursor = System.Windows.Forms.Cursors.Default
		Me.GruppenListe.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.GruppenListe.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.GruppenListe.Sorted = False
		Me.GruppenListe.TabStop = True
		Me.GruppenListe.Visible = True
		Me.GruppenListe.MultiColumn = False
		Me.GruppenListe.Name = "GruppenListe"
		Me.Label1.Text = "Produktgruppen:"
		Me.Label1.Size = New System.Drawing.Size(161, 17)
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
		Me.Controls.Add(btn_fertig)
		Me.Controls.Add(btn_ab)
		Me.Controls.Add(btn_auf)
		Me.Controls.Add(GruppenListe)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class