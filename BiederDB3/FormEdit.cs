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
        /// <summary>
        /// current artikel data
        /// </summary>
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
            db = new Datenbank();

            //read Gruppentexte for artikel assignment
            _gTexts = new Gruppentexte();

            lstHgr_Id.Items.Clear();
            foreach (Gruppentexte.gruppentext g in _gTexts.getGruppentexte())
            {
                lstHgr_Id.Items.Add(g);
            }
            lstHgr_Id.Items.Insert(0, new Gruppentexte.gruppentext("Nicht zugeordnet", -1, "Nicht zugeordnet", 0));
            lstHgr_Id.SelectedIndex = 0;

            //read Gruppentexte for selection
            lstGroups.Items.Clear();
            foreach (Gruppentexte.gruppentext g in _gTexts.getGruppentexte())
            {
                lstGroups.Items.Add(g);
                LoggerClass.log("Added Hofdgroep: '" + g.GruppenName + "', " + g.ID.ToString());
            }
            lstGroups.Items.Insert(0, new Gruppentexte.gruppentext("Alle", -1, "Alle", 0));
            lstGroups.SelectedIndex = 0;

            //read artikel
            _artikelClass = new Artikel();
            _artikelListe = _artikelClass.getArtikel(-1);

            if (_artikelListe.Count > 0)
            {
                _artikel = _artikelListe[iCurrent];
                //readData();
            }
            else
                this.Enabled = false;

            bIsStarting = false;
            DataChanged( false);
        }
        void readData(){
            txtArtNr.Text = _artikel.ArtNr;
            txtBesteld.Text = _artikel.Besteld.ToString();
            txtBewerkt.Text = _artikel.Bewerkt.ToString();
            chkBewerkt.Checked = _artikel.Bewerkt;
            txtFoto.Text = _artikel.Foto;
            pictFoto.Image = new Bitmap(txtFoto.Text);
            txtHgrId.Text = _artikel.Hgr_ID.ToString();

            lstHgr_Id.SelectedIndex = selectHgrIdList(_artikel.Hgr_ID);
            
            txtHPrijsBew.Text = _artikel.H_PrijsBew.ToString();
            txtHPrijsOnb.Text = _artikel.H_PrijsOnb.ToString();
            txtPrijsBew.Text = _artikel.W_PrijsBew.ToString();
            txtPrijsOnb.Text = _artikel.W_PrijsOnb.ToString();

            txtOmschrijving.Text = _artikel.Omschrijving;
            txtMaat.Text = _artikel.Maat;

            statusArtID.Text = _artikel.Art_ID.ToString();
            this.ValidateChildren();
            
            doValidate(this);
            
            DataChanged(false);
        }
        int selectHgrIdList(int hgrid)
        {
            int iRet=0;
            for (int i=0; i<lstHgr_Id.Items.Count; i++)
            {
                Gruppentexte.gruppentext g = (Gruppentexte.gruppentext)lstHgr_Id.Items[i];
                if (g.ID == hgrid)
                {
                    return i;
                }
            }
            return iRet;
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
            _artikel.Hgr_ID = int.Parse(txtHgrId.Text, System.Globalization.CultureInfo.CurrentCulture);
            DataChanged(true);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!doValidate(this))
            {
                Utils.showInfoMsg("Eingabefehler korrigieren", "Daten speichern");
                return;
            }
            if (_artikelClass.update(_artikel) > 0)
                Utils.showInfoMsg("Datensatz gespeichert", "Daten speichern");
            else
                Utils.showErrorMsg("Kein Datensatz gespeichert", "Daten speichern");

            DataChanged(false);
            
        }

        private void txtPrijsOnb_Validated(object sender, EventArgs e)
        {
            //_artikel.W_PrijsOnb = Single.Parse(txtPrijsOnb.Text);
            DataChanged(true);
        }

        private void txtPrijsBew_Validated(object sender, EventArgs e)
        {
            _artikel.W_PrijsBew = Single.Parse(txtPrijsBew.Text);
            DataChanged(true);
        }

        private void txtOmschrijving_Validated(object sender, EventArgs e)
        {
            _artikel.Omschrijving = txtOmschrijving.Text;
            DataChanged(true);
        }

        private void txtBesteld_Validated(object sender, EventArgs e)
        {
            _artikel.Besteld = Single.Parse(txtBesteld.Text);
            DataChanged(true);
        }

        private void txtBewerkt_Validated(object sender, EventArgs e)
        {
            if (chkBewerkt.Checked)
                _artikel.Bewerkt = true;
            else
                _artikel.Bewerkt = false;
            DataChanged(true);
        }

        private void txtMaat_Validated(object sender, EventArgs e)
        {
            _artikel.Maat = txtMaat.Text;
            DataChanged(true);
        }

        private void txtFoto_Validated(object sender, EventArgs e)
        {
            _artikel.Foto = txtFoto.Text;
            DataChanged(true);
        }

        private void chkBewerkt_Validated(object sender, EventArgs e)
        {
            _artikel.Bewerkt = chkBewerkt.Checked;
            DataChanged(true);
        }
        void DataChanged(bool bChanged)
        {
            if (bChanged)
            {
                statusDataChanged.Text = "geändert";
                statusDataChanged.BackColor = Color.LightPink;
            }
            else
            {
                statusDataChanged.Text = "unverändert";
                statusDataChanged.BackColor = Color.LightGreen;
            }
            bDataChanged = bChanged;
        }
        bool doValidate(Control ctrl)
        {
            bool bRet = true;
            if (ctrl == null)
                ctrl = this;
            foreach (Control c in ctrl.Controls)
            {
                if (c.HasChildren)
                    return doValidate(c);
                if (c is TextBox)
                {
                    if (c.Name.Contains("Prijs"))
                    {
                        try
                        {
                            Single s = Single.Parse(c.Text);
                            c.BackColor = Color.LightGreen;
                        }
                        catch (Exception)
                        {
                            c.BackColor = Color.LightPink;
                            return false;
                        }
                    }
                    else
                        c.BackColor = Color.LightGreen;
                }
            }
            return bRet;
        }
    }
}
