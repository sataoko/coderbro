using System;
using System.Data;
using System.Configuration;

namespace CashReg
{
    /// <summary>
    /// Summary description for User
    /// </summary>
    public class StockItemTransactions
    {
        public int ID;
public int FirmID;
public int BranchID;
public int InvoiceID;
public int StoreID;
public int StorePartID;
public int StockItemID;
public int CompanyID;
public int OrderID;
public int CompanyCode;
public string StockItemCode=string.Empty;
public string Barcode=string.Empty;
public string OrderNo=string.Empty;
public int StockItemTransactionTypeID;
public bool Out;
public decimal Quantity1;
public decimal Quantity2;
public decimal VAT;
public decimal VATTotal;
public decimal UnitPrice;
public decimal TotalPrice;
public int ExchangeID;
public DateTime TransactionDate;
public DateTime InvoiceDate;
public string InvoiceNo=string.Empty;
public string Inserter=string.Empty;
public string Updater=string.Empty;

        private DALStockItemTransactions dalStockItemTransactions;

        public StockItemTransactions()
        {
            dalStockItemTransactions = new DALStockItemTransactions();
        }

        public RV Add()
        {
            RV r = dalStockItemTransactions.Add(this);
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public RV Update()
        {
            RV r = dalStockItemTransactions.Update(this);
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public StockItemTransactions GetStockItemTransactionsByID(string ID)
        {
            return dalStockItemTransactions.GetStockItemTransactionsByID(ID);
        }        

        public RV GetStockItemTransactionss()
        {
            RV r = dalStockItemTransactions.GetStockItemTransactionss();
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public RV DeleteStockItemTransactionsByID(string ID)
        {
            return dalStockItemTransactions.DeleteStockItemTransactionsByID(ID);
        }

    }
}


