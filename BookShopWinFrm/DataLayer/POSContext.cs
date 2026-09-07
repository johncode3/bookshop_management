using Oracle.ManagedDataAccess.Client;
using System;
using System.Reflection;

namespace BookShopWinFrm.DataLayer
{
    public class POSContext
    {
        private static OracleConnection db;

        public static void OpenConnection()
        {
            if (db != null)
                return;

            db = new OracleConnection();
            db.ConnectionString = ResolveConnectionString();
            db.Open();
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

        private static string ResolveConnectionString()
        {
            string localConnection = TryGetLocalConnectionString();
            if (!string.IsNullOrWhiteSpace(localConnection))
                return localConnection;

            string envConnection = Environment.GetEnvironmentVariable("BOOKSHOP_ORACLE_CONNECTION");
            if (!string.IsNullOrWhiteSpace(envConnection))
                return envConnection;

            throw new InvalidOperationException("Oracle connection string is not configured. Create a local POSContext.local.cs or set BOOKSHOP_ORACLE_CONNECTION.");
        }

        private static string TryGetLocalConnectionString()
        {
            Type localType = Type.GetType("BookShopWinFrm.DataLayer.POSContextLocal, BookShopWinFrm");
            MethodInfo method = localType?.GetMethod("GetConnectionString", BindingFlags.Public | BindingFlags.Static);
            return method?.Invoke(null, null) as string;
        }
    }
}
