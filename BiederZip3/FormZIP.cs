using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BiederZip3
{
    public partial class FormZIP : Form
    {
        BiederDB3.BiederDBSettings2 _settings;

        public FormZIP()
        {
            InitializeComponent();
            _settings = new BiederDB3.BiederDBSettings2();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text1.Text))
                return;
            if (List1.SelectedIndex == -1)
            {
                List1.Items.Add(Text1.Text);
            }
            else
            {
                List1.Items.Insert(List1.SelectedIndex + 1, Text1.Text);
                List1.SelectedIndex = List1.SelectedIndex + 1;
            }

        }

        private void bt_autofill_Click(object sender, EventArgs e)
        {
            //Dim db As Database
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            List1.Items.Clear();
            List1.Items.Add(_settings.datenbank);
            
            List1.Items.Add((_settings.webRoot + "\\*.*"));
            List1.Items.Add((BiederDB3.Utils.AppPath + "*.*"));

            BiederDB3.Datenbank _db = new BiederDB3.Datenbank();
            int iResult = _db.executeQuery("Drop table VList;");
            iResult = _db.executeQuery("SELECT DISTINCT FOTO INTO VList FROM Artikel where Besteld>0");
            //DataTable _dt = _db.getTable("SELECT DISTINCT FOTO INTO VList FROM Artikel where Besteld>0");
            BiederDB3.dataclasses.VList _vlist = new BiederDB3.dataclasses.VList();
            BiederDB3.dataclasses.VList.vlist[] vListe = _vlist.getVList("");
            int RecordCount = vListe.Length;
            
            for (int i = 0; i < RecordCount; i++)
            {
                string sFoto ="";
                try 
	            {
                    sFoto = vListe[i].Foto;
	            }
	            catch (Exception)
	            {
	            }
                if (sFoto.Length > 0)
                {
                    string t = System.IO.Path.GetFullPath(sFoto);
                    if(!t.EndsWith("\\"))
                        t+="\\";
                    //t = GetPfad(VList.Fields("Foto").Value);
                    vListe[i].Foto=t;
                    _vlist.update(vListe[i]);
                }
            }
            //VList = db.CreateDynaset("SELECT DISTINCT FOTO FROM VList order by FOTO");
            //VList.MoveLast();
            //VList.MoveFirst();
            for (int i = 0; i < RecordCount; i++)
            {
                if (vListe[i].Foto.Length > 0)
                    List1.Items.Add(vListe[i].Foto + "*.*");
            }
//            VList.Close();
            Cursor = System.Windows.Forms.Cursors.Default;
//            db.Close();

        }
    }
}
