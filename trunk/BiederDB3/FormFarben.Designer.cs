namespace BiederDB3
{
    partial class FormFarben
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
            this.bt_defaultColors = new System.Windows.Forms.Button();
            this.WebBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Combo1 = new System.Windows.Forms.ComboBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.ColorTest = new System.Windows.Forms.Label();
            this.ColorHex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_defaultColors
            // 
            this.bt_defaultColors.BackColor = System.Drawing.SystemColors.Control;
            this.bt_defaultColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_defaultColors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_defaultColors.Location = new System.Drawing.Point(372, 43);
            this.bt_defaultColors.Name = "bt_defaultColors";
            this.bt_defaultColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_defaultColors.Size = new System.Drawing.Size(153, 27);
            this.bt_defaultColors.TabIndex = 17;
            this.bt_defaultColors.Text = "Standardfarben laden";
            this.bt_defaultColors.UseVisualStyleBackColor = false;
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Location = new System.Drawing.Point(12, 87);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(513, 533);
            this.WebBrowser1.TabIndex = 12;
            // 
            // Combo1
            // 
            this.Combo1.BackColor = System.Drawing.SystemColors.Window;
            this.Combo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Combo1.Location = new System.Drawing.Point(12, 11);
            this.Combo1.Name = "Combo1";
            this.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Combo1.Size = new System.Drawing.Size(121, 21);
            this.Combo1.TabIndex = 11;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.Location = new System.Drawing.Point(372, 11);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_cancel.Size = new System.Drawing.Size(73, 25);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Abbruch";
            this.bt_cancel.UseVisualStyleBackColor = false;
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.SystemColors.Control;
            this.bt_ok.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ok.Location = new System.Drawing.Point(452, 11);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_ok.Size = new System.Drawing.Size(73, 25);
            this.bt_ok.TabIndex = 9;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(228, 11);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(129, 17);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Doppelklick zum Ändern";
            // 
            // cname
            // 
            this.cname.BackColor = System.Drawing.SystemColors.Control;
            this.cname.Cursor = System.Windows.Forms.Cursors.Default;
            this.cname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cname.Location = new System.Drawing.Point(140, 11);
            this.cname.Name = "cname";
            this.cname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cname.Size = new System.Drawing.Size(81, 17);
            this.cname.TabIndex = 15;
            this.cname.Text = "Html-Element:";
            // 
            // ColorTest
            // 
            this.ColorTest.BackColor = System.Drawing.Color.Yellow;
            this.ColorTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorTest.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorTest.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ColorTest.Location = new System.Drawing.Point(228, 27);
            this.ColorTest.Name = "ColorTest";
            this.ColorTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorTest.Size = new System.Drawing.Size(137, 33);
            this.ColorTest.TabIndex = 14;
            this.ColorTest.Text = "Farbfeld";
            this.ColorTest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ColorHex
            // 
            this.ColorHex.BackColor = System.Drawing.SystemColors.Control;
            this.ColorHex.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorHex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColorHex.Location = new System.Drawing.Point(140, 35);
            this.ColorHex.Name = "ColorHex";
            this.ColorHex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorHex.Size = new System.Drawing.Size(73, 17);
            this.ColorHex.TabIndex = 13;
            this.ColorHex.Text = "HTMLColor";
            // 
            // FormFarben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 538);
            this.Controls.Add(this.bt_defaultColors);
            this.Controls.Add(this.WebBrowser1);
            this.Controls.Add(this.Combo1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.ColorTest);
            this.Controls.Add(this.ColorHex);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFarben";
            this.Text = "FormFarben";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bt_defaultColors;
        public System.Windows.Forms.WebBrowser WebBrowser1;
        public System.Windows.Forms.ComboBox Combo1;
        public System.Windows.Forms.Button bt_cancel;
        public System.Windows.Forms.Button bt_ok;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label cname;
        public System.Windows.Forms.Label ColorTest;
        public System.Windows.Forms.Label ColorHex;
    }
}