using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BiederDB3
{
    public partial class FormPublishForWeb : Form
    {
        bool _bListChange = false;
        bool _bAbbruch = false;
        bool _bStatus = true;
        StreamWriter swLog;

        dataclasses.Gruppentexte.gruppentext[] _gTexte;
        BiederDBSettings2 _settings;

        public FormPublishForWeb()
        {
            InitializeComponent();
            loadForm();
        }
        void loadForm()
        {
            _settings= new BiederDBSettings2();
            bt_view.Enabled = false;
            readGroups();
            Text1.Text = _settings.webKopf;
            Text2.Text = _settings.webRoot;
            Text3.Text = _settings.mainPage;
            File1._sPath = _settings.webRoot;
            loadList2();
            txt_StartSeite.Text = _settings.startSeite;
            if (txt_StartSeite.Text != "index.htm")
                Utils.showWarningMsg("Wenn Sie eine externe Datei als Hauptseite angeben, müssen Sie in diese einen Link auf die Datei 'index1.htm' einfügen, damit die generierten Webseiten erreichbar sind!", "ACHTUNG");
            farbe.read_colors();
        }

        void readGroups()
        {
            List1.Items.Clear();
            dataclasses.Gruppentexte gruppenTexte = new BiederDB3.dataclasses.Gruppentexte();
            _gTexte = gruppenTexte.getGruppenTexte();
            for (int i = 0; i < _gTexte.Length; i++)
                List1.Items.Insert(i, _gTexte[i]);

        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sRemoveDoubleEntries(ListBox ctlCompare, ListBox ctlResult)
        {
            int iRet = 0;
            int iFindDoubleItem = 0;
            int iRemoveToCompare = 0;
            for (iRemoveToCompare = 0; iRemoveToCompare < ctlResult.Items.Count; iRemoveToCompare++)
            {
                for (iFindDoubleItem = 0; iFindDoubleItem < ctlCompare.Items.Count; iFindDoubleItem++)
                {
                    Application.DoEvents();
                    if(ctlCompare.Items[iFindDoubleItem].ToString().Equals(ctlResult.Items[iRemoveToCompare].ToString()))
                    {
                        ctlResult.Items.RemoveAt(iRemoveToCompare);
                        iRemoveToCompare--;
                        iRet++;
                        continue;
                    }
                }
            }
            return iRet;
        }

        private void bt_copy_Click(object sender, EventArgs e)
        {
            if (List1.SelectedIndex == -1)
                return;
            List2.Items.Add(List1.SelectedItem);
        }

        private void bt_savelist_Click(object sender, EventArgs e)
        {
            string fileName = Utils.AppPath + "_publist.ini";
            dataclasses.Gruppentexte.gruppentext gText;
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                for (int ix = 0; ix < List2.Items.Count; ix++)
                {
                    gText = (dataclasses.Gruppentexte.gruppentext)List2.Items[ix];
                    sw.WriteLine(gText.GruppenName);
                    sw.WriteLine(gText.ID.ToString());
                }
            }
        }
        private void loadList2()
        {
            string fileName = Utils.AppPath + "_publist.ini";
            dataclasses.Gruppentexte.gruppentext gText;
            List2.Items.Clear();
            using (StreamReader sw = new StreamReader(fileName))
            {
                try
                {
                    string lineName;
                    do
                    {
                        lineName = sw.ReadLine();//gText.GruppenName
                        string lineID = sw.ReadLine();// (gText.ID.ToString());
                        if (lineID != null && lineName != null)
                        {
                            gText = new BiederDB3.dataclasses.Gruppentexte.gruppentext(lineName, int.Parse(lineID), lineName, 0);
                            List2.Items.Add(gText);
                        }
                    }while (lineName != null);
                }
                catch
                {
                }
            }
        }

        private void List2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (List2.SelectedIndex == -1)
                return;
            List2.Items.RemoveAt(List2.SelectedIndex);
            _bListChange = true;
        }

        private void List1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (List1.SelectedIndex == -1)
                return;

            if (List2.SelectedIndex == -1)
                List2.Items.Add(List1.SelectedItem);
            else
                if(List2.SelectedIndex>0)
                    List2.Items.Insert(List2.SelectedIndex - 1, List1.SelectedItem);
                else
                    List2.Items.Insert(List2.SelectedIndex, List1.SelectedItem);
            _bListChange = true;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            //List2 enthält die zu publizierenden Kategorien
            if (List2.Items.Count == 0)
            {
                Utils.showErrorMsg("Keine Gruppe(n) gewählt", "Für Web vorbereiten");
                return;
            }
            if (chk_nur1Gruppe.Checked && List2.SelectedIndex == -1)
            {
                Utils.showErrorMsg("Sie müssen eine Gruppe auswählen", "Für Web vorbereiten");
                return;
            }
            if (!System.IO.Directory.Exists(Text2.Text))
            {
                Utils.showErrorMsg("Kann Verzeichnis '" + Text2.Text + "' nicht finden!", "Für Web vorbereiten");
                return;
            }

            txt_status.Text = "Starte...";
            
            //open a file to log messages
            swLog = new StreamWriter(Utils.AppPath + "_status.log", false);

            int NumLoops, MaxArtikel, ArtikelProSeite, LeftOver;
            string SeiteZahl, beschreibung, foto, ArtNr, foto_th, masse;
            int s, AnzahlSeiten, Rest, Seite, Artikel;
            int nCount;

            string KategorieHtml;
            string ArtikelHtml;
            string LeftHtml;
            
            int i, file_kategorie, file_Artikel, file_left;

            int p;
            string PortalHtml;
            string[]PortalTexte;
            string StandardText;
            int f;
            string tmp;

            bt_view.Enabled = false;
            bt_AktuellBearbeiten.Enabled = false;

            if (!status("Abbruch"))
                goto abbruch;
            weblist.Items.Clear();

            //test output path
            if (!System.IO.Directory.Exists(Text2.Text))
            {
                Utils.showErrorMsg("Fehler: Kann Verzeichnis: " + Text2.Text + "' nicht finden", "Ausgabefehler");
                goto abbruch;
            }
            if(!Text2.Text.EndsWith("\\"))
                Text2.Text+="\\";

            _bAbbruch = false;
            if (!status("Weberstellung, " +
                DateTime.Now.ToShortDateString() +
                DateTime.Now.ToShortTimeString()))
                goto abbruch;

            bt_start.Enabled = false;
            bt_close.Enabled = false;
            bt_cancel.Enabled = true;
            
            if (chk_nur1Gruppe.Checked)
            {
                if (!status("Erstelle nur Dateien für die Gruppe: '" + List2.SelectedItem.ToString() + "' neu"))
                    goto abbruch;
            }
            else
            {
                //'Index-, Main- und Top-Datei kopieren
                DateiKopie(Utils.AppPath + "_topback.gif", Text2.Text + "_topback.gif");
                DateiKopie(Utils.AppPath + "_lftback.gif", Text2.Text + "_lftback.gif");
                DateiKopie(Utils.AppPath + "_mainback.gif", Text2.Text + "_mainback.gif");
                DateiKopie(Utils.AppPath + "_artback.gif", Text2.Text + "_artback.gif");
                DateiKopie(Utils.AppPath + "_weg.gif", Text2.Text + "_weg.gif");
                //'DateiKopie Utils.AppPath + "logo-falk.gif", Text2.text + "logo-falk.gif"
                DateiKopie(Utils.AppPath + "_index.htm", Text2.Text + _settings.startSeite);
                DateiKopie((Text3.Text), Text2.Text + "_main.htm");
                DateiKopie((Text1.Text), Text2.Text + "_top.htm");
                DateiKopie(Utils.AppPath + "_weg.htm", Text2.Text + "_weg.htm");
                //'Die linke Seite sollte mit dem Start-Link anfangen
                //'danach alle Kategorien listen. Das bedeutet eine index.htm, eine left.htm,
                //'eine main.htm, eine top.htm,

            LeftHtml = "";
            LeftHtml = "<html>" + "\r\n" + "<head>" + "\r\n" + "<title>" + "Der Biedermann - Landhausmöbel in Wuppertal" + "</title>" + "\r\n";
            LeftHtml = LeftHtml + "<meta http-equiv=" + "\"" + "Content-Type" + "\"" + " content=" + "\"" + "text/html; charset=ISO-8859-1" + "\"" + ">" + "\r\n";
            LeftHtml = LeftHtml + "<meta name=" + "\"" + "GENERATOR" + "\"" + " content=" + "\"" + "bieder.db (c)HJ Gode" + "\"" + ">" + "\r\n";
            LeftHtml = LeftHtml + _settings.keywords_htm + "\r\n" + "</head>";
            LeftHtml = LeftHtml + "<body bgcolor=" + "\"" + farbe.farben[farbe.left_bgcolor].html + "\"" + " text=" + "\"" + farbe.farben[farbe.left_txtcolor].html + "\"";
            if (_settings.bg_left)
                LeftHtml = LeftHtml + " background=" + "\"" + "_lftback.gif" + "\"";
            LeftHtml = LeftHtml + " link=" + "\"" + farbe.farben[farbe.left_link].html + "\"";
            LeftHtml = LeftHtml + " vlink=" + "\"" + farbe.farben[farbe.left_vlink].html + "\"";
            LeftHtml = LeftHtml + " alink=" + "\"" + farbe.farben[farbe.left_alink].html + "\"" + ">" + "\r\n";


            }


                    


        abbruch:
            swLog.Close();
            bt_start.Enabled = true;
            bt_close.Enabled = true;
            bt_cancel.Enabled = false;
            bt_view.Enabled = true;
            bt_AktuellBearbeiten.Enabled = true;

        }
        
        void DateiKopie(string sSrc, string sTrg){
            try{
                status("Kopiere '" + sSrc +"' nach '" + sTrg +"'");
                System.IO.File.Copy(sSrc, sTrg, true);
                weblist.Items.Add(System.IO.Path.GetFileName(sTrg));
            }
            catch(Exception ex){
                status("Kopieren fehlgeschlagen! " +ex.Message);
            }
        }

        bool status(String s)
        {
            Application.DoEvents();
            if (_bAbbruch)
            {
                txt_status.Text="Abbruch durch Anwender";
                _bStatus = false;
                return false;
            }
            txt_status.Text = s;
            if (swLog != null)
            {
                swLog.WriteLine(s);
                swLog.Flush();
            }
            return true;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            _bAbbruch = true;
        }
    }
}
