using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ImageTransitions;

namespace TransitionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(".\\bed653.jpg");
        }
        static int iPercent=0;
        private void button1_Click(object sender, EventArgs e)
        {

            ImageTransitions.ImageTransitionsClass.blend _blend = new ImageTransitionsClass.blend();
            
            Image img_to = Image.FromFile(".\\kle701.jpg");

            for (iPercent = 0; iPercent <= 100; iPercent += 10)
            {
                label1.Text = iPercent.ToString();
                _blend.transitionRender(ref this.pictureBox1, pictureBox1.Image, img_to, iPercent, 0, 1);
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(".\\bed653.jpg");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageTransitions.ImageTransitionsClass.bar_wipe _blend = new ImageTransitionsClass.bar_wipe();
            
            Image img_to = Image.FromFile(".\\kle701.jpg");

            for (iPercent = 0; iPercent <= 100; iPercent += 10)
            {
                label1.Text = iPercent.ToString();
                if(chkBottom.Checked)
                    _blend.img_bottom(ref this.pictureBox1, pictureBox1.Image, img_to, iPercent);
                else if(chkLeft.Checked)
                    _blend.img_left(ref this.pictureBox1, pictureBox1.Image, img_to, iPercent);
                else if(chkRight.Checked)
                    _blend.img_right(ref this.pictureBox1, pictureBox1.Image, img_to, iPercent);
                else if(chkTop.Checked)
                    _blend.img_top(ref this.pictureBox1, pictureBox1.Image, img_to, iPercent);
                else
                    _blend.img_top(ref this.pictureBox1, pictureBox1.Image, img_to, iPercent);

                // transitionRender(ref this.pictureBox1, pictureBox1.Image, img_to, iPercent, 0, 1);
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }

        }
    }
}
