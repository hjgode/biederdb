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
    public partial class FormMain : Form
    {
        //GlobalSettings global;
        BiederDBSettings2 _settings;
        public FormMain()
        {
            InitializeComponent();
            //GlobalSettings.settings _settings = new GlobalSettings.settings();
            //_settings.read();
            _settings = new BiederDBSettings2();
            if (_settings.bPathValidated != 0)
            {
                FormOptions frm = new FormOptions(ref _settings);
                frm.ShowDialog();
                if ( _settings.bPathValidated!=0)
                {
                    Utils.showWarningMsg("Kann nicht ohne korrekte Einstellungen weiter", "Options ungültig");
                    Application.Exit();
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuSettings_Click(object sender, EventArgs e)
        {
            _settings = new BiederDBSettings2();
            FormOptions fo = new FormOptions(ref _settings);
            fo.ShowDialog();
            fo.Dispose();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            ab1.ShowDialog();
        }

        private void mnuGroupTextEdit_Click(object sender, EventArgs e)
        {
            FormProduktGruppenTexte frm = new FormProduktGruppenTexte();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void mnuGroupRename_Click(object sender, EventArgs e)
        {
            FormGruppenNamen frm = new FormGruppenNamen();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void mnuGroupDelete_Click(object sender, EventArgs e)
        {
            FormGruppenRemove frm = new FormGruppenRemove();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void mnuGroupSort_Click(object sender, EventArgs e)
        {
            FormGruppenSort frm = new FormGruppenSort();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void mnuWebCleanup_Click(object sender, EventArgs e)
        {

        }

        private void btnDataEdit_Click(object sender, EventArgs e)
        {
            FormEdit  frm = new FormEdit();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnDiaShow_Click(object sender, EventArgs e)
        {
            FormSlideShow1 frm = new FormSlideShow1();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void mnuColors_Click(object sender, EventArgs e)
        {
            FormFarben frm = new FormFarben();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnPublish2Web_Click(object sender, EventArgs e)
        {
            FormPublishForWeb frm = new FormPublishForWeb();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {

        }
    }
}
