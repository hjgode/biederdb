using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace BiederDB3.dataclasses
{
    public class Gruppentexte:IDisposable
    {
        Datenbank db;
        bool bNewDB = false;
        public Gruppentexte()
        {
            db = new Datenbank();
            bNewDB = true;
        }
        public Gruppentexte(ref Datenbank datenbank)
        {
            db = datenbank;
        }
        public void Dispose()
        {
            if (bNewDB)
                db.Dispose();
        }
        //hoofdgroep
        public class gruppentext
        {
            public string GruppenName;
            public int ID;
            public string Gruppentext;
            public int Sortorder;
            public gruppentext(string sName, int iID, string sText, int iSortorder)
            {
                GruppenName = sName;
                ID = iID;
                Gruppentext = sText;
                Sortorder = iSortorder;
            }
            public override string ToString()
            {
                return GruppenName;
            }
        }

        /// <summary>
        /// return a list of Gruppen sorted by SortOrder
        /// </summary>
        /// <returns></returns>
        public List<gruppentext> getGruppentexte()
        {
            List<gruppentext> liste = new List<gruppentext>();
            if (!db.connected)
                db.doConnect();
            try
            {
                //test for SortOrder field
                bool bFoundIt = false;
                foreach (string s in db.getFieldNames("Hoofdgroep"))
                {
                    if (s.ToLower() == "sortorder")
                    {
                        bFoundIt = true;
                        continue;
                    }
                }
                OleDbCommand cmd;
                if (bFoundIt)
                    cmd = new OleDbCommand("SELECT * from hoofdgroep order by SortOrder", db._connection);
                else
                    cmd = new OleDbCommand("SELECT * from hoofdgroep order by Hgr_Id", db._connection);
                LoggerClass.log("Executing: " + cmd.CommandText);
                OleDbDataReader rdr = cmd.ExecuteReader();

                if (rdr.HasRows)
                {
                    string s1 = "", s2 = ""; int iHgr = 0; int iSort = 0;
                    while (rdr.Read())
                    {
                        s1 = db.readerGetString(rdr, "hoofdgroep");
                        s2 = db.readerGetString(rdr, "Produkttext");
                        iHgr = db.readerGetInt(rdr, "Hgr_Id");
                        iSort = db.readerGetInt(rdr, "SortOrder");
                        liste.Add(new gruppentext(s1, iHgr, s2, iSort));
                        //dict.Add(rdr[""].ToString(), rdr[].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getFields. Exception: " + ex.Message);
            }
            return liste;

        }
        public int updateGruppeSortorder(int ID, int iSort)
        {
            int iRet = -1;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = db._connection;
            try
            {
                cmd.CommandText = "update hoofdgroep set SortOrder='" + iSort + "' WHERE Hgr_Id=" + ID.ToString() + ";";
                int iCount = cmd.ExecuteNonQuery();
                iRet = iCount;
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: updateGruppe. Exception: " + ex.Message);
            }
            return iRet;
        }

        public int updateGruppe(int ID, string snewText){
            int iRet = -1;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = db._connection;
            try
            {
                cmd.CommandText = "update hoofdgroep set Produkttext='" + snewText +"' WHERE Hgr_Id=" + ID.ToString() + ";";
                int iCount = cmd.ExecuteNonQuery();
                iRet = iCount;
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: updateGruppe. Exception: " + ex.Message);
            }
            return iRet;
        }
        public int updateGruppenName(int ID, string snewName)
        {
            int iRet = -1;
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = db._connection;
            try
            {
                cmd.CommandText = "update hoofdgroep set hoofdgroep='" + snewName + "' WHERE Hgr_Id=" + ID.ToString() + ";";
                int iCount = cmd.ExecuteNonQuery();
                iRet = iCount;
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: updateGruppenName. Exception: " + ex.Message);
            }
            return iRet;
        }
        public int deleteGruppe(int iGruppenID)
        {
            int iDeleted1 = 0;
            int iDeleted2 = 0;

            if (!db.connected)
                db.doConnect();
            try
            {
                OleDbCommand cmd;

                cmd = new OleDbCommand("delete * from Hoofdgroep where hgr_id==" + iGruppenID.ToString(), db._connection);
                LoggerClass.log("Executing: " + cmd.CommandText);
                iDeleted2 = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: deleteArtikel. Exception: " + ex.Message);
            }
            return iDeleted1 + iDeleted2;
        }
    }
}
