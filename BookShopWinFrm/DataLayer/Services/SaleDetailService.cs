using BookShopWinFrm.DataLayer.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer.Services
{
    public class SaleDetailService
    {
        public static DataTable GetDetail(int saleid)
        {
            OracleCommand command = new OracleCommand("SaleDetailGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SaleId", saleid);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static void AddDetail(SaleDetail saleDetail)
        {
            OracleCommand command = new OracleCommand("SaleDetailAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.Add("P_SaleId", saleDetail.SaleId);
            command.Parameters.Add("P_ItemId", saleDetail.ItemId);
            command.Parameters.Add("P_Description", saleDetail.Description);
            command.Parameters.Add("P_Quantity", saleDetail.Quantity);
            command.Parameters.Add("P_UnitPriceAtSale", saleDetail.UnitPriceAtSale);
            command.Parameters.Add("P_DiscountAmount", saleDetail.DiscountAmount);
            command.Parameters.Add("P_Price", saleDetail.Price);
            
            command.ExecuteNonQuery();

        }
        internal static void DeleteDetail(int saleid)
        {
            OracleCommand command = new OracleCommand("SaleDetailDelete",
           POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SaleId", saleid);
            command.ExecuteNonQuery();
        }
    }
}
