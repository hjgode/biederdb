namespace BiederDB3
{
    partial class FormPublishForWeb
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bt_AktuellBearbeiten = new System.Windows.Forms.Button();
            this.bt_view = new System.Windows.Forms.Button();
            this.txt_StartSeite = new System.Windows.Forms.TextBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bt_savelist = new System.Windows.Forms.Button();
            this.bt_ab = new System.Windows.Forms.Button();
            this.bt_auf = new System.Windows.Forms.Button();
            this.chk_nur1Gruppe = new System.Windows.Forms.CheckBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.List1 = new System.Windows.Forms.ListBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.ListBox();
            this.weblist = new System.Windows.Forms.ListBox();
            this.chk_cleanwebdir = new System.Windows.Forms.CheckBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.bt_copy = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.File1 = new BiederDB3.FileListBox();
            this.SuspendLayout();
            // 
            // bt_AktuellBearbeiten
            // 
            this.bt_AktuellBearbeiten.BackColor = System.Drawing.SystemColors.Control;
            this.bt_AktuellBearbeiten.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_AktuellBearbeiten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_AktuellBearbeiten.Location = new System.Drawing.Point(380, 219);
            this.bt_AktuellBearbeiten.Name = "bt_AktuellBearbeiten";
            this.bt_AktuellBearbeiten.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_AktuellBearbeiten.Size = new System.Drawing.Size(105, 25);
            this.bt_AktuellBearbeiten.TabIndex = 52;
            this.bt_AktuellBearbeiten.Text = "Aktuell bearbeiten";
            this.bt_AktuellBearbeiten.UseVisualStyleBackColor = false;
            // 
            // bt_view
            // 
            this.bt_view.BackColor = System.Drawing.SystemColors.Control;
            this.bt_view.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_view.Location = new System.Drawing.Point(401, 107);
            this.bt_view.Name = "bt_view";
            this.bt_view.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_view.Size = new System.Drawing.Size(84, 25);
            this.bt_view.TabIndex = 51;
            this.bt_view.Text = "Anzeigen";
            this.bt_view.UseVisualStyleBackColor = false;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // txt_StartSeite
            // 
            this.txt_StartSeite.AcceptsReturn = true;
            this.txt_StartSeite.BackColor = System.Drawing.SystemColors.Window;
            this.txt_StartSeite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_StartSeite.Enabled = false;
            this.txt_StartSeite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_StartSeite.Location = new System.Drawing.Point(292, 219);
            this.txt_StartSeite.MaxLength = 0;
            this.txt_StartSeite.Name = "txt_StartSeite";
            this.txt_StartSeite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_StartSeite.Size = new System.Drawing.Size(81, 20);
            this.txt_StartSeite.TabIndex = 50;
            this.txt_StartSeite.Text = "Text4";
            // 
            // bt_savelist
            // 
            this.bt_savelist.BackColor = System.Drawing.SystemColors.Control;
            this.bt_savelist.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_savelist.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_savelist.Location = new System.Drawing.Point(220, 115);
            this.bt_savelist.Name = "bt_savelist";
            this.bt_savelist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_savelist.Size = new System.Drawing.Size(121, 27);
            this.bt_savelist.TabIndex = 45;
            this.bt_savelist.Text = "Liste speichern";
            this.ToolTip1.SetToolTip(this.bt_savelist, "Aktuelle Liste speichern");
            this.bt_savelist.UseVisualStyleBackColor = false;
            this.bt_savelist.Click += new System.EventHandler(this.bt_savelist_Click);
            // 
            // bt_ab
            // 
            this.bt_ab.BackColor = System.Drawing.SystemColors.Control;
            this.bt_ab.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_ab.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bt_ab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ab.Location = new System.Drawing.Point(348, 67);
            this.bt_ab.Name = "bt_ab";
            this.bt_ab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_ab.Size = new System.Drawing.Size(25, 25);
            this.bt_ab.TabIndex = 44;
            this.bt_ab.Text = "¯";
            this.ToolTip1.SetToolTip(this.bt_ab, "Eintrag nach unten schieben");
            this.bt_ab.UseVisualStyleBackColor = false;
            this.bt_ab.Click += new System.EventHandler(this.bt_ab_Click);
            // 
            // bt_auf
            // 
            this.bt_auf.BackColor = System.Drawing.SystemColors.Control;
            this.bt_auf.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_auf.Font = new System.Drawing.Font("Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bt_auf.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_auf.Location = new System.Drawing.Point(348, 43);
            this.bt_auf.Name = "bt_auf";
            this.bt_auf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_auf.Size = new System.Drawing.Size(25, 25);
            this.bt_auf.TabIndex = 43;
            this.bt_auf.Text = "­";
            this.ToolTip1.SetToolTip(this.bt_auf, "Eintrag nach oben schieben");
            this.bt_auf.UseVisualStyleBackColor = false;
            this.bt_auf.Click += new System.EventHandler(this.bt_auf_Click);
            // 
            // chk_nur1Gruppe
            // 
            this.chk_nur1Gruppe.BackColor = System.Drawing.SystemColors.Control;
            this.chk_nur1Gruppe.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk_nur1Gruppe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_nur1Gruppe.Location = new System.Drawing.Point(220, 148);
            this.chk_nur1Gruppe.Name = "chk_nur1Gruppe";
            this.chk_nur1Gruppe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_nur1Gruppe.Size = new System.Drawing.Size(241, 17);
            this.chk_nur1Gruppe.TabIndex = 42;
            this.chk_nur1Gruppe.Text = "Nur die eine gewählte Gruppe neu erstellen";
            this.ToolTip1.SetToolTip(this.chk_nur1Gruppe, "Hiermit wird nur die gewählte Gruppe neu erstellt. Alle anderen Dateien werden ni" +
                    "cht aktualisiert.");
            this.chk_nur1Gruppe.UseVisualStyleBackColor = false;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_cancel.Enabled = false;
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.Location = new System.Drawing.Point(401, 75);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_cancel.Size = new System.Drawing.Size(84, 25);
            this.bt_cancel.TabIndex = 40;
            this.bt_cancel.Text = "Abbrechen";
            this.ToolTip1.SetToolTip(this.bt_cancel, "Abbrechen der Weberstellung");
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // Text3
            // 
            this.Text3.AcceptsReturn = true;
            this.Text3.BackColor = System.Drawing.SystemColors.Window;
            this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text3.Enabled = false;
            this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text3.Location = new System.Drawing.Point(12, 219);
            this.Text3.MaxLength = 0;
            this.Text3.Name = "Text3";
            this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text3.Size = new System.Drawing.Size(209, 20);
            this.Text3.TabIndex = 39;
            this.Text3.Text = "Text3";
            this.ToolTip1.SetToolTip(this.Text3, "Dieses Verzeichnis wird über Optionen-Einstellungen festgelegt");
            // 
            // Text2
            // 
            this.Text2.AcceptsReturn = true;
            this.Text2.BackColor = System.Drawing.SystemColors.Window;
            this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text2.Location = new System.Drawing.Point(12, 259);
            this.Text2.MaxLength = 0;
            this.Text2.Name = "Text2";
            this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text2.Size = new System.Drawing.Size(209, 20);
            this.Text2.TabIndex = 37;
            this.Text2.Text = "Text2";
            this.ToolTip1.SetToolTip(this.Text2, "Dieses Verzeichnis wird über Optionen-Einstellungen festgelegt");
            // 
            // Text1
            // 
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = System.Drawing.SystemColors.Window;
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.Enabled = false;
            this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text1.Location = new System.Drawing.Point(12, 179);
            this.Text1.MaxLength = 0;
            this.Text1.Name = "Text1";
            this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text1.Size = new System.Drawing.Size(209, 20);
            this.Text1.TabIndex = 35;
            this.Text1.Text = "Text1";
            this.ToolTip1.SetToolTip(this.Text1, "Diese Datei wird über Optionen-Einstellungen festgelegt");
            // 
            // List2
            // 
            this.List2.BackColor = System.Drawing.SystemColors.Window;
            this.List2.Cursor = System.Windows.Forms.Cursors.Default;
            this.List2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.List2.Location = new System.Drawing.Point(220, 27);
            this.List2.Name = "List2";
            this.List2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.List2.Size = new System.Drawing.Size(121, 82);
            this.List2.TabIndex = 31;
            this.ToolTip1.SetToolTip(this.List2, "Doppelklicken zu Entfernen");
            this.List2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List2_MouseDoubleClick);
            // 
            // List1
            // 
            this.List1.BackColor = System.Drawing.SystemColors.Window;
            this.List1.Cursor = System.Windows.Forms.Cursors.Default;
            this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.List1.Location = new System.Drawing.Point(12, 27);
            this.List1.Name = "List1";
            this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.List1.Size = new System.Drawing.Size(121, 82);
            this.List1.TabIndex = 29;
            this.ToolTip1.SetToolTip(this.List1, "Doppleklicken zum Übernehmen");
            this.List1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List1_MouseDoubleClick);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.Control;
            this.bt_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_close.Location = new System.Drawing.Point(401, 43);
            this.bt_close.Name = "bt_close";
            this.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_close.Size = new System.Drawing.Size(84, 25);
            this.bt_close.TabIndex = 28;
            this.bt_close.Text = "Schliessen";
            this.ToolTip1.SetToolTip(this.bt_close, "Fenster schliessen");
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_start
            // 
            this.bt_start.BackColor = System.Drawing.SystemColors.Control;
            this.bt_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_start.Location = new System.Drawing.Point(401, 11);
            this.bt_start.Name = "bt_start";
            this.bt_start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_start.Size = new System.Drawing.Size(84, 25);
            this.bt_start.TabIndex = 27;
            this.bt_start.Text = "Start";
            this.ToolTip1.SetToolTip(this.bt_start, "Starten der Erstellung der Webseiten");
            this.bt_start.UseVisualStyleBackColor = false;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // filesList
            // 
            this.filesList.BackColor = System.Drawing.SystemColors.Window;
            this.filesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.filesList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.filesList.Location = new System.Drawing.Point(356, 329);
            this.filesList.Name = "filesList";
            this.filesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.filesList.Size = new System.Drawing.Size(129, 56);
            this.filesList.Sorted = true;
            this.filesList.TabIndex = 48;
            // 
            // weblist
            // 
            this.weblist.BackColor = System.Drawing.SystemColors.Window;
            this.weblist.Cursor = System.Windows.Forms.Cursors.Default;
            this.weblist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.weblist.Location = new System.Drawing.Point(220, 329);
            this.weblist.Name = "weblist";
            this.weblist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.weblist.Size = new System.Drawing.Size(129, 56);
            this.weblist.Sorted = true;
            this.weblist.TabIndex = 47;
            // 
            // chk_cleanwebdir
            // 
            this.chk_cleanwebdir.BackColor = System.Drawing.SystemColors.Control;
            this.chk_cleanwebdir.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk_cleanwebdir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_cleanwebdir.Location = new System.Drawing.Point(228, 259);
            this.chk_cleanwebdir.Name = "chk_cleanwebdir";
            this.chk_cleanwebdir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_cleanwebdir.Size = new System.Drawing.Size(193, 17);
            this.chk_cleanwebdir.TabIndex = 46;
            this.chk_cleanwebdir.Text = "Webverzeichnis bereinigen";
            this.chk_cleanwebdir.UseVisualStyleBackColor = false;
            // 
            // txt_status
            // 
            this.txt_status.AcceptsReturn = true;
            this.txt_status.BackColor = System.Drawing.SystemColors.Window;
            this.txt_status.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_status.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_status.Location = new System.Drawing.Point(12, 283);
            this.txt_status.MaxLength = 0;
            this.txt_status.Name = "txt_status";
            this.txt_status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_status.Size = new System.Drawing.Size(473, 20);
            this.txt_status.TabIndex = 41;
            this.txt_status.Text = "txt_status";
            // 
            // bt_copy
            // 
            this.bt_copy.BackColor = System.Drawing.SystemColors.Control;
            this.bt_copy.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_copy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_copy.Location = new System.Drawing.Point(136, 59);
            this.bt_copy.Name = "bt_copy";
            this.bt_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_copy.Size = new System.Drawing.Size(81, 25);
            this.bt_copy.TabIndex = 32;
            this.bt_copy.Text = "Übernehmen";
            this.bt_copy.UseVisualStyleBackColor = false;
            this.bt_copy.Click += new System.EventHandler(this.bt_copy_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(228, 219);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(65, 17);
            this.Label6.TabIndex = 49;
            this.Label6.Text = "Hauptseite:";
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(12, 203);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(145, 17);
            this.Label5.TabIndex = 38;
            this.Label5.Text = "3. Startseite festlegen:";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(12, 243);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(161, 17);
            this.Label4.TabIndex = 36;
            this.Label4.Text = "4. Web-Stammverzeichnis:";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(12, 163);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(129, 17);
            this.Label3.TabIndex = 34;
            this.Label3.Text = "2. Kopfbereichsdatei(html):";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(212, 11);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(137, 17);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "Übernommene Kategorien:";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(12, 11);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(145, 17);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "1. Kategorien auswählen:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(12, 309);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Verzeichnis:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(220, 309);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Für Internet:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(355, 309);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(121, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Überflüssig:";
            // 
            // File1
            // 
            this.File1._sPath = "C:\\Program Files (x86)\\Microsoft Visual Studio 9.0\\Common7\\IDE\\";
            this.File1.Location = new System.Drawing.Point(12, 329);
            this.File1.Name = "File1";
            this.File1.Size = new System.Drawing.Size(121, 56);
            this.File1.TabIndex = 53;
            // 
            // FormPublishForWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 397);
            this.ControlBox = false;
            this.Controls.Add(this.File1);
            this.Controls.Add(this.bt_AktuellBearbeiten);
            this.Controls.Add(this.bt_view);
            this.Controls.Add(this.txt_StartSeite);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.weblist);
            this.Controls.Add(this.chk_cleanwebdir);
            this.Controls.Add(this.bt_savelist);
            this.Controls.Add(this.bt_ab);
            this.Controls.Add(this.bt_auf);
            this.Controls.Add(this.chk_nur1Gruppe);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.bt_copy);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPublishForWeb";
            this.Text = "FormPublishForWeb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bt_AktuellBearbeiten;
        public System.Windows.Forms.Button bt_view;
        public System.Windows.Forms.TextBox txt_StartSeite;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button bt_savelist;
        public System.Windows.Forms.Button bt_ab;
        public System.Windows.Forms.Button bt_auf;
        public System.Windows.Forms.CheckBox chk_nur1Gruppe;
        public System.Windows.Forms.Button bt_cancel;
        public System.Windows.Forms.TextBox Text3;
        public System.Windows.Forms.TextBox Text2;
        public System.Windows.Forms.TextBox Text1;
        /// <summary>
        /// List2 enthält die zu publizierenden Kategorien
        /// </summary>
        public System.Windows.Forms.ListBox List2;
        public System.Windows.Forms.ListBox List1;
        public System.Windows.Forms.Button bt_close;
        public System.Windows.Forms.Button bt_start;
        public System.Windows.Forms.ListBox filesList;
        public System.Windows.Forms.ListBox weblist;
        public System.Windows.Forms.CheckBox chk_cleanwebdir;
        public System.Windows.Forms.TextBox txt_status;
        public System.Windows.Forms.Button bt_copy;
        public System.Windows.Forms.Label Label6;
        public System.Windows.Forms.Label Label5;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.Label Label1;
        private FileListBox File1;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
    }
}