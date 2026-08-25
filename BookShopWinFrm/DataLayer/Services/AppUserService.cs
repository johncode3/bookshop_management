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
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
                appuser.EmployeeId = Convert.ToInt32(reader["EmployeeId"].ToString());
                appuser.Username = reader["UserName"].ToString();
                appuser.Password = reader["Password"].ToString();
                appuser.Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null;
                appuser.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                appuser.IsAdmin = Convert.ToBoolean(reader["IsAdmin"].ToString());
            }
            return appuser;
        }
        public static Add(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("AppUserAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_EmployeeId", appuser.EmployeeId);
            command.Parameters.Add("P_UserName", appuser.Username);
            command.Parameters.Add("P_Password", appuser.Password);
            command.Parameters.Add("P_Avatar", appuser.Avatar);
            command.Parameters.Add("P_IsActive", appuser.IsActive);
            command.Parameters.Add("P_IsAdmin", appuser.IsAdmin);
            command.ExecuteNonQuery();
        }
        public static update(AppUser appuser)
        {
            OracleCommand command = new OracleCommand("AppUserUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appuser.AppUserId);
            command.Parameters.Add("P_EmployeeId", appuser.EmployeeId);
            command.Parameters.Add("P_UserName", appuser.Username);
            command.Parameters.Add("P_Password", appuser.Password);
            command.Parameters.Add("P_Avatar", appuser.Avatar);
            command.Parameters.Add("P_IsActive", appuser.IsActive);
            command.Parameters.Add("P_IsAdmin", appuser.IsAdmin);
            command.ExecuteNonQuery();
        }
        public static delete(int appuserid)
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
                appuser.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
                appuser.EmployeeId = Convert.ToInt32(reader["EmployeeId"].ToString());
                appuser.Username = reader["UserName"].ToString();
                appuser.Password = reader["Password"].ToString();
                appuser.Avatar = reader["Avatar"] != DBNull.Value ? (byte[])reader["Avatar"] : null;
                appuser.IsActive = Convert.ToBoolean(reader["IsActive"].ToString());
                appuser.IsAdmin = Convert.ToBoolean(reader["IsAdmin"].ToString());
            }
            return appuser;
        }
        public static DataTable GetPermissions(int appuserid)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appuserid);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        internal static void AddPermission(AppUserPermission permission)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appUserPermission.AppUserId);
            command.Parameters.Add("P_PermissionId", appUserPermission.PermissionId);
            command.ExecuteNonQuery();
        }
        internal static void DeletePermission(AppUserPermission permission)
        {
            OracleCommand command = new OracleCommand("AppUserPermissionDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", appUserPermission.AppUserId);
            command.Parameters.Add("P_PermissionId", appUserPermission.PermissionId);
            command.ExecuteNonQuery();
        }
    }
}