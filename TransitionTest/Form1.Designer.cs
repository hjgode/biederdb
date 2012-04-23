namespace TransitionTest
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkTop = new System.Windows.Forms.RadioButton();
            this.chkLeft = new System.Windows.Forms.RadioButton();
            this.chkBottom = new System.Windows.Forms.RadioButton();
            this.chkRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 347);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "blend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(404, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 26);
            this.button3.TabIndex = 1;
            this.button3.Text = "wipe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkRight);
            this.panel1.Controls.Add(this.chkLeft);
            this.panel1.Controls.Add(this.chkBottom);
            this.panel1.Controls.Add(this.chkTop);
            this.panel1.Location = new System.Drawing.Point(361, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 47);
            this.panel1.TabIndex = 4;
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(3, 3);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(44, 17);
            this.chkTop.TabIndex = 0;
            this.chkTop.TabStop = true;
            this.chkTop.Text = "Top";
            this.chkTop.UseVisualStyleBackColor = true;
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(68, 3);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(43, 17);
            this.chkLeft.TabIndex = 0;
            this.chkLeft.TabStop = true;
            this.chkLeft.Text = "Left";
            this.chkLeft.UseVisualStyleBackColor = true;
            // 
            // chkBottom
            // 
            this.chkBottom.AutoSize = true;
            this.chkBottom.Location = new System.Drawing.Point(3, 26);
            this.chkBottom.Name = "chkBottom";
            this.chkBottom.Size = new System.Drawing.Size(58, 17);
            this.chkBottom.TabIndex = 0;
            this.chkBottom.TabStop = true;
            this.chkBottom.Text = "Bottom";
            this.chkBottom.UseVisualStyleBackColor = true;
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(68, 26);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(50, 17);
            this.chkRight.TabIndex = 0;
            this.chkRight.TabStop = true;
            this.chkRight.Text = "Right";
            this.chkRight.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton chkRight;
        private System.Windows.Forms.RadioButton chkLeft;
        private System.Windows.Forms.RadioButton chkBottom;
        private System.Windows.Forms.RadioButton chkTop;
    }
}

