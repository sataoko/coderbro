using System;
using System.Data;
using System.Configuration;

namespace CashReg
{
    /// <summary>
    /// Summary description for User
    /// </summary>
    public class StockItem
    {
        public int ID;
public int FirmID;
public int BranchID;
public int SuppliarID;
public string Code=string.Empty;
public string Name=string.Empty;
public string Barcode1=string.Empty;
public string Barcode2=string.Empty;
public string Barcode3=string.Empty;
public decimal Weight;
public int GroupCode1ID;
public int GroupCode2ID;
public int GroupCode3ID;
public string UnitID1=string.Empty;
public string UnitID2=string.Empty;
public decimal UnitBuyingPrice;
public decimal UnitSalesPrice;
public decimal VAT;
public decimal Balance;
public decimal HeighestStockAmount;
public decimal LowestStockAmount;
public int OrderID;
public bool Active;
public string Inserter=string.Empty;
public DateTime InsertDate;
public string Updater=string.Empty;
public DateTime UpdateDate;

        private DALStockItem dalStockItem;

        public StockItem()
        {
            dalStockItem = new DALStockItem();
        }

        public RV Add()
        {
            RV r = dalStockItem.Add(this);
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public RV Update()
        {
            RV r = dalStockItem.Update(this);
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public StockItem GetStockItemByID(string ID)
        {
            return dalStockItem.GetStockItemByID(ID);
        }        

        public RV GetStockItems()
        {
            RV r = dalStockItem.GetStockItems();
            r.SourceClassName+=">"+this.GetType().FullName;
            r.SourceMethodName+=">"+System.Reflection.MethodBase.GetCurrentMethod().Name;
            return r;
        }

        public RV DeleteStockItemByID(string ID)
        {
            return dalStockItem.DeleteStockItemByID(ID);
        }

    }
}


