<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Hauptform
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
	Public WithEvents m_ende As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_datei As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_delete_group As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_SortGroups As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_rename_group As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_edit_gruppentexte As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_bar As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_clean4web As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_doppelte As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_bar2 As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_daten As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_einstellungen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_colors As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_optionen As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_info As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents m_hilfe As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents bt_diashow As System.Windows.Forms.Button
	Public WithEvents bt_zip As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents BT_bearbeiten As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Hauptform))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.m_datei = New System.Windows.Forms.ToolStripMenuItem
		Me.m_ende = New System.Windows.Forms.ToolStripMenuItem
		Me.m_daten = New System.Windows.Forms.ToolStripMenuItem
		Me.m_delete_group = New System.Windows.Forms.ToolStripMenuItem
		Me.m_SortGroups = New System.Windows.Forms.ToolStripMenuItem
		Me.m_rename_group = New System.Windows.Forms.ToolStripMenuItem
		Me.m_edit_gruppentexte = New System.Windows.Forms.ToolStripMenuItem
		Me.m_bar = New System.Windows.Forms.ToolStripMenuItem
		Me.m_clean4web = New System.Windows.Forms.ToolStripMenuItem
		Me.m_doppelte = New System.Windows.Forms.ToolStripMenuItem
		Me.m_bar2 = New System.Windows.Forms.ToolStripMenuItem
		Me.m_optionen = New System.Windows.Forms.ToolStripMenuItem
		Me.m_einstellungen = New System.Windows.Forms.ToolStripMenuItem
		Me.m_colors = New System.Windows.Forms.ToolStripMenuItem
		Me.m_hilfe = New System.Windows.Forms.ToolStripMenuItem
		Me.m_info = New System.Windows.Forms.ToolStripMenuItem
		Me.bt_diashow = New System.Windows.Forms.Button
		Me.bt_zip = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.BT_bearbeiten = New System.Windows.Forms.Button
		Me.MainMenu1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Der Biedermann"
		Me.ClientSize = New System.Drawing.Size(306, 249)
		Me.Location = New System.Drawing.Point(10, 48)
		Me.Icon = CType(resources.GetObject("Hauptform.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "Hauptform"
		Me.m_datei.Name = "m_datei"
		Me.m_datei.Text = "&Datei"
		Me.m_datei.Checked = False
		Me.m_datei.Enabled = True
		Me.m_datei.Visible = True
		Me.m_ende.Name = "m_ende"
		Me.m_ende.Text = "&Ende"
		Me.m_ende.Checked = False
		Me.m_ende.Enabled = True
		Me.m_ende.Visible = True
		Me.m_daten.Name = "m_daten"
		Me.m_daten.Text = "D&aten"
		Me.m_daten.Checked = False
		Me.m_daten.Enabled = True
		Me.m_daten.Visible = True
		Me.m_delete_group.Name = "m_delete_group"
		Me.m_delete_group.Text = "&Gruppe löschen"
		Me.m_delete_group.Checked = False
		Me.m_delete_group.Enabled = True
		Me.m_delete_group.Visible = True
		Me.m_SortGroups.Name = "m_SortGroups"
		Me.m_SortGroups.Text = "Gruppen &sortieren"
		Me.m_SortGroups.Checked = False
		Me.m_SortGroups.Enabled = True
		Me.m_SortGroups.Visible = True
		Me.m_rename_group.Name = "m_rename_group"
		Me.m_rename_group.Text = "Gruppe &umbenennen"
		Me.m_rename_group.Checked = False
		Me.m_rename_group.Enabled = True
		Me.m_rename_group.Visible = True
		Me.m_edit_gruppentexte.Name = "m_edit_gruppentexte"
		Me.m_edit_gruppentexte.Text = "Gruppen&texte erfassen"
		Me.m_edit_gruppentexte.Checked = False
		Me.m_edit_gruppentexte.Enabled = True
		Me.m_edit_gruppentexte.Visible = True
		Me.m_bar.Name = "m_bar"
		Me.m_bar.Text = "----------------------------"
		Me.m_bar.Enabled = False
		Me.m_bar.Checked = False
		Me.m_bar.Visible = True
		Me.m_clean4web.Name = "m_clean4web"
		Me.m_clean4web.Text = "&Für WEB  bereiningen"
		Me.m_clean4web.Checked = False
		Me.m_clean4web.Enabled = True
		Me.m_clean4web.Visible = True
		Me.m_doppelte.Name = "m_doppelte"
		Me.m_doppelte.Text = "&Doppelte Daten zusammenfassen"
		Me.m_doppelte.Checked = False
		Me.m_doppelte.Enabled = True
		Me.m_doppelte.Visible = True
		Me.m_bar2.Name = "m_bar2"
		Me.m_bar2.Text = "----------------------------"
		Me.m_bar2.Checked = False
		Me.m_bar2.Enabled = True
		Me.m_bar2.Visible = True
		Me.m_optionen.Name = "m_optionen"
		Me.m_optionen.Text = "&Optionen"
		Me.m_optionen.Checked = False
		Me.m_optionen.Enabled = True
		Me.m_optionen.Visible = True
		Me.m_einstellungen.Name = "m_einstellungen"
		Me.m_einstellungen.Text = "&Einstellungen"
		Me.m_einstellungen.Checked = False
		Me.m_einstellungen.Enabled = True
		Me.m_einstellungen.Visible = True
		Me.m_colors.Name = "m_colors"
		Me.m_colors.Text = "&Internet Farben"
		Me.m_colors.Checked = False
		Me.m_colors.Enabled = True
		Me.m_colors.Visible = True
		Me.m_hilfe.Name = "m_hilfe"
		Me.m_hilfe.Text = "&?"
		Me.m_hilfe.Checked = False
		Me.m_hilfe.Enabled = True
		Me.m_hilfe.Visible = True
		Me.m_info.Name = "m_info"
		Me.m_info.Text = "&Info über BIEDERDB"
		Me.m_info.Checked = False
		Me.m_info.Enabled = True
		Me.m_info.Visible = True
		Me.bt_diashow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.bt_diashow.Text = "DiaShow"
		Me.bt_diashow.Size = New System.Drawing.Size(305, 57)
		Me.bt_diashow.Location = New System.Drawing.Point(0, 80)
		Me.bt_diashow.Image = CType(resources.GetObject("bt_diashow.Image"), System.Drawing.Image)
		Me.bt_diashow.TabIndex = 3
		Me.bt_diashow.BackColor = System.Drawing.SystemColors.Control
		Me.bt_diashow.CausesValidation = True
		Me.bt_diashow.Enabled = True
		Me.bt_diashow.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_diashow.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_diashow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_diashow.TabStop = True
		Me.bt_diashow.Name = "bt_diashow"
		Me.bt_zip.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.bt_zip.Text = "Backup/Restore ZIP"
		Me.bt_zip.Size = New System.Drawing.Size(305, 57)
		Me.bt_zip.Location = New System.Drawing.Point(0, 192)
		Me.bt_zip.Image = CType(resources.GetObject("bt_zip.Image"), System.Drawing.Image)
		Me.bt_zip.TabIndex = 2
		Me.ToolTip1.SetToolTip(Me.bt_zip, "Hier klicken, um die Daten als Webseiten zu publizieren")
		Me.bt_zip.BackColor = System.Drawing.SystemColors.Control
		Me.bt_zip.CausesValidation = True
		Me.bt_zip.Enabled = True
		Me.bt_zip.ForeColor = System.Drawing.SystemColors.ControlText
		Me.bt_zip.Cursor = System.Windows.Forms.Cursors.Default
		Me.bt_zip.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.bt_zip.TabStop = True
		Me.bt_zip.Name = "bt_zip"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.Command1.Text = "Daten für Web publizieren"
		Me.Command1.Size = New System.Drawing.Size(305, 57)
		Me.Command1.Location = New System.Drawing.Point(0, 136)
		Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
		Me.Command1.TabIndex = 1
		Me.ToolTip1.SetToolTip(Me.Command1, "Hier klicken, um die Daten als Webseiten zu publizieren")
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.BT_bearbeiten.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.BT_bearbeiten.Text = "Daten bearbeiten"
		Me.BT_bearbeiten.Size = New System.Drawing.Size(305, 57)
		Me.BT_bearbeiten.Location = New System.Drawing.Point(0, 24)
		Me.BT_bearbeiten.Image = CType(resources.GetObject("BT_bearbeiten.Image"), System.Drawing.Image)
		Me.BT_bearbeiten.TabIndex = 0
		Me.ToolTip1.SetToolTip(Me.BT_bearbeiten, "Hierüber können die Daten bearbeitet werden")
		Me.BT_bearbeiten.BackColor = System.Drawing.SystemColors.Control
		Me.BT_bearbeiten.CausesValidation = True
		Me.BT_bearbeiten.Enabled = True
		Me.BT_bearbeiten.ForeColor = System.Drawing.SystemColors.ControlText
		Me.BT_bearbeiten.Cursor = System.Windows.Forms.Cursors.Default
		Me.BT_bearbeiten.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.BT_bearbeiten.TabStop = True
		Me.BT_bearbeiten.Name = "BT_bearbeiten"
		Me.Controls.Add(bt_diashow)
		Me.Controls.Add(bt_zip)
		Me.Controls.Add(Command1)
		Me.Controls.Add(BT_bearbeiten)
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.m_datei, Me.m_daten, Me.m_optionen, Me.m_hilfe})
		m_datei.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.m_ende})
		m_daten.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.m_delete_group, Me.m_SortGroups, Me.m_rename_group, Me.m_edit_gruppentexte, Me.m_bar, Me.m_clean4web, Me.m_doppelte, Me.m_bar2})
		m_optionen.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.m_einstellungen, Me.m_colors})
		m_hilfe.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.m_info})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class