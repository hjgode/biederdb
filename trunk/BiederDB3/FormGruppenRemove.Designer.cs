namespace BiederDB3
{
    partial class FormGruppenRemove
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
            this.cboGruppenAuswahl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfRecords = new System.Windows.Forms.TextBox();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboGruppenAuswahl
            // 
            this.cboGruppenAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGruppenAuswahl.FormattingEnabled = true;
            this.cboGruppenAuswahl.Location = new System.Drawing.Point(145, 6);
            this.cboGruppenAuswahl.Name = "cboGruppenAuswahl";
            this.cboGruppenAuswahl.Size = new System.Drawing.Size(142, 21);
            this.cboGruppenAuswahl.TabIndex = 3;
            this.cboGruppenAuswahl.SelectedIndexChanged += new System.EventHandler(this.cboGruppenAuswahl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gruppe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anzahl der Daten mit dieser Gruppe:";
            // 
            // txtNumberOfRecords
            // 
            this.txtNumberOfRecords.Location = new System.Drawing.Point(195, 37);
            this.txtNumberOfRecords.Name = "txtNumberOfRecords";
            this.txtNumberOfRecords.ReadOnly = true;
            this.txtNumberOfRecords.Size = new System.Drawing.Size(92, 20);
            this.txtNumberOfRecords.TabIndex = 4;
            this.txtNumberOfRecords.TextChanged += new System.EventHandler(this.txtNumberOfRecords_TextChanged);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(145, 81);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(142, 28);
            this.btnDeleteData.TabIndex = 5;
            this.btnDeleteData.Text = "Daten löschen";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Enabled = false;
            this.btnDeleteGroup.Location = new System.Drawing.Point(145, 115);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(142, 28);
            this.btnDeleteGroup.TabIndex = 5;
            this.btnDeleteGroup.Text = "Gruppe löschen";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormGruppenRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 210);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.txtNumberOfRecords);
            this.Controls.Add(this.cboGruppenAuswahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGruppenRemove";
            this.Text = "Gruppen löschen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboGruppenAuswahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfRecords;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnClose;
    }
}