using Oracle.ManagedDataAccess.Client;

namespace BookShopWinFrm.DataLayer
{
    /// <summary>
    /// Example only. Copy this pattern to a local POSContext.local.cs file and keep real credentials out of Git.
    /// </summary>
    public static class POSContextExample
    {
        public static OracleConnection CreateConnection()
        {
            var db = new OracleConnection
            {
                ConnectionString = "Data Source=YOUR_HOST:PORT/YOUR_SERVICE;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
            };

            return db;
        }
    }
}
