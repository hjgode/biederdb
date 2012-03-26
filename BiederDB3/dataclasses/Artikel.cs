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

                        liste.Add(new artikel(sArtNr, sOmschrijving, sFoto, iHgr_Id, iArt_ID));
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
