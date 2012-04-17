<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class zip_frm
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
	Public WithEvents vbzip As AxVBZip_Control.AxRichsoftVBZip
	Public WithEvents bt_back As System.Windows.Forms.Button
	Public WithEvents bt_close As System.Windows.Forms.Button
	Public WithEvents opt_onlynewer As System.Windows.Forms.CheckBox
	Public WithEvents opt_overwrite As System.Windows.Forms.CheckBox
	Public WithEvents txtExtractTo As System.Windows.Forms.TextBox
	Public WithEvents bt_targetdir As System.Windows.Forms.Button
	Public WithEvents bt_restore As System.Windows.Forms.Button
	Public WithEvents Text3 As System.Windows.Forms.TextBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents bt_autofill As System.Windows.Forms.Button
	Public WithEvents bt_remove As System.Windows.Forms.Button
	Public WithEvents bt_suchdir As System.Windows.Forms.Button
	Public WithEvents bt_zipfilename As System.Windows.Forms.Button
	Public WithEvents bt_zip_start As System.Windows.Forms.Button
	Public WithEvents List1 As System.Windows.Forms.ListBox
	Public WithEvents bt_add As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents bt_search As System.Windows.Forms.Button
	Public WithEvents bt_change As System.Windows.Forms.Button
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents lvwArchive As AxComctlLib.AxListView
	Public WithEvents iglIcons As AxComctlLib.AxImageList
	Public WithEvents lblFiles As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(zip_frm))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.vbzip = New AxVBZip_Control.AxRichsoftVBZip
		Me.bt_back = New System.Windows.Forms.Button
		Me.bt_close = New System.Windows.Forms.Button
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.opt_onlynewer = New System.Windows.Forms.CheckBox
		Me.opt_overwrite = New System.Windows.Forms.CheckBox
		Me.txtExtractTo = New System.Windows.Forms.TextBox
		Me.bt_targetdir = New System.Windows.Forms.Button
		Me.bt_restore = New System.Windows.Forms.Button
		Me.Text3 = New System.Windows.Forms.TextBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.bt_autofill = New System.Windows.Forms.Button
		Me.bt_remove = New System.Windows.Forms.Button
		Me.bt_suchdir = New System.Windows.Forms.Button
		Me.bt_zipfilename = New System.Windows.Forms.Button
		Me.bt_zip_start = New System.Windows.Forms.Button
		Me.List1 = New System.Windows.Forms.ListBox
		Me.bt_add = New System.Windows.Forms.Button
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.bt_search = New System.Windows.Forms.Button
		Me.bt_change = New System.Windows.Forms.Button
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.lvwArchive = New AxComctlLib.AxListView
		Me.iglIcons = New AxComctlLib.AxImageList
		Me.lblFiles = New System.Windows.Forms.Label
		Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
		Me.CommonDialog1Save = New System.Windows.Forms.SaveFileDialog
		Me.Frame2.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.vbzip, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.lvwArchive, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.iglIcons, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "BiederZIP Datenbackup"
		Me.ClientSize = New System.Drawing.Size(524, 338)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.Icon = CType(resources.GetObject("zip_frm.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "zip_frm"
		vbzip.OcxState = CType(resources.GetObject("vbzip.OcxState"), System.Windows.Forms.AxHost.State)
		Me.vbzip.Location = New System.Drawing.Point(328, 232)
		Me.vbzip.Name = "vbzip"
		Me.bt_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_back.Text = "&Zurück zu BiederDB"
		Me.bt_back.Size = New System.Drawing.Size(129, 25)
		Me.bt_back.Location = New System.Drawing.Point(384, 272)
		Me.bt_back.TabIndex = 21
		Me.bt_back.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_back.BackColor = System.Drawing.SystemColors.Control
		Me.bt_back.CausesValidation = True
		Me.bt_back.Enabled = True
		Me.bt_back.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_back.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_back.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_back.TabStop = True
		Me.bt_back.Name = "bt_back"
		Me.bt_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_close.Text = "B&eenden"
		Me.bt_close.Size = New System.Drawing.Size(81, 25)
		Me.bt_close.Location = New System.Drawing.Point(432, 304)
		Me.bt_close.TabIndex = 19
		Me.bt_close.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_close.BackColor = System.Drawing.SystemColors.Control
		Me.bt_close.CausesValidation = True
		Me.bt_close.Enabled = True
		Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_close.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_close.TabStop = True
		Me.bt_close.Name = "bt_close"
		Me.Frame2.Text = "Restore:"
		Me.Frame2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame2.Size = New System.Drawing.Size(313, 105)
		Me.Frame2.Location = New System.Drawing.Point(8, 224)
		Me.Frame2.TabIndex = 9
		Me.Frame2.BackColor = System.Drawing.SystemColors.Control
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.opt_onlynewer.Text = "Ältere überspringen"
		Me.opt_onlynewer.Size = New System.Drawing.Size(137, 17)
		Me.opt_onlynewer.Location = New System.Drawing.Point(8, 80)
		Me.opt_onlynewer.TabIndex = 18
		Me.ToolTip1.SetToolTip(Me.opt_onlynewer, "Nur neuere Dateien wiederherstellen. Alte werden überschreiben. Neuere werden nicht überschrieben.")
		Me.opt_onlynewer.CheckState = System.Windows.Forms.CheckState.Checked
		Me.opt_onlynewer.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opt_onlynewer.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opt_onlynewer.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.opt_onlynewer.BackColor = System.Drawing.SystemColors.Control
		Me.opt_onlynewer.CausesValidation = True
		Me.opt_onlynewer.Enabled = True
		Me.opt_onlynewer.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opt_onlynewer.Cursor = System.Windows.Forms.Cursors.Default
		Me.opt_onlynewer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opt_onlynewer.Appearance = System.Windows.Forms.Appearance.Normal
		Me.opt_onlynewer.TabStop = True
		Me.opt_onlynewer.Visible = True
		Me.opt_onlynewer.Name = "opt_onlynewer"
		Me.opt_overwrite.Text = "Alles überschreiben"
		Me.opt_overwrite.Size = New System.Drawing.Size(121, 17)
		Me.opt_overwrite.Location = New System.Drawing.Point(8, 64)
		Me.opt_overwrite.TabIndex = 17
		Me.ToolTip1.SetToolTip(Me.opt_overwrite, "Alle bestehenden Dateien überschreiben.")
		Me.opt_overwrite.CheckState = System.Windows.Forms.CheckState.Checked
		Me.opt_overwrite.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.opt_overwrite.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opt_overwrite.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.opt_overwrite.BackColor = System.Drawing.SystemColors.Control
		Me.opt_overwrite.CausesValidation = True
		Me.opt_overwrite.Enabled = True
		Me.opt_overwrite.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opt_overwrite.Cursor = System.Windows.Forms.Cursors.Default
		Me.opt_overwrite.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opt_overwrite.Appearance = System.Windows.Forms.Appearance.Normal
		Me.opt_overwrite.TabStop = True
		Me.opt_overwrite.Visible = True
		Me.opt_overwrite.Name = "opt_overwrite"
		Me.txtExtractTo.AutoSize = False
		Me.txtExtractTo.Size = New System.Drawing.Size(217, 19)
		Me.txtExtractTo.Location = New System.Drawing.Point(88, 40)
		Me.txtExtractTo.TabIndex = 14
		Me.txtExtractTo.Text = "C:\"
		Me.txtExtractTo.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtExtractTo.AcceptsReturn = True
		Me.txtExtractTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtExtractTo.BackColor = System.Drawing.SystemColors.Window
		Me.txtExtractTo.CausesValidation = True
		Me.txtExtractTo.Enabled = True
		Me.txtExtractTo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtExtractTo.HideSelection = True
		Me.txtExtractTo.ReadOnly = False
		Me.txtExtractTo.Maxlength = 0
		Me.txtExtractTo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtExtractTo.MultiLine = False
		Me.txtExtractTo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtExtractTo.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtExtractTo.TabStop = True
		Me.txtExtractTo.Visible = True
		Me.txtExtractTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtExtractTo.Name = "txtExtractTo"
		Me.bt_targetdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_targetdir.Text = "&Zielverz.:"
		Me.bt_targetdir.Size = New System.Drawing.Size(73, 17)
		Me.bt_targetdir.Location = New System.Drawing.Point(8, 40)
		Me.bt_targetdir.TabIndex = 13
		Me.bt_targetdir.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_targetdir.BackColor = System.Drawing.SystemColors.Control
		Me.bt_targetdir.CausesValidation = True
		Me.bt_targetdir.Enabled = True
		Me.bt_targetdir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_targetdir.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_targetdir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_targetdir.TabStop = True
		Me.bt_targetdir.Name = "bt_targetdir"
		Me.bt_restore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_restore.Text = "Daten &wiederherstellen"
		Me.bt_restore.Size = New System.Drawing.Size(145, 25)
		Me.bt_restore.Location = New System.Drawing.Point(160, 64)
		Me.bt_restore.TabIndex = 12
		Me.ToolTip1.SetToolTip(Me.bt_restore, "Rücksicherung der Dateien")
		Me.bt_restore.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_restore.BackColor = System.Drawing.SystemColors.Control
		Me.bt_restore.CausesValidation = True
		Me.bt_restore.Enabled = True
		Me.bt_restore.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_restore.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_restore.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_restore.TabStop = True
		Me.bt_restore.Name = "bt_restore"
		Me.Text3.AutoSize = False
		Me.Text3.Size = New System.Drawing.Size(217, 19)
		Me.Text3.Location = New System.Drawing.Point(88, 16)
		Me.Text3.TabIndex = 11
		Me.Text3.Text = "C:\Eigene Dateien\biederdb.zip"
		Me.Text3.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text3.AcceptsReturn = True
		Me.Text3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text3.BackColor = System.Drawing.SystemColors.Window
		Me.Text3.CausesValidation = True
		Me.Text3.Enabled = True
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
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "&Quelldatei:"
		Me.Command1.Size = New System.Drawing.Size(73, 17)
		Me.Command1.Location = New System.Drawing.Point(8, 16)
		Me.Command1.TabIndex = 10
		Me.Command1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Frame1.Text = "Backup:"
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Size = New System.Drawing.Size(513, 217)
		Me.Frame1.Location = New System.Drawing.Point(8, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.bt_autofill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_autofill.Text = "Automatisch"
		Me.bt_autofill.Size = New System.Drawing.Size(73, 17)
		Me.bt_autofill.Location = New System.Drawing.Point(8, 16)
		Me.bt_autofill.TabIndex = 20
		Me.bt_autofill.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_autofill.BackColor = System.Drawing.SystemColors.Control
		Me.bt_autofill.CausesValidation = True
		Me.bt_autofill.Enabled = True
		Me.bt_autofill.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_autofill.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_autofill.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_autofill.TabStop = True
		Me.bt_autofill.Name = "bt_autofill"
		Me.bt_remove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_remove.Text = "Ent&fernen"
		Me.bt_remove.Size = New System.Drawing.Size(73, 17)
		Me.bt_remove.Location = New System.Drawing.Point(232, 40)
		Me.bt_remove.TabIndex = 16
		Me.bt_remove.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_remove.BackColor = System.Drawing.SystemColors.Control
		Me.bt_remove.CausesValidation = True
		Me.bt_remove.Enabled = True
		Me.bt_remove.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_remove.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_remove.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_remove.TabStop = True
		Me.bt_remove.Name = "bt_remove"
		Me.bt_suchdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_suchdir.Text = "&Verz. suchen"
		Me.bt_suchdir.Size = New System.Drawing.Size(73, 17)
		Me.bt_suchdir.Location = New System.Drawing.Point(8, 56)
		Me.bt_suchdir.TabIndex = 15
		Me.bt_suchdir.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_suchdir.BackColor = System.Drawing.SystemColors.Control
		Me.bt_suchdir.CausesValidation = True
		Me.bt_suchdir.Enabled = True
		Me.bt_suchdir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_suchdir.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_suchdir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_suchdir.TabStop = True
		Me.bt_suchdir.Name = "bt_suchdir"
		Me.bt_zipfilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_zipfilename.Text = "Back&updatei:"
		Me.bt_zipfilename.Size = New System.Drawing.Size(73, 17)
		Me.bt_zipfilename.Location = New System.Drawing.Point(8, 160)
		Me.bt_zipfilename.TabIndex = 8
		Me.bt_zipfilename.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_zipfilename.BackColor = System.Drawing.SystemColors.Control
		Me.bt_zipfilename.CausesValidation = True
		Me.bt_zipfilename.Enabled = True
		Me.bt_zipfilename.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_zipfilename.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_zipfilename.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_zipfilename.TabStop = True
		Me.bt_zipfilename.Name = "bt_zipfilename"
		Me.bt_zip_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_zip_start.Text = "Backup-Datei &erstellen"
		Me.bt_zip_start.Size = New System.Drawing.Size(145, 25)
		Me.bt_zip_start.Location = New System.Drawing.Point(160, 184)
		Me.bt_zip_start.TabIndex = 7
		Me.ToolTip1.SetToolTip(Me.bt_zip_start, "Sicherung der Liste starten")
		Me.bt_zip_start.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_zip_start.BackColor = System.Drawing.SystemColors.Control
		Me.bt_zip_start.CausesValidation = True
		Me.bt_zip_start.Enabled = True
		Me.bt_zip_start.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_zip_start.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_zip_start.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_zip_start.TabStop = True
		Me.bt_zip_start.Name = "bt_zip_start"
		Me.List1.Size = New System.Drawing.Size(217, 98)
		Me.List1.Location = New System.Drawing.Point(88, 56)
		Me.List1.TabIndex = 6
		Me.List1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.bt_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_add.Text = "&Hinzufügen"
		Me.bt_add.Size = New System.Drawing.Size(73, 17)
		Me.bt_add.Location = New System.Drawing.Point(88, 40)
		Me.bt_add.TabIndex = 5
		Me.bt_add.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_add.BackColor = System.Drawing.SystemColors.Control
		Me.bt_add.CausesValidation = True
		Me.bt_add.Enabled = True
		Me.bt_add.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_add.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_add.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_add.TabStop = True
		Me.bt_add.Name = "bt_add"
		Me.Text1.AutoSize = False
		Me.Text1.Size = New System.Drawing.Size(217, 19)
		Me.Text1.Location = New System.Drawing.Point(88, 16)
		Me.Text1.TabIndex = 4
		Me.Text1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		Me.bt_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_search.Text = "&Datei suchen"
		Me.bt_search.Size = New System.Drawing.Size(73, 17)
		Me.bt_search.Location = New System.Drawing.Point(8, 40)
		Me.bt_search.TabIndex = 3
		Me.bt_search.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_search.BackColor = System.Drawing.SystemColors.Control
		Me.bt_search.CausesValidation = True
		Me.bt_search.Enabled = True
		Me.bt_search.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_search.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_search.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_search.TabStop = True
		Me.bt_search.Name = "bt_search"
		Me.bt_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.bt_change.Text = "&Bearbeiten"
		Me.bt_change.Size = New System.Drawing.Size(73, 17)
		Me.bt_change.Location = New System.Drawing.Point(160, 40)
		Me.bt_change.TabIndex = 2
		Me.bt_change.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.bt_change.BackColor = System.Drawing.SystemColors.Control
		Me.bt_change.CausesValidation = True
		Me.bt_change.Enabled = True
		Me.bt_change.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_change.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_change.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_change.TabStop = True
		Me.bt_change.Name = "bt_change"
		Me.Text2.AutoSize = False
		Me.Text2.Size = New System.Drawing.Size(217, 19)
		Me.Text2.Location = New System.Drawing.Point(88, 160)
		Me.Text2.TabIndex = 1
		Me.Text2.Text = "C:\Eigene Dateien\biederdb.zip"
		Me.Text2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
		lvwArchive.OcxState = CType(resources.GetObject("lvwArchive.OcxState"), System.Windows.Forms.AxHost.State)
		Me.lvwArchive.Size = New System.Drawing.Size(193, 161)
		Me.lvwArchive.Location = New System.Drawing.Point(312, 16)
		Me.lvwArchive.TabIndex = 23
		Me.lvwArchive.Name = "lvwArchive"
		iglIcons.OcxState = CType(resources.GetObject("iglIcons.OcxState"), System.Windows.Forms.AxHost.State)
		Me.iglIcons.Location = New System.Drawing.Point(8, 80)
		Me.iglIcons.Name = "iglIcons"
		Me.lblFiles.Size = New System.Drawing.Size(193, 25)
		Me.lblFiles.Location = New System.Drawing.Point(312, 184)
		Me.lblFiles.TabIndex = 22
		Me.lblFiles.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblFiles.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblFiles.BackColor = System.Drawing.SystemColors.Control
		Me.lblFiles.Enabled = True
		Me.lblFiles.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblFiles.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblFiles.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblFiles.UseMnemonic = True
		Me.lblFiles.Visible = True
		Me.lblFiles.AutoSize = False
		Me.lblFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblFiles.Name = "lblFiles"
		Me.Controls.Add(vbzip)
		Me.Controls.Add(bt_back)
		Me.Controls.Add(bt_close)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame1)
		Me.Frame2.Controls.Add(opt_onlynewer)
		Me.Frame2.Controls.Add(opt_overwrite)
		Me.Frame2.Controls.Add(txtExtractTo)
		Me.Frame2.Controls.Add(bt_targetdir)
		Me.Frame2.Controls.Add(bt_restore)
		Me.Frame2.Controls.Add(Text3)
		Me.Frame2.Controls.Add(Command1)
		Me.Frame1.Controls.Add(bt_autofill)
		Me.Frame1.Controls.Add(bt_remove)
		Me.Frame1.Controls.Add(bt_suchdir)
		Me.Frame1.Controls.Add(bt_zipfilename)
		Me.Frame1.Controls.Add(bt_zip_start)
		Me.Frame1.Controls.Add(List1)
		Me.Frame1.Controls.Add(bt_add)
		Me.Frame1.Controls.Add(Text1)
		Me.Frame1.Controls.Add(bt_search)
		Me.Frame1.Controls.Add(bt_change)
		Me.Frame1.Controls.Add(Text2)
		Me.Frame1.Controls.Add(lvwArchive)
		Me.Frame1.Controls.Add(iglIcons)
		Me.Frame1.Controls.Add(lblFiles)
		CType(Me.iglIcons, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.lvwArchive, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.vbzip, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame2.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class