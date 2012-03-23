using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BiederDB3.dataclasses;

namespace BiederDB3
{
    public partial class FormGruppenRemove : Form
    {
        Datenbank db;
        Gruppentexte _gruppen;
        Artikel _artikel;

        public FormGruppenRemove()
        {
            InitializeComponent();
            db = new Datenbank();
            loadData();
        }

        void loadData()
        {
            _gruppen = new Gruppentexte(ref db);
            _artikel = new Artikel(ref db);

            List<Gruppentexte.gruppentext> liste = _gruppen.getGruppentexte();

            Gruppentexte.gruppentext[] _gruppentexte = liste.ToArray();

            cboGruppenAuswahl.Items.Clear();

            foreach (Gruppentexte.gruppentext g in _gruppentexte)
                cboGruppenAuswahl.Items.Add(g);

            cboGruppenAuswahl.SelectedIndex = 0;
        }

        private void cboGruppenAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Artikel.artikel> artikel =  _artikel.getArtikel(((Gruppentexte.gruppentext)(cboGruppenAuswahl.SelectedItem)).ID);
            txtNumberOfRecords.Text = (artikel.Count).ToString();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (Utils.showQuestionYesNo("Sind Sie sicher, dass Sie alle diese Artikel löschen wollen", txtNumberOfRecords.Text + " Daten werden gelöscht"))
            {
                _artikel.deleteArtikel(((Gruppentexte.gruppentext)(cboGruppenAuswahl.SelectedItem)).ID);
                //update form
                List<Artikel.artikel> artikel = _artikel.getArtikel(((Gruppentexte.gruppentext)(cboGruppenAuswahl.SelectedItem)).ID);
                txtNumberOfRecords.Text = (artikel.Count).ToString();
            }
            
        }
        private void deleteData()
        {
            if (Utils.showQuestionYesNo("Sind Sie sicher, dass Sie diese Gruppe löschen wollen",
                ((Gruppentexte.gruppentext)(cboGruppenAuswahl.SelectedItem)).GruppenName + " Daten werden gelöscht"))
            {
                _gruppen.deleteGruppe(((Gruppentexte.gruppentext)(cboGruppenAuswahl.SelectedItem)).ID);
                cboGruppenAuswahl.Items.Remove(cboGruppenAuswahl.SelectedItem);
            }
        }

        private void txtNumberOfRecords_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfRecords.Text == "0")
            {
                btnDeleteGroup.Enabled = true;
                btnDeleteData.Enabled = false;
            }
            else
            {
                btnDeleteData.Enabled = true;
                btnDeleteGroup.Enabled = false;
            }
        }
    }
}
