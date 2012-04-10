using System;
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
            fillFileList(File1, _settings.webRoot);
        }
        void fillFileList(ListBox listBox, string path)
        {
            listBox.Items.Clear();
            xxxxx
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
        void sRemoveDoubleEntries(ListBox ctlCompare, ListBox ctlResult)
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
                        continue;
                    }
                }
            }
        }
    }
}
