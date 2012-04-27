using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AnimationControl;

namespace BiederDB3
{
    public partial class FormSlideshow2 : Form
    {
        BiederDBSettings2 _settings = new BiederDBSettings2();
        Random random;
        bool _bRandom = true;
        List<object> transitionList;
        object[] transArr;
        dataclasses.Artikel.artikel[] _artikelListe;
        int iCurrentTrans = 0;
        int iImageCurrent = 0, iImageNext = 0;

        public FormSlideshow2(dataclasses.Artikel.artikel[] artikelList, bool bRandom)
        {
            InitializeComponent();
            _settings = new BiederDBSettings2();
            random = new Random();
            transitionList = new List<object>();
            foreach (ImageTransitionControl.TransitionTypes t in Enum.GetValues(typeof(ImageTransitionControl.TransitionTypes)))
            {
                transitionList.Add(t);
            }
            transArr = transitionList.ToArray();
            imageTransition31.TransitionTime = _settings.showTime;
            //imageTransition31.onTransitionProgress += new EventHandler<ImageTransitionControl.TransitionEventArgs>(imageTransition31_onTransitionProgress);
            imageTransition31.onTransitionDone+=new EventHandler<ImageTransitionControl.TransitionEventArgs>(imageTransition31_onTransitionDone);
            this.SizeChanged+=new EventHandler(FormSlideshow2_SizeChanged);
            
            _artikelListe = artikelList;
            _bRandom = bRandom;

            if (_bRandom)
                //calc next image
                iImageNext = RandomNumber(0, _artikelListe.Length);
            else
                iImageNext = iImageCurrent+1;

            imageTransition31.ImageA = Bitmap.FromFile(_artikelListe[iImageCurrent].Foto);
            imageTransition31.ImageB = Bitmap.FromFile(_artikelListe[iImageNext].Foto);

            imageTransition31.Go();
        }

        void imageTransition31_onTransitionDone(object sender, ImageTransitionControl.TransitionEventArgs e)
        {
                System.Diagnostics.Debug.WriteLine("------------ DONE ----------");
                //next transitiontype
                iCurrentTrans++;
                if (iCurrentTrans == transArr.Length)
                    iCurrentTrans = 0;
                //imageTransition31.TransitionType = (ImageTransitionControl.TransitionTypes)transArr[iCurrentTrans];
                imageTransition31.TransitionType = imageTransition31.getRandom();
                //next image
                if (_bRandom)
                {
                    //calc next image
                    iImageNext = RandomNumber(0, _artikelListe.Length);
                    if(iImageNext==iImageCurrent)
                        iImageNext = RandomNumber(0, _artikelListe.Length);
                }
                else
                {
                    iImageNext = iImageCurrent + 1;
                    if (iImageNext > _artikelListe.Length)
                        iImageNext = 0;
                }//random
                try
                {
                    Image img = Bitmap.FromFile(_artikelListe[iImageNext].Foto);
                    imageTransition31.ImageB = img;
                    txtArtikelText.Text = _artikelListe[iImageNext].ArtNr + "\r\n" + _artikelListe[iImageNext].Omschrijving;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception for imageTransition31.ImageB: " + _artikelListe[iImageNext].Foto + "\r\n\t" + ex.Message);
                }
                imageTransition31.Go();
        }
        void imageTransition31_onTransitionProgress(object sender, ImageTransitionControl.TransitionEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(e.Message + ": " + e.percentDone.ToString());
        }
        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        private void imageTransition31_Click(object sender, EventArgs e)
        {
            if (_settings.PasswortSchutzEin)
            {
                imageTransition31.stop();

                FormPassword frm = new FormPassword();
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    frm.Dispose();
                    imageTransition31.Go();
                    return;
                }
            }
            imageTransition31.stop();
            this.Close();
        }

        private void FormSlideshow2_SizeChanged(object sender, EventArgs e)
        {
            Size sNew = this.ClientSize;
            //ratio
            int ratioNew = (int)(sNew.Width / sNew.Height);
            // Figure out the ratio
            double ratioX = (double)sNew.Width / (double)640;
            double ratioY = (double)sNew.Height / (double)480;
            double ratio = ratioX < ratioY ? ratioX : ratioY; // use whichever multiplier is smaller
            double newHeight = Convert.ToInt32(480 * ratio);
            double newWidth = Convert.ToInt32(640 * ratio);
            this.imageTransition31.Width = (int)newWidth;
            this.imageTransition31.Height = (int)newHeight;
            //move to rigth
            this.imageTransition31.Left = (int)((this.Width - newWidth)/2);
        }

        private void FormSlideshow2_FormClosing(object sender, FormClosingEventArgs e)
        {
            imageTransition31.stop();
        }

        private void imageTransition31_Click_1(object sender, EventArgs e)
        {
            if (_settings.PasswortSchutzEin)
            {
                FormPassword frm = new FormPassword();
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    frm.Dispose();
                    return;
                }
            }
            this.Close();
        }

        private void FormSlideshow2_Click(object sender, EventArgs e)
        {
            if (_settings.PasswortSchutzEin)
            {
                FormPassword frm = new FormPassword();
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    frm.Dispose();
                    return;
                }
            }
            this.Close();

        }

    }
}
