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
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.ColorTest = new System.Windows.Forms.Label();
            this.ColorHex = new System.Windows.Forms.Label();
            this.comboColors = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_defaultColors
            // 
            this.bt_defaultColors.BackColor = System.Drawing.SystemColors.Control;
            this.bt_defaultColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_defaultColors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_defaultColors.Location = new System.Drawing.Point(365, 8);
            this.bt_defaultColors.Name = "bt_defaultColors";
            this.bt_defaultColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_defaultColors.Size = new System.Drawing.Size(134, 25);
            this.bt_defaultColors.TabIndex = 17;
            this.bt_defaultColors.Text = "Standardfarben laden";
            this.bt_defaultColors.UseVisualStyleBackColor = false;
            this.bt_defaultColors.Click += new System.EventHandler(this.bt_defaultColors_Click);
            // 
            // WebBrowser1
            // 
            this.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser1.Location = new System.Drawing.Point(3, 63);
            this.WebBrowser1.Name = "WebBrowser1";
            this.WebBrowser1.Size = new System.Drawing.Size(687, 472);
            this.WebBrowser1.TabIndex = 12;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.bt_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_cancel.Location = new System.Drawing.Point(505, 8);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_cancel.Size = new System.Drawing.Size(73, 25);
            this.bt_cancel.TabIndex = 10;
            this.bt_cancel.Text = "Abbruch";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.SystemColors.Control;
            this.bt_ok.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_ok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_ok.Location = new System.Drawing.Point(584, 8);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_ok.Size = new System.Drawing.Size(73, 25);
            this.bt_ok.TabIndex = 9;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(221, 8);
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
            this.cname.Location = new System.Drawing.Point(133, 8);
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
            this.ColorTest.Location = new System.Drawing.Point(221, 24);
            this.ColorTest.Name = "ColorTest";
            this.ColorTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorTest.Size = new System.Drawing.Size(137, 25);
            this.ColorTest.TabIndex = 14;
            this.ColorTest.Text = "Farbfeld";
            this.ColorTest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ColorTest.DoubleClick += new System.EventHandler(this.ColorTest_DoubleClick);
            // 
            // ColorHex
            // 
            this.ColorHex.BackColor = System.Drawing.SystemColors.Control;
            this.ColorHex.Cursor = System.Windows.Forms.Cursors.Default;
            this.ColorHex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ColorHex.Location = new System.Drawing.Point(133, 32);
            this.ColorHex.Name = "ColorHex";
            this.ColorHex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColorHex.Size = new System.Drawing.Size(73, 17);
            this.ColorHex.TabIndex = 13;
            this.ColorHex.Text = "HTMLColor";
            // 
            // comboColors
            // 
            this.comboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColors.FormattingEnabled = true;
            this.comboColors.Location = new System.Drawing.Point(5, 9);
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(120, 21);
            this.comboColors.TabIndex = 18;
            this.comboColors.SelectedIndexChanged += new System.EventHandler(this.comboColors_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboColors);
            this.panel1.Controls.Add(this.ColorHex);
            this.panel1.Controls.Add(this.bt_defaultColors);
            this.panel1.Controls.Add(this.ColorTest);
            this.panel1.Controls.Add(this.cname);
            this.panel1.Controls.Add(this.bt_cancel);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.bt_ok);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 54);
            this.panel1.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WebBrowser1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 538);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // FormFarben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 538);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(701, 565);
            this.MinimizeBox = false;
            this.Name = "FormFarben";
            this.Text = "Farben festlegen";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button bt_defaultColors;
        public System.Windows.Forms.WebBrowser WebBrowser1;
        public System.Windows.Forms.Button bt_cancel;
        public System.Windows.Forms.Button bt_ok;
        public System.Windows.Forms.Label Label1;
        public System.Windows.Forms.Label cname;
        public System.Windows.Forms.Label ColorTest;
        public System.Windows.Forms.Label ColorHex;
        private System.Windows.Forms.ComboBox comboColors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}