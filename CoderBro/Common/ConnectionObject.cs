using System;
using System.Data;
using System.Configuration;
using System.Data.OleDb;

namespace CoderBro
{
    /// <summary>
    /// Summary description for DataObject
    /// </summary>
    public class ConnectionObject
    {
        public string ConnectionString;
        public OleDbConnection Connection;
        public ConnectionObject()
        {
            ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb";
            Connection = new OleDbConnection(ConnectionString);
        }

        public ConnectionObject(string connectionString)
        {
            ConnectionString = connectionString;
            Connection = new OleDbConnection(ConnectionString);
        }
    }

}