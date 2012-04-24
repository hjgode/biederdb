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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.imageTransitionControl1 = new ImageTransitions.ImageTransitionControl();
            this.cboTransType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageTransitionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "GO";
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
            // imageTransitionControl1
            // 
            this.imageTransitionControl1.ImageA = null;
            this.imageTransitionControl1.ImageB = null;
            this.imageTransitionControl1.Location = new System.Drawing.Point(12, 15);
            this.imageTransitionControl1.Name = "imageTransitionControl1";
            this.imageTransitionControl1.Size = new System.Drawing.Size(320, 240);
            this.imageTransitionControl1.TabIndex = 5;
            this.imageTransitionControl1.TabStop = false;
            this.imageTransitionControl1.TransitionTime = 1F;
            this.imageTransitionControl1.TransitionType = ImageTransitions.ImageTransitionControl.TransitionTypes.Fade;
            // 
            // cboTransType
            // 
            this.cboTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransType.FormattingEnabled = true;
            this.cboTransType.Location = new System.Drawing.Point(337, 15);
            this.cboTransType.Name = "cboTransType";
            this.cboTransType.Size = new System.Drawing.Size(145, 21);
            this.cboTransType.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 418);
            this.Controls.Add(this.cboTransType);
            this.Controls.Add(this.imageTransitionControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageTransitionControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private ImageTransitions.ImageTransitionControl imageTransitionControl1;
        private System.Windows.Forms.ComboBox cboTransType;
    }
}

