using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace BiederDB3
{
    public class Datenbank:IDisposable
    {
        private bool _connected=false;
        GlobalSettings _global = new GlobalSettings();
        GlobalSettings.settings _settings = new GlobalSettings.settings();

        public OleDbConnection _connection;
        string _provider = @"Provider=Microsoft.Jet.OLEDB.4.0;";
        string _datasource = "Data source=";
        string _connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                                   @"Data source=C:\Documents and Settings\username\My Documents\dbFile.mdb";

        public Datenbank()
        {
            doConnect();
        }
        public void Dispose(){
            if (_connected)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }

        public bool connected
        {
            get { return _connected; }
        }

        public bool doConnect()
        {
            bool bRet = false;
            try
            {
                _connectionString = _provider + _datasource + _settings.datenbank + ";" ;
                _connection = new OleDbConnection(_connectionString);
                _connection.Open();
                _connection.StateChange += new StateChangeEventHandler(_connection_StateChange);
                _connected = true;
                bRet = true;
            }
            catch (Exception ex)
            {
                LoggerClass.log("Exception in doConnect(): " + ex.Message);                
            }
            return bRet;
        }

        void _connection_StateChange(object sender, StateChangeEventArgs e)
        {
            LoggerClass.log("Datenbank: ConnectionState=" + e.CurrentState.ToString());
            if (e.CurrentState == ConnectionState.Open)
                _connected = true;
            else
                _connected = false;
        }
        public ArrayList getFieldNames(string sTabelle)
        {
            if (!this._connected)
                doConnect();
            ArrayList sARR = new ArrayList();
            try
            {
                OleDbCommand cmd = new OleDbCommand("Select * from " + sTabelle, _connection);
                OleDbDataReader rdr = cmd.ExecuteReader();
                DataTable dt = rdr.GetSchemaTable();
                if (dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sARR.Add(dt.Rows[i].ItemArray[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getFields. Exception: " + ex.Message);
            }
            return sARR;
        }


        public string readerGetString(OleDbDataReader rdr, string sField)
        {
            string s = "";
            try
            {
                object o = rdr[sField];
                if (o != null)
                    s = (string)o;
            }
            catch (Exception ex)
            {
                
            }
            return s;
        }
        public int readerGetInt(OleDbDataReader rdr, string sField)
        {
            int i = 0;
            try
            {
                object o = rdr[sField];
                if (o != null)
                    i = (int)o;
            }
            catch (Exception ex)
            {

            }
            return i;
        }
    }
}
