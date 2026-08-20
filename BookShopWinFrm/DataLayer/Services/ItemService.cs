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
    public class ItemService
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("ItemGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static Item Get(int itemid)
        {
            Item item = null;
            OracleCommand command = new OracleCommand("ItemGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_ItemId", itemid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                item = new Item();
                item.ItemId = Convert.ToInt32(reader["ItemId"]);
                item.ItemName = reader["ItemName"]?.ToString() ?? "";
                item.Category = reader["Category"]?.ToString() ?? "";
                item.Author = reader["Author"]?.ToString() ?? "";
                item.Rating = reader["Rating"] != DBNull.Value ? Convert.ToDecimal(reader["Rating"]) : 0;
                item.ItemDescription = reader["ItemDescription"]?.ToString() ?? "";
                item.Quantity = reader["Quantity"] != DBNull.Value ? Convert.ToDecimal(reader["Quantity"]) : 0;
                item.SalePrice = reader["SalePrice"] != DBNull.Value ? Convert.ToDecimal(reader["SalePrice"]) : 0;

                if (reader["Thumbnail"] != DBNull.Value)
                    item.Thumnail = (byte[])reader["Thumbnail"];

                item.IsDeleted = Convert.ToInt32(reader["IsDeleted"]);
            }
            reader.Close();
            return item;
        }
        public static int Add(Item item)
        {
            OracleCommand command = new OracleCommand("ItemAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            int newId = 0;
            command.Parameters.Add("P_ItemName", item.ItemName);
            command.Parameters.Add("P_Category", item.Category ?? (object)DBNull.Value);
            command.Parameters.Add("P_Author", item.Author ?? (object)DBNull.Value);
            command.Parameters.Add("P_Rating", item.Rating);
            command.Parameters.Add("P_ItemDescription", item.ItemDescription ?? (object)DBNull.Value);
            command.Parameters.Add("P_Quantity", item.Quantity);
            command.Parameters.Add("P_SalePrice", item.SalePrice);

            OracleParameter thumbParam = new OracleParameter("P_Thumbnail", OracleDbType.Blob);
            thumbParam.Value = item.Thumnail ?? (object)DBNull.Value;
            command.Parameters.Add(thumbParam);

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
        public static void Update(Item item)
        {
            OracleCommand command = new OracleCommand("ItemUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_ItemId", item.ItemId);
            command.Parameters.Add("P_ItemName", item.ItemName);
            command.Parameters.Add("P_Category", item.Category ?? (object)DBNull.Value);
            command.Parameters.Add("P_Author", item.Author ?? (object)DBNull.Value);
            command.Parameters.Add("P_Rating", item.Rating);
            command.Parameters.Add("P_ItemDescription", item.ItemDescription ?? (object)DBNull.Value);
            command.Parameters.Add("P_Quantity", item.Quantity);
            command.Parameters.Add("P_SalePrice", item.SalePrice);

            OracleParameter thumbParam = new OracleParameter("P_Thumbnail", OracleDbType.Blob);
            thumbParam.Value = item.Thumnail ?? (object)DBNull.Value;
            command.Parameters.Add(thumbParam);

            command.ExecuteNonQuery();
        }
        public static void Delete(int itemid)
        {
            OracleCommand command = new OracleCommand("ItemDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_ItemId", itemid);
            command.ExecuteNonQuery();
        }
    }
}