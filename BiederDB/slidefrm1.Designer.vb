<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class slide
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
	Public WithEvents chk_passwort As System.Windows.Forms.CheckBox
	Public WithEvents bt_close As System.Windows.Forms.Button
	Public WithEvents _opt_auswahl_1 As System.Windows.Forms.RadioButton
	Public WithEvents _opt_auswahl_0 As System.Windows.Forms.RadioButton
	Public WithEvents GruppenListe As System.Windows.Forms.ListBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents _opt_reihenfolge_1 As System.Windows.Forms.RadioButton
	Public WithEvents _opt_reihenfolge_0 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdFullScr As System.Windows.Forms.Button
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Quelle As System.Windows.Forms.PictureBox
	Public WithEvents opt_auswahl As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents opt_reihenfolge As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chk_passwort = New System.Windows.Forms.CheckBox
        Me.bt_close = New System.Windows.Forms.Button
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me._opt_auswahl_1 = New System.Windows.Forms.RadioButton
        Me._opt_auswahl_0 = New System.Windows.Forms.RadioButton
        Me.GruppenListe = New System.Windows.Forms.ListBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me._opt_reihenfolge_1 = New System.Windows.Forms.RadioButton
        Me._opt_reihenfolge_0 = New System.Windows.Forms.RadioButton
        Me.cmdFullScr = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Quelle = New System.Windows.Forms.PictureBox
        Me.opt_auswahl = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.opt_reihenfolge = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(Me.components)
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.Quelle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opt_auswahl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opt_reihenfolge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chk_passwort
        '
        Me.chk_passwort.BackColor = System.Drawing.SystemColors.Control
        Me.chk_passwort.Checked = True
        Me.chk_passwort.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_passwort.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_passwort.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_passwort.Location = New System.Drawing.Point(8, 8)
        Me.chk_passwort.Name = "chk_passwort"
        Me.chk_passwort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk_passwort.Size = New System.Drawing.Size(129, 25)
        Me.chk_passwort.TabIndex = 10
        Me.chk_passwort.Text = "Passwortschutz EIN"
        Me.chk_passwort.UseVisualStyleBackColor = False
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.SystemColors.Control
        Me.bt_close.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_close.Location = New System.Drawing.Point(24, 296)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_close.Size = New System.Drawing.Size(97, 17)
        Me.bt_close.TabIndex = 9
        Me.bt_close.Text = "SCHLIESSEN"
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me._opt_auswahl_1)
        Me.Frame2.Controls.Add(Me._opt_auswahl_0)
        Me.Frame2.Controls.Add(Me.GruppenListe)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 136)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(129, 145)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Auswahl:"
        '
        '_opt_auswahl_1
        '
        Me._opt_auswahl_1.BackColor = System.Drawing.SystemColors.Control
        Me._opt_auswahl_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt_auswahl_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opt_auswahl.SetIndex(Me._opt_auswahl_1, CType(1, Short))
        Me._opt_auswahl_1.Location = New System.Drawing.Point(8, 40)
        Me._opt_auswahl_1.Name = "_opt_auswahl_1"
        Me._opt_auswahl_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._opt_auswahl_1.Size = New System.Drawing.Size(113, 25)
        Me._opt_auswahl_1.TabIndex = 8
        Me._opt_auswahl_1.TabStop = True
        Me._opt_auswahl_1.Text = "Nur Produktgruppe:"
        Me._opt_auswahl_1.UseVisualStyleBackColor = False
        '
        '_opt_auswahl_0
        '
        Me._opt_auswahl_0.BackColor = System.Drawing.SystemColors.Control
        Me._opt_auswahl_0.Checked = True
        Me._opt_auswahl_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt_auswahl_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opt_auswahl.SetIndex(Me._opt_auswahl_0, CType(0, Short))
        Me._opt_auswahl_0.Location = New System.Drawing.Point(8, 16)
        Me._opt_auswahl_0.Name = "_opt_auswahl_0"
        Me._opt_auswahl_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._opt_auswahl_0.Size = New System.Drawing.Size(113, 25)
        Me._opt_auswahl_0.TabIndex = 7
        Me._opt_auswahl_0.TabStop = True
        Me._opt_auswahl_0.Text = "Alle"
        Me._opt_auswahl_0.UseVisualStyleBackColor = False
        '
        'GruppenListe
        '
        Me.GruppenListe.BackColor = System.Drawing.SystemColors.Window
        Me.GruppenListe.Cursor = System.Windows.Forms.Cursors.Default
        Me.GruppenListe.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GruppenListe.Location = New System.Drawing.Point(8, 64)
        Me.GruppenListe.Name = "GruppenListe"
        Me.GruppenListe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GruppenListe.Size = New System.Drawing.Size(113, 69)
        Me.GruppenListe.TabIndex = 6
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me._opt_reihenfolge_1)
        Me.Frame1.Controls.Add(Me._opt_reihenfolge_0)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(8, 64)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(129, 65)
        Me.Frame1.TabIndex = 2
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Reihenfolge:"
        '
        '_opt_reihenfolge_1
        '
        Me._opt_reihenfolge_1.BackColor = System.Drawing.SystemColors.Control
        Me._opt_reihenfolge_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt_reihenfolge_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opt_reihenfolge.SetIndex(Me._opt_reihenfolge_1, CType(1, Short))
        Me._opt_reihenfolge_1.Location = New System.Drawing.Point(8, 40)
        Me._opt_reihenfolge_1.Name = "_opt_reihenfolge_1"
        Me._opt_reihenfolge_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._opt_reihenfolge_1.Size = New System.Drawing.Size(73, 17)
        Me._opt_reihenfolge_1.TabIndex = 4
        Me._opt_reihenfolge_1.TabStop = True
        Me._opt_reihenfolge_1.Text = "Normal"
        Me._opt_reihenfolge_1.UseVisualStyleBackColor = False
        '
        '_opt_reihenfolge_0
        '
        Me._opt_reihenfolge_0.BackColor = System.Drawing.SystemColors.Control
        Me._opt_reihenfolge_0.Checked = True
        Me._opt_reihenfolge_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._opt_reihenfolge_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.opt_reihenfolge.SetIndex(Me._opt_reihenfolge_0, CType(0, Short))
        Me._opt_reihenfolge_0.Location = New System.Drawing.Point(8, 16)
        Me._opt_reihenfolge_0.Name = "_opt_reihenfolge_0"
        Me._opt_reihenfolge_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._opt_reihenfolge_0.Size = New System.Drawing.Size(73, 17)
        Me._opt_reihenfolge_0.TabIndex = 3
        Me._opt_reihenfolge_0.TabStop = True
        Me._opt_reihenfolge_0.Text = "Zufall"
        Me._opt_reihenfolge_0.UseVisualStyleBackColor = False
        '
        'cmdFullScr
        '
        Me.cmdFullScr.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFullScr.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFullScr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFullScr.Location = New System.Drawing.Point(32, 40)
        Me.cmdFullScr.Name = "cmdFullScr"
        Me.cmdFullScr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFullScr.Size = New System.Drawing.Size(89, 17)
        Me.cmdFullScr.TabIndex = 1
        Me.cmdFullScr.Text = "START"
        Me.cmdFullScr.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Quelle
        '
        Me.Quelle.BackColor = System.Drawing.SystemColors.Desktop
        Me.Quelle.Cursor = System.Windows.Forms.Cursors.Default
        Me.Quelle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Quelle.Location = New System.Drawing.Point(144, 8)
        Me.Quelle.Name = "Quelle"
        Me.Quelle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Quelle.Size = New System.Drawing.Size(640, 480)
        Me.Quelle.TabIndex = 0
        '
        'slide
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(811, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.chk_passwort)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdFullScr)
        Me.Controls.Add(Me.Quelle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "slide"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Slideshow viewer"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.Quelle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opt_auswahl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opt_reihenfolge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class