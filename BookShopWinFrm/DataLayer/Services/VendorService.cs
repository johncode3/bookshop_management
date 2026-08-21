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
    public class VendorService
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("VendorGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_VendorId", OracleDbType.Int32).Value = 0;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static Vendor Get(int vendorid)
        {
            Vendor vendor = null;
            OracleCommand command = new OracleCommand("VendorGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_VendorId", vendorid);
            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                vendor = new Vendor();
                vendor.VendorId = Convert.ToInt32(reader["VendorId"].ToString());
                vendor.VendorName = reader["VendorName"].ToString();
                vendor.CompanyName = reader["CompanyName"].ToString();
                vendor.Phone = reader["Phone"].ToString();
                vendor.Email = reader["Email"].ToString();
                vendor.Address = reader["Address"].ToString();
                vendor.IsDeleted = Convert.ToInt32(reader["IsDeleted"].ToString());
            }
            reader.Close();
            return vendor;
        }
        public static int Add(Vendor vendor)
        {
            OracleCommand command = new OracleCommand("VendorAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            int newId = 0;
            command.Parameters.Add("P_VendorName", vendor.VendorName);
            command.Parameters.Add("P_CompanyName", vendor.CompanyName);
            command.Parameters.Add("P_Phone", vendor.Phone);
            command.Parameters.Add("P_Email", vendor.Email);
            command.Parameters.Add("P_Address", vendor.Address);

            OracleParameter outId = new OracleParameter("P_ItemId", OracleDbType.Int32);
            outId.Direction = ParameterDirection.Output;
            command.Parameters.Add(outId);

            command.ExecuteNonQuery();

            if (outId.Value != null && outId.Value != DBNull.Value)
            {
                newId = Convert.ToInt32(outId.Value.ToString());
            }
            return newId;
        }
        public static void Update(Vendor vendor)
        {
            OracleCommand command = new OracleCommand("VendorUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_VendorId", vendor.VendorId);
            command.Parameters.Add("P_VendorName", vendor.VendorName);
            command.Parameters.Add("P_CompanyName", vendor.CompanyName);
            command.Parameters.Add("P_Phone", vendor.Phone);
            command.Parameters.Add("P_Email", vendor.Email);
            command.Parameters.Add("P_Address", vendor.Address);
            command.ExecuteNonQuery();
        }
        public static void Delete(int vendorid)
        {
            OracleCommand command = new OracleCommand("VendorDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_VendorId", vendorid);
            command.ExecuteNonQuery();
        }
    }
}
