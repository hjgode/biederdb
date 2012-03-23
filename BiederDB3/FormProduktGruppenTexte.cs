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
    public partial class FormProduktGruppenTexte : Form
    {
        Datenbank db;
        Gruppentexte gTexte;
        bool bIsStart = true;
        bool bTextChanged = false;

        public FormProduktGruppenTexte()
        {
            InitializeComponent();
            loadDefaultText();
            loadData();
            bIsStart = false;
        }
        void loadDefaultText()
        {
            string s = Utils.getFileContent("stdgrp.txt");
            if (s.Length == 0)
                txtStandardGruppentext.Text = "Auf den Produktübersichtseiten finden Sie im oberen Bereich Zahlen für die einzelnen Seiten.\r\nKlicken Sie auf die Seitenzahlen, um zwischen den Seiten zu wechseln.\r\nDie Produktübersichtseiten enthalten kleine Abbildungen und Texte dazu." + "\r\n" +
                    "Klicken Sie auf eine Abbildung, um das Produktbild zu vergrössern.";
            else
                txtStandardGruppentext.Text = s;
        }
        void loadData()
        {
            db = new Datenbank();
            gTexte = new Gruppentexte(ref db);

            List<Gruppentexte.gruppentext> liste = gTexte.getGruppentexte();

            Gruppentexte.gruppentext[] _gruppentexte = liste.ToArray();

            foreach (Gruppentexte.gruppentext g in _gruppentexte)
                cboGruppenAuswahl.Items.Add(g);
            
            cboGruppenAuswahl.SelectedIndex = 0;
        }

        private void cboGruppenAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gruppentexte.gruppentext gCurrent = (Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem;
            if (bTextChanged)
                if(! Utils.showQuestionYesNo("Text geändert. Verwerfen?", "Gruppentext für " + gCurrent.GruppenName))
                    return;

            //read data for selected group
            txtGroupActive.Text = gCurrent.GruppenName;
            txtGroupActiveID.Text = gCurrent.ID.ToString();
            txtGruppeText.Text = gCurrent.Gruppentext;
            bTextChanged=false;
        }

        private void btnSaveGruppentext_Click(object sender, EventArgs e)
        {
            Gruppentexte.gruppentext gCurrent = (Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem;
            
            int iRes = gTexte.updateGruppe(gCurrent.ID, txtGruppeText.Text);

            if (iRes > 0)
            {
                Utils.showInfoMsg("Erfolgreich gespeichert", "Gruppentext für " + gCurrent.GruppenName);
                gCurrent.Gruppentext = txtGruppeText.Text;  //local update
            }
            else
                Utils.showErrorMsg("Fehler beim Speichern", "Gruppentext für " + gCurrent.GruppenName);
            bTextChanged = false;
        }

        private void btnSaveStandardText_Click(object sender, EventArgs e)
        {
            if(Utils.putFileContent("stdgrp.txt", txtStandardGruppentext.Text))
            {
                Utils.showInfoMsg("Erfolgreich gespeichert", "Standard Gruppentext");
            }
            else
                Utils.showErrorMsg("Fehler beim Speichern", "Standard Gruppentext");
        }
        private void txtGruppeText_TextChanged(object sender, EventArgs e)
        {
            if (bIsStart)
                return;
            bTextChanged = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(bTextChanged)
                if (!Utils.showQuestionYesNo("Text geändert. Verwerfen?", "Änderungen verwerfen?"))
                    return;
            this.Close();
        }
    }
}
