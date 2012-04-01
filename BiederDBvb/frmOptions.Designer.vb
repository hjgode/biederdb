<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOptions
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
	Public WithEvents bgbild_artikel As System.Windows.Forms.CheckBox
	Public WithEvents bgbild_main As System.Windows.Forms.CheckBox
	Public WithEvents bgbild_left As System.Windows.Forms.CheckBox
	Public WithEvents bgbild_top As System.Windows.Forms.CheckBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents Text7 As System.Windows.Forms.TextBox
	Public WithEvents Option2 As System.Windows.Forms.RadioButton
	Public WithEvents Option1 As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents btn_ArtikelKopfText As System.Windows.Forms.Button
	Public WithEvents HScroll1 As System.Windows.Forms.HScrollBar
	Public WithEvents Text6 As System.Windows.Forms.TextBox
	Public WithEvents bt_iview_suchen As System.Windows.Forms.Button
	Public WithEvents iview_path As System.Windows.Forms.TextBox
	Public WithEvents Text5 As System.Windows.Forms.TextBox
	Public WithEvents bt_webstartsuchen As System.Windows.Forms.Button
	Public WithEvents bt_webkopfsuchen As System.Windows.Forms.Button
	Public WithEvents Text4 As System.Windows.Forms.TextBox
	Public WithEvents bt_suchenweb As System.Windows.Forms.Button
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents List1 As System.Windows.Forms.ComboBox
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public WithEvents bt_suchen As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents fraSample4 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_3 As System.Windows.Forms.Panel
	Public WithEvents fraSample3 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_2 As System.Windows.Forms.Panel
	Public WithEvents fraSample2 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_1 As System.Windows.Forms.Panel
	Public WithEvents cmdCancel As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.bgbild_artikel = New System.Windows.Forms.CheckBox
        Me.bgbild_main = New System.Windows.Forms.CheckBox
        Me.bgbild_left = New System.Windows.Forms.CheckBox
        Me.bgbild_top = New System.Windows.Forms.CheckBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Text7 = New System.Windows.Forms.TextBox
        Me.Option2 = New System.Windows.Forms.RadioButton
        Me.Option1 = New System.Windows.Forms.RadioButton
        Me.btn_ArtikelKopfText = New System.Windows.Forms.Button
        Me.HScroll1 = New System.Windows.Forms.HScrollBar
        Me.Text6 = New System.Windows.Forms.TextBox
        Me.bt_iview_suchen = New System.Windows.Forms.Button
        Me.iview_path = New System.Windows.Forms.TextBox
        Me.Text5 = New System.Windows.Forms.TextBox
        Me.bt_webstartsuchen = New System.Windows.Forms.Button
        Me.bt_webkopfsuchen = New System.Windows.Forms.Button
        Me.Text4 = New System.Windows.Forms.TextBox
        Me.bt_suchenweb = New System.Windows.Forms.Button
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.List1 = New System.Windows.Forms.ComboBox
        Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
        Me.bt_suchen = New System.Windows.Forms.Button
        Me.Text1 = New System.Windows.Forms.TextBox
        Me._picOptions_3 = New System.Windows.Forms.Panel
        Me.fraSample4 = New System.Windows.Forms.GroupBox
        Me._picOptions_2 = New System.Windows.Forms.Panel
        Me.fraSample3 = New System.Windows.Forms.GroupBox
        Me._picOptions_1 = New System.Windows.Forms.Panel
        Me.fraSample2 = New System.Windows.Forms.GroupBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.picOptions = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Frame2.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me._picOptions_3.SuspendLayout()
        Me._picOptions_2.SuspendLayout()
        Me._picOptions_1.SuspendLayout()
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.SystemColors.Control
        Me.Frame2.Controls.Add(Me.bgbild_artikel)
        Me.Frame2.Controls.Add(Me.bgbild_main)
        Me.Frame2.Controls.Add(Me.bgbild_left)
        Me.Frame2.Controls.Add(Me.bgbild_top)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 296)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(193, 73)
        Me.Frame2.TabIndex = 34
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Hintergrundbilder verwenden:"
        '
        'bgbild_artikel
        '
        Me.bgbild_artikel.BackColor = System.Drawing.SystemColors.Control
        Me.bgbild_artikel.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgbild_artikel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bgbild_artikel.Location = New System.Drawing.Point(96, 40)
        Me.bgbild_artikel.Name = "bgbild_artikel"
        Me.bgbild_artikel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgbild_artikel.Size = New System.Drawing.Size(81, 25)
        Me.bgbild_artikel.TabIndex = 38
        Me.bgbild_artikel.Text = "Artikel"
        Me.bgbild_artikel.UseVisualStyleBackColor = False
        '
        'bgbild_main
        '
        Me.bgbild_main.BackColor = System.Drawing.SystemColors.Control
        Me.bgbild_main.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgbild_main.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bgbild_main.Location = New System.Drawing.Point(96, 16)
        Me.bgbild_main.Name = "bgbild_main"
        Me.bgbild_main.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgbild_main.Size = New System.Drawing.Size(81, 25)
        Me.bgbild_main.TabIndex = 37
        Me.bgbild_main.Text = "Hauptteil"
        Me.bgbild_main.UseVisualStyleBackColor = False
        '
        'bgbild_left
        '
        Me.bgbild_left.BackColor = System.Drawing.SystemColors.Control
        Me.bgbild_left.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgbild_left.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bgbild_left.Location = New System.Drawing.Point(8, 40)
        Me.bgbild_left.Name = "bgbild_left"
        Me.bgbild_left.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgbild_left.Size = New System.Drawing.Size(73, 25)
        Me.bgbild_left.TabIndex = 36
        Me.bgbild_left.Text = "Links"
        Me.bgbild_left.UseVisualStyleBackColor = False
        '
        'bgbild_top
        '
        Me.bgbild_top.BackColor = System.Drawing.SystemColors.Control
        Me.bgbild_top.Cursor = System.Windows.Forms.Cursors.Default
        Me.bgbild_top.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bgbild_top.Location = New System.Drawing.Point(8, 16)
        Me.bgbild_top.Name = "bgbild_top"
        Me.bgbild_top.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bgbild_top.Size = New System.Drawing.Size(73, 25)
        Me.bgbild_top.TabIndex = 35
        Me.bgbild_top.Text = "Oben"
        Me.bgbild_top.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.Text7)
        Me.Frame1.Controls.Add(Me.Option2)
        Me.Frame1.Controls.Add(Me.Option1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(80, 216)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(257, 41)
        Me.Frame1.TabIndex = 30
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Hauptseite:"
        '
        'Text7
        '
        Me.Text7.AcceptsReturn = True
        Me.Text7.BackColor = System.Drawing.SystemColors.Window
        Me.Text7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text7.Enabled = False
        Me.Text7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text7.Location = New System.Drawing.Point(168, 16)
        Me.Text7.MaxLength = 0
        Me.Text7.Name = "Text7"
        Me.Text7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text7.Size = New System.Drawing.Size(81, 19)
        Me.Text7.TabIndex = 33
        Me.Text7.Text = "Text7"
        '
        'Option2
        '
        Me.Option2.BackColor = System.Drawing.SystemColors.Control
        Me.Option2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option2.Location = New System.Drawing.Point(88, 16)
        Me.Option2.Name = "Option2"
        Me.Option2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option2.Size = New System.Drawing.Size(65, 17)
        Me.Option2.TabIndex = 32
        Me.Option2.TabStop = True
        Me.Option2.Text = "Extern"
        Me.Option2.UseVisualStyleBackColor = False
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.SystemColors.Control
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Option1.Location = New System.Drawing.Point(16, 16)
        Me.Option1.Name = "Option1"
        Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Option1.Size = New System.Drawing.Size(65, 17)
        Me.Option1.TabIndex = 31
        Me.Option1.TabStop = True
        Me.Option1.Text = "Intern"
        Me.Option1.UseVisualStyleBackColor = False
        '
        'btn_ArtikelKopfText
        '
        Me.btn_ArtikelKopfText.BackColor = System.Drawing.SystemColors.Control
        Me.btn_ArtikelKopfText.Cursor = System.Windows.Forms.Cursors.Default
        Me.btn_ArtikelKopfText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_ArtikelKopfText.Location = New System.Drawing.Point(248, 272)
        Me.btn_ArtikelKopfText.Name = "btn_ArtikelKopfText"
        Me.btn_ArtikelKopfText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_ArtikelKopfText.Size = New System.Drawing.Size(153, 25)
        Me.btn_ArtikelKopfText.TabIndex = 29
        Me.btn_ArtikelKopfText.Text = "Artikel Kopftext bearbeiten"
        Me.btn_ArtikelKopfText.UseVisualStyleBackColor = False
        '
        'HScroll1
        '
        Me.HScroll1.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll1.LargeChange = 1
        Me.HScroll1.Location = New System.Drawing.Point(136, 272)
        Me.HScroll1.Maximum = 60
        Me.HScroll1.Minimum = 1
        Me.HScroll1.Name = "HScroll1"
        Me.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HScroll1.Size = New System.Drawing.Size(89, 17)
        Me.HScroll1.TabIndex = 28
        Me.HScroll1.TabStop = True
        Me.HScroll1.Value = 1
        '
        'Text6
        '
        Me.Text6.AcceptsReturn = True
        Me.Text6.BackColor = System.Drawing.SystemColors.Window
        Me.Text6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text6.Location = New System.Drawing.Point(104, 272)
        Me.Text6.MaxLength = 0
        Me.Text6.Name = "Text6"
        Me.Text6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text6.Size = New System.Drawing.Size(25, 19)
        Me.Text6.TabIndex = 27
        Me.Text6.Text = "3"
        '
        'bt_iview_suchen
        '
        Me.bt_iview_suchen.BackColor = System.Drawing.SystemColors.Control
        Me.bt_iview_suchen.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_iview_suchen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_iview_suchen.Location = New System.Drawing.Point(344, 192)
        Me.bt_iview_suchen.Name = "bt_iview_suchen"
        Me.bt_iview_suchen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_iview_suchen.Size = New System.Drawing.Size(57, 17)
        Me.bt_iview_suchen.TabIndex = 25
        Me.bt_iview_suchen.Text = "Suchen"
        Me.bt_iview_suchen.UseVisualStyleBackColor = False
        '
        'iview_path
        '
        Me.iview_path.AcceptsReturn = True
        Me.iview_path.BackColor = System.Drawing.SystemColors.Window
        Me.iview_path.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.iview_path.ForeColor = System.Drawing.SystemColors.WindowText
        Me.iview_path.Location = New System.Drawing.Point(80, 192)
        Me.iview_path.MaxLength = 0
        Me.iview_path.Name = "iview_path"
        Me.iview_path.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.iview_path.Size = New System.Drawing.Size(257, 19)
        Me.iview_path.TabIndex = 24
        Me.iview_path.Text = "Text5"
        '
        'Text5
        '
        Me.Text5.AcceptsReturn = True
        Me.Text5.BackColor = System.Drawing.SystemColors.Window
        Me.Text5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text5.Location = New System.Drawing.Point(80, 152)
        Me.Text5.MaxLength = 0
        Me.Text5.Name = "Text5"
        Me.Text5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text5.Size = New System.Drawing.Size(257, 19)
        Me.Text5.TabIndex = 21
        Me.Text5.Text = "Text5"
        '
        'bt_webstartsuchen
        '
        Me.bt_webstartsuchen.BackColor = System.Drawing.SystemColors.Control
        Me.bt_webstartsuchen.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_webstartsuchen.Enabled = False
        Me.bt_webstartsuchen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_webstartsuchen.Location = New System.Drawing.Point(344, 152)
        Me.bt_webstartsuchen.Name = "bt_webstartsuchen"
        Me.bt_webstartsuchen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_webstartsuchen.Size = New System.Drawing.Size(57, 17)
        Me.bt_webstartsuchen.TabIndex = 20
        Me.bt_webstartsuchen.Text = "Suchen"
        Me.bt_webstartsuchen.UseVisualStyleBackColor = False
        '
        'bt_webkopfsuchen
        '
        Me.bt_webkopfsuchen.BackColor = System.Drawing.SystemColors.Control
        Me.bt_webkopfsuchen.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_webkopfsuchen.Enabled = False
        Me.bt_webkopfsuchen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_webkopfsuchen.Location = New System.Drawing.Point(344, 112)
        Me.bt_webkopfsuchen.Name = "bt_webkopfsuchen"
        Me.bt_webkopfsuchen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_webkopfsuchen.Size = New System.Drawing.Size(57, 17)
        Me.bt_webkopfsuchen.TabIndex = 19
        Me.bt_webkopfsuchen.Text = "Suchen"
        Me.bt_webkopfsuchen.UseVisualStyleBackColor = False
        '
        'Text4
        '
        Me.Text4.AcceptsReturn = True
        Me.Text4.BackColor = System.Drawing.SystemColors.Window
        Me.Text4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text4.Location = New System.Drawing.Point(80, 112)
        Me.Text4.MaxLength = 0
        Me.Text4.Name = "Text4"
        Me.Text4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text4.Size = New System.Drawing.Size(257, 19)
        Me.Text4.TabIndex = 18
        Me.Text4.Text = "Text4"
        '
        'bt_suchenweb
        '
        Me.bt_suchenweb.BackColor = System.Drawing.SystemColors.Control
        Me.bt_suchenweb.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_suchenweb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_suchenweb.Location = New System.Drawing.Point(344, 72)
        Me.bt_suchenweb.Name = "bt_suchenweb"
        Me.bt_suchenweb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_suchenweb.Size = New System.Drawing.Size(57, 17)
        Me.bt_suchenweb.TabIndex = 16
        Me.bt_suchenweb.Text = "Suchen"
        Me.bt_suchenweb.UseVisualStyleBackColor = False
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.BackColor = System.Drawing.SystemColors.Window
        Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.Location = New System.Drawing.Point(80, 72)
        Me.Text3.MaxLength = 0
        Me.Text3.Name = "Text3"
        Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text3.Size = New System.Drawing.Size(257, 19)
        Me.Text3.TabIndex = 15
        Me.Text3.Text = "Text3"
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.Enabled = False
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(144, 32)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(121, 19)
        Me.Text2.TabIndex = 13
        Me.Text2.Text = "Text2"
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.Location = New System.Drawing.Point(272, 32)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(129, 21)
        Me.List1.TabIndex = 12
        '
        'bt_suchen
        '
        Me.bt_suchen.BackColor = System.Drawing.SystemColors.Control
        Me.bt_suchen.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_suchen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_suchen.Location = New System.Drawing.Point(344, 8)
        Me.bt_suchen.Name = "bt_suchen"
        Me.bt_suchen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_suchen.Size = New System.Drawing.Size(57, 17)
        Me.bt_suchen.TabIndex = 10
        Me.bt_suchen.Text = "Suchen"
        Me.bt_suchen.UseVisualStyleBackColor = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(80, 8)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(257, 19)
        Me.Text1.TabIndex = 9
        Me.Text1.Text = "Text1"
        '
        '_picOptions_3
        '
        Me._picOptions_3.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_3.Controls.Add(Me.fraSample4)
        Me._picOptions_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOptions.SetIndex(Me._picOptions_3, CType(3, Short))
        Me._picOptions_3.Location = New System.Drawing.Point(-1333, 32)
        Me._picOptions_3.Name = "_picOptions_3"
        Me._picOptions_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picOptions_3.Size = New System.Drawing.Size(379, 252)
        Me._picOptions_3.TabIndex = 4
        '
        'fraSample4
        '
        Me.fraSample4.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSample4.Location = New System.Drawing.Point(140, 56)
        Me.fraSample4.Name = "fraSample4"
        Me.fraSample4.Padding = New System.Windows.Forms.Padding(0)
        Me.fraSample4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSample4.Size = New System.Drawing.Size(137, 119)
        Me.fraSample4.TabIndex = 7
        Me.fraSample4.TabStop = False
        Me.fraSample4.Text = "Beispiel 4"
        '
        '_picOptions_2
        '
        Me._picOptions_2.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_2.Controls.Add(Me.fraSample3)
        Me._picOptions_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOptions.SetIndex(Me._picOptions_2, CType(2, Short))
        Me._picOptions_2.Location = New System.Drawing.Point(-1333, 32)
        Me._picOptions_2.Name = "_picOptions_2"
        Me._picOptions_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picOptions_2.Size = New System.Drawing.Size(379, 252)
        Me._picOptions_2.TabIndex = 3
        '
        'fraSample3
        '
        Me.fraSample3.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSample3.Location = New System.Drawing.Point(103, 45)
        Me.fraSample3.Name = "fraSample3"
        Me.fraSample3.Padding = New System.Windows.Forms.Padding(0)
        Me.fraSample3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSample3.Size = New System.Drawing.Size(137, 119)
        Me.fraSample3.TabIndex = 6
        Me.fraSample3.TabStop = False
        Me.fraSample3.Text = "Beispiel 3"
        '
        '_picOptions_1
        '
        Me._picOptions_1.BackColor = System.Drawing.SystemColors.Control
        Me._picOptions_1.Controls.Add(Me.fraSample2)
        Me._picOptions_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._picOptions_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picOptions.SetIndex(Me._picOptions_1, CType(1, Short))
        Me._picOptions_1.Location = New System.Drawing.Point(-1333, 32)
        Me._picOptions_1.Name = "_picOptions_1"
        Me._picOptions_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._picOptions_1.Size = New System.Drawing.Size(379, 252)
        Me._picOptions_1.TabIndex = 2
        '
        'fraSample2
        '
        Me.fraSample2.BackColor = System.Drawing.SystemColors.Control
        Me.fraSample2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fraSample2.Location = New System.Drawing.Point(43, 20)
        Me.fraSample2.Name = "fraSample2"
        Me.fraSample2.Padding = New System.Windows.Forms.Padding(0)
        Me.fraSample2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraSample2.Size = New System.Drawing.Size(137, 119)
        Me.fraSample2.TabIndex = 5
        Me.fraSample2.TabStop = False
        Me.fraSample2.Text = "Beispiel 2"
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(248, 376)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Abbrechen"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(328, 377)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK.TabIndex = 0
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Zeit für Diashow:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(177, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Irfan View Programmpfad:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(177, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Web Startseite:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(177, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Web Kopfseite:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(169, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Stammverzeichnis für Webexport:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(129, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Datenbank sortieren nach:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Datenbank:"
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(410, 407)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.btn_ArtikelKopfText)
        Me.Controls.Add(Me.HScroll1)
        Me.Controls.Add(Me.Text6)
        Me.Controls.Add(Me.bt_iview_suchen)
        Me.Controls.Add(Me.iview_path)
        Me.Controls.Add(Me.Text5)
        Me.Controls.Add(Me.bt_webstartsuchen)
        Me.Controls.Add(Me.bt_webkopfsuchen)
        Me.Controls.Add(Me.Text4)
        Me.Controls.Add(Me.bt_suchenweb)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.bt_suchen)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me._picOptions_3)
        Me.Controls.Add(Me._picOptions_2)
        Me.Controls.Add(Me._picOptions_1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(14, 11)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Optionen"
        Me.Frame2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me._picOptions_3.ResumeLayout(False)
        Me._picOptions_2.ResumeLayout(False)
        Me._picOptions_1.ResumeLayout(False)
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
#End Region 
End Class