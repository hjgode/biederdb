namespace BiederDB3
{
    partial class FormTextEdit
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Standard = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel2.SetColumnSpan(this.Label1, 2);
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(3, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(600, 54);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Text normal bearbeiten. Zeilenschaltungen werden durch <br>, Absatzschaltungen du" +
                "rch <p> erreicht. Vorsicht mit Sonderzeichen, es handelt sich um HTML Text!";
            // 
            // txtEdit
            // 
            this.txtEdit.AcceptsReturn = true;
            this.txtEdit.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.SetColumnSpan(this.txtEdit, 2);
            this.txtEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEdit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEdit.Location = new System.Drawing.Point(3, 57);
            this.txtEdit.MaxLength = 0;
            this.txtEdit.Multiline = true;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEdit.Size = new System.Drawing.Size(600, 329);
            this.txtEdit.TabIndex = 5;
            this.txtEdit.WordWrap = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Cancel.Location = new System.Drawing.Point(0, 0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Cancel.Size = new System.Drawing.Size(96, 24);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Abbruch";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.SystemColors.Control;
            this.btn_OK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_OK.Location = new System.Drawing.Point(205, 0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_OK.Size = new System.Drawing.Size(92, 24);
            this.btn_OK.TabIndex = 6;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_OK);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Location = new System.Drawing.Point(306, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 24);
            this.panel1.TabIndex = 10;
            // 
            // btn_Standard
            // 
            this.btn_Standard.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Standard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Standard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Standard.Location = new System.Drawing.Point(3, 392);
            this.btn_Standard.Name = "btn_Standard";
            this.btn_Standard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Standard.Size = new System.Drawing.Size(89, 24);
            this.btn_Standard.TabIndex = 8;
            this.btn_Standard.Text = "Standardtext";
            this.btn_Standard.UseVisualStyleBackColor = false;
            this.btn_Standard.Click += new System.EventHandler(this.btn_Standard_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtEdit, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_Standard, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.02439F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.97561F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(606, 422);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // FormTextEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 422);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTextEdit";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.FormTextEdit_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.TextBox txtEdit;
        public System.Windows.Forms.Button btn_Standard;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_OK;
        public System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}