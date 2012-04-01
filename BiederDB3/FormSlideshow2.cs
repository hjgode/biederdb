﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace BiederDB3
{
    public partial class FormSlideshow2 : Form
    {
        public FormSlideshow2()
        {
            InitializeComponent();
        }
        private SlidePL.CSlideImage m_SDImageA;
        private SlidePL.CSlideImage m_SDImageB;
        private SlidePL.CSlideImage m_SDImageC;
        private byte[] m_Bits;                                          // bits of processed image C

        private SlidePL.CSlideTransition m_SDTransition;                // transition handle
        private SlidePL.ISlideFactory m_SDFactory;                      // transition factory
        private System.Windows.Int32Rect m_DirtyRt;                                    // dirty region
        private int m_Percent;
        private System.Windows.Media.Imaging.WriteableBitmap m_Image;   // WPF image for display
        //private Bitmap m_Image;   // WPF image for display
        private Thread m_Thread;                                        // thread instance

        System.Windows.Forms.Timer _timer;
        private struct transEffect
        {
            public string name;
            public int ID;
            public SlidePL.CSlideTransition transition;
        }
        private transEffect[] _transitions;

        string[] _sFilelist;

        public FormSlideshow2(string[] sFileList)
        {
            _sFilelist = sFileList;
            _timer.Interval = 3000;
            _timer.Enabled = true;

        }
        private void LoadTransition()
        {
            // get current working dir
            string strDir = Utils.AppPath;
            // the transition Plug-ins are put here
            strDir += "transition";

            // create the SDK factory component
            m_SDFactory = new SlidePL.CSlideFactory();

            // tell the factory where is the transition plug-ins folder
            m_SDFactory.SetTransitionDir(strDir);

            // get transitions and add them into listbox
            int iTransitionCount = m_SDFactory.GetTransitionCount();
            _transitions = new transEffect [iTransitionCount];

            for (int i = 0; i < iTransitionCount; i++)
            {
                _transitions[i].ID = i;
                _transitions[i].name = m_SDFactory.GetTransitionName(i);
                
                //// get transition name by ID
                //System.String strName = m_SDFactory.GetTransitionName(i);

                //// new an item instance
                //System.Windows.Controls.ListBoxItem item = new System.Windows.Controls.ListBoxItem();
                //item.DataContext = i;   // saving ID 
                //item.Content = strName; // saving Name

                //// add to listbox
                //Transitions.Items.Add(item);
            }
        }

        private void LoadImages()
        {
            // get current working folder
            string strWorkingDir = System.Environment.CurrentDirectory;

            // create processing instance image A and instance image B
            m_SDImageA = new SlidePL.CSlideImage();
            m_SDImageB = new SlidePL.CSlideImage();

            // create result image C
            m_SDImageC = new SlidePL.CSlideImage();

            // load image A
            string strImageFileName = _sFilelist[0];// strWorkingDir + "\\pics\\a.png";
            try
            {
                // load image A
                m_SDImageA.LoadFile(strImageFileName);

                // make sure the image B's size == image A's size
                m_SDImageB.SetSize(m_SDImageA.GetWidth(), m_SDImageA.GetHeight());
            }
            catch (Exception eExcep)
            {
                Utils.showErrorMsg(strImageFileName, "Can't load image A");
                return;
            }

            // Load image B
            strImageFileName = _sFilelist[1]; //strWorkingDir + "\\pics\\b.png";
            try
            {
                SlidePL.CSlideImage ImageLoading = new SlidePL.CSlideImage();
                ImageLoading.LoadFile(strImageFileName);
                if (ImageLoading.GetWidth() == m_SDImageA.GetWidth() && ImageLoading.GetHeight() == m_SDImageA.GetHeight())
                    m_SDImageB.CopyFrom(ImageLoading);
                else
                    ImageLoading.ResizeTo(m_SDImageB, 1);

            }
            catch (Exception eExcep)
            {
                Utils.showErrorMsg(strImageFileName, "Can't load image B");
                return;
            }

            // get processing image's width and height
            int height = m_SDImageA.GetHeight();
            int width = m_SDImageA.GetWidth();

            // init the dirty region
            m_DirtyRt = new System.Windows.Int32Rect(0, 0, width, height);

            // allocate a byte array to store image C's bits
            int pitch = width * 4;
            int total = pitch * height;
            m_Bits = new byte[total];

            // pass the array to Image C, the ImageC will hold this bits
            m_SDImageC.Attach(width, height, pitch, ref m_Bits[0]);

            // copy image A's content to displaying image
            m_SDImageA.GetBits(ref m_Bits[0], pitch);
            m_Image = new System.Windows.Media.Imaging.WriteableBitmap(width, height, 96, 96, System.Windows.Media.PixelFormats.Bgr32, null);

            m_Image.WritePixels(m_DirtyRt, m_Bits, pitch, 0); 

            // update the image control
            WndImage.Image = (Bitmap)m_Image;
        }

        private void Transitions_SelectionChanged(int iNextTransition)
        {
            // while selected transition changed, create the new transition with the ID
            if (m_SDTransition != null)
            {
                m_SDTransition = null;
            }
            int iTransition = iNextTransition;

            // reset the processing percent to 0
            m_Percent = 0;

            // create transition by ID
            m_SDTransition = m_SDFactory.CreateTransition(iTransition, 0);

            // create a thread to loop calling transition processing
            //Transitions.IsEnabled = false;

            m_Thread = new Thread(new ThreadStart(ThreadLoop));
            m_Thread.IsBackground = true;
            m_Thread.Start();
        }

        private void ThreadLoop()
        {
            while (m_Percent <= 100)
            {
                OnProcess();
                m_Percent += 1;
                Thread.Sleep(5);
            }
            m_Percent = 0;
        }
        protected delegate void DoTransitionProxy();
        protected void DoTransition()
        {
            m_SDTransition.DoEffect(m_SDImageC, m_SDImageA, m_SDImageB, m_Percent, 0);

            int pitch = m_SDImageC.GetWidth();
            pitch <<= 2;

            m_Image.Lock();
            m_Image.WritePixels(m_DirtyRt, m_Bits, pitch, 0);
            m_Image.Unlock();

            //if (m_Percent >= 100)
            //    Transitions.IsEnabled = true;
        }

        private void OnProcess()
        {
            DoTransitionProxy update = new DoTransitionProxy(DoTransition);
            this.Invoke(update);
        }       

    }
}
