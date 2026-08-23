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
    public class InventoryAdjustmentService
    {
        //InventoryAdjustment
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("InventoryAdjustmentGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static InventoryAdjustment Get(int inventoryadjustmentid)
        {
            InventoryAdjustment inventoryadjustment = null;
            OracleCommand command = new OracleCommand("InventoryAdjustmentGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_InvAdjId", inventoryadjustmentid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                inventoryadjustment = new InventoryAdjustment();
                inventoryadjustment.InventoryAdjustmentId = Convert.ToInt32(reader["InventoryAdjustmentId"]);
                inventoryadjustment.AdjustmentDate = Convert.ToDateTime(reader["AdjustmentDate"].ToString());
                inventoryadjustment.RefNumber = reader["RefNumber"].ToString();
                inventoryadjustment.EmployeeId = Convert.ToInt32(reader["EmployeeId"].ToString());
                inventoryadjustment.Note = reader["Note"].ToString();
            }
            reader.Close();

            return inventoryadjustment;
        }
        public static int Add(InventoryAdjustment inventoryadjustment)
        {
            OracleCommand command = new OracleCommand("InventoryAdjustmentAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            int inventoryadjustmentid = 0;
            command.Parameters.Add("P_AdjustmentDate", inventoryadjustment.AdjustmentDate);
            command.Parameters.Add("P_RefNumber", inventoryadjustment.RefNumber);
            command.Parameters.Add("P_EmployeeId", inventoryadjustment.EmployeeId);
            command.Parameters.Add("P_Note", inventoryadjustment.Note);
            command.Parameters.Add("P_InvAdjId", OracleDbType.Int32).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            inventoryadjustmentid = Convert.ToInt32(command.Parameters["P_InvAdjId"].Value.ToString());
            return inventoryadjustmentid;
        }
        public static void Update(InventoryAdjustment inventoryadjustment)
        {
            OracleCommand command = new OracleCommand("InventoryAdjustmentUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_InvAdjId", inventoryadjustment.InventoryAdjustmentId);
            command.Parameters.Add("P_AdjustmentDate", inventoryadjustment.AdjustmentDate);
            command.Parameters.Add("P_RefNumber", inventoryadjustment.RefNumber);
            command.Parameters.Add("P_EmployeeId", inventoryadjustment.EmployeeId);
            command.Parameters.Add("P_Note", inventoryadjustment.Note);
            command.ExecuteNonQuery();
        }

        //InventoryAdjustmentDetail
        public static DataTable GetDetail(int inventoryadjustmentid)
        {
            OracleCommand command = new OracleCommand("InvAdjDetailGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_InvAdjId", inventoryadjustmentid);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static void AddDetail(InventoryAdjustmentDetail inventoryDetail)
        {
            OracleCommand command = new OracleCommand("InvAdjDetailAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_InvAdjId", inventoryDetail.InventoryAdjustmentId);
            command.Parameters.Add("P_ItemId", inventoryDetail.ItemId);
            command.Parameters.Add("P_Description", inventoryDetail.Description);
            command.Parameters.Add("P_Quantity", inventoryDetail.Quantity);
            command.Parameters.Add("P_UnitPrice", inventoryDetail.UnitPrice);
            command.Parameters.Add("P_TotalAmount", inventoryDetail.TotalAmount);

            command.ExecuteNonQuery();
        }
        internal static void DeleteDetail(int invAdjId)
        {
            OracleCommand command = new OracleCommand("DELETE FROM InventoryAdjustmentDetail WHERE InventoryAdjustmentId = :id", POSContext.GetConnection());
            command.Parameters.Add(":id", invAdjId);
            command.ExecuteNonQuery();
        }
    }

}
