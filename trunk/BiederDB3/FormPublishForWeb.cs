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
            bool bAbbruch = false;
            
            StreamWriter swLog = new StreamWriter(Utils.AppPath + "_status.log", false);

            if (status("Abbruch"))
                goto abbruch;
            weblist.Items.Clear();

        abbruch:
            swLog.Close();
        }
        bool status(String s)
        {
            bool bRet = false;
            return bRet;
        }
    }
}
