using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.OleDb;
using System.Data;

namespace BiederDB3.dataclasses
{
    public class Artikel:IDisposable
    {
        Datenbank db;
        bool bNewDB = false;
        BiederDBSettings2 _settings = new BiederDBSettings2();
        public Artikel()
        {
            db = new Datenbank();
            bNewDB = true;
        }
        public Artikel(ref Datenbank datenbank)
        {
            db = datenbank;
        }
        public void Dispose()
        {
            if (bNewDB)
                db.Dispose();
        }
        //artikel table
        public class artikel
        {
            public string ArtNr;        // string 30
            public string Omschrijving;
            public Single H_PrijsOnb;
            public Single H_PrijsBew;
            public Single W_PrijsOnb;
            public Single W_PrijsBew;
            public Single Besteld;      // marker if publish to web or not
            public string Maat;         // string 25
            public string Foto;         // string 80
            public bool Bewerkt;
            public int Hgr_ID;
            public int Art_ID;
            public artikel(string artnr, string beschreibung, 
                Single h_prijsOnb, Single h_prijsBew, Single w_prijsOnb, Single w_prijsBew,
                Single besteld, string maat, string foto, bool bewerkt, int hgr_id, int art_id)
            {
                ArtNr = artnr;
                Omschrijving = beschreibung;
                H_PrijsOnb = h_prijsOnb;
                H_PrijsBew = h_prijsBew;
                W_PrijsOnb = w_prijsOnb;
                Besteld = besteld;
                Maat = maat;
                Foto = foto;
                Bewerkt = bewerkt;
                Hgr_ID = hgr_id;
                Art_ID = art_id;
            }
            public artikel(string artnr, string beschreibung, string foto, int hgr_id, int art_id)
            {
                Art_ID = art_id;
                Hgr_ID = hgr_id;
                ArtNr = artnr;
                Omschrijving = beschreibung;
                Foto = foto;
                H_PrijsBew = 0;
                H_PrijsOnb = 0;
                W_PrijsBew = 0;
                W_PrijsOnb = 0;
                Maat = "";
                Bewerkt = false;
                Besteld = 0;
            }
        }

        public int update(Artikel.artikel _artikel1){
            int iRet=0;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = db._connection;
            try
            {
                System.Globalization.CultureInfo myInfo = System.Globalization.CultureInfo.InvariantCulture;
                cmd.CommandText = "update Artikel set " +
                    "ArtNr='" + _artikel1.ArtNr + "', " +
                    "Omschrijving='" + _artikel1.Omschrijving + "', " +
                    "H_PrijsOnb=" + _artikel1.H_PrijsOnb.ToString(myInfo) + ", " +
                    "H_PrijsBew=" + _artikel1.H_PrijsBew.ToString(myInfo) + ", " +
                    "W_PrijsOnb=" + _artikel1.W_PrijsOnb.ToString(myInfo) + ", " +
                    "W_PrijsBew=" + _artikel1.W_PrijsBew.ToString(myInfo) + ", " +
                    "Besteld=" + _artikel1.Besteld.ToString("0") + ", " +

                    "Maat='" + _artikel1.Maat + "', " +
                    "Foto='" + _artikel1.Foto.Replace("'", "''") + "', " +
                    "Bewerkt=" + _artikel1.Bewerkt.ToString() + ", " +
                    "Hgr_ID=" + _artikel1.Hgr_ID.ToString("0") + " " +

                    " WHERE Art_ID=" + _artikel1.Art_ID.ToString() + ";";

                int iCount = cmd.ExecuteNonQuery();
                iRet = iCount;
            }
            catch (Exception ex)// {"Syntax error (missing operator) in query expression ''C:\\Applicaties\\Foto's artikelen\\Kasten\\wit032.jpeg', Bewerkt=False, Hgr_ID=58  WHERE Art_ID=2241;'."}
            {
                LoggerClass.log("Datenbank: updateArtikel. Exception: " + ex.Message);
            }

            return iRet;
        }
        public DataSet getDataset(string sFilter)
        {
            DataSet ds = new DataSet();
            if (!db.connected)
                db.doConnect();
            try
            {
                //test for SortOrder field
                OleDbCommand cmd;
                OleDbDataAdapter da = new OleDbDataAdapter();
                if (sFilter != "")
                    cmd = new OleDbCommand("SELECT * from Artikel Where Hgr_Id='" + sFilter + "' order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);
                else
                    cmd = new OleDbCommand("SELECT * from Artikel order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);

                LoggerClass.log("Executing: " + cmd.CommandText);

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getTable. Exception: " + ex.Message);
            }
            return ds;
        }

        public DataTable getTable(string sFilter)
        {
            DataTable dt = new DataTable();
            if (!db.connected)
                db.doConnect();
            try
            {
                //test for SortOrder field
                OleDbCommand cmd;
                OleDbDataAdapter da= new OleDbDataAdapter();
                //DataSet ds = new DataSet();
                if(sFilter!="")
                    cmd = new OleDbCommand("SELECT * from Artikel Where Hgr_Id='" + sFilter + "' order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);
                else
                    cmd = new OleDbCommand("SELECT * from Artikel order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);

                LoggerClass.log("Executing: " + cmd.CommandText);

                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getTable. Exception: " + ex.Message);
            }
            return dt;
        }
        
        public artikel[] selectArtikel(string sSelect)
        {
            artikel[] liste = null;
            if (!db.connected)
                db.doConnect();
            DataTable dt = new DataTable();
            if (!db.connected)
                db.doConnect();
            try
            {
                //test for SortOrder field
                OleDbCommand cmd;
                OleDbDataAdapter da = new OleDbDataAdapter();
                //DataSet ds = new DataSet();
                cmd = new OleDbCommand(sSelect, db._connection);

                LoggerClass.log("Executing: " + cmd.CommandText);

                da.SelectCommand = cmd;
                da.Fill(dt);
                liste = new artikel[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sArtNr = "";
                    string sOmschrijving = "";
                    string sFoto = "";
                    Single iH_PrijsOnb = 0;
                    Single iH_PrijsBew = 0;
                    Single iW_PrijsOnb = 0;
                    Single iW_PrijsBew = 0;
                    Single iBesteld = 0;
                    string sMaat = "";
                    bool bBewerkt = false;
                    int iHgr_Id = 0;
                    int iArt_ID = 0;

                    sArtNr = dt.Rows[i]["ArtNr"].ToString();
                    System.Diagnostics.Debug.WriteLine("Reader: read='" + sArtNr + "'");
                    sOmschrijving = dt.Rows[i]["Omschrijving"].ToString();
                    sFoto = dt.Rows[i]["Foto"].ToString();
                    iH_PrijsOnb = (Single)dt.Rows[i]["H_PrijsOnb"];
                    iH_PrijsBew = (Single)dt.Rows[i]["H_PrijsBew"];
                    iW_PrijsOnb = (Single)dt.Rows[i]["W_PrijsOnb"];
                    iW_PrijsBew = (Single)dt.Rows[i]["W_PrijsBew"];
                    iBesteld = (Single)dt.Rows[i]["Besteld"];
                    sMaat = dt.Rows[i]["Maat"].ToString();
                    bBewerkt = (bool)dt.Rows[i]["Bewerkt"];
                    iHgr_Id = (int)dt.Rows[i]["Hgr_Id"];
                    iArt_ID = (int)dt.Rows[i]["Art_ID"];

                    liste[i] = (new artikel(sArtNr, sOmschrijving, iH_PrijsOnb, iH_PrijsBew, iW_PrijsOnb, iW_PrijsBew, iBesteld, sMaat, sFoto, bBewerkt, iHgr_Id, iArt_ID));
                    //dict.Add(rdr[""].ToString(), rdr[].ToString());

                }
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getTable. Exception: " + ex.Message);
            }
            return liste;
        }
        public artikel[] getArtikel(string sFilter)
        {
            artikel[] liste = null;
            if (!db.connected)
                db.doConnect();
            DataTable dt = new DataTable();
            if (!db.connected)
                db.doConnect();
            try
            {
                //test for SortOrder field
                OleDbCommand cmd;
                OleDbDataAdapter da = new OleDbDataAdapter();
                //DataSet ds = new DataSet();
                if (sFilter != "")
                    cmd = new OleDbCommand("SELECT * from Artikel " + sFilter + " order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);
                else
                    cmd = new OleDbCommand("SELECT * from Artikel order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);

                LoggerClass.log("Executing: " + cmd.CommandText);

                da.SelectCommand = cmd;
                da.Fill(dt);
                liste = new artikel[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string sArtNr = "";
                    string sOmschrijving = "";
                    string sFoto = "";
                    Single iH_PrijsOnb = 0;
                    Single iH_PrijsBew = 0;
                    Single iW_PrijsOnb = 0;
                    Single iW_PrijsBew = 0;
                    Single iBesteld = 0;
                    string sMaat = "";
                    bool bBewerkt = false;
                    int iHgr_Id = 0;
                    int iArt_ID = 0;

                        sArtNr = dt.Rows[i]["ArtNr"].ToString();
                        System.Diagnostics.Debug.WriteLine("Reader: read='" + sArtNr + "'");
                        sOmschrijving = dt.Rows[i]["Omschrijving"].ToString();
                        sFoto = dt.Rows[i]["Foto"].ToString();
                        iH_PrijsOnb = (Single) dt.Rows[i]["H_PrijsOnb"];
                        iH_PrijsBew = (Single)dt.Rows[i]["H_PrijsBew"];
                        iW_PrijsOnb = (Single)dt.Rows[i]["W_PrijsOnb"];
                        iW_PrijsBew = (Single)dt.Rows[i]["W_PrijsBew"];
                        iBesteld = (Single)dt.Rows[i]["Besteld"];
                        sMaat = dt.Rows[i]["Maat"].ToString();
                        bBewerkt = (bool) dt.Rows[i]["Bewerkt"];
                        iHgr_Id = (int)dt.Rows[i]["Hgr_Id"];
                        iArt_ID = (int)dt.Rows[i]["Art_ID"];

                        liste[i] = (new artikel(sArtNr, sOmschrijving, iH_PrijsOnb, iH_PrijsBew, iW_PrijsOnb, iW_PrijsBew, iBesteld, sMaat, sFoto, bBewerkt, iHgr_Id, iArt_ID));
                        //dict.Add(rdr[""].ToString(), rdr[].ToString());

                }
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getTable. Exception: " + ex.Message);
            }
            return liste;
        }


        public List<artikel> getArtikel(int sFilter)
        {
            List<artikel> liste = new List<artikel>();
            if (!db.connected)
                db.doConnect();
            try
            {
                //test for SortOrder field
                OleDbCommand cmd;

                if (sFilter != -1)
                    cmd = new OleDbCommand("SELECT * from Artikel Where Hgr_Id=" + sFilter + " order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);
                else
                    cmd = new OleDbCommand("SELECT * from Artikel order by " + _settings.sortField  /*Hgr_ID"*/ , db._connection);

                LoggerClass.log("Executing: " + cmd.CommandText);
                OleDbDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string sArtNr = "";
                    string sOmschrijving = "";
                    string sFoto = "";
                    Single iH_PrijsOnb = 0;
                    Single iH_PrijsBew = 0;
                    Single iW_PrijsOnb = 0;
                    Single iW_PrijsBew = 0;
                    Single iBesteld = 0;
                    string sMaat = "";
                    bool bBewerkt = false;
                    int iHgr_Id = 0;
                    int iArt_ID = 0;
                    while (rdr.Read())
                    {
                        sArtNr = db.readerGetString(rdr, "ArtNr");
                        System.Diagnostics.Debug.WriteLine("Reader: read='" + sArtNr + "'");
                        sOmschrijving = db.readerGetString(rdr, "Omschrijving");
                        sFoto = db.readerGetString(rdr, "Foto");
                        iH_PrijsOnb = db.readerGetSingle(rdr, "H_PrijsOnb");
                        iH_PrijsBew = db.readerGetSingle(rdr, "H_PrijsBew");
                        iW_PrijsOnb = db.readerGetSingle(rdr, "W_PrijsOnb");
                        iW_PrijsBew = db.readerGetSingle(rdr, "W_PrijsBew");
                        iBesteld = db.readerGetSingle(rdr, "Besteld");
                        sMaat = db.readerGetString(rdr, "Maat");
                        bBewerkt = db.readerGetBool(rdr, "Bewerkt");
                        iHgr_Id = db.readerGetInt(rdr, "Hgr_Id");
                        iArt_ID = db.readerGetInt(rdr, "Art_ID");

                        liste.Add(new artikel(sArtNr,sOmschrijving,iH_PrijsOnb, iH_PrijsBew, iW_PrijsOnb, iW_PrijsBew, iBesteld, sMaat, sFoto, bBewerkt, iHgr_Id, iArt_ID));
                        //dict.Add(rdr[""].ToString(), rdr[].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getArtikel. Exception: " + ex.Message);
            }
            return liste;
        }

        public int deleteArtikel(int iGruppenID)
        {
            int iDeleted1 = 0;
            int iDeleted2 = 0;

            if (!db.connected)
                db.doConnect();
            try
            {
                OleDbCommand cmd;

                cmd = new OleDbCommand("delete * from Artikel where hgr_id=" + iGruppenID.ToString(), db._connection);
                LoggerClass.log("Executing: " + cmd.CommandText);
                iDeleted1 = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: deleteArtikel. Exception: " + ex.Message);
            }
            return iDeleted1 + iDeleted2;
        }
    }
}
