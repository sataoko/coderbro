

using System;
using System.Data;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CashReg
{
    /// <summary>
    /// Summary description for DAL
    /// </summary>
    public class DALStockItemTransactions : ConnectionObject
    {
        public DALStockItemTransactions()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public RV Add(StockItemTransactions StockItemTransactions)
        {
            try
            {
                string sqlStr = "INSERT INTO accSTOCKITEM_TRANSACTIONS(ID,FirmID,BranchID,InvoiceID,StoreID,StorePartID,StockItemID,CompanyID,OrderID,CompanyCode,StockItemCode,Barcode,OrderNo,StockItemTransactionTypeID,Out,Quantity1,Quantity2,VAT,VATTotal,UnitPrice,TotalPrice,ExchangeID,TransactionDate,InvoiceDate,InvoiceNo,Inserter,Updater) VALUES (@ID,@FirmID,@BranchID,@InvoiceID,@StoreID,@StorePartID,@StockItemID,@CompanyID,@OrderID,@CompanyCode,@StockItemCode,@Barcode,@OrderNo,@StockItemTransactionTypeID,@Out,@Quantity1,@Quantity2,@VAT,@VATTotal,@UnitPrice,@TotalPrice,@ExchangeID,@TransactionDate,@InvoiceDate,@InvoiceNo,@Inserter,@Updater)";


                SqlCommand cmd = new SqlCommand(sqlStr, this.Connection);
                
                cmd.Parameters.AddWithValue("@ID",StockItemTransactions.ID);
cmd.Parameters.AddWithValue("@FirmID",StockItemTransactions.FirmID);
cmd.Parameters.AddWithValue("@BranchID",StockItemTransactions.BranchID);
cmd.Parameters.AddWithValue("@InvoiceID",StockItemTransactions.InvoiceID);
cmd.Parameters.AddWithValue("@StoreID",StockItemTransactions.StoreID);
cmd.Parameters.AddWithValue("@StorePartID",StockItemTransactions.StorePartID);
cmd.Parameters.AddWithValue("@StockItemID",StockItemTransactions.StockItemID);
cmd.Parameters.AddWithValue("@CompanyID",StockItemTransactions.CompanyID);
cmd.Parameters.AddWithValue("@OrderID",StockItemTransactions.OrderID);
cmd.Parameters.AddWithValue("@CompanyCode",StockItemTransactions.CompanyCode);
cmd.Parameters.AddWithValue("@StockItemCode",StockItemTransactions.StockItemCode);
cmd.Parameters.AddWithValue("@Barcode",StockItemTransactions.Barcode);
cmd.Parameters.AddWithValue("@OrderNo",StockItemTransactions.OrderNo);
cmd.Parameters.AddWithValue("@StockItemTransactionTypeID",StockItemTransactions.StockItemTransactionTypeID);
cmd.Parameters.AddWithValue("@Out",StockItemTransactions.Out);
cmd.Parameters.AddWithValue("@Quantity1",StockItemTransactions.Quantity1);
cmd.Parameters.AddWithValue("@Quantity2",StockItemTransactions.Quantity2);
cmd.Parameters.AddWithValue("@VAT",StockItemTransactions.VAT);
cmd.Parameters.AddWithValue("@VATTotal",StockItemTransactions.VATTotal);
cmd.Parameters.AddWithValue("@UnitPrice",StockItemTransactions.UnitPrice);
cmd.Parameters.AddWithValue("@TotalPrice",StockItemTransactions.TotalPrice);
cmd.Parameters.AddWithValue("@ExchangeID",StockItemTransactions.ExchangeID);
cmd.Parameters.AddWithValue("@TransactionDate",StockItemTransactions.TransactionDate);
cmd.Parameters.AddWithValue("@InvoiceDate",StockItemTransactions.InvoiceDate);
cmd.Parameters.AddWithValue("@InvoiceNo",StockItemTransactions.InvoiceNo);
cmd.Parameters.AddWithValue("@Inserter",StockItemTransactions.Inserter);
cmd.Parameters.AddWithValue("@Updater",StockItemTransactions.Updater);
  

                this.Connection.Open();
                this.ReturnValue.CommandResult = cmd.ExecuteNonQuery();
                return this.ReturnValue;
                
            }
            catch (Exception exp)
            {
                this.ReturnValue.ErrorMessage = exp.ToString();
                this.ReturnValue.Error = true;
                return this.ReturnValue;
            }
            finally
            {
                this.ReturnValue.SourceMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                this.ReturnValue.SourceClassName = this.GetType().FullName;
                this.Connection.Close();
            }
        }

        public RV Update(StockItemTransactions StockItemTransactions)
        {
            try
            {
                string sqlStr = "UPDATE accSTOCKITEM_TRANSACTIONS SET ID=@ID,FirmID=@FirmID,BranchID=@BranchID,InvoiceID=@InvoiceID,StoreID=@StoreID,StorePartID=@StorePartID,StockItemID=@StockItemID,CompanyID=@CompanyID,OrderID=@OrderID,CompanyCode=@CompanyCode,StockItemCode=@StockItemCode,Barcode=@Barcode,OrderNo=@OrderNo,StockItemTransactionTypeID=@StockItemTransactionTypeID,Out=@Out,Quantity1=@Quantity1,Quantity2=@Quantity2,VAT=@VAT,VATTotal=@VATTotal,UnitPrice=@UnitPrice,TotalPrice=@TotalPrice,ExchangeID=@ExchangeID,TransactionDate=@TransactionDate,InvoiceDate=@InvoiceDate,InvoiceNo=@InvoiceNo,Inserter=@Inserter,Updater=@Updater WHERE ID=";
                sqlStr += StockItemTransactions.ID;

                SqlCommand cmd = new SqlCommand(sqlStr, this.Connection);

                cmd.Parameters.AddWithValue("@ID",StockItemTransactions.ID);
cmd.Parameters.AddWithValue("@FirmID",StockItemTransactions.FirmID);
cmd.Parameters.AddWithValue("@BranchID",StockItemTransactions.BranchID);
cmd.Parameters.AddWithValue("@InvoiceID",StockItemTransactions.InvoiceID);
cmd.Parameters.AddWithValue("@StoreID",StockItemTransactions.StoreID);
cmd.Parameters.AddWithValue("@StorePartID",StockItemTransactions.StorePartID);
cmd.Parameters.AddWithValue("@StockItemID",StockItemTransactions.StockItemID);
cmd.Parameters.AddWithValue("@CompanyID",StockItemTransactions.CompanyID);
cmd.Parameters.AddWithValue("@OrderID",StockItemTransactions.OrderID);
cmd.Parameters.AddWithValue("@CompanyCode",StockItemTransactions.CompanyCode);
cmd.Parameters.AddWithValue("@StockItemCode",StockItemTransactions.StockItemCode);
cmd.Parameters.AddWithValue("@Barcode",StockItemTransactions.Barcode);
cmd.Parameters.AddWithValue("@OrderNo",StockItemTransactions.OrderNo);
cmd.Parameters.AddWithValue("@StockItemTransactionTypeID",StockItemTransactions.StockItemTransactionTypeID);
cmd.Parameters.AddWithValue("@Out",StockItemTransactions.Out);
cmd.Parameters.AddWithValue("@Quantity1",StockItemTransactions.Quantity1);
cmd.Parameters.AddWithValue("@Quantity2",StockItemTransactions.Quantity2);
cmd.Parameters.AddWithValue("@VAT",StockItemTransactions.VAT);
cmd.Parameters.AddWithValue("@VATTotal",StockItemTransactions.VATTotal);
cmd.Parameters.AddWithValue("@UnitPrice",StockItemTransactions.UnitPrice);
cmd.Parameters.AddWithValue("@TotalPrice",StockItemTransactions.TotalPrice);
cmd.Parameters.AddWithValue("@ExchangeID",StockItemTransactions.ExchangeID);
cmd.Parameters.AddWithValue("@TransactionDate",StockItemTransactions.TransactionDate);
cmd.Parameters.AddWithValue("@InvoiceDate",StockItemTransactions.InvoiceDate);
cmd.Parameters.AddWithValue("@InvoiceNo",StockItemTransactions.InvoiceNo);
cmd.Parameters.AddWithValue("@Inserter",StockItemTransactions.Inserter);
cmd.Parameters.AddWithValue("@Updater",StockItemTransactions.Updater);

                this.Connection.Open();
                this.ReturnValue.CommandResult = cmd.ExecuteNonQuery();
                return this.ReturnValue;
            }

            catch (Exception exp)
            {
                this.ReturnValue.ErrorMessage = exp.ToString();
                this.ReturnValue.Error = true;
                return this.ReturnValue;
            }
            finally
            {
                this.ReturnValue.SourceMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                this.ReturnValue.SourceClassName = this.GetType().FullName;
                this.Connection.Close();
            }
        }

        public RV DeleteStockItemTransactionsByID(string ID)
        {
            try
            {
                string sqlStr = "DELETE FROM accSTOCKITEM_TRANSACTIONS WHERE ID=";
                sqlStr+=ID; 
                SqlCommand cmd = new SqlCommand(sqlStr, this.Connection);
                this.Connection.Open();
                this.ReturnValue.CommandResult = cmd.ExecuteNonQuery();
                return this.ReturnValue;
            }

            catch (Exception exp)
            {
                this.ReturnValue.ErrorMessage = exp.ToString();
                this.ReturnValue.Error = true;
                return this.ReturnValue;
            }
            finally
            {
                this.ReturnValue.SourceMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                this.ReturnValue.SourceClassName = this.GetType().FullName;
                this.Connection.Close();
            }
        }


        public RV GetStockItemTransactionsByID(string ID)
        {
            try
            {
                string selectString = "SELECT ID,FirmID,BranchID,InvoiceID,StoreID,StorePartID,StockItemID,CompanyID,OrderID,CompanyCode,StockItemCode,Barcode,OrderNo,StockItemTransactionTypeID,Out,Quantity1,Quantity2,VAT,VATTotal,UnitPrice,TotalPrice,ExchangeID,TransactionDate,InvoiceDate,InvoiceNo,Inserter,Updater FROM accSTOCKITEM_TRANSACTIONS";
                SqlDataAdapter adp = new SqlDataAdapter(selectString, this.Connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "X");
                this.Connection.Open();
                this.ReturnValue.Dataset = ds;
                return this.ReturnValue;
            }
            catch (Exception exp)
            {
                this.ReturnValue.ErrorMessage = exp.ToString();
                this.ReturnValue.Error = true;
                return this.ReturnValue;
            }
            finally
            {
                this.ReturnValue.SourceMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                this.ReturnValue.SourceClassName = this.GetType().FullName;
                this.Connection.Close();
            }

        }


        public RV GetStockItemTransactionss()
        {
            try
            {
                string selectString = "SELECT ID,FirmID,BranchID,InvoiceID,StoreID,StorePartID,StockItemID,CompanyID,OrderID,CompanyCode,StockItemCode,Barcode,OrderNo,StockItemTransactionTypeID,Out,Quantity1,Quantity2,VAT,VATTotal,UnitPrice,TotalPrice,ExchangeID,TransactionDate,InvoiceDate,InvoiceNo,Inserter,Updater FROM accSTOCKITEM_TRANSACTIONS";
                SqlDataAdapter adp = new SqlDataAdapter(selectString, this.Connection);
                DataSet ds = new DataSet();
                adp.Fill(ds, "X");
                this.Connection.Open();
                this.ReturnValue.Dataset = ds;
                return this.ReturnValue;
            }
            catch (Exception exp)
            {
                this.ReturnValue.ErrorMessage = exp.ToString();
                this.ReturnValue.Error = true;
                return this.ReturnValue;
            }
            finally
            {
                this.ReturnValue.SourceMethodName = System.Reflection.MethodBase.GetCurrentMethod().Name;
                this.ReturnValue.SourceClassName = this.GetType().FullName;
                this.Connection.Close();
            }

        }

    }
}
