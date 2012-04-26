namespace BiederDB3
{
    partial class FormSlideshow2
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
            this.txtArtikelText = new System.Windows.Forms.TextBox();
            this.imageTransition31 = new BiederDB3.ImageTransitionControl();
            this.SuspendLayout();
            // 
            // txtArtikelText
            // 
            this.txtArtikelText.AcceptsReturn = true;
            this.txtArtikelText.AcceptsTab = true;
            this.txtArtikelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtikelText.Location = new System.Drawing.Point(15, 15);
            this.txtArtikelText.Multiline = true;
            this.txtArtikelText.Name = "txtArtikelText";
            this.txtArtikelText.ReadOnly = true;
            this.txtArtikelText.Size = new System.Drawing.Size(220, 158);
            this.txtArtikelText.TabIndex = 1;
            // 
            // imageTransition31
            // 
            this.imageTransition31.BackColor = System.Drawing.SystemColors.Highlight;
            this.imageTransition31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageTransition31.ImageA = null;
            this.imageTransition31.ImageB = null;
            this.imageTransition31.Location = new System.Drawing.Point(105, 0);
            this.imageTransition31.Name = "imageTransition31";
            this.imageTransition31.pauseTime = 1.5F;
            this.imageTransition31.Size = new System.Drawing.Size(792, 500);
            this.imageTransition31.TabIndex = 0;
            this.imageTransition31.TransitionTime = 1F;
            this.imageTransition31.TransitionType = BiederDB3.ImageTransitionControl.TransitionTypes.Fade;
            this.imageTransition31.Click += new System.EventHandler(this.imageTransition31_Click_1);
            // 
            // FormSlideshow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(894, 563);
            this.Controls.Add(this.txtArtikelText);
            this.Controls.Add(this.imageTransition31);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSlideshow2";
            this.Text = "Slideshow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.FormSlideshow2_SizeChanged);
            this.Click += new System.EventHandler(this.FormSlideshow2_Click);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSlideshow2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ImageTransitionControl imageTransition31;
        private System.Windows.Forms.TextBox txtArtikelText;


    }
}