namespace BiederZip3
{
    partial class Form1
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
            this.Text1 = new System.Windows.Forms.TextBox();
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
            this.bt_restore = new System.Windows.Forms.Button();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.Command1 = new System.Windows.Forms.Button();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.bt_remove = new System.Windows.Forms.Button();
            this.bt_zip_start = new System.Windows.Forms.Button();
            this.bt_autofill = new System.Windows.Forms.Button();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.AcceptsReturn = true;
            this.Text1.BackColor = System.Drawing.SystemColors.Window;
            this.Text1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text1.Location = new System.Drawing.Point(103, 16);
            this.Text1.MaxLength = 0;
            this.Text1.Name = "Text1";
            this.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text1.Size = new System.Drawing.Size(249, 20);
            this.Text1.TabIndex = 4;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.SystemColors.Control;
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_add.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_add.Location = new System.Drawing.Point(135, 55);
            this.bt_add.Name = "bt_add";
            this.bt_add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_add.Size = new System.Drawing.Size(73, 27);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "&Hinzufügen";
            this.bt_add.UseVisualStyleBackColor = false;
            // 
            // List1
            // 
            this.List1.BackColor = System.Drawing.SystemColors.Window;
            this.List1.Cursor = System.Windows.Forms.Cursors.Default;
            this.List1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.List1.ItemHeight = 14;
            this.List1.Location = new System.Drawing.Point(103, 103);
            this.List1.Name = "List1";
            this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.List1.Size = new System.Drawing.Size(249, 88);
            this.List1.TabIndex = 6;
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.SystemColors.Control;
            this.bt_back.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_back.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_back.Location = new System.Drawing.Point(386, 383);
            this.bt_back.Name = "bt_back";
            this.bt_back.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_back.Size = new System.Drawing.Size(129, 25);
            this.bt_back.TabIndex = 25;
            this.bt_back.Text = "&Zurück zu BiederDB";
            this.bt_back.UseVisualStyleBackColor = false;
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
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.SystemColors.Control;
            this.bt_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_search.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_search.Location = new System.Drawing.Point(8, 55);
            this.bt_search.Name = "bt_search";
            this.bt_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_search.Size = new System.Drawing.Size(89, 27);
            this.bt_search.TabIndex = 3;
            this.bt_search.Text = "&Datei suchen";
            this.bt_search.UseVisualStyleBackColor = false;
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.SystemColors.Control;
            this.bt_close.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_close.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_close.Location = new System.Drawing.Point(386, 338);
            this.bt_close.Name = "bt_close";
            this.bt_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_close.Size = new System.Drawing.Size(129, 25);
            this.bt_close.TabIndex = 24;
            this.bt_close.Text = "B&eenden";
            this.bt_close.UseVisualStyleBackColor = false;
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
            this.bt_suchdir.Location = new System.Drawing.Point(8, 103);
            this.bt_suchdir.Name = "bt_suchdir";
            this.bt_suchdir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_suchdir.Size = new System.Drawing.Size(89, 24);
            this.bt_suchdir.TabIndex = 15;
            this.bt_suchdir.Text = "&Verz. suchen";
            this.bt_suchdir.UseVisualStyleBackColor = false;
            // 
            // bt_change
            // 
            this.bt_change.BackColor = System.Drawing.SystemColors.Control;
            this.bt_change.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_change.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_change.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_change.Location = new System.Drawing.Point(207, 55);
            this.bt_change.Name = "bt_change";
            this.bt_change.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_change.Size = new System.Drawing.Size(73, 27);
            this.bt_change.TabIndex = 2;
            this.bt_change.Text = "&Bearbeiten";
            this.bt_change.UseVisualStyleBackColor = false;
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
            this.lblFiles.Size = new System.Drawing.Size(193, 25);
            this.lblFiles.TabIndex = 22;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.opt_onlynewer);
            this.Frame2.Controls.Add(this.opt_overwrite);
            this.Frame2.Controls.Add(this.txtExtractTo);
            this.Frame2.Controls.Add(this.bt_targetdir);
            this.Frame2.Controls.Add(this.Command1);
            this.Frame2.Controls.Add(this.bt_restore);
            this.Frame2.Controls.Add(this.Text3);
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
            // Text3
            // 
            this.Text3.AcceptsReturn = true;
            this.Text3.BackColor = System.Drawing.SystemColors.Window;
            this.Text3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text3.Location = new System.Drawing.Point(88, 16);
            this.Text3.MaxLength = 0;
            this.Text3.Name = "Text3";
            this.Text3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text3.Size = new System.Drawing.Size(217, 20);
            this.Text3.TabIndex = 11;
            this.Text3.Text = "C:\\Eigene Dateien\\biederdb.zip";
            // 
            // Command1
            // 
            this.Command1.BackColor = System.Drawing.SystemColors.Control;
            this.Command1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Command1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Command1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Command1.Location = new System.Drawing.Point(9, 16);
            this.Command1.Name = "Command1";
            this.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Command1.Size = new System.Drawing.Size(73, 22);
            this.Command1.TabIndex = 10;
            this.Command1.Text = "&Quelldatei:";
            this.Command1.UseVisualStyleBackColor = false;
            // 
            // Text2
            // 
            this.Text2.AcceptsReturn = true;
            this.Text2.BackColor = System.Drawing.SystemColors.Window;
            this.Text2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Text2.Location = new System.Drawing.Point(103, 203);
            this.Text2.MaxLength = 0;
            this.Text2.Name = "Text2";
            this.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text2.Size = new System.Drawing.Size(249, 20);
            this.Text2.TabIndex = 1;
            this.Text2.Text = "C:\\Eigene Dateien\\biederdb.zip";
            // 
            // bt_remove
            // 
            this.bt_remove.BackColor = System.Drawing.SystemColors.Control;
            this.bt_remove.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_remove.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_remove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_remove.Location = new System.Drawing.Point(279, 55);
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
            // 
            // bt_autofill
            // 
            this.bt_autofill.BackColor = System.Drawing.SystemColors.Control;
            this.bt_autofill.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_autofill.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_autofill.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_autofill.Location = new System.Drawing.Point(8, 16);
            this.bt_autofill.Name = "bt_autofill";
            this.bt_autofill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_autofill.Size = new System.Drawing.Size(89, 27);
            this.bt_autofill.TabIndex = 20;
            this.bt_autofill.Text = "Automatisch";
            this.bt_autofill.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.bt_autofill);
            this.Frame1.Controls.Add(this.bt_remove);
            this.Frame1.Controls.Add(this.bt_suchdir);
            this.Frame1.Controls.Add(this.bt_zipfilename);
            this.Frame1.Controls.Add(this.bt_zip_start);
            this.Frame1.Controls.Add(this.List1);
            this.Frame1.Controls.Add(this.bt_add);
            this.Frame1.Controls.Add(this.Text1);
            this.Frame1.Controls.Add(this.bt_search);
            this.Frame1.Controls.Add(this.bt_change);
            this.Frame1.Controls.Add(this.Text2);
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
            // Form1
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
            this.Name = "Form1";
            this.Text = "BiederDBZip3";
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox Text1;
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
        public System.Windows.Forms.TextBox Text3;
        public System.Windows.Forms.Button Command1;
        public System.Windows.Forms.TextBox Text2;
        public System.Windows.Forms.Button bt_remove;
        public System.Windows.Forms.Button bt_zip_start;
        public System.Windows.Forms.Button bt_autofill;
        public System.Windows.Forms.GroupBox Frame1;
    }
}

