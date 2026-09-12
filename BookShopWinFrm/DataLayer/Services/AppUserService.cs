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
    public class AppUserService
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("AppUserGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static AppUser Get(int userid)
        {
            AppUser appuser = null;
            OracleCommand command = new OracleCommand("AppUserGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", userid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                appuser = new AppUser();
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"]);
                appuser.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                appuser.UserName = reader["UserName"]?.ToString() ?? "";
                appuser.Password = reader["Password"]?.ToString() ?? "";
                appuser.Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null;
                appuser.IsActive = Convert.ToInt32(reader["IsActive"]) == 1;
                appuser.IsAdmin = Convert.ToInt32(reader["IsAdmin"]) == 1;
            }
            reader.Close();
            return appuser;
        }

        public static int Add(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("AppUserAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            int newId = 0;
            command.Parameters.Add("P_EmployeeId", appuser.EmployeeId);
            command.Parameters.Add("P_UserName", appuser.UserName);
            command.Parameters.Add("P_Password", appuser.Password);
            OracleParameter thumbParam = new OracleParameter("P_Avatar", OracleDbType.Blob);
            thumbParam.Value = appuser.Avatar ?? (object)DBNull.Value;
            command.Parameters.Add(thumbParam);
            command.Parameters.Add("P_IsActive", appuser.IsActive ? 1 : 0);
            command.Parameters.Add("P_IsAdmin", appuser.IsAdmin ? 1 : 0);


            OracleParameter outId = new OracleParameter("P_AppUserId", OracleDbType.Int32);
            outId.Direction = ParameterDirection.Output;
            command.Parameters.Add(outId);

            command.ExecuteNonQuery();

            if (outId.Value != null && outId.Value != DBNull.Value)
            {
                newId = Convert.ToInt32(outId.Value.ToString());
            }
            return newId;
        }

        public static void Update(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("AppUserUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appuser.AppUserId);
            command.Parameters.Add("P_EmployeeId", appuser.EmployeeId);
            command.Parameters.Add("P_UserName", appuser.UserName);
            command.Parameters.Add("P_Password", appuser.Password);
            OracleParameter thumbParam = new OracleParameter("P_Avatar", OracleDbType.Blob);
            thumbParam.Value = appuser.Avatar ?? (object)DBNull.Value;
            command.Parameters.Add(thumbParam);
            command.Parameters.Add("P_IsActive", appuser.IsActive ? 1 : 0);
            command.Parameters.Add("P_IsAdmin", appuser.IsAdmin ? 1 : 0);


            command.ExecuteNonQuery();
        }

        public static void Delete(int appuserid)
        {
            OracleCommand command = new OracleCommand("AppUserDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appuserid);
            command.ExecuteNonQuery();
        }

        public static AppUser Login(string username, string password)
        {
            AppUser appuser = null;
            OracleCommand command = new OracleCommand("AppUserLogin", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_UserName", username);
            command.Parameters.Add("P_Password", password);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                appuser = new AppUser();
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"]);
                appuser.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                appuser.UserName = reader["UserName"]?.ToString() ?? "";
                appuser.Password = reader["Password"]?.ToString() ?? "";
                appuser.Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null;
                appuser.IsActive = Convert.ToInt32(reader["IsActive"]) == 1;
                appuser.IsAdmin = Convert.ToInt32(reader["IsAdmin"]) == 1;
            }
            reader.Close();
            return appuser;
        }

        public static DataTable GetUserPermissions(int appuserid)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appuserid);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        internal static void AddUserPermission(AppUserPermission appUserpermission)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appUserpermission.AppUserId);
            command.Parameters.Add("P_PermissionName", appUserpermission.PermissionName);
            command.ExecuteNonQuery();
        }

        internal static void DeleteUserPermission(AppUserPermission appUserpermission)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appUserpermission.AppUserId);
            command.ExecuteNonQuery();
        }
    }
}