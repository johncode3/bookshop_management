using Oracle.ManagedDataAccess.Client;
using System;

namespace BookShopWinFrm.DataLayer
{
    // EXAMPLE only: do NOT commit real credentials. 
    // Copy this file to POSContext.local.cs and edit the connection string for local development.
    // POSContext.cs in the repository loads the connection string from the environment (BOOKSHOP_CONNECTION_STRING).
    public class POSContextExample
    {
        static OracleConnection db;
        public static void OpenConnection()
        {
            if (db == null)
            {
                db = new OracleConnection();
                // Replace the placeholder password below with your local DB password before copying to POSContext.local.cs
                db.ConnectionString = "Data Source=localhost:1521/XEPDB1;User Id=BookShop;Password=your_password_here;";
                db.Open();
            }
        }
        public static OracleConnection GetConnection()
        {
            if (db == null)
            {
                OpenConnection();
            }
            return db;
        }
        public static void CloseConnection()
        {
            if (db != null)
            {
                db.Close();
            }
            db = null;
        }
    }
}
