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
    public partial class FormGruppenNamen : Form
    {
        Datenbank db;
        Gruppentexte gTexte;
        bool bIsStart = true;
        bool bTextChanged = false;

        public FormGruppenNamen()
        {
            InitializeComponent();
            loadData();
            bIsStart = false;
        }
        void loadData()
        {
            if (bIsStart)
            {
                db = new Datenbank();
                gTexte = new Gruppentexte(ref db);
            }

            List<Gruppentexte.gruppentext> liste = gTexte.getGruppentexte();

            Gruppentexte.gruppentext[] _gruppentexte = liste.ToArray();
            
            cboGruppenAuswahl.Items.Clear();
            
            foreach (Gruppentexte.gruppentext g in _gruppentexte)
                cboGruppenAuswahl.Items.Add(g);

            cboGruppenAuswahl.SelectedIndex = 0;
        }

        private void cboGruppenAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gruppentexte.gruppentext gCurrent = (Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem;
            if (bTextChanged)
                if (!Utils.showQuestionYesNo("Text geändert. Verwerfen?", "Gruppentext für " + gCurrent.GruppenName))
                    return;

            //read data for selected group
            txtGruppeText.Text = gCurrent.GruppenName;
            bTextChanged = false;
            btnRename.Enabled = false;
        }

        private void txtGruppeText_TextChanged(object sender, EventArgs e)
        {
            if (bIsStart)
                return;
            bTextChanged = true;
            btnRename.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (bTextChanged)
                if (!Utils.showQuestionYesNo("Text geändert. Verwerfen?", "Änderungen verwerfen?"))
                    return;
            this.Close();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            int iSelected = cboGruppenAuswahl.SelectedIndex;

            Gruppentexte.gruppentext gCurrent = (Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem;

            int iRes = gTexte.updateGruppenName(gCurrent.ID, txtGruppeText.Text);

            if (iRes > 0)
            {
                Utils.showInfoMsg("Erfolgreich gespeichert", "Gruppentext für " + gCurrent.GruppenName);
                bTextChanged = false;    //avoid change notification
                gCurrent.GruppenName = txtGruppeText.Text;  //local update
                cboGruppenAuswahl.Items[iSelected] = gCurrent;
                cboGruppenAuswahl.Refresh();
                
            }
            else
                Utils.showErrorMsg("Fehler beim Speichern", "Gruppentext für " + gCurrent.GruppenName);
            bTextChanged = false;

        }
    }
}
