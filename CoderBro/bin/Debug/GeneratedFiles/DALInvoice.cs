

using System;
using System.Data;
using System.Configuration;
using System.Data.Sql;

namespace CashReg
{
    /// <summary>
    /// Summary description for DAL
    /// </summary>
    public class DALInvoice : ConnectionObject
    {
        public DALInvoice()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public RV Add(Invoice Invoice)
        {
            try
            {
                string sqlStr = "INSERT INTO accINVOICES(ID,FirmID,BranchID,StockItemTransactionTypeID,CompanyID,CompanyCode,InvoiceDate,TransactionDate,DueDate,Explanation,InvoiceGroup1ID,InvoiceGroup2ID,InvoiceCode,ExchangeTypeID,CashID,Discount,VAT,Total,VATTotal,TotalAmount,UserID,RelatedPersonID,Inserter,InsertDate,Updater,UpdateDate) VALUES (@ID,@FirmID,@BranchID,@StockItemTransactionTypeID,@CompanyID,@CompanyCode,@InvoiceDate,@TransactionDate,@DueDate,@Explanation,@InvoiceGroup1ID,@InvoiceGroup2ID,@InvoiceCode,@ExchangeTypeID,@CashID,@Discount,@VAT,@Total,@VATTotal,@TotalAmount,@UserID,@RelatedPersonID,@Inserter,@InsertDate,@Updater,@UpdateDate)";


                SqlCommand cmd = new SqlCommand(sqlStr, this.Connection);
                
                cmd.Parameters.AddWithValue("@ID",Invoice.ID);
cmd.Parameters.AddWithValue("@FirmID",Invoice.FirmID);
cmd.Parameters.AddWithValue("@BranchID",Invoice.BranchID);
cmd.Parameters.AddWithValue("@StockItemTransactionTypeID",Invoice.StockItemTransactionTypeID);
cmd.Parameters.AddWithValue("@CompanyID",Invoice.CompanyID);
cmd.Parameters.AddWithValue("@CompanyCode",Invoice.CompanyCode);
cmd.Parameters.AddWithValue("@InvoiceDate",Invoice.InvoiceDate);
cmd.Parameters.AddWithValue("@TransactionDate",Invoice.TransactionDate);
cmd.Parameters.AddWithValue("@DueDate",Invoice.DueDate);
cmd.Parameters.AddWithValue("@Explanation",Invoice.Explanation);
cmd.Parameters.AddWithValue("@InvoiceGroup1ID",Invoice.InvoiceGroup1ID);
cmd.Parameters.AddWithValue("@InvoiceGroup2ID",Invoice.InvoiceGroup2ID);
cmd.Parameters.AddWithValue("@InvoiceCode",Invoice.InvoiceCode);
cmd.Parameters.AddWithValue("@ExchangeTypeID",Invoice.ExchangeTypeID);
cmd.Parameters.AddWithValue("@CashID",Invoice.CashID);
cmd.Parameters.AddWithValue("@Discount",Invoice.Discount);
cmd.Parameters.AddWithValue("@VAT",Invoice.VAT);
cmd.Parameters.AddWithValue("@Total",Invoice.Total);
cmd.Parameters.AddWithValue("@VATTotal",Invoice.VATTotal);
cmd.Parameters.AddWithValue("@TotalAmount",Invoice.TotalAmount);
cmd.Parameters.AddWithValue("@UserID",Invoice.UserID);
cmd.Parameters.AddWithValue("@RelatedPersonID",Invoice.RelatedPersonID);
cmd.Parameters.AddWithValue("@Inserter",Invoice.Inserter);
cmd.Parameters.AddWithValue("@InsertDate",Invoice.InsertDate);
cmd.Parameters.AddWithValue("@Updater",Invoice.Updater);
cmd.Parameters.AddWithValue("@UpdateDate",Invoice.UpdateDate);
  

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

        public RV Update(Invoice Invoice)
        {
            try
            {
                string sqlStr = "UPDATE accINVOICES SET ID=@ID,FirmID=@FirmID,BranchID=@BranchID,StockItemTransactionTypeID=@StockItemTransactionTypeID,CompanyID=@CompanyID,CompanyCode=@CompanyCode,InvoiceDate=@InvoiceDate,TransactionDate=@TransactionDate,DueDate=@DueDate,Explanation=@Explanation,InvoiceGroup1ID=@InvoiceGroup1ID,InvoiceGroup2ID=@InvoiceGroup2ID,InvoiceCode=@InvoiceCode,ExchangeTypeID=@ExchangeTypeID,CashID=@CashID,Discount=@Discount,VAT=@VAT,Total=@Total,VATTotal=@VATTotal,TotalAmount=@TotalAmount,UserID=@UserID,RelatedPersonID=@RelatedPersonID,Inserter=@Inserter,InsertDate=@InsertDate,Updater=@Updater,UpdateDate=@UpdateDate WHERE ID=";
                sqlStr += Invoice.ID;

                SqlCommand cmd = new SqlCommand(sqlStr, this.Connection);

                cmd.Parameters.AddWithValue("@ID",Invoice.ID);
cmd.Parameters.AddWithValue("@FirmID",Invoice.FirmID);
cmd.Parameters.AddWithValue("@BranchID",Invoice.BranchID);
cmd.Parameters.AddWithValue("@StockItemTransactionTypeID",Invoice.StockItemTransactionTypeID);
cmd.Parameters.AddWithValue("@CompanyID",Invoice.CompanyID);
cmd.Parameters.AddWithValue("@CompanyCode",Invoice.CompanyCode);
cmd.Parameters.AddWithValue("@InvoiceDate",Invoice.InvoiceDate);
cmd.Parameters.AddWithValue("@TransactionDate",Invoice.TransactionDate);
cmd.Parameters.AddWithValue("@DueDate",Invoice.DueDate);
cmd.Parameters.AddWithValue("@Explanation",Invoice.Explanation);
cmd.Parameters.AddWithValue("@InvoiceGroup1ID",Invoice.InvoiceGroup1ID);
cmd.Parameters.AddWithValue("@InvoiceGroup2ID",Invoice.InvoiceGroup2ID);
cmd.Parameters.AddWithValue("@InvoiceCode",Invoice.InvoiceCode);
cmd.Parameters.AddWithValue("@ExchangeTypeID",Invoice.ExchangeTypeID);
cmd.Parameters.AddWithValue("@CashID",Invoice.CashID);
cmd.Parameters.AddWithValue("@Discount",Invoice.Discount);
cmd.Parameters.AddWithValue("@VAT",Invoice.VAT);
cmd.Parameters.AddWithValue("@Total",Invoice.Total);
cmd.Parameters.AddWithValue("@VATTotal",Invoice.VATTotal);
cmd.Parameters.AddWithValue("@TotalAmount",Invoice.TotalAmount);
cmd.Parameters.AddWithValue("@UserID",Invoice.UserID);
cmd.Parameters.AddWithValue("@RelatedPersonID",Invoice.RelatedPersonID);
cmd.Parameters.AddWithValue("@Inserter",Invoice.Inserter);
cmd.Parameters.AddWithValue("@InsertDate",Invoice.InsertDate);
cmd.Parameters.AddWithValue("@Updater",Invoice.Updater);
cmd.Parameters.AddWithValue("@UpdateDate",Invoice.UpdateDate);

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

        public RV DeleteInvoiceByID(string ID)
        {
            try
            {
                string sqlStr = "DELETE FROM accINVOICES WHERE ID=";
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


        public RV GetInvoiceByID(string ID)
        {
            try
            {
                string selectString = "SELECT ID,FirmID,BranchID,StockItemTransactionTypeID,CompanyID,CompanyCode,InvoiceDate,TransactionDate,DueDate,Explanation,InvoiceGroup1ID,InvoiceGroup2ID,InvoiceCode,ExchangeTypeID,CashID,Discount,VAT,Total,VATTotal,TotalAmount,UserID,RelatedPersonID,Inserter,InsertDate,Updater,UpdateDate FROM accINVOICES";
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


        public RV GetInvoices()
        {
            try
            {
                string selectString = "SELECT ID,FirmID,BranchID,StockItemTransactionTypeID,CompanyID,CompanyCode,InvoiceDate,TransactionDate,DueDate,Explanation,InvoiceGroup1ID,InvoiceGroup2ID,InvoiceCode,ExchangeTypeID,CashID,Discount,VAT,Total,VATTotal,TotalAmount,UserID,RelatedPersonID,Inserter,InsertDate,Updater,UpdateDate FROM accINVOICES";
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
