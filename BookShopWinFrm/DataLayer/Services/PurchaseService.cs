using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopWinFrm.DataLayer.Model;
using Oracle.ManagedDataAccess.Client;

namespace BookShopWinFrm.DataLayer.Services
{
    public class PurchaseService
    {
        //Purchase
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("PurchaseGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static Purchase Get(int purchaseid)
        {
            Purchase purchase = null;
            OracleCommand command = new OracleCommand("PurchaseGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchaseid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                purchase = new Purchase();
                purchase.PurchaseId = Convert.ToInt32(reader["PurchaseId"]);
                purchase.PurchaseDate = Convert.ToDateTime(reader["PurchaseDate"].ToString());
                purchase.RefNumber = reader["RefNumber"].ToString();
                purchase.VendorId = Convert.ToInt32(reader["VendorId"].ToString());
                purchase.EmployeeId = Convert.ToInt32(reader["EmployeeId"].ToString());
                purchase.TotalAmount = Convert.ToDecimal(reader["TotalAmount"].ToString());
                purchase.Status = reader["Status"].ToString();
                purchase.Note = reader["Note"].ToString();
            }
            reader.Close();

            return purchase;
        }
        public static int Add(Purchase purchase)
        {
            OracleCommand command = new OracleCommand("PurchaseAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            int purchaseid = 0;
            command.Parameters.Add("P_PurchaseDate", purchase.PurchaseDate);
            command.Parameters.Add("P_RefNumber", purchase.RefNumber);
            command.Parameters.Add("P_VendorId", purchase.VendorId);
            command.Parameters.Add("P_EmployeeId", purchase.EmployeeId);
            command.Parameters.Add("P_TotalAmount", purchase.TotalAmount);
            command.Parameters.Add("P_Status", purchase.Status);
            command.Parameters.Add("P_Note", purchase.Note);
            command.Parameters.Add("P_PurchaseId", OracleDbType.Int32).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            purchaseid = Convert.ToInt32(command.Parameters["P_PurchaseId"].Value.ToString());
            return purchaseid;
        }
        public static void Update(Purchase purchase)
        {
            OracleCommand command = new OracleCommand("PurchaseUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_PurchaseId", purchase.PurchaseId);
            command.Parameters.Add("P_PurchaseDate", purchase.PurchaseDate);
            command.Parameters.Add("P_RefNumber", purchase.RefNumber);
            command.Parameters.Add("P_VendorId", purchase.VendorId);
            command.Parameters.Add("P_EmployeeId", purchase.EmployeeId);
            command.Parameters.Add("P_TotalAmount", purchase.TotalAmount);
            command.Parameters.Add("P_Status", purchase.Status);
            command.Parameters.Add("P_Note", purchase.Note);
            command.ExecuteNonQuery();
        }

        public static void Delete(Purchase purchase)
        {
            OracleCommand command = new OracleCommand("PurchaseDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_PurchaseId", purchase.PurchaseId);
            command.ExecuteNonQuery();
        }

        //PurchaseDetail
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
