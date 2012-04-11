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
    public partial class FormOptions : Form
    {
//        GlobalSettings global;
//        GlobalSettings.settings _settings;
        BiederDBSettings2 _settings;
        private string lastDir = "";
        public FormOptions(ref BiederDBSettings2 theSettings)
        {
            InitializeComponent();

            Datenbank db = new Datenbank();
            foreach (string s in db.getFieldNames("Artikel"))
            {
                cboSortList.Items.Add(s);
            }

            _settings = theSettings;

            lastDir = Utils.AppPath;

            txtDatabase.Text = _settings.datenbank;
            txtWebDir.Text = _settings.webRoot;
            
            txtSortField.Text = _settings.sortField;
            int ix = cboSortList.Items.IndexOf(_settings.sortField);
            if (ix != -1)
                cboSortList.SelectedIndex = ix;

            txtWebHead.Text = _settings.webKopf;
            txtWebStart.Text = _settings.mainPage;
            txtIviewExe.Text = _settings.iview;

            optionArtikel.Checked = _settings.bg_artikel;
            optionLinks.Checked = _settings.bg_left;
            optionMain.Checked = _settings.bg_main;
            optionOben.Checked = _settings.bg_top;

            txtCustomIndexFile.Text = _settings.startSeite;
            if (txtCustomIndexFile.Text != "index.htm")
            {
                radioExtern.Checked = true;
                _settings.UseCustomIndexFile = true;
                radioIntern.Checked = false;
                txtCustomIndexFile.Enabled = true;
            }
            else
                txtCustomIndexFile.Enabled = false;

            numDiaTimeout.Value = _settings.showTime;

            txtDatabase.Validating += new CancelEventHandler(txtFileName_Validating);
            txtWebHead.Validating += new CancelEventHandler(txtFileName_Validating);
            txtWebStart.Validating += new CancelEventHandler(txtFileName_Validating);
            txtWebDir.Validating += new CancelEventHandler(txtFileName_Validating);
            txtIviewExe.Validating += new CancelEventHandler(txtFileName_Validating);
            
            this.ValidateChildren();
            //_settings.save();
        }

        void txtFileName_Validating(object sender, CancelEventArgs e)
        {
            TextBox tBox = (TextBox)sender;
            if (_settings.bIsValidFile(tBox.Text))
                tBox.BackColor = Color.LightGreen;
            else
                tBox.BackColor = Color.LightPink;
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.InitialDirectory = lastDir;
            fd.Filter = "MS Access (*.mdb)|*.mdb";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtDatabase.Text = fd.FileName;
                lastDir = System.IO.Path.GetDirectoryName(fd.FileName);
            }
            fd.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _settings.datenbank = txtDatabase.Text;
            _settings.webRoot = txtWebDir.Text;
            _settings.sortField = txtSortField.Text;
            _settings.webKopf = txtWebHead.Text;
            _settings.mainPage = txtWebStart.Text;
            _settings.iview = txtIviewExe.Text;
            _settings.bg_artikel = optionArtikel.Checked;
            _settings.bg_left = optionLinks.Checked;
            _settings.bg_main = optionMain.Checked;
            _settings.bg_top = optionOben.Checked;
            _settings.showTime = (int)numDiaTimeout.Value;

            _settings.startSeite = txtCustomIndexFile.Text;

            if (radioExtern.Checked)
                _settings.UseCustomIndexFile = true;
            else
                _settings.UseCustomIndexFile = false;

            _settings.save();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        private void btnWebexportDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowNewFolderButton = false;
            fd.RootFolder = Environment.SpecialFolder.MyComputer;// 
            fd.SelectedPath = lastDir;
            if (fd.ShowDialog() == DialogResult.OK)
                txtWebDir.Text = fd.SelectedPath;
            lastDir = System.IO.Path.GetDirectoryName(fd.SelectedPath);
            fd.Dispose();
        }

        private void btnWebHead_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.InitialDirectory = Utils.AppPath;
            fd.Filter = "Web Seite (*.htm)|*.htm";
            if (fd.ShowDialog() == DialogResult.OK)
                txtWebHead.Text = fd.FileName;
            lastDir = System.IO.Path.GetDirectoryName(fd.FileName);
            fd.Dispose();
        }

        private void btnWebStart_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.InitialDirectory = Utils.AppPath;
            fd.Filter = "Web Seite (*.htm)|*.htm";
            if (fd.ShowDialog() == DialogResult.OK)
                txtWebStart.Text = fd.FileName;
            lastDir = System.IO.Path.GetDirectoryName(fd.FileName);
            fd.Dispose();

        }

        private void btnIview_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();            
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.InitialDirectory = Utils.AppPath;
            fd.Filter = "IrvanView Programm (iview.exe)|iview.exe|Programme (*.exe)|*.exe";
            if (fd.ShowDialog() == DialogResult.OK)
                txtIviewExe.Text = fd.FileName;
            lastDir = System.IO.Path.GetDirectoryName(fd.FileName);
            fd.Dispose();

        }

        private void btnArtikelKopfText_Click(object sender, EventArgs e)
        {
            FormTextEdit ft = new FormTextEdit();
            ft.ShowDialog();
            ft.Dispose();
        }

        private void cboSortList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSortField.Text = cboSortList.Items[cboSortList.SelectedIndex].ToString();
        }

        private void radioIntern_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomIndexFile.Enabled = !radioIntern.Checked;
        }

        private void radioExtern_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomIndexFile.Enabled = radioExtern.Checked;
        }
    }
}
