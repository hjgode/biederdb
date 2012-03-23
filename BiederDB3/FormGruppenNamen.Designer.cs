namespace BiederDB3
{
    partial class FormGruppenNamen
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboGruppenAuswahl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGruppeText = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gruppe:";
            // 
            // cboGruppenAuswahl
            // 
            this.cboGruppenAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGruppenAuswahl.FormattingEnabled = true;
            this.cboGruppenAuswahl.Location = new System.Drawing.Point(93, 6);
            this.cboGruppenAuswahl.Name = "cboGruppenAuswahl";
            this.cboGruppenAuswahl.Size = new System.Drawing.Size(142, 21);
            this.cboGruppenAuswahl.TabIndex = 1;
            this.cboGruppenAuswahl.SelectedIndexChanged += new System.EventHandler(this.cboGruppenAuswahl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Neuer Name:";
            // 
            // txtGruppeText
            // 
            this.txtGruppeText.Location = new System.Drawing.Point(93, 41);
            this.txtGruppeText.Name = "txtGruppeText";
            this.txtGruppeText.Size = new System.Drawing.Size(141, 20);
            this.txtGruppeText.TabIndex = 2;
            this.txtGruppeText.TextChanged += new System.EventHandler(this.txtGruppeText_TextChanged);
            // 
            // btnRename
            // 
            this.btnRename.Enabled = false;
            this.btnRename.Location = new System.Drawing.Point(265, 35);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(98, 30);
            this.btnRename.TabIndex = 3;
            this.btnRename.Text = "Umbenennen";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(265, 80);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormGruppenNamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 134);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txtGruppeText);
            this.Controls.Add(this.cboGruppenAuswahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGruppenNamen";
            this.Text = "Gruppe umbenennen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGruppenAuswahl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGruppeText;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnClose;
    }
}