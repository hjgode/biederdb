namespace BiederDB3
{
    partial class FormGruppenSort
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
            this.cboGruppenAuswahl = new System.Windows.Forms.ListBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboGruppenAuswahl
            // 
            this.cboGruppenAuswahl.FormattingEnabled = true;
            this.cboGruppenAuswahl.Location = new System.Drawing.Point(15, 25);
            this.cboGruppenAuswahl.Name = "cboGruppenAuswahl";
            this.cboGruppenAuswahl.Size = new System.Drawing.Size(190, 212);
            this.cboGruppenAuswahl.TabIndex = 0;
            this.cboGruppenAuswahl.SelectedIndexChanged += new System.EventHandler(this.cboGruppenAuswahl_SelectedIndexChanged);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(211, 25);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(83, 27);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Auf";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(211, 58);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(83, 27);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "Ab";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gruppen:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 26);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormGruppenSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 248);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.cboGruppenAuswahl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGruppenSort";
            this.Text = "Gruppen sortieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cboGruppenAuswahl;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}