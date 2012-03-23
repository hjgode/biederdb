namespace BiederDB3
{
    partial class FormProduktGruppenTexte
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGroupActive = new System.Windows.Forms.TextBox();
            this.txtGroupActiveID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGruppeText = new System.Windows.Forms.TextBox();
            this.cboGruppenAuswahl = new System.Windows.Forms.ComboBox();
            this.txtStandardGruppentext = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveGruppentext = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveStandardText = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gruppen-ID:";
            // 
            // txtGroupActive
            // 
            this.txtGroupActive.Location = new System.Drawing.Point(114, 6);
            this.txtGroupActive.Name = "txtGroupActive";
            this.txtGroupActive.ReadOnly = true;
            this.txtGroupActive.Size = new System.Drawing.Size(117, 20);
            this.txtGroupActive.TabIndex = 1;
            // 
            // txtGroupActiveID
            // 
            this.txtGroupActiveID.Location = new System.Drawing.Point(114, 30);
            this.txtGroupActiveID.Name = "txtGroupActiveID";
            this.txtGroupActiveID.ReadOnly = true;
            this.txtGroupActiveID.Size = new System.Drawing.Size(117, 20);
            this.txtGroupActiveID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gruppen-Text:";
            // 
            // txtGruppeText
            // 
            this.txtGruppeText.Location = new System.Drawing.Point(12, 74);
            this.txtGruppeText.Multiline = true;
            this.txtGruppeText.Name = "txtGruppeText";
            this.txtGruppeText.Size = new System.Drawing.Size(361, 104);
            this.txtGruppeText.TabIndex = 2;
            this.txtGruppeText.TextChanged += new System.EventHandler(this.txtGruppeText_TextChanged);
            // 
            // cboGruppenAuswahl
            // 
            this.cboGruppenAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGruppenAuswahl.FormattingEnabled = true;
            this.cboGruppenAuswahl.Location = new System.Drawing.Point(250, 6);
            this.cboGruppenAuswahl.Name = "cboGruppenAuswahl";
            this.cboGruppenAuswahl.Size = new System.Drawing.Size(122, 21);
            this.cboGruppenAuswahl.TabIndex = 3;
            this.cboGruppenAuswahl.SelectedIndexChanged += new System.EventHandler(this.cboGruppenAuswahl_SelectedIndexChanged);
            // 
            // txtStandardGruppentext
            // 
            this.txtStandardGruppentext.Location = new System.Drawing.Point(11, 247);
            this.txtStandardGruppentext.Multiline = true;
            this.txtStandardGruppentext.Name = "txtStandardGruppentext";
            this.txtStandardGruppentext.Size = new System.Drawing.Size(361, 104);
            this.txtStandardGruppentext.TabIndex = 2;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(12, 184);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 28);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(56, 184);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 28);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(378, 151);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveGruppentext
            // 
            this.btnSaveGruppentext.Location = new System.Drawing.Point(379, 74);
            this.btnSaveGruppentext.Name = "btnSaveGruppentext";
            this.btnSaveGruppentext.Size = new System.Drawing.Size(83, 27);
            this.btnSaveGruppentext.TabIndex = 5;
            this.btnSaveGruppentext.Text = "Speichern";
            this.btnSaveGruppentext.UseVisualStyleBackColor = true;
            this.btnSaveGruppentext.Click += new System.EventHandler(this.btnSaveGruppentext_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Standard-Text:";
            // 
            // btnSaveStandardText
            // 
            this.btnSaveStandardText.Location = new System.Drawing.Point(378, 247);
            this.btnSaveStandardText.Name = "btnSaveStandardText";
            this.btnSaveStandardText.Size = new System.Drawing.Size(83, 27);
            this.btnSaveStandardText.TabIndex = 5;
            this.btnSaveStandardText.Text = "Speichern";
            this.btnSaveStandardText.UseVisualStyleBackColor = true;
            this.btnSaveStandardText.Click += new System.EventHandler(this.btnSaveStandardText_Click);
            // 
            // FormProduktGruppenTexte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 367);
            this.Controls.Add(this.btnSaveStandardText);
            this.Controls.Add(this.btnSaveGruppentext);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.cboGruppenAuswahl);
            this.Controls.Add(this.txtStandardGruppentext);
            this.Controls.Add(this.txtGruppeText);
            this.Controls.Add(this.txtGroupActiveID);
            this.Controls.Add(this.txtGroupActive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProduktGruppenTexte";
            this.Text = "Produktgruppentexte bearbeiten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGroupActive;
        private System.Windows.Forms.TextBox txtGroupActiveID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGruppeText;
        private System.Windows.Forms.ComboBox cboGruppenAuswahl;
        private System.Windows.Forms.TextBox txtStandardGruppentext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveGruppentext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveStandardText;
    }
}