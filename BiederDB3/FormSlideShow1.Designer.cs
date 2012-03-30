namespace BiederDB3
{
    partial class FormSlideShow1
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
            this.chk_passwort = new System.Windows.Forms.CheckBox();
            this.chkOrderNormal = new System.Windows.Forms.RadioButton();
            this.chkOrderRandom = new System.Windows.Forms.RadioButton();
            this.cboGruppenAuswahl = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.chkSelectByGroup = new System.Windows.Forms.RadioButton();
            this.chkSelectAll = new System.Windows.Forms.RadioButton();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_passwort
            // 
            this.chk_passwort.BackColor = System.Drawing.SystemColors.Control;
            this.chk_passwort.Checked = true;
            this.chk_passwort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_passwort.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk_passwort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_passwort.Location = new System.Drawing.Point(12, 12);
            this.chk_passwort.Name = "chk_passwort";
            this.chk_passwort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_passwort.Size = new System.Drawing.Size(129, 25);
            this.chk_passwort.TabIndex = 16;
            this.chk_passwort.Text = "Passwortschutz EIN";
            this.ToolTip1.SetToolTip(this.chk_passwort, "Wenn Passwortschutz EIN gewählt ist, können Sie die Slideshow nur mit einem Passw" +
                    "ort verlassen");
            this.chk_passwort.UseVisualStyleBackColor = false;
            // 
            // chkOrderNormal
            // 
            this.chkOrderNormal.BackColor = System.Drawing.SystemColors.Control;
            this.chkOrderNormal.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkOrderNormal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOrderNormal.Location = new System.Drawing.Point(8, 40);
            this.chkOrderNormal.Name = "chkOrderNormal";
            this.chkOrderNormal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkOrderNormal.Size = new System.Drawing.Size(73, 17);
            this.chkOrderNormal.TabIndex = 4;
            this.chkOrderNormal.TabStop = true;
            this.chkOrderNormal.Text = "Normal";
            this.chkOrderNormal.UseVisualStyleBackColor = false;
            // 
            // chkOrderRandom
            // 
            this.chkOrderRandom.BackColor = System.Drawing.SystemColors.Control;
            this.chkOrderRandom.Checked = true;
            this.chkOrderRandom.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkOrderRandom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOrderRandom.Location = new System.Drawing.Point(8, 16);
            this.chkOrderRandom.Name = "chkOrderRandom";
            this.chkOrderRandom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkOrderRandom.Size = new System.Drawing.Size(73, 17);
            this.chkOrderRandom.TabIndex = 3;
            this.chkOrderRandom.TabStop = true;
            this.chkOrderRandom.Text = "Zufall";
            this.chkOrderRandom.UseVisualStyleBackColor = false;
            // 
            // cboGruppenAuswahl
            // 
            this.cboGruppenAuswahl.BackColor = System.Drawing.SystemColors.Window;
            this.cboGruppenAuswahl.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboGruppenAuswahl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboGruppenAuswahl.Location = new System.Drawing.Point(8, 64);
            this.cboGruppenAuswahl.Name = "cboGruppenAuswahl";
            this.cboGruppenAuswahl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboGruppenAuswahl.Size = new System.Drawing.Size(113, 69);
            this.cboGruppenAuswahl.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClose.Location = new System.Drawing.Point(28, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnClose.Size = new System.Drawing.Size(97, 25);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "SCHLIESSEN";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.chkSelectByGroup);
            this.Frame2.Controls.Add(this.chkSelectAll);
            this.Frame2.Controls.Add(this.cboGruppenAuswahl);
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(12, 150);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(0);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(129, 145);
            this.Frame2.TabIndex = 14;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Auswahl:";
            // 
            // chkSelectByGroup
            // 
            this.chkSelectByGroup.BackColor = System.Drawing.SystemColors.Control;
            this.chkSelectByGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSelectByGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSelectByGroup.Location = new System.Drawing.Point(8, 40);
            this.chkSelectByGroup.Name = "chkSelectByGroup";
            this.chkSelectByGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSelectByGroup.Size = new System.Drawing.Size(113, 25);
            this.chkSelectByGroup.TabIndex = 8;
            this.chkSelectByGroup.TabStop = true;
            this.chkSelectByGroup.Text = "Nur Produktgruppe:";
            this.chkSelectByGroup.UseVisualStyleBackColor = false;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.BackColor = System.Drawing.SystemColors.Control;
            this.chkSelectAll.Checked = true;
            this.chkSelectAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSelectAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSelectAll.Location = new System.Drawing.Point(8, 16);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSelectAll.Size = new System.Drawing.Size(113, 25);
            this.chkSelectAll.TabIndex = 7;
            this.chkSelectAll.TabStop = true;
            this.chkSelectAll.Text = "Alle";
            this.chkSelectAll.UseVisualStyleBackColor = false;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.chkOrderNormal);
            this.Frame1.Controls.Add(this.chkOrderRandom);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(12, 78);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(129, 65);
            this.Frame1.TabIndex = 13;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Reihenfolge:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Location = new System.Drawing.Point(36, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(89, 28);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox.Location = new System.Drawing.Point(148, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pictureBox.Size = new System.Drawing.Size(640, 480);
            this.pictureBox.TabIndex = 11;
            // 
            // FormSlideShow1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 512);
            this.Controls.Add(this.chk_passwort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSlideShow1";
            this.Text = "Slideshow Viewer";
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.CheckBox chk_passwort;
        public System.Windows.Forms.RadioButton chkOrderNormal;
        public System.Windows.Forms.RadioButton chkOrderRandom;
        public System.Windows.Forms.ListBox cboGruppenAuswahl;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.GroupBox Frame2;
        public System.Windows.Forms.RadioButton chkSelectByGroup;
        public System.Windows.Forms.RadioButton chkSelectAll;
        public System.Windows.Forms.GroupBox Frame1;
        public System.Windows.Forms.ToolTip ToolTip1;
        public System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}