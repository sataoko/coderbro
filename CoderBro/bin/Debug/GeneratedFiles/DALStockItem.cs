

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
    public class DALStockItem : ConnectionObject
    {
        public DALStockItem()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public RV Add(StockItem StockItem)
        {
            try
            {
                string sqlStr = "INSERT INTO prdSTOCKITEMS(ID,FirmID,BranchID,SuppliarID,Code,Name,Barcode1,Barcode2,Barcode3,Weight,GroupCode1ID,GroupCode2ID,GroupCode3ID,UnitID1,UnitID2,UnitBuyingPrice,UnitSalesPrice,VAT,Balance,HeighestStockAmount,LowestStockAmount,OrderID,Active,Inserter,InsertDate,Updater,UpdateDate) VALUES (@ID,@FirmID,@BranchID,@SuppliarID,@Code,@Name,@Barcode1,@Barcode2,@Barcode3,@Weight,@GroupCode1ID,@GroupCode2ID,@GroupCode3ID,@UnitID1,@UnitID2,@UnitBuyingPrice,@UnitSalesPrice,@VAT,@Balance,@HeighestStockAmount,@LowestStockAmount,@OrderID,@Active,@Inserter,@InsertDate,@Updater,@UpdateDate)";


                SqlCommand cmd = new SqlCommand(sqlStr, this.Connection);
                
                cmd.Parameters.AddWithValue("@ID",StockItem.ID);
cmd.Parameters.AddWithValue("@FirmID",StockItem.FirmID);
cmd.Parameters.AddWithValue("@BranchID",StockItem.BranchID);
cmd.Parameters.AddWithValue("@SuppliarID",StockItem.SuppliarID);
cmd.Parameters.AddWithValue("@Code",StockItem.Code);
cmd.Parameters.AddWithValue("@Name",StockItem.Name);
cmd.Parameters.AddWithValue("@Barcode1",StockItem.Barcode1);
cmd.Parameters.AddWithValue("@Barcode2",StockItem.Barcode2);
cmd.Parameters.AddWithValue("@Barcode3",StockItem.Barcode3);
cmd.Parameters.AddWithValue("@Weight",StockItem.Weight);
cmd.Parameters.AddWithValue("@GroupCode1ID",StockItem.GroupCode1ID);
cmd.Parameters.AddWithValue("@GroupCode2ID",StockItem.GroupCode2ID);
cmd.Parameters.AddWithValue("@GroupCode3ID",StockItem.GroupCode3ID);
cmd.Parameters.AddWithValue("@UnitID1",StockItem.UnitID1);
cmd.Parameters.AddWithValue("@UnitID2",StockItem.UnitID2);
cmd.Parameters.AddWithValue("@UnitBuyingPrice",StockItem.UnitBuyingPrice);
cmd.Parameters.AddWithValue("@UnitSalesPrice",StockItem.UnitSalesPrice);
cmd.Parameters.AddWithValue("@VAT",StockItem.VAT);
cmd.Parameters.AddWithValue("@Balance",StockItem.Balance);
cmd.Parameters.AddWithValue("@HeighestStockAmount",StockItem.HeighestStockAmount);
cmd.Parameters.AddWithValue("@LowestStockAmount",StockItem.LowestStockAmount);
cmd.Parameters.AddWithValue("@OrderID",StockItem.OrderID);
cmd.Parameters.AddWithValue("@Active",StockItem.Active);
cmd.Parameters.AddWithValue("@Inserter",StockItem.Inserter);
cmd.Parameters.AddWithValue("@InsertDate",StockItem.InsertDate);
cmd.Parameters.AddWithValue("@Updater",StockItem.Updater);
cmd.Parameters.AddWithValue("@UpdateDate",StockItem.UpdateDate);
  

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

        public RV Update(StockItem StockItem)
        {
            try
            {
                string sqlStr = "UPDATE prdSTOCKITEMS SET ID=@ID,FirmID=@FirmID,BranchID=@BranchID,SuppliarID=@SuppliarID,Code=@Code,Name=@Name,Barcode1=@Barcode1,Barcode2=@Barcode2,Barcode3=@Barcode3,Weight=@Weight,GroupCode1ID=@GroupCode1ID,GroupCode2ID=@GroupCode2ID,GroupCode3ID=@GroupCode3ID,UnitID1=@UnitID1,UnitID2=@UnitID2,UnitBuyingPrice=@UnitBuyingPrice,UnitSalesPrice=@UnitSalesPrice,VAT=@VAT,Balance=@Balance,HeighestStockAmount=@HeighestStockAmount,LowestStockAmount=@LowestStockAmount,OrderID=@OrderID,Active=@Active,Inserter=@Inserter,InsertDate=@InsertDate,Updater=@Updater,UpdateDate=@UpdateDate WHERE ID=";
                sqlStr += StockItem.ID;

                SqlCommand cmd = new SqlCommand(sqlStr, this.Connection);

                cmd.Parameters.AddWithValue("@ID",StockItem.ID);
cmd.Parameters.AddWithValue("@FirmID",StockItem.FirmID);
cmd.Parameters.AddWithValue("@BranchID",StockItem.BranchID);
cmd.Parameters.AddWithValue("@SuppliarID",StockItem.SuppliarID);
cmd.Parameters.AddWithValue("@Code",StockItem.Code);
cmd.Parameters.AddWithValue("@Name",StockItem.Name);
cmd.Parameters.AddWithValue("@Barcode1",StockItem.Barcode1);
cmd.Parameters.AddWithValue("@Barcode2",StockItem.Barcode2);
cmd.Parameters.AddWithValue("@Barcode3",StockItem.Barcode3);
cmd.Parameters.AddWithValue("@Weight",StockItem.Weight);
cmd.Parameters.AddWithValue("@GroupCode1ID",StockItem.GroupCode1ID);
cmd.Parameters.AddWithValue("@GroupCode2ID",StockItem.GroupCode2ID);
cmd.Parameters.AddWithValue("@GroupCode3ID",StockItem.GroupCode3ID);
cmd.Parameters.AddWithValue("@UnitID1",StockItem.UnitID1);
cmd.Parameters.AddWithValue("@UnitID2",StockItem.UnitID2);
cmd.Parameters.AddWithValue("@UnitBuyingPrice",StockItem.UnitBuyingPrice);
cmd.Parameters.AddWithValue("@UnitSalesPrice",StockItem.UnitSalesPrice);
cmd.Parameters.AddWithValue("@VAT",StockItem.VAT);
cmd.Parameters.AddWithValue("@Balance",StockItem.Balance);
cmd.Parameters.AddWithValue("@HeighestStockAmount",StockItem.HeighestStockAmount);
cmd.Parameters.AddWithValue("@LowestStockAmount",StockItem.LowestStockAmount);
cmd.Parameters.AddWithValue("@OrderID",StockItem.OrderID);
cmd.Parameters.AddWithValue("@Active",StockItem.Active);
cmd.Parameters.AddWithValue("@Inserter",StockItem.Inserter);
cmd.Parameters.AddWithValue("@InsertDate",StockItem.InsertDate);
cmd.Parameters.AddWithValue("@Updater",StockItem.Updater);
cmd.Parameters.AddWithValue("@UpdateDate",StockItem.UpdateDate);

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

        public RV DeleteStockItemByID(int ID)
        {
            try
            {
                string sqlStr = "DELETE FROM prdSTOCKITEMS WHERE ID=";
                sqlStr+=ID.ToString(); 
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


        public RV GetStockItemByID(int ID)
        {
            try
            {
                string selectString = "SELECT ID,FirmID,BranchID,SuppliarID,Code,Name,Barcode1,Barcode2,Barcode3,Weight,GroupCode1ID,GroupCode2ID,GroupCode3ID,UnitID1,UnitID2,UnitBuyingPrice,UnitSalesPrice,VAT,Balance,HeighestStockAmount,LowestStockAmount,OrderID,Active,Inserter,InsertDate,Updater,UpdateDate FROM prdSTOCKITEMS";
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


        public RV GetStockItems()
        {
            try
            {
                string selectString = "SELECT ID,FirmID,BranchID,SuppliarID,Code,Name,Barcode1,Barcode2,Barcode3,Weight,GroupCode1ID,GroupCode2ID,GroupCode3ID,UnitID1,UnitID2,UnitBuyingPrice,UnitSalesPrice,VAT,Balance,HeighestStockAmount,LowestStockAmount,OrderID,Active,Inserter,InsertDate,Updater,UpdateDate FROM prdSTOCKITEMS";
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
