using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopWinFrm.DataLayer
{
    public class POSContext
    {
        static OracleConnection db;
        public static void OpenConnection()
        {
            if (db == null)
            {
                db = new OracleConnection();
                db.ConnectionString = "Data Source=localhost:1521/XEPDB1;User Id=BookShop;Password=1234;";
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