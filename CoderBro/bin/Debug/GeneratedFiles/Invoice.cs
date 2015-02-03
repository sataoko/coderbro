using System;
using System.Data;
using System.Configuration;

namespace CashReg
{
    /// <summary>
    /// Summary description for User
    /// </summary>
    public class Invoice
    {
        public int ID;
public int FirmID;
public int BranchID;
public int StockItemTransactionTypeID;
public int CompanyID;
public string CompanyCode=string.Empty;
public DateTime InvoiceDate;
public DateTime TransactionDate;
public DateTime DueDate;
public string Explanation=string.Empty;
public int InvoiceGroup1ID;
public int InvoiceGroup2ID;
public string InvoiceCode=string.Empty;
public int ExchangeTypeID;
public int CashID;
public decimal Discount;
public decimal VAT;
public decimal Total;
public decimal VATTotal;
public decimal TotalAmount;
public int UserID;
public int RelatedPersonID;
public string Inserter=string.Empty;
public DateTime InsertDate;
public string Updater=string.Empty;
public DateTime UpdateDate;

        private DALInvoice dalInvoice;

        public Invoice()
        {
            dalInvoice = new DALInvoice();
        }

        public RV Add()
        {
            RV r = dalInvoice.Add(this);
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public RV Update()
        {
            RV r = dalInvoice.Update(this);
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public Invoice GetInvoiceByID(string ID)
        {
            return dalInvoice.GetInvoiceByID(ID);
        }        

        public RV GetInvoices()
        {
            RV r = dalInvoice.GetInvoices();
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public RV DeleteInvoiceByID(string ID)
        {
            return dalInvoice.DeleteInvoiceByID(ID);
        }

    }
}


