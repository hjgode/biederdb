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
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.bt_savelist = New System.Windows.Forms.Button
        Me.bt_ab = New System.Windows.Forms.Button
        Me.bt_auf = New System.Windows.Forms.Button
        Me.chk_nur1Gruppe = New System.Windows.Forms.CheckBox
        Me.bt_cancel = New System.Windows.Forms.Button
        Me.Text3 = New System.Windows.Forms.TextBox
        Me.Text2 = New System.Windows.Forms.TextBox
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.List2 = New System.Windows.Forms.ListBox
        Me.List1 = New System.Windows.Forms.ListBox
        Me.bt_close = New System.Windows.Forms.Button
        Me.bt_start = New System.Windows.Forms.Button
        Me.bt_AktuellBearbeiten = New System.Windows.Forms.Button
        Me.bt_view = New System.Windows.Forms.Button
        Me.txt_StartSeite = New System.Windows.Forms.TextBox
        Me.File1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.filesList = New System.Windows.Forms.ListBox
        Me.weblist = New System.Windows.Forms.ListBox
        Me.chk_cleanwebdir = New System.Windows.Forms.CheckBox
        Me.txt_status = New System.Windows.Forms.TextBox
        Me.bt_copy = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'bt_savelist
        '
        Me.bt_savelist.BackColor = System.Drawing.SystemColors.Control
        Me.bt_savelist.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_savelist.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_savelist.Location = New System.Drawing.Point(216, 112)
        Me.bt_savelist.Name = "bt_savelist"
        Me.bt_savelist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_savelist.Size = New System.Drawing.Size(121, 17)
        Me.bt_savelist.TabIndex = 18
        Me.bt_savelist.Text = "Liste speichern"
        Me.ToolTip1.SetToolTip(Me.bt_savelist, "Aktuelle Liste speichern")
        Me.bt_savelist.UseVisualStyleBackColor = False
        '
        'bt_ab
        '
        Me.bt_ab.BackColor = System.Drawing.SystemColors.Control
        Me.bt_ab.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_ab.Font = New System.Drawing.Font("Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.bt_ab.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_ab.Location = New System.Drawing.Point(344, 64)
        Me.bt_ab.Name = "bt_ab"
        Me.bt_ab.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_ab.Size = New System.Drawing.Size(25, 25)
        Me.bt_ab.TabIndex = 17
        Me.bt_ab.Text = "¯"
        Me.ToolTip1.SetToolTip(Me.bt_ab, "Eintrag nach unten schieben")
        Me.bt_ab.UseVisualStyleBackColor = False
        '
        'bt_auf
        '
        Me.bt_auf.BackColor = System.Drawing.SystemColors.Control
        Me.bt_auf.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_auf.Font = New System.Drawing.Font("Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.bt_auf.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_auf.Location = New System.Drawing.Point(344, 40)
        Me.bt_auf.Name = "bt_auf"
        Me.bt_auf.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_auf.Size = New System.Drawing.Size(25, 25)
        Me.bt_auf.TabIndex = 16
        Me.bt_auf.Text = "­"
        Me.ToolTip1.SetToolTip(Me.bt_auf, "Eintrag nach oben schieben")
        Me.bt_auf.UseVisualStyleBackColor = False
        '
        'chk_nur1Gruppe
        '
        Me.chk_nur1Gruppe.BackColor = System.Drawing.SystemColors.Control
        Me.chk_nur1Gruppe.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_nur1Gruppe.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_nur1Gruppe.Location = New System.Drawing.Point(216, 136)
        Me.chk_nur1Gruppe.Name = "chk_nur1Gruppe"
        Me.chk_nur1Gruppe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk_nur1Gruppe.Size = New System.Drawing.Size(241, 17)
        Me.chk_nur1Gruppe.TabIndex = 15
        Me.chk_nur1Gruppe.Text = "Nur die eine gewählte Gruppe neu erstellen"
        Me.ToolTip1.SetToolTip(Me.chk_nur1Gruppe, "Hiermit wird nur die gewählte Gruppe neu erstellt. Alle anderen Dateien werden ni" & _
                "cht aktualisiert.")
        Me.chk_nur1Gruppe.UseVisualStyleBackColor = False
        '
        'bt_cancel
        '
        Me.bt_cancel.BackColor = System.Drawing.SystemColors.Control
        Me.bt_cancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_cancel.Enabled = False
        Me.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_cancel.Location = New System.Drawing.Point(416, 72)
        Me.bt_cancel.Name = "bt_cancel"
        Me.bt_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_cancel.Size = New System.Drawing.Size(65, 25)
        Me.bt_cancel.TabIndex = 13
        Me.bt_cancel.Text = "Abbrechen"
        Me.ToolTip1.SetToolTip(Me.bt_cancel, "Abbrechen der Weberstellung")
        Me.bt_cancel.UseVisualStyleBackColor = False
        '
        'Text3
        '
        Me.Text3.AcceptsReturn = True
        Me.Text3.BackColor = System.Drawing.SystemColors.Window
        Me.Text3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text3.Enabled = False
        Me.Text3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text3.Location = New System.Drawing.Point(8, 216)
        Me.Text3.MaxLength = 0
        Me.Text3.Name = "Text3"
        Me.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text3.Size = New System.Drawing.Size(209, 19)
        Me.Text3.TabIndex = 12
        Me.Text3.Text = "Text3"
        Me.ToolTip1.SetToolTip(Me.Text3, "Dieses Verzeichnis wird über Optionen-Einstellungen festgelegt")
        '
        'Text2
        '
        Me.Text2.AcceptsReturn = True
        Me.Text2.BackColor = System.Drawing.SystemColors.Window
        Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text2.Location = New System.Drawing.Point(8, 256)
        Me.Text2.MaxLength = 0
        Me.Text2.Name = "Text2"
        Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text2.Size = New System.Drawing.Size(209, 19)
        Me.Text2.TabIndex = 10
        Me.Text2.Text = "Text2"
        Me.ToolTip1.SetToolTip(Me.Text2, "Dieses Verzeichnis wird über Optionen-Einstellungen festgelegt")
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Enabled = False
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(8, 176)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(209, 19)
        Me.Text1.TabIndex = 8
        Me.Text1.Text = "Text1"
        Me.ToolTip1.SetToolTip(Me.Text1, "Diese Datei wird über Optionen-Einstellungen festgelegt")
        '
        'List2
        '
        Me.List2.BackColor = System.Drawing.SystemColors.Window
        Me.List2.Cursor = System.Windows.Forms.Cursors.Default
        Me.List2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List2.Location = New System.Drawing.Point(216, 24)
        Me.List2.Name = "List2"
        Me.List2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List2.Size = New System.Drawing.Size(121, 82)
        Me.List2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.List2, "Doppelklicken zu Entfernen")
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.Location = New System.Drawing.Point(8, 24)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.List1.Size = New System.Drawing.Size(121, 82)
        Me.List1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.List1, "Doppleklicken zum Übernehmen")
        '
        'bt_close
        '
        Me.bt_close.BackColor = System.Drawing.SystemColors.Control
        Me.bt_close.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_close.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_close.Location = New System.Drawing.Point(416, 40)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_close.Size = New System.Drawing.Size(65, 25)
        Me.bt_close.TabIndex = 1
        Me.bt_close.Text = "Schliessen"
        Me.ToolTip1.SetToolTip(Me.bt_close, "Fenster schliessen")
        Me.bt_close.UseVisualStyleBackColor = False
        '
        'bt_start
        '
        Me.bt_start.BackColor = System.Drawing.SystemColors.Control
        Me.bt_start.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_start.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_start.Location = New System.Drawing.Point(416, 8)
        Me.bt_start.Name = "bt_start"
        Me.bt_start.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_start.Size = New System.Drawing.Size(65, 25)
        Me.bt_start.TabIndex = 0
        Me.bt_start.Text = "Start"
        Me.ToolTip1.SetToolTip(Me.bt_start, "Starten der Erstellung der Webseiten")
        Me.bt_start.UseVisualStyleBackColor = False
        '
        'bt_AktuellBearbeiten
        '
        Me.bt_AktuellBearbeiten.BackColor = System.Drawing.SystemColors.Control
        Me.bt_AktuellBearbeiten.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_AktuellBearbeiten.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_AktuellBearbeiten.Location = New System.Drawing.Point(376, 216)
        Me.bt_AktuellBearbeiten.Name = "bt_AktuellBearbeiten"
        Me.bt_AktuellBearbeiten.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_AktuellBearbeiten.Size = New System.Drawing.Size(105, 25)
        Me.bt_AktuellBearbeiten.TabIndex = 26
        Me.bt_AktuellBearbeiten.Text = "Aktuell bearbeiten"
        Me.bt_AktuellBearbeiten.UseVisualStyleBackColor = False
        '
        'bt_view
        '
        Me.bt_view.BackColor = System.Drawing.SystemColors.Control
        Me.bt_view.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_view.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_view.Location = New System.Drawing.Point(416, 104)
        Me.bt_view.Name = "bt_view"
        Me.bt_view.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_view.Size = New System.Drawing.Size(65, 25)
        Me.bt_view.TabIndex = 25
        Me.bt_view.Text = "Anzeigen"
        Me.bt_view.UseVisualStyleBackColor = False
        '
        'txt_StartSeite
        '
        Me.txt_StartSeite.AcceptsReturn = True
        Me.txt_StartSeite.BackColor = System.Drawing.SystemColors.Window
        Me.txt_StartSeite.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_StartSeite.Enabled = False
        Me.txt_StartSeite.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_StartSeite.Location = New System.Drawing.Point(288, 216)
        Me.txt_StartSeite.MaxLength = 0
        Me.txt_StartSeite.Name = "txt_StartSeite"
        Me.txt_StartSeite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_StartSeite.Size = New System.Drawing.Size(81, 19)
        Me.txt_StartSeite.TabIndex = 24
        Me.txt_StartSeite.Text = "Text4"
        '
        'File1
        '
        Me.File1.BackColor = System.Drawing.SystemColors.Window
        Me.File1.Cursor = System.Windows.Forms.Cursors.Default
        Me.File1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.File1.FormattingEnabled = True
        Me.File1.Location = New System.Drawing.Point(8, 304)
        Me.File1.Name = "File1"
        Me.File1.Pattern = "*.*"
        Me.File1.Size = New System.Drawing.Size(113, 56)
        Me.File1.TabIndex = 22
        Me.File1.Visible = False
        '
        'filesList
        '
        Me.filesList.BackColor = System.Drawing.SystemColors.Window
        Me.filesList.Cursor = System.Windows.Forms.Cursors.Default
        Me.filesList.Enabled = False
        Me.filesList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.filesList.Location = New System.Drawing.Point(352, 304)
        Me.filesList.Name = "filesList"
        Me.filesList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.filesList.Size = New System.Drawing.Size(129, 56)
        Me.filesList.Sorted = True
        Me.filesList.TabIndex = 21
        '
        'weblist
        '
        Me.weblist.BackColor = System.Drawing.SystemColors.Window
        Me.weblist.Cursor = System.Windows.Forms.Cursors.Default
        Me.weblist.Enabled = False
        Me.weblist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.weblist.Location = New System.Drawing.Point(216, 304)
        Me.weblist.Name = "weblist"
        Me.weblist.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.weblist.Size = New System.Drawing.Size(129, 56)
        Me.weblist.Sorted = True
        Me.weblist.TabIndex = 20
        '
        'chk_cleanwebdir
        '
        Me.chk_cleanwebdir.BackColor = System.Drawing.SystemColors.Control
        Me.chk_cleanwebdir.Cursor = System.Windows.Forms.Cursors.Default
        Me.chk_cleanwebdir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chk_cleanwebdir.Location = New System.Drawing.Point(224, 256)
        Me.chk_cleanwebdir.Name = "chk_cleanwebdir"
        Me.chk_cleanwebdir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chk_cleanwebdir.Size = New System.Drawing.Size(193, 17)
        Me.chk_cleanwebdir.TabIndex = 19
        Me.chk_cleanwebdir.Text = "Webverzeichnis bereinigen"
        Me.chk_cleanwebdir.UseVisualStyleBackColor = False
        '
        'txt_status
        '
        Me.txt_status.AcceptsReturn = True
        Me.txt_status.BackColor = System.Drawing.SystemColors.Window
        Me.txt_status.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_status.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_status.Location = New System.Drawing.Point(8, 280)
        Me.txt_status.MaxLength = 0
        Me.txt_status.Name = "txt_status"
        Me.txt_status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_status.Size = New System.Drawing.Size(473, 19)
        Me.txt_status.TabIndex = 14
        Me.txt_status.Text = "txt_status"
        '
        'bt_copy
        '
        Me.bt_copy.BackColor = System.Drawing.SystemColors.Control
        Me.bt_copy.Cursor = System.Windows.Forms.Cursors.Default
        Me.bt_copy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bt_copy.Location = New System.Drawing.Point(136, 56)
        Me.bt_copy.Name = "bt_copy"
        Me.bt_copy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bt_copy.Size = New System.Drawing.Size(73, 25)
        Me.bt_copy.TabIndex = 5
        Me.bt_copy.Text = "Übernehmen"
        Me.bt_copy.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(224, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Hauptseite:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(145, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "3. Startseite festlegen:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(161, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "4. Web-Stammverzeichnis:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "2. Kopfbereichsdatei(html):"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(208, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(137, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Übernommene Kategorien:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(145, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "1. Kategorien auswählen:"
        '
        'db2web
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(484, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_AktuellBearbeiten)
        Me.Controls.Add(Me.bt_view)
        Me.Controls.Add(Me.txt_StartSeite)
        Me.Controls.Add(Me.File1)
        Me.Controls.Add(Me.filesList)
        Me.Controls.Add(Me.weblist)
        Me.Controls.Add(Me.chk_cleanwebdir)
        Me.Controls.Add(Me.bt_savelist)
        Me.Controls.Add(Me.bt_ab)
        Me.Controls.Add(Me.bt_auf)
        Me.Controls.Add(Me.chk_nur1Gruppe)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.bt_cancel)
        Me.Controls.Add(Me.Text3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.bt_copy)
        Me.Controls.Add(Me.List2)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.bt_start)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(14, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "db2web"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Daten für Web aufbereiten"
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class