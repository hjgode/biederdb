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

        void _timer_Tick(object sender, EventArgs e)
        {
            if (chkOrderNormal.Checked)
            {
                if (System.IO.File.Exists(_sImageList[iCurrent]))
                {
                    try
                    {
                        if (img != null)
                        {
                            img.Dispose();
                            img = null;
                        }
                        img = Image.FromFile(_sImageList[iCurrent]);// "C:\\Applicaties\\Foto's artikelen\\Stoelen\\sto361.jpg");
                        System.Diagnostics.Debug.WriteLine("_timer_Tick with '" + _sImageList[iCurrent]);
                        pictureBox.Image = img;
                    }
                    catch(Exception ex) {
                        System.Diagnostics.Debug.WriteLine("Exception in _timer_Tick: " + _sImageList[iCurrent]);
                    }
                }
                iCurrent++;
                if (iCurrent == iCurrentMax)
                    iCurrent = 0;
            }
            else
            {
                int iNext = RandomNumber(0, iCurrentMax);
                pictureBox.Image = new Bitmap(_sImageList[iNext]);
            }
        }
        private void readData()
        {
            _screenSize = Screen.PrimaryScreen.Bounds;

            _passwordSchutz = _settings.PasswortSchutzEin;
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
            if (_timer.Enabled)
            {
                _timer.Enabled = false;
            }
            string sCmd="";
            if (chkSelectAll.Checked)
                sCmd = "SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID  where Artikel.Besteld>1;";
            else
                sCmd = "SELECT Artikel.*, Hoofdgroep.Hoofdgroep FROM Hoofdgroep RIGHT JOIN Artikel ON Hoofdgroep.Hgr_ID = Artikel.Hgr_ID  where Artikel.Besteld>1 AND Artikel.HGR_ID=" + ((dataclasses.Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem).ID.ToString() + ";";
            int iCount = 0;
            dt = db.getTable(sCmd);
            //ds = db.getDataset(sCmd, ref iCount);
            //if (iCount == 0)
            iCurrentMax=dt.Rows.Count;
            if(iCurrentMax==0)
            {
                Utils.showErrorMsg("Keine Daten mit dieser Auswahl vorhanden", "Fehler bei Gruppenauswahl");
                return;
            }
            LoggerClass.log("Slideshow started with " + iCurrentMax.ToString() + " articles...");
            _sImageList = new string[dt.Rows.Count];
            for (int i = 0; i < iCurrentMax; i++)
            {                
                _sImageList[i] = dt.Rows[i]["foto"].ToString();
            }
            
            _timer.Enabled = true;
        }
        private int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
