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
    public partial class FormEdit : Form
    {
        Datenbank db;
        Artikel _artikelClass;
        Artikel.artikel _artikel;
        List<Artikel.artikel> _artikelListe = new List<Artikel.artikel>();
        BiederDBSettings2 _settings = new BiederDBSettings2();
        Gruppentexte _gTexts;
        int iCurrent = 0;
        bool bDataChanged = false;
        bool bIsStarting = true;
        public FormEdit()
        {
            InitializeComponent();
            _gTexts = new Gruppentexte();

            lstHgr_Id.Items.Clear();
            foreach (Gruppentexte.gruppentext g in _gTexts.getGruppentexte())
            {
                lstHgr_Id.Items.Add(g);
            }
            //lstHgr_Id.Items.Insert(0, new Gruppentexte.gruppentext("Alle", -1, "Alle", 0));
            lstHgr_Id.SelectedIndex = 0;

            lstGroups.Items.Clear();
            foreach (Gruppentexte.gruppentext g in _gTexts.getGruppentexte())
            {
                lstGroups.Items.Add(g);
                LoggerClass.log("Added Hofdgroep: '" + g.GruppenName + "', " + g.ID.ToString());
            }
            lstGroups.Items.Insert(0, new Gruppentexte.gruppentext("Alle", -1, "Alle", 0));
            lstGroups.SelectedIndex = 0;

            db = new Datenbank();
            _artikelClass = new Artikel();
            _artikelListe = _artikelClass.getArtikel(-1);

            if (_artikelListe.Count > 0)
            {
                _artikel = _artikelListe[iCurrent];
                readData();
            }
            else
                this.Enabled = false;
            bIsStarting = false;
            bDataChanged = false;
        }
        void readData(){
            txtArtNr.Text = _artikel.ArtNr;
            txtBesteld.Text = _artikel.Besteld.ToString();
            txtBewerkt.Text = _artikel.Bewerkt.ToString();
            chkBewerkt.Checked = _artikel.Bewerkt;
            txtFoto.Text = _artikel.Foto;
            pictFoto.Image = new Bitmap(txtFoto.Text);
            txtHgrId.Text = _artikel.Hgr_ID.ToString();

            Gruppentexte.gruppentext g = _gTexts.getGruppe(_artikel.Hgr_ID);
            if(g.ID!=-1)
                lstHgr_Id.SelectedIndex = lstHgr_Id.Items.IndexOf(g);
            
            txtHPrijsBew.Text = _artikel.H_PrijsBew.ToString();
            txtHPrijsOnb.Text = _artikel.H_PrijsOnb.ToString();
            txtPrijsBew.Text = _artikel.W_PrijsBew.ToString();
            txtPrijsOnb.Text = _artikel.W_PrijsOnb.ToString();

            txtOmschrijving.Text = _artikel.Omschrijving;
            txtMaat.Text = _artikel.Maat;          

        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            if (iCurrent < _artikelListe.Count - 1)
            {
                _artikel = _artikelListe[++iCurrent];
                readData();
            }
        }

        private void btnMoveBack_Click(object sender, EventArgs e)
        {
            if (iCurrent > 0)
            {
                _artikel = _artikelListe[--iCurrent];
                readData();
            }
        }

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gruppentexte.gruppentext g = (Gruppentexte.gruppentext)lstGroups.SelectedItem;
            _artikelClass = new Artikel();
            _artikelListe = _artikelClass.getArtikel(g.ID);

            if (_artikelListe.Count > 0)
            {
                _artikel = _artikelListe[iCurrent];
                readData();
            }
            else
                Utils.showInfoMsg("Keine Artikel gefunden", "Daten bearbeiten");

        }

        private void lstHgr_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bIsStarting || lstHgr_Id.SelectedIndex==-1)
                return;
            txtHgrId.Text = ((Gruppentexte.gruppentext)(lstHgr_Id.SelectedItem)).ID.ToString();
            bDataChanged = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (bDataChanged)
            {
                if (Utils.showQuestionYesNo("Daten geändert. Erst speichern?", "Daten bearbeiten"))
                    saveData(); //save data
            }
            this.Close();
        }
        private void saveData()
        {
        }
    }
}
