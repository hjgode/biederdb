<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class db2web
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
	Public WithEvents bt_AktuellBearbeiten As System.Windows.Forms.Button
	Public WithEvents bt_view As System.Windows.Forms.Button
	Public WithEvents txt_StartSeite As System.Windows.Forms.TextBox
	Public WithEvents File1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
	Public WithEvents filesList As System.Windows.Forms.ListBox
	Public WithEvents weblist As System.Windows.Forms.ListBox
	Public WithEvents chk_cleanwebdir As System.Windows.Forms.CheckBox
	Public WithEvents bt_savelist As System.Windows.Forms.Button
	Public WithEvents bt_ab As System.Windows.Forms.Button
	Public WithEvents bt_auf As System.Windows.Forms.Button
	Public WithEvents chk_nur1Gruppe As System.Windows.Forms.CheckBox
	Public WithEvents txt_status As System.Windows.Forms.TextBox
	Public WithEvents bt_cancel As System.Windows.Forms.Button
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents bt_copy As System.Windows.Forms.Button
	Public WithEvents List2 As System.Windows.Forms.ListBox
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents bt_close As System.Windows.Forms.Button
	Public WithEvents bt_start As System.Windows.Forms.Button
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(db2web))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.bt_AktuellBearbeiten = New System.Windows.Forms.Button
		Me.bt_view = New System.Windows.Forms.Button
		Me.txt_StartSeite = New System.Windows.Forms.TextBox
		Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
		Me.filesList = New System.Windows.Forms.ListBox
		Me.weblist = New System.Windows.Forms.ListBox
		Me.chk_cleanwebdir = New System.Windows.Forms.CheckBox
		Me.bt_savelist = New System.Windows.Forms.Button
		Me.bt_ab = New System.Windows.Forms.Button
		Me.bt_auf = New System.Windows.Forms.Button
		Me.chk_nur1Gruppe = New System.Windows.Forms.CheckBox
		Me.txt_status = New System.Windows.Forms.TextBox
		Me.bt_cancel = New System.Windows.Forms.Button
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.bt_copy = New System.Windows.Forms.Button
		Me.List2 = New System.Windows.Forms.ListBox
		Me.List1 = New System.Windows.Forms.ListBox
		Me.bt_close = New System.Windows.Forms.Button
		Me.bt_start = New System.Windows.Forms.Button
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Daten für Web aufbereiten"
		Me.ClientSize = New System.Drawing.Size(484, 367)
		Me.Location = New System.Drawing.Point(14, 22)
		Me.ControlBox = False
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "db2web"
		Me.bt_AktuellBearbeiten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_AktuellBearbeiten.Text = "Aktuell bearbeiten"
		Me.bt_AktuellBearbeiten.Size = New System.Drawing.Size(105, 25)
		Me.bt_AktuellBearbeiten.Location = New System.Drawing.Point(376, 216)
		Me.bt_AktuellBearbeiten.TabIndex = 26
		Me.bt_AktuellBearbeiten.BackColor = System.Drawing.SystemColors.Control
		Me.bt_AktuellBearbeiten.CausesValidation = True
		Me.bt_AktuellBearbeiten.Enabled = True
		Me.bt_AktuellBearbeiten.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_AktuellBearbeiten.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_AktuellBearbeiten.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_AktuellBearbeiten.TabStop = True
		Me.bt_AktuellBearbeiten.Name = "bt_AktuellBearbeiten"
		Me.bt_view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_view.Text = "Anzeigen"
		Me.bt_view.Size = New System.Drawing.Size(65, 25)
		Me.bt_view.Location = New System.Drawing.Point(416, 104)
		Me.bt_view.TabIndex = 25
		Me.bt_view.BackColor = System.Drawing.SystemColors.Control
		Me.bt_view.CausesValidation = True
		Me.bt_view.Enabled = True
		Me.bt_view.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_view.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_view.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_view.TabStop = True
		Me.bt_view.Name = "bt_view"
		Me.txt_StartSeite.AutoSize = False
		Me.txt_StartSeite.Enabled = False
		Me.txt_StartSeite.Size = New System.Drawing.Size(81, 19)
		Me.txt_StartSeite.Location = New System.Drawing.Point(288, 216)
		Me.txt_StartSeite.TabIndex = 24
		Me.txt_StartSeite.Text = "Text4"
		Me.txt_StartSeite.AcceptsReturn = True
		Me.txt_StartSeite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txt_StartSeite.BackColor = System.Drawing.SystemColors.Window
		Me.txt_StartSeite.CausesValidation = True
		Me.txt_StartSeite.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txt_StartSeite.HideSelection = True
		Me.txt_StartSeite.ReadOnly = False
		Me.txt_StartSeite.Maxlength = 0
		Me.txt_StartSeite.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txt_StartSeite.MultiLine = False
		Me.txt_StartSeite.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txt_StartSeite.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txt_StartSeite.TabStop = True
		Me.txt_StartSeite.Visible = True
		Me.txt_StartSeite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txt_StartSeite.Name = "txt_StartSeite"
		Me.File1.Size = New System.Drawing.Size(113, 58)
		Me.File1.Location = New System.Drawing.Point(8, 304)
		Me.File1.TabIndex = 22
		Me.File1.Visible = False
		Me.File1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.File1.Archive = True
		Me.File1.BackColor = System.Drawing.SystemColors.Window
		Me.File1.CausesValidation = True
		Me.File1.Enabled = True
		Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.File1.Hidden = False
		Me.File1.Cursor = System.Windows.Forms.Cursors.Default
		Me.File1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.File1.Normal = True
		Me.File1.Pattern = "*.*"
		Me.File1.ReadOnly = True
		Me.File1.System = False
		Me.File1.TabStop = True
		Me.File1.TopIndex = 0
		Me.File1.Name = "File1"
		Me.filesList.Enabled = False
		Me.filesList.Size = New System.Drawing.Size(129, 59)
		Me.filesList.Location = New System.Drawing.Point(352, 304)
		Me.filesList.Sorted = True
		Me.filesList.TabIndex = 21
		Me.filesList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.filesList.BackColor = System.Drawing.SystemColors.Window
		Me.filesList.CausesValidation = True
		Me.filesList.ForeColor = System.Drawing.SystemColors.WindowText
		Me.filesList.IntegralHeight = True
		Me.filesList.Cursor = System.Windows.Forms.Cursors.Default
		Me.filesList.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.filesList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.filesList.TabStop = True
		Me.filesList.Visible = True
		Me.filesList.MultiColumn = False
		Me.filesList.Name = "filesList"
		Me.weblist.Enabled = False
		Me.weblist.Size = New System.Drawing.Size(129, 59)
		Me.weblist.Location = New System.Drawing.Point(216, 304)
		Me.weblist.Sorted = True
		Me.weblist.TabIndex = 20
		Me.weblist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.weblist.BackColor = System.Drawing.SystemColors.Window
		Me.weblist.CausesValidation = True
		Me.weblist.ForeColor = System.Drawing.SystemColors.WindowText
		Me.weblist.IntegralHeight = True
		Me.weblist.Cursor = System.Windows.Forms.Cursors.Default
		Me.weblist.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.weblist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.weblist.TabStop = True
		Me.weblist.Visible = True
		Me.weblist.MultiColumn = False
		Me.weblist.Name = "weblist"
		Me.chk_cleanwebdir.Text = "Webverzeichnis bereinigen"
		Me.chk_cleanwebdir.Size = New System.Drawing.Size(193, 17)
		Me.chk_cleanwebdir.Location = New System.Drawing.Point(224, 256)
		Me.chk_cleanwebdir.TabIndex = 19
		Me.chk_cleanwebdir.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chk_cleanwebdir.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chk_cleanwebdir.BackColor = System.Drawing.SystemColors.Control
		Me.chk_cleanwebdir.CausesValidation = True
		Me.chk_cleanwebdir.Enabled = True
		Me.chk_cleanwebdir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk_cleanwebdir.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk_cleanwebdir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk_cleanwebdir.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chk_cleanwebdir.TabStop = True
		Me.chk_cleanwebdir.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chk_cleanwebdir.Visible = True
		Me.chk_cleanwebdir.Name = "chk_cleanwebdir"
		Me.bt_savelist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_savelist.Text = "Liste speichern"
		Me.bt_savelist.Size = New System.Drawing.Size(121, 17)
		Me.bt_savelist.Location = New System.Drawing.Point(216, 112)
		Me.bt_savelist.TabIndex = 18
		Me.ToolTip1.SetToolTip(Me.bt_savelist, "Aktuelle Liste speichern")
		Me.bt_savelist.BackColor = System.Drawing.SystemColors.Control
		Me.bt_savelist.CausesValidation = True
		Me.bt_savelist.Enabled = True
		Me.bt_savelist.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_savelist.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_savelist.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_savelist.TabStop = True
		Me.bt_savelist.Name = "bt_savelist"
		Me.bt_ab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_ab.Text = "¯"
		Me.bt_ab.Font = New System.Drawing.Font("Symbol", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.bt_ab.Size = New System.Drawing.Size(25, 25)
		Me.bt_ab.Location = New System.Drawing.Point(344, 64)
		Me.bt_ab.TabIndex = 17
		Me.ToolTip1.SetToolTip(Me.bt_ab, "Eintrag nach unten schieben")
		Me.bt_ab.BackColor = System.Drawing.SystemColors.Control
		Me.bt_ab.CausesValidation = True
		Me.bt_ab.Enabled = True
		Me.bt_ab.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_ab.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_ab.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_ab.TabStop = True
		Me.bt_ab.Name = "bt_ab"
		Me.bt_auf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_auf.Text = "­"
		Me.bt_auf.Font = New System.Drawing.Font("Symbol", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
		Me.bt_auf.Size = New System.Drawing.Size(25, 25)
		Me.bt_auf.Location = New System.Drawing.Point(344, 40)
		Me.bt_auf.TabIndex = 16
		Me.ToolTip1.SetToolTip(Me.bt_auf, "Eintrag nach oben schieben")
		Me.bt_auf.BackColor = System.Drawing.SystemColors.Control
		Me.bt_auf.CausesValidation = True
		Me.bt_auf.Enabled = True
		Me.bt_auf.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_auf.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_auf.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_auf.TabStop = True
		Me.bt_auf.Name = "bt_auf"
		Me.chk_nur1Gruppe.Text = "Nur die eine gewählte Gruppe neu erstellen"
		Me.chk_nur1Gruppe.Size = New System.Drawing.Size(241, 17)
		Me.chk_nur1Gruppe.Location = New System.Drawing.Point(216, 136)
		Me.chk_nur1Gruppe.TabIndex = 15
		Me.ToolTip1.SetToolTip(Me.chk_nur1Gruppe, "Hiermit wird nur die gewählte Gruppe neu erstellt. Alle anderen Dateien werden nicht aktualisiert.")
		Me.chk_nur1Gruppe.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chk_nur1Gruppe.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chk_nur1Gruppe.BackColor = System.Drawing.SystemColors.Control
		Me.chk_nur1Gruppe.CausesValidation = True
		Me.chk_nur1Gruppe.Enabled = True
		Me.chk_nur1Gruppe.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk_nur1Gruppe.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk_nur1Gruppe.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk_nur1Gruppe.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chk_nur1Gruppe.TabStop = True
		Me.chk_nur1Gruppe.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chk_nur1Gruppe.Visible = True
		Me.chk_nur1Gruppe.Name = "chk_nur1Gruppe"
		Me.txt_status.AutoSize = False
		Me.txt_status.Size = New System.Drawing.Size(473, 19)
		Me.txt_status.Location = New System.Drawing.Point(8, 280)
		Me.txt_status.TabIndex = 14
		Me.txt_status.Text = "txt_status"
		Me.txt_status.AcceptsReturn = True
		Me.txt_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txt_status.BackColor = System.Drawing.SystemColors.Window
		Me.txt_status.CausesValidation = True
		Me.txt_status.Enabled = True
		Me.txt_status.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txt_status.HideSelection = True
		Me.txt_status.ReadOnly = False
		Me.txt_status.Maxlength = 0
		Me.txt_status.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txt_status.MultiLine = False
		Me.txt_status.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txt_status.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txt_status.TabStop = True
		Me.txt_status.Visible = True
		Me.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txt_status.Name = "txt_status"
		Me.bt_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_cancel.Text = "Abbrechen"
		Me.bt_cancel.Enabled = False
		Me.bt_cancel.Size = New System.Drawing.Size(65, 25)
		Me.bt_cancel.Location = New System.Drawing.Point(416, 72)
		Me.bt_cancel.TabIndex = 13
		Me.ToolTip1.SetToolTip(Me.bt_cancel, "Abbrechen der Weberstellung")
		Me.bt_cancel.BackColor = System.Drawing.SystemColors.Control
		Me.bt_cancel.CausesValidation = True
		Me.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_cancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_cancel.TabStop = True
		Me.bt_cancel.Name = "bt_cancel"
		Me.Text3.AutoSize = False
		Me.Text3.Enabled = False
		Me.Text3.Size = New System.Drawing.Size(209, 19)
		Me.Text3.Location = New System.Drawing.Point(8, 216)
		Me.Text3.TabIndex = 12
		Me.Text3.Text = "Text3"
		Me.ToolTip1.SetToolTip(Me.Text3, "Dieses Verzeichnis wird über Optionen-Einstellungen festgelegt")
		Me.Text3.AcceptsReturn = True
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text3.BackColor = System.Drawing.SystemColors.Window
		Me.Text3.CausesValidation = True
		Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text3.HideSelection = True
		Me.Text3.ReadOnly = False
		Me.Text3.Maxlength = 0
		Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text3.MultiLine = False
		Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text3.TabStop = True
		Me.Text3.Visible = True
		Me.Text3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text3.Name = "Text3"
		Me.Text2.AutoSize = False
		Me.Text2.Size = New System.Drawing.Size(209, 19)
		Me.Text2.Location = New System.Drawing.Point(8, 256)
		Me.Text2.TabIndex = 10
		Me.Text2.Text = "Text2"
		Me.ToolTip1.SetToolTip(Me.Text2, "Dieses Verzeichnis wird über Optionen-Einstellungen festgelegt")
		Me.Text2.AcceptsReturn = True
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text2.BackColor = System.Drawing.SystemColors.Window
		Me.Text2.CausesValidation = True
		Me.Text2.Enabled = True
		Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text2.HideSelection = True
		Me.Text2.ReadOnly = False
		Me.Text2.Maxlength = 0
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.TabStop = True
		Me.Text2.Visible = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text2.Name = "Text2"
		Me.Text1.AutoSize = False
		Me.Text1.Enabled = False
		Me.Text1.Size = New System.Drawing.Size(209, 19)
		Me.Text1.Location = New System.Drawing.Point(8, 176)
		Me.Text1.TabIndex = 8
		Me.Text1.Text = "Text1"
		Me.ToolTip1.SetToolTip(Me.Text1, "Diese Datei wird über Optionen-Einstellungen festgelegt")
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
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
		Me.bt_copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_copy.Text = "Übernehmen"
		Me.bt_copy.Size = New System.Drawing.Size(73, 25)
		Me.bt_copy.Location = New System.Drawing.Point(136, 56)
		Me.bt_copy.TabIndex = 5
		Me.bt_copy.BackColor = System.Drawing.SystemColors.Control
		Me.bt_copy.CausesValidation = True
		Me.bt_copy.Enabled = True
		Me.bt_copy.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_copy.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_copy.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_copy.TabStop = True
		Me.bt_copy.Name = "bt_copy"
		Me.List2.Size = New System.Drawing.Size(121, 85)
		Me.List2.Location = New System.Drawing.Point(216, 24)
		Me.List2.TabIndex = 4
		Me.ToolTip1.SetToolTip(Me.List2, "Doppelklicken zu Entfernen")
		Me.List2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.List2.BackColor = System.Drawing.SystemColors.Window
		Me.List2.CausesValidation = True
		Me.List2.Enabled = True
		Me.List2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.List2.IntegralHeight = True
		Me.List2.Cursor = System.Windows.Forms.Cursors.Default
		Me.List2.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.List2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.List2.Sorted = False
		Me.List2.TabStop = True
		Me.List2.Visible = True
		Me.List2.MultiColumn = False
		Me.List2.Name = "List2"
		Me.List1.Size = New System.Drawing.Size(121, 85)
		Me.List1.Location = New System.Drawing.Point(8, 24)
		Me.List1.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.List1, "Doppleklicken zum Übernehmen")
		Me.List1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.List1.BackColor = System.Drawing.SystemColors.Window
		Me.List1.CausesValidation = True
		Me.List1.Enabled = True
		Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.List1.IntegralHeight = True
		Me.List1.Cursor = System.Windows.Forms.Cursors.Default
		Me.List1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.List1.Sorted = False
		Me.List1.TabStop = True
		Me.List1.Visible = True
		Me.List1.MultiColumn = False
		Me.List1.Name = "List1"
		Me.bt_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_close.Text = "Schliessen"
		Me.bt_close.Size = New System.Drawing.Size(65, 25)
		Me.bt_close.Location = New System.Drawing.Point(416, 40)
		Me.bt_close.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.bt_close, "Fenster schliessen")
		Me.bt_close.BackColor = System.Drawing.SystemColors.Control
		Me.bt_close.CausesValidation = True
		Me.bt_close.Enabled = True
		Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_close.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_close.TabStop = True
		Me.bt_close.Name = "bt_close"
		Me.bt_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_start.Text = "Start"
		Me.bt_start.Size = New System.Drawing.Size(65, 25)
		Me.bt_start.Location = New System.Drawing.Point(416, 8)
		Me.bt_start.TabIndex = 0
		Me.ToolTip1.SetToolTip(Me.bt_start, "Starten der Erstellung der Webseiten")
		Me.bt_start.BackColor = System.Drawing.SystemColors.Control
		Me.bt_start.CausesValidation = True
		Me.bt_start.Enabled = True
		Me.bt_start.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_start.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_start.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_start.TabStop = True
		Me.bt_start.Name = "bt_start"
		Me.Label6.Text = "Hauptseite:"
		Me.Label6.Size = New System.Drawing.Size(65, 17)
		Me.Label6.Location = New System.Drawing.Point(224, 216)
		Me.Label6.TabIndex = 23
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.Text = "3. Startseite festlegen:"
		Me.Label5.Size = New System.Drawing.Size(145, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 200)
		Me.Label5.TabIndex = 11
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "4. Web-Stammverzeichnis:"
		Me.Label4.Size = New System.Drawing.Size(161, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 240)
		Me.Label4.TabIndex = 9
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "2. Kopfbereichsdatei(html):"
		Me.Label3.Size = New System.Drawing.Size(129, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 160)
		Me.Label3.TabIndex = 7
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Übernommene Kategorien:"
		Me.Label2.Size = New System.Drawing.Size(137, 17)
		Me.Label2.Location = New System.Drawing.Point(208, 8)
		Me.Label2.TabIndex = 6
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
		Me.Label1.Text = "1. Kategorien auswählen:"
		Me.Label1.Size = New System.Drawing.Size(145, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 8)
		Me.Label1.TabIndex = 3
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
		Me.Controls.Add(bt_AktuellBearbeiten)
		Me.Controls.Add(bt_view)
		Me.Controls.Add(txt_StartSeite)
		Me.Controls.Add(File1)
		Me.Controls.Add(filesList)
		Me.Controls.Add(weblist)
		Me.Controls.Add(chk_cleanwebdir)
		Me.Controls.Add(bt_savelist)
		Me.Controls.Add(bt_ab)
		Me.Controls.Add(bt_auf)
		Me.Controls.Add(chk_nur1Gruppe)
		Me.Controls.Add(txt_status)
		Me.Controls.Add(bt_cancel)
		Me.Controls.Add(Text3)
		Me.Controls.Add(Text2)
		Me.Controls.Add(Text1)
		Me.Controls.Add(bt_copy)
		Me.Controls.Add(List2)
		Me.Controls.Add(List1)
		Me.Controls.Add(bt_close)
		Me.Controls.Add(bt_start)
		Me.Controls.Add(Label6)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class