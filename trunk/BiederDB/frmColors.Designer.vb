<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmColors
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
	Public WithEvents bt_defaultColors As System.Windows.Forms.Button
	Public CommonDialog1Color As System.Windows.Forms.ColorDialog
	Public WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents bt_cancel As System.Windows.Forms.Button
	Public WithEvents bt_ok As System.Windows.Forms.Button
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents cname As System.Windows.Forms.Label
	Public WithEvents ColorTest As System.Windows.Forms.Label
	Public WithEvents ColorHex As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorTest = New System.Windows.Forms.Label
        Me.bt_defaultColors = New System.Windows.Forms.Button
        Me.CommonDialog1Color = New System.Windows.Forms.ColorDialog
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.bt_ok = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cname = New System.Windows.Forms.Label
        Me.ColorHex = New System.Windows.Forms.Label
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.SuspendLayout()
        '
        'ColorTest
        '
        Me.ColorTest.BackColor = System.Drawing.Color.Yellow
        Me.ColorTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ColorTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.ColorTest.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ColorTest.Location = New System.Drawing.Point(224, 24)
        Me.ColorTest.Name = "ColorTest"
        Me.ColorTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ColorTest.Size = New System.Drawing.Size(137, 33)
        Me.ColorTest.TabIndex = 5
        Me.ColorTest.Text = "Farbfeld"
        Me.ColorTest.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.ColorTest, "Doppelklick zum Ändern")
        '
        'bt_defaultColors
        '
        Me.bt_defaultColors.BackColor = System.Drawing.SystemColors.Control
        Me.bt_defaultColors.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_defaultColors.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_defaultColors.Location = New System.Drawing.Point(368, 40)
        Me.bt_defaultColors.Name = "bt_defaultColors"
        Me.bt_defaultColors.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_defaultColors.Size = New System.Drawing.Size(153, 17)
        Me.bt_defaultColors.TabIndex = 8
        Me.bt_defaultColors.Text = "Standardfarben laden"
        Me.bt_defaultColors.UseVisualStyleBackColor = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(8, 64)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(513, 553)
        Me.WebBrowser1.TabIndex = 3
        '
        'Combo1
        '
        Me.Combo1.BackColor = System.Drawing.SystemColors.Window
        Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo1.Location = New System.Drawing.Point(8, 8)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo1.Size = New System.Drawing.Size(121, 21)
        Me.Combo1.TabIndex = 2
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_cancel.Location = New System.Drawing.Point(368, 8)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_cancel.Size = New System.Drawing.Size(73, 25)
        Me.bt_cancel.TabIndex = 1
        Me.bt_cancel.Text = "Abbruch"
        Me.bt_cancel.UseVisualStyleBackColor = False
        '
        'bt_ok
        '
        Me.bt_ok.BackColor = System.Drawing.SystemColors.Control
        Me.bt_ok.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_ok.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_ok.Location = New System.Drawing.Point(448, 8)
        Me.bt_ok.Name = "bt_ok"
        Me.bt_ok.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_ok.Size = New System.Drawing.Size(73, 25)
        Me.bt_ok.TabIndex = 0
        Me.bt_ok.Text = "OK"
        Me.bt_ok.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(224, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(129, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Doppelklick zum Ändern"
        '
        'cname
        '
        Me.cname.BackColor = System.Drawing.SystemColors.Control
        Me.cname.Cursor = System.Windows.Forms.Cursors.Default
        Me.cname.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cname.Location = New System.Drawing.Point(136, 8)
        Me.cname.Name = "cname"
        Me.cname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cname.Size = New System.Drawing.Size(81, 17)
        Me.cname.TabIndex = 6
        Me.cname.Text = "Html-Element:"
        '
        'ColorHex
        '
        Me.ColorHex.BackColor = System.Drawing.SystemColors.Control
        Me.ColorHex.Cursor = System.Windows.Forms.Cursors.Default
        Me.ColorHex.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ColorHex.Location = New System.Drawing.Point(136, 32)
        Me.ColorHex.Name = "ColorHex"
        Me.ColorHex.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ColorHex.Size = New System.Drawing.Size(73, 17)
        Me.ColorHex.TabIndex = 4
        Me.ColorHex.Text = "HTMLColor"
        '
        'frmColors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(527, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_defaultColors)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.bt_ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.ColorTest)
        Me.Controls.Add(Me.ColorHex)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(139, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColors"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Farben anpassen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
#End Region 
End Class