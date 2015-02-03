using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace CoderBro
{
    class DALNewDataConnection:ConnectionObject
    {
       public string Add()
       {
         try
         {
             this.Connection.Open();
             string sqlStr = "INSERT INTO YORUMLAR (BASLIK,YORUM,TARIH,GONDEREN) VALUES(?,?,?,?)";
             OleDbCommand cmd = new OleDbCommand(sqlStr, this.Connection);
             cmd.Parameters.AddWithValue("@BASLIK", "");
             cmd.Parameters.AddWithValue("@YORUM", "");
             cmd.Parameters.AddWithValue("@TARIH", DateTime.Today);
             cmd.Parameters.AddWithValue("@GONDEREN", "");
             cmd.ExecuteNonQuery();
             return "OK";
         }
         catch (Exception exp)
         {
             return exp.ToString();
         }
         finally
         {
             this.Connection.Close();
         }


       }

    }


    

}
