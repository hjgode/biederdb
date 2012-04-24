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
            this.imageTransition31 = new BiederDB3.ImageTransitionControl();
            this.SuspendLayout();
            // 
            // imageTransition31
            // 
            this.imageTransition31.Location = new System.Drawing.Point(24, 55);
            this.imageTransition31.Name = "imageTransition31";
            this.imageTransition31.Size = new System.Drawing.Size(443, 341);
            this.imageTransition31.TabIndex = 0;
            // 
            // FormSlideshow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 563);
            this.Controls.Add(this.imageTransition31);
            this.Name = "FormSlideshow2";
            this.Text = "FormSlideshow2";
            this.SizeChanged += new System.EventHandler(this.FormSlideshow2_SizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSlideshow2_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageTransitionControl imageTransition31;


    }
}