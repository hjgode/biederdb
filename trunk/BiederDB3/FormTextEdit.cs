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
    public partial class FormTextEdit : Form
    {
        public FormTextEdit()
        {
            InitializeComponent();
        }

        private void FormTextEdit_Load(object sender, EventArgs e)
        {
            string s = Utils.replaceBRbyCR(Utils.getFileContent("Der_Biedermann.txt"));
            txtEdit.Text = Utils.specialDecode(s);
        }

        private void btn_Standard_Click(object sender, EventArgs e)
        {
            GlobalSettings.settings _s = new GlobalSettings.settings();
            _s.read();
            txtEdit.Text = Utils.replaceBRbyCR(_s.der_biedermann_default);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            string s = Utils.replaceCRbyBR(txtEdit.Text);
            s = Utils.specialEncode(s);
            if (Utils.putFileContent("Der_Biedermann.txt", s))
                MessageBox.Show("Datei gespeichert", "Der_Biedermann.txt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Datei speichern fehlgeschlagen", "Der_Biedermann.txt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
