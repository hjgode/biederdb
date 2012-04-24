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
            cboTransType.Items.Clear();
            foreach (ImageTransitionControl.TransitionTypes t in Enum.GetValues(typeof(ImageTransitionControl.TransitionTypes)))
            {
                cboTransType.Items.Add(t);
            }
            cboTransType.SelectedIndex = 0;
            imageTransitionControl1.onTransitionDone += new EventHandler<ImageTransitionControl.TransitionEventArgs>(imageTransitionControl1_onTransitionDone);
        }
        delegate void SetTextCallback(string text);
        private void setLabel(string s)
        {
            if (this.label1.InvokeRequired)
            {
                SetTextCallback dele = new SetTextCallback(setLabel);
                this.Invoke(dele, new object[] { s });
            }
            else
            {
                label1.Text = s;
            }
        }
        void imageTransitionControl1_onTransitionDone(object sender, ImageTransitionControl.TransitionEventArgs e)
        {
            setLabel(((int)(e.percentDone)).ToString());
            if(e.percentDone==100){
                ;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int iSel = cboTransType.SelectedIndex;
            if (iSel == -1)
                return;

            imageTransitionControl1.ImageA=Image.FromFile(".\\bed653.jpg");
            imageTransitionControl1.ImageB=Image.FromFile(".\\kle701.jpg");
            imageTransitionControl1.TransitionTime = 3;

            imageTransitionControl1.TransitionType = (ImageTransitionControl.TransitionTypes)cboTransType.SelectedItem; //ImageTransitions.ImageTransitionControl.TransitionTypes.BarnDoor;
            imageTransitionControl1.Go();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageTransitionControl1.Image = Image.FromFile(".\\bed653.jpg");

        }

    }
}
