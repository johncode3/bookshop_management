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
    public class SaleService
    {
        //Sale 
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("SaleGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static Sale Get(int saleid)
        {
            Sale sale = null;
            OracleCommand command = new OracleCommand("SaleGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SaleId", saleid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                sale = new Sale();
                sale.SaleId = Convert.ToInt32(reader["SaleId"]);
                sale.SaleDate = Convert.ToDateTime(reader["SaleDate"].ToString());
                sale.RefNumber = reader["RefNumber"].ToString();
                sale.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
                sale.EmployeeId = Convert.ToInt32(reader["EmployeeId"].ToString());
                sale.TotalAmount = Convert.ToDecimal(reader["TotalAmount"].ToString());
                sale.Status = reader["Status"].ToString();
                sale.Note = reader["Note"].ToString();
            }
            reader.Close();

            return sale;
        }
        public static int Add(Sale sale)
        {
            OracleCommand command = new OracleCommand("saleAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            int saleid = 0;
            command.Parameters.Add("P_SaleDate", sale.SaleDate);
            command.Parameters.Add("P_RefNumber", sale.RefNumber);
            command.Parameters.Add("P_CustomerId", sale.CustomerId);
            command.Parameters.Add("P_EmployeeId", sale.EmployeeId);
            command.Parameters.Add("P_TotalAmount", sale.TotalAmount);
            command.Parameters.Add("P_Status", sale.Status);
            command.Parameters.Add("P_Note", sale.Note);
            command.Parameters.Add("P_SaleId", OracleDbType.Int32).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            saleid = Convert.ToInt32(command.Parameters["P_SaleId"].Value.ToString());
            return saleid;
        }
        public static void Update(Sale sale)
        {
            OracleCommand command = new OracleCommand("SaleUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_SaleId", sale.SaleId);
            command.Parameters.Add("P_SaleDate", sale.SaleDate);
            command.Parameters.Add("P_RefNumber", sale.RefNumber);
            command.Parameters.Add("P_CustomerId", sale.CustomerId);
            command.Parameters.Add("P_EmployeeId", sale.EmployeeId);
            command.Parameters.Add("P_TotalAmount", sale.TotalAmount);
            command.Parameters.Add("P_Status", sale.Status);
            command.Parameters.Add("P_Note", sale.Note);
            command.ExecuteNonQuery();
        }

        public static void Delete(Sale sale)
        {
            OracleCommand command = new OracleCommand("SaleDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_SaleId", sale.SaleId);
            command.ExecuteNonQuery();
        }



        //SaleDetail
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
