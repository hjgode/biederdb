namespace BiederZip3
{
    partial class FormZIP
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
            this.txtFile = new System.Windows.Forms.TextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.ListBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_zipfilename = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.opt_onlynewer = new System.Windows.Forms.CheckBox();
            this.bt_suchdir = new System.Windows.Forms.Button();
            this.bt_change = new System.Windows.Forms.Button();
            this.lblFiles = new System.Windows.Forms.Label();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.opt_overwrite = new System.Windows.Forms.CheckBox();
            this.txtExtractTo = new System.Windows.Forms.TextBox();
            this.bt_targetdir = new System.Windows.Forms.Button();
            this.bt_ZipFileRestore = new System.Windows.Forms.Button();
            this.bt_restore = new System.Windows.Forms.Button();
            this.txtRestoreFile = new System.Windows.Forms.TextBox();
            this.txtBackupfile = new System.Windows.Forms.TextBox();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_zip_start = new System.Windows.Forms.Button();
            this.bt_autofill = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.bt_TEST = new System.Windows.Forms.Button();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.AcceptsReturn = true;
            this.txtFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFile.Location = new System.Drawing.Point(9, 16);
            this.txtFile.MaxLength = 0;
            this.txtFile.Name = "txtFile";
            this.txtFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFile.Size = new System.Drawing.Size(343, 20);
            this.txtFile.TabIndex = 4;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.SystemColors.Control;
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_add.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_add.Location = new System.Drawing.Point(135, 42);
            this.bt_add.Name = "bt_add";
            this.bt_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_add.Size = new System.Drawing.Size(73, 27);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "&Hinzufügen";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // List1
            // 
            this.List1.BackColor = System.Drawing.SystemColors.Window;
            this.List1.Cursor = System.Windows.Forms.Cursors.Default;
            this.List1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.List1.ItemHeight = 14;
            this.List1.Location = new System.Drawing.Point(9, 75);
            this.List1.Name = "List1";
            this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.List1.Size = new System.Drawing.Size(343, 116);
            this.List1.TabIndex = 6;
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.SystemColors.Control;
            this.bt_back.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_back.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_back.Location = new System.Drawing.Point(383, 383);
            this.bt_back.Name = "bt_back";
            this.bt_back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_back.Size = new System.Drawing.Size(129, 36);
            this.bt_back.TabIndex = 25;
            this.bt_back.Text = "&Zurück zu BiederDB";
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_zipfilename
            // 
            this.bt_zipfilename.BackColor = System.Drawing.SystemColors.Control;
            this.bt_zipfilename.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_zipfilename.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_zipfilename.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_zipfilename.Location = new System.Drawing.Point(8, 203);
            this.bt_zipfilename.Name = "bt_zipfilename";
            this.bt_zipfilename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_zipfilename.Size = new System.Drawing.Size(89, 31);
            this.bt_zipfilename.TabIndex = 8;
            this.bt_zipfilename.Text = "Back&updatei:";
            this.bt_zipfilename.UseVisualStyleBackColor = false;
            this.bt_zipfilename.Click += new System.EventHandler(this.bt_zipfilename_Click);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.SystemColors.Control;
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_search.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_search.Location = new System.Drawing.Point(411, 59);
            this.bt_search.Name = "bt_search";
            this.bt_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_search.Size = new System.Drawing.Size(89, 37);
            this.bt_search.TabIndex = 3;
            this.bt_search.Text = "&Datei suchen";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.Control;
            this.bt_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_close.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_close.Location = new System.Drawing.Point(383, 341);
            this.bt_close.Name = "bt_close";
            this.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_close.Size = new System.Drawing.Size(129, 36);
            this.bt_close.TabIndex = 24;
            this.bt_close.Text = "B&eenden";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // opt_onlynewer
            // 
            this.opt_onlynewer.BackColor = System.Drawing.SystemColors.Control;
            this.opt_onlynewer.Checked = true;
            this.opt_onlynewer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opt_onlynewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.opt_onlynewer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_onlynewer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opt_onlynewer.Location = new System.Drawing.Point(8, 96);
            this.opt_onlynewer.Name = "opt_onlynewer";
            this.opt_onlynewer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opt_onlynewer.Size = new System.Drawing.Size(137, 17);
            this.opt_onlynewer.TabIndex = 18;
            this.opt_onlynewer.Text = "Ältere überspringen";
            this.opt_onlynewer.UseVisualStyleBackColor = false;
            // 
            // bt_suchdir
            // 
            this.bt_suchdir.BackColor = System.Drawing.SystemColors.Control;
            this.bt_suchdir.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_suchdir.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_suchdir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_suchdir.Location = new System.Drawing.Point(411, 102);
            this.bt_suchdir.Name = "bt_suchdir";
            this.bt_suchdir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_suchdir.Size = new System.Drawing.Size(89, 37);
            this.bt_suchdir.TabIndex = 15;
            this.bt_suchdir.Text = "&Verz. suchen";
            this.bt_suchdir.UseVisualStyleBackColor = false;
            this.bt_suchdir.Click += new System.EventHandler(this.bt_suchdir_Click);
            // 
            // bt_change
            // 
            this.bt_change.BackColor = System.Drawing.SystemColors.Control;
            this.bt_change.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_change.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_change.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_change.Location = new System.Drawing.Point(207, 42);
            this.bt_change.Name = "bt_change";
            this.bt_change.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_change.Size = new System.Drawing.Size(73, 27);
            this.bt_change.TabIndex = 2;
            this.bt_change.Text = "&Bearbeiten";
            this.bt_change.UseVisualStyleBackColor = false;
            this.bt_change.Click += new System.EventHandler(this.bt_change_Click);
            // 
            // lblFiles
            // 
            this.lblFiles.BackColor = System.Drawing.SystemColors.Control;
            this.lblFiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFiles.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFiles.Location = new System.Drawing.Point(159, 240);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFiles.Size = new System.Drawing.Size(340, 25);
            this.lblFiles.TabIndex = 22;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.opt_onlynewer);
            this.Frame2.Controls.Add(this.opt_overwrite);
            this.Frame2.Controls.Add(this.txtExtractTo);
            this.Frame2.Controls.Add(this.bt_targetdir);
            this.Frame2.Controls.Add(this.bt_ZipFileRestore);
            this.Frame2.Controls.Add(this.bt_restore);
            this.Frame2.Controls.Add(this.txtRestoreFile);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(12, 287);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(352, 137);
            this.Frame2.TabIndex = 23;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Restore:";
            // 
            // opt_overwrite
            // 
            this.opt_overwrite.BackColor = System.Drawing.SystemColors.Control;
            this.opt_overwrite.Checked = true;
            this.opt_overwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opt_overwrite.Cursor = System.Windows.Forms.Cursors.Default;
            this.opt_overwrite.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_overwrite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opt_overwrite.Location = new System.Drawing.Point(8, 80);
            this.opt_overwrite.Name = "opt_overwrite";
            this.opt_overwrite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opt_overwrite.Size = new System.Drawing.Size(121, 17);
            this.opt_overwrite.TabIndex = 17;
            this.opt_overwrite.Text = "Alles überschreiben";
            this.opt_overwrite.UseVisualStyleBackColor = false;
            // 
            // txtExtractTo
            // 
            this.txtExtractTo.AcceptsReturn = true;
            this.txtExtractTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtExtractTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExtractTo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtractTo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtExtractTo.Location = new System.Drawing.Point(88, 40);
            this.txtExtractTo.MaxLength = 0;
            this.txtExtractTo.Name = "txtExtractTo";
            this.txtExtractTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExtractTo.Size = new System.Drawing.Size(217, 20);
            this.txtExtractTo.TabIndex = 14;
            this.txtExtractTo.Text = "C:\\";
            // 
            // bt_targetdir
            // 
            this.bt_targetdir.BackColor = System.Drawing.SystemColors.Control;
            this.bt_targetdir.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_targetdir.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_targetdir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_targetdir.Location = new System.Drawing.Point(9, 40);
            this.bt_targetdir.Name = "bt_targetdir";
            this.bt_targetdir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_targetdir.Size = new System.Drawing.Size(73, 24);
            this.bt_targetdir.TabIndex = 13;
            this.bt_targetdir.Text = "&Zielverz.:";
            this.bt_targetdir.UseVisualStyleBackColor = false;
            this.bt_targetdir.Click += new System.EventHandler(this.bt_targetdir_Click);
            // 
            // bt_ZipFileRestore
            // 
            this.bt_ZipFileRestore.BackColor = System.Drawing.SystemColors.Control;
            this.bt_ZipFileRestore.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_ZipFileRestore.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ZipFileRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ZipFileRestore.Location = new System.Drawing.Point(9, 16);
            this.bt_ZipFileRestore.Name = "bt_ZipFileRestore";
            this.bt_ZipFileRestore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_ZipFileRestore.Size = new System.Drawing.Size(73, 22);
            this.bt_ZipFileRestore.TabIndex = 10;
            this.bt_ZipFileRestore.Text = "&Quelldatei:";
            this.bt_ZipFileRestore.UseVisualStyleBackColor = false;
            this.bt_ZipFileRestore.Click += new System.EventHandler(this.Command1_Click);
            // 
            // bt_restore
            // 
            this.bt_restore.BackColor = System.Drawing.SystemColors.Control;
            this.bt_restore.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_restore.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_restore.Location = new System.Drawing.Point(160, 80);
            this.bt_restore.Name = "bt_restore";
            this.bt_restore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_restore.Size = new System.Drawing.Size(145, 25);
            this.bt_restore.TabIndex = 12;
            this.bt_restore.Text = "Daten &wiederherstellen";
            this.bt_restore.UseVisualStyleBackColor = false;
            // 
            // txtRestoreFile
            // 
            this.txtRestoreFile.AcceptsReturn = true;
            this.txtRestoreFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtRestoreFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestoreFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestoreFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRestoreFile.Location = new System.Drawing.Point(88, 16);
            this.txtRestoreFile.MaxLength = 0;
            this.txtRestoreFile.Name = "txtRestoreFile";
            this.txtRestoreFile.ReadOnly = true;
            this.txtRestoreFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRestoreFile.Size = new System.Drawing.Size(217, 20);
            this.txtRestoreFile.TabIndex = 11;
            this.txtRestoreFile.Text = "C:\\Eigene Dateien\\biederdb.zip";
            // 
            // txtBackupfile
            // 
            this.txtBackupfile.AcceptsReturn = true;
            this.txtBackupfile.BackColor = System.Drawing.SystemColors.Window;
            this.txtBackupfile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupfile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackupfile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBackupfile.Location = new System.Drawing.Point(103, 203);
            this.txtBackupfile.MaxLength = 0;
            this.txtBackupfile.Name = "txtBackupfile";
            this.txtBackupfile.ReadOnly = true;
            this.txtBackupfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackupfile.Size = new System.Drawing.Size(249, 20);
            this.txtBackupfile.TabIndex = 1;
            this.txtBackupfile.Text = "e:\\biederdb.zip";
            this.txtBackupfile.TextChanged += new System.EventHandler(this.txtBackupfile_TextChanged);
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.SystemColors.Control;
            this.bt_remove.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_remove.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_remove.Location = new System.Drawing.Point(279, 42);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_remove.Size = new System.Drawing.Size(73, 27);
            this.bt_remove.TabIndex = 16;
            this.bt_remove.Text = "Ent&fernen";
            this.bt_remove.UseVisualStyleBackColor = false;
            // 
            // bt_zip_start
            // 
            this.bt_zip_start.BackColor = System.Drawing.SystemColors.Control;
            this.bt_zip_start.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_zip_start.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_zip_start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_zip_start.Location = new System.Drawing.Point(9, 240);
            this.bt_zip_start.Name = "bt_zip_start";
            this.bt_zip_start.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_zip_start.Size = new System.Drawing.Size(145, 25);
            this.bt_zip_start.TabIndex = 7;
            this.bt_zip_start.Text = "Backup-Datei &erstellen";
            this.bt_zip_start.UseVisualStyleBackColor = false;
            this.bt_zip_start.Click += new System.EventHandler(this.bt_zip_start_Click);
            // 
            // bt_autofill
            // 
            this.bt_autofill.BackColor = System.Drawing.SystemColors.Control;
            this.bt_autofill.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_autofill.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_autofill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_autofill.Location = new System.Drawing.Point(411, 16);
            this.bt_autofill.Name = "bt_autofill";
            this.bt_autofill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_autofill.Size = new System.Drawing.Size(89, 37);
            this.bt_autofill.TabIndex = 20;
            this.bt_autofill.Text = "Automatisch";
            this.bt_autofill.UseVisualStyleBackColor = false;
            this.bt_autofill.Click += new System.EventHandler(this.bt_autofill_Click);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.bt_TEST);
            this.Frame1.Controls.Add(this.bt_autofill);
            this.Frame1.Controls.Add(this.bt_remove);
            this.Frame1.Controls.Add(this.bt_suchdir);
            this.Frame1.Controls.Add(this.bt_zipfilename);
            this.Frame1.Controls.Add(this.bt_zip_start);
            this.Frame1.Controls.Add(this.List1);
            this.Frame1.Controls.Add(this.bt_add);
            this.Frame1.Controls.Add(this.txtFile);
            this.Frame1.Controls.Add(this.bt_search);
            this.Frame1.Controls.Add(this.bt_change);
            this.Frame1.Controls.Add(this.txtBackupfile);
            this.Frame1.Controls.Add(this.lblFiles);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 12);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(503, 269);
            this.Frame1.TabIndex = 22;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Backup:";
            // 
            // bt_TEST
            // 
            this.bt_TEST.Location = new System.Drawing.Point(411, 145);
            this.bt_TEST.Name = "bt_TEST";
            this.bt_TEST.Size = new System.Drawing.Size(88, 37);
            this.bt_TEST.TabIndex = 23;
            this.bt_TEST.Text = "TEST";
            this.bt_TEST.UseVisualStyleBackColor = true;
            this.bt_TEST.Click += new System.EventHandler(this.bt_TEST_Click);
            // 
            // FormZIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 427);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormZIP";
            this.Text = "BiederDBZip3";
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox txtFile;
        public System.Windows.Forms.Button bt_add;
        public System.Windows.Forms.ListBox List1;
        public System.Windows.Forms.Button bt_back;
        public System.Windows.Forms.Button bt_zipfilename;
        public System.Windows.Forms.Button bt_search;
        public System.Windows.Forms.Button bt_close;
        public System.Windows.Forms.CheckBox opt_onlynewer;
        public System.Windows.Forms.Button bt_suchdir;
        public System.Windows.Forms.Button bt_change;
        public System.Windows.Forms.Label lblFiles;
        public System.Windows.Forms.GroupBox Frame2;
        public System.Windows.Forms.CheckBox opt_overwrite;
        public System.Windows.Forms.TextBox txtExtractTo;
        public System.Windows.Forms.Button bt_targetdir;
        public System.Windows.Forms.Button bt_restore;
        public System.Windows.Forms.TextBox txtRestoreFile;
        public System.Windows.Forms.Button bt_ZipFileRestore;
        public System.Windows.Forms.TextBox txtBackupfile;
        public System.Windows.Forms.Button bt_remove;
        public System.Windows.Forms.Button bt_zip_start;
        public System.Windows.Forms.Button bt_autofill;
        public System.Windows.Forms.GroupBox Frame1;
        private System.Windows.Forms.Button bt_TEST;
    }
}

