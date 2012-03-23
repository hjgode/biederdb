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
    public partial class FormGruppenSort : Form
    {
        Datenbank db;
        Gruppentexte _gruppen;
        public FormGruppenSort()
        {
            InitializeComponent();
            db = new Datenbank();
            loadData();
        }
        void loadData()
        {
            _gruppen = new Gruppentexte(ref db);

            List<Gruppentexte.gruppentext> liste = _gruppen.getGruppentexte();

            Gruppentexte.gruppentext[] _gruppentexte = liste.ToArray();

            cboGruppenAuswahl.Items.Clear();
            int iSort = 1;
            foreach (Gruppentexte.gruppentext g in _gruppentexte)
            {
                if(g.Sortorder==0)  //no SortOrder?
                    g.Sortorder=iSort++;
                cboGruppenAuswahl.Items.Add(g);
            }
            
            if(cboGruppenAuswahl.Items.Count>0)
                cboGruppenAuswahl.SelectedIndex = 0;
        }

        private void cboGruppenAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGruppenAuswahl.SelectedItem == null)
                return;
            Gruppentexte.gruppentext gCurrent = (Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem;
            System.Diagnostics.Debug.WriteLine("Selected: " + gCurrent.GruppenName + ": " + gCurrent.Sortorder.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int iCount = 0;
            foreach (Gruppentexte.gruppentext g in cboGruppenAuswahl.Items)
            {
                _gruppen.updateGruppeSortorder(g.ID, g.Sortorder);
                iCount++;
            }
            Utils.showInfoMsg(iCount.ToString() + " Gruppen gespeichert", "Gruppen sortieren");
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int idx = cboGruppenAuswahl.SelectedIndex;
            if (idx < 1)
                return;
            Gruppentexte.gruppentext g = (Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem;
            cboGruppenAuswahl.Items.RemoveAt(idx);
            g.Sortorder = idx - 1;
            cboGruppenAuswahl.Items.Insert(idx - 1, g);
            cboGruppenAuswahl.SelectedIndex = idx - 1;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int idx = cboGruppenAuswahl.SelectedIndex;
            if (idx == cboGruppenAuswahl.Items.Count-1)
                return;
            Gruppentexte.gruppentext g = (Gruppentexte.gruppentext)cboGruppenAuswahl.SelectedItem;
            cboGruppenAuswahl.Items.RemoveAt(idx);
            g.Sortorder = idx + 1;
            cboGruppenAuswahl.Items.Insert(idx + 1, g);
            cboGruppenAuswahl.SelectedIndex = idx+1;
        }

    }
}
