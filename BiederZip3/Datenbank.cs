using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

using System.ComponentModel;

namespace BiederDB3
{
    public class Datenbank:IDisposable
    {
        private bool _connected=false;
        BiederDBSettings2 _settings= new BiederDBSettings2();
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

        public DataSet getDataset(string sCmd, ref int iResult)
        {
            DataSet ds = new DataSet();
            if (!_connected)
                doConnect();

            OleDbDataAdapter da = new OleDbDataAdapter(sCmd, _connection);
            iResult = da.Fill(ds);

            return ds;
        }
        public DataTable getTable(string sCmd)
        {
            DataTable dt = new DataTable();
            if (!_connected)
                doConnect();

            OleDbDataAdapter da = new OleDbDataAdapter(sCmd, _connection);
            int iResult = da.Fill(dt);

            return dt;
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
                        sARR.Add(dt.Rows[i].ItemArray[0]); //ColumnName 
                        //System.Diagnostics.Debug.WriteLine("ColumnName: " + dt.Rows[i].ItemArray[0]); //ColumnName 
                        //System.Diagnostics.Debug.WriteLine("ColumnSize: " + dt.Rows[i].ItemArray[2]); //ColumnSize 
                        //System.Diagnostics.Debug.WriteLine("DataType:   " + dt.Rows[i].ItemArray[5]); //.NET DataType 
                    }
                }
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: getFields. Exception: " + ex.Message);
            }
            return sARR;
        }

        public int executeQuery(string sQuery)
        {
            int iRet = 0;
            if (!this._connected)
                doConnect();
            try
            {
                OleDbCommand cmd = new OleDbCommand(sQuery, _connection);
                iRet = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LoggerClass.log("Datenbank: executeQuery '"+ sQuery + "'. Exception: " + ex.Message);
            }
            return iRet;
        }

        public string readerGetString(OleDbDataReader rdr, string sField)
        {
            string s = "";
            try
            {
                object o = rdr[sField];
                if (o != null)
                {
                    s = (string)o;
                    s = s.Replace("''", "'");   // single quotes are special in msaccess
                }
            }
            catch (Exception )
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
            catch (Exception )
            {

            }
            return i;
        }
        public Single readerGetSingle(OleDbDataReader rdr, string sField)
        {
            Single i = 0;
            try
            {
                object o = rdr[sField];
                if (o != null)
                    i = (Single)o;
            }
            catch (Exception )
            {

            }
            return i;
        }
        public bool readerGetBool(OleDbDataReader rdr, string sField)
        {
            bool i = false;
            try
            {
                object o = rdr[sField];
                if (o != null)
                    i = (bool)o;
            }
            catch (Exception )
            {

            }
            return i;
        }
        public T readerGetValue<T>(OleDbDataReader rdr, string sField)
        {
            object o = new object();
            try
            {
                o = rdr[sField];
                if (o != null)
                    return (T)(o);
            }
            catch (Exception )
            {

            }
            return (T)o;
        }

    }
}
