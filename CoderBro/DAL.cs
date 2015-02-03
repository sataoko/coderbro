using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Data.SqlClient;

namespace CoderBro
{
    class DAL
    {
        public static DataTable GetTable(string SQLStr)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb");
            OleDbCommand cmd = new OleDbCommand(SQLStr, conn);

            try
            {
                conn.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "X");
                return ds.Tables[0];

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conn.Close();
            }

        }

        public static DataTable GetTable(string SQLStr, string mdbPath)
        {
            //DBManager dbm = new DBManager(DataProvider.SqlServer, ConfigurationManager.ConnectionStrings["MainConnectionString"].ToString());

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath);
            OleDbCommand cmd = new OleDbCommand(SQLStr, conn);

            try
            {
                conn.Open();
                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "X");
                return ds.Tables[0];

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conn.Close();
            }

        }

        public static DataTable GetTable4SQLServer(string selectString, string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(selectString, conn);
                conn.Open();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }



        public static string GenerateOleDBUpdateString(string tableName, List<string> fields)
        {
            string updateSQL = "UPDATE " + tableName + " SET ";
            foreach (string f in fields)
            {
                updateSQL += f + "=@" + f + ",";
            }

            updateSQL = updateSQL.Remove(updateSQL.Length - 1, 1);//remove last comma in updateSQL string
            updateSQL += " WHERE ID=\"+ID";
            return updateSQL;
        }

        public static string GenerateUpdateMethod(string updateMethodName, string tableName, List<string> fields)
        {

            string updateMethod = "public string " + updateMethodName + "(a,b,c, string ID){";

            updateMethod += "OleDbConnection conn = new OleDbConnection(\"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Data.mdb\"";
            updateMethod += @" 
            try
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();";

            updateMethod += "cmd.CommandText =\"" + GenerateOleDBUpdateString(tableName, fields);

            string commandString = string.Empty;
            foreach (string f in fields)
            {
                commandString += "cmd.Parameters.AddWithValue(\"@\"" + f + "," + f + ");";
            }

            updateMethod += "cmd.ExecuteNonQuery();\n\r";
            updateMethod += "return \"OK\";\n\r";
            updateMethod += @"}
            catch (Exception exp)
            {
                return exp.ToString();
            }
            finally
            {
                conn.Close();
            }\r\n";

            updateMethod += "}";


            return updateMethod;

        }




        public static string Update(string tableName, Hashtable parametersWithValues, string ID, string mdbPath)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbPath);
            try
            {

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                conn.Open();
                string updateSQL = "UPDATE " + tableName + " SET ";
                ICollection anahtar = parametersWithValues.Keys;
                foreach (string a in anahtar)
                {
                    updateSQL += a + "=@" + a + ",";
                    if ((parametersWithValues[a].ToString().ToUpper() == "TRUE") || (parametersWithValues[a].ToString().ToUpper() == "FALSE"))
                        cmd.Parameters.AddWithValue("@" + a, Convert.ToBoolean(parametersWithValues[a]));
                    else cmd.Parameters.AddWithValue("@" + a, parametersWithValues[a]);
                }
                updateSQL = updateSQL.Remove(updateSQL.Length - 1, 1);//remove last comma in updateSQL string
                updateSQL += " WHERE ID=" + ID;
                //cmd.CommandText = updateSQL;

                //cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception exp)
            {
                return exp.ToString();
            }
            finally
            {
                conn.Close();
            }
        }

        public static DataTable GetSQLDBTables(string connectionString)
        {
            DataTable tables = new DataTable("Tables");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select 2,3,table_name as Name from INFORMATION_SCHEMA.Tables where TABLE_TYPE ='BASE TABLE'";
                connection.Open();
                tables.Load(command.ExecuteReader(CommandBehavior.CloseConnection));
            }
            return tables;
        }
    }




}
