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
    public class PurchaseDetailService
    {
        public static DataTable GetDetail(int purchaseid)
        {
            OracleCommand command = new OracleCommand("PurchaseDetailGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchaseid);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static void AddDetail(PurchaseDetail purchaseDetail)
        {
            OracleCommand command = new OracleCommand("PurchaseDetailAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.Add("P_PurchaseId", purchaseDetail.PurchaseId);
            command.Parameters.Add("P_ItemId", purchaseDetail.ItemId);
            command.Parameters.Add("P_Description", purchaseDetail.Description);
            command.Parameters.Add("P_Quantity", purchaseDetail.Quantity);
            command.Parameters.Add("P_UnitPriceAtSale", purchaseDetail.UnitPriceAtSale);
            command.Parameters.Add("P_DiscountAmount", purchaseDetail.DiscountAmount);
            command.Parameters.Add("P_Price", purchaseDetail.Price);
            
            command.ExecuteNonQuery();

        }
        internal static void DeleteDetail(int purchaseid)
        {
            OracleCommand command = new OracleCommand("PurchaseDetailDelete",
           POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchaseid);
            command.ExecuteNonQuery();
        }
    }
}
