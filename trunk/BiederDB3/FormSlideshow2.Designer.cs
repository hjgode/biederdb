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
            this.WndImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WndImage)).BeginInit();
            this.SuspendLayout();
            // 
            // WndImage
            // 
            this.WndImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WndImage.Location = new System.Drawing.Point(0, 0);
            this.WndImage.Name = "WndImage";
            this.WndImage.Size = new System.Drawing.Size(640, 507);
            this.WndImage.TabIndex = 0;
            this.WndImage.TabStop = false;
            // 
            // FormSlideshow2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 507);
            this.Controls.Add(this.WndImage);
            this.Name = "FormSlideshow2";
            this.Text = "FormSlideshow2";
            ((System.ComponentModel.ISupportInitialize)(this.WndImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WndImage;
    }
}