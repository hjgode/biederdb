using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

using System.IO;

namespace BiederDB3
{
    public partial class FormSlideShow1 : Form
    {
        bool _passwordSchutz = true;
        BiederDBSettings2 _settings = new BiederDBSettings2();
        dataclasses.Gruppentexte _gTexte;
        Datenbank db;
        DataSet ds;
        DataTable dt;
        string[] _sImageList;
        Timer _timer;
        Rectangle _screenSize;
        int iCurrent = 0;
        int iCurrentMax = 0;
        Random random;
        Image img;

        public FormSlideShow1()
        {
            InitializeComponent();
            random = new Random();
            readData();
            _timer = new Timer();
            _timer.Enabled = false;
            _timer.Interval = _settings.showTime*1000;
            _timer.Tick += new EventHandler(_timer_Tick);
          
        }
        bool loadImage(string sFile)
        {
            bool bRet = false;
            if (System.IO.File.Exists(sFile))
            {
                try
                {
                    System.Diagnostics.Debug.WriteLine("loadImage '" + sFile +"'");
                    pictureBox.Image = Image.FromFile(sFile);// "C:\\Applicaties\\Foto's artikelen\\Stoelen\\sto361.jpg");
                    bRet = true;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Exception in loadImage: " + sFile+"' Ex="+ex.Message);
                }
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("loadImage: File Not Found '" + sFile+"'");
            }
            return bRet;
        }

        void _timer_Tick(object sender, EventArgs e)
        {
            if (chkOrderNormal.Checked)
            {
                loadImage(_sImageList[iCurrent]);
                iCurrent++;
                if (iCurrent == iCurrentMax)
                    iCurrent = 0;
            }
            else
            {
                iCurrent = RandomNumber(0, iCurrentMax);
                System.Diagnostics.Debug.WriteLine("_timer_Tick with Random = " + iCurrent.ToString() + ", '" + _sImageList[iCurrent] + "'");
                loadImage(_sImageList[iCurrent]);
            }
        }
        private void readData()
        {
            _screenSize = Screen.PrimaryScreen.Bounds;
            _passwordSchutz = _settings.PasswortSchutzEin;
            chk_passwort.Checked = _passwordSchutz;

            db = new Datenbank();

            _gTexte = new dataclasses.Gruppentexte(ref db);

            List<dataclasses.Gruppentexte.gruppentext> liste = _gTexte.getGruppentexte();

            dataclasses.Gruppentexte.gruppentext[] _gruppentexte = liste.ToArray();

            cboGruppenAuswahl.Items.Clear();

            foreach (dataclasses.Gruppentexte.gruppentext g in _gruppentexte)
                cboGruppenAuswahl.Items.Add(g);

            cboGruppenAuswahl.SelectedIndex = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _settings.PasswortSchutzEin = chk_passwort.Checked;
            _settings.save();

            if (_timer.Enabled)
            {
                _timer.Enabled = false;
                btnStart.Text = "START";
                return;
            }
            dataclasses.Artikel artClass = new BiederDB3.dataclasses.Artikel();
            dataclasses.Artikel.artikel[] _art = artClass.getArtikel("");
            try
            {
                GC.Collect();
                FormSlideshow2 frm = new FormSlideshow2(_art, chkOrderRandom.Checked);
                //ImageControl1 frm = new ImageControl1(_art, chkOrderRandom.Checked);
                frm.ShowDialog();
                frm = null;
                return;
            }
            catch (Exception ex)
            {
                Utils.showErrorMsg(ex.Message +"\r\n" + ex.InnerException, "Error in ImageControl1");
                return;
            }

            //string sCmd="";
            //if (chkSelectAll.Checked)
            //    sCmd = "SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID  where Artikel.Besteld>1;";
            //else
            //    sCmd = "SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID  where Artikel.Besteld>1 AND Artikel.HGR_ID=" + ((dataclasses.Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem).ID.ToString() + ";";
            //if (System.Diagnostics.Debugger.IsAttached)
            //    sCmd = "SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID;";
            
            //dt = db.getTable(sCmd);
            ////ds = db.getDataset(sCmd, ref iCount);
            ////if (iCount == 0)
            //iCurrentMax=dt.Rows.Count;
            //if(iCurrentMax==0)
            //{
            //    Utils.showErrorMsg("Keine Daten mit dieser Auswahl vorhanden", "Fehler bei Gruppenauswahl");
            //    return;
            //}
            //LoggerClass.log("Slideshow started with " + iCurrentMax.ToString() + " articles...");
            //_sImageList = new string[dt.Rows.Count];
            //for (int i = 0; i < iCurrentMax; i++)
            //{                
            //    _sImageList[i] = dt.Rows[i]["foto"].ToString();
            //}

            //_timer.Enabled = true;
            //btnStart.Text="STOP";
        }
        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (dt != null)
            {
                if (_timer.Enabled)
                {
                    g.DrawString(dt.Rows[iCurrent]["ArtNr"].ToString(), new Font("Arial", 12), new SolidBrush(Color.DarkBlue), new Point(25, 25));
                    g.DrawString(dt.Rows[iCurrent]["Omschrijving"].ToString(), new Font("Arial", 12), new SolidBrush(Color.DarkBlue), new Point(25, 50));
                }
            }
        }

        private void FormSlideShow1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _settings.PasswortSchutzEin = chk_passwort.Checked;
            _settings.save();
        }
    }
}
