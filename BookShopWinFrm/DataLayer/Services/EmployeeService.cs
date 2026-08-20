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
    public class EmployeeService
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("EmployeeGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter adapter = new OracleDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Columns.Contains("HaveSpouse"))
            {
                table.Columns.Add("HaveSpouseText", typeof(string));

                foreach (DataRow row in table.Rows)
                {
                    if (row["HaveSpouse"] != DBNull.Value)
                    {
                        int val = Convert.ToInt32(row["HaveSpouse"]);
                        row["HaveSpouseText"] = (val == 1) ? "Yes" : "No";
                    }
                    else
                    {
                        row["HaveSpouseText"] = "No";
                    }
                }
                table.Columns.Remove("HaveSpouse");
                table.Columns["HaveSpouseText"].ColumnName = "HaveSpouse";
            }

            return table;
        }

        public static Employee Get(int employeeid)
        {
            Employee employee = null;
            OracleCommand command = new OracleCommand("EmployeeGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_EmployeeId", employeeid);

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                employee = new Employee();
                employee.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                employee.EmployeeName = reader["EmployeeName"]?.ToString() ?? "";
                employee.Sex = reader["Sex"]?.ToString() ?? "";
                employee.DOB = reader["DOB"] != DBNull.Value ? Convert.ToDateTime(reader["DOB"]) : DateTime.Now;
                employee.Address = reader["Address"]?.ToString() ?? "";
                employee.MaritalStatus = reader["MaritalStatus"]?.ToString() ?? "";
                employee.HaveSpouse = reader["HaveSpouse"] != DBNull.Value ? Convert.ToInt32(reader["HaveSpouse"]) : 0;
                employee.NumberOfChildren = reader["NumberOfChildren"] != DBNull.Value ? Convert.ToInt32(reader["NumberOfChildren"]) : 0;
                employee.HiredDate = reader["HiredDate"] != DBNull.Value ? Convert.ToDateTime(reader["HiredDate"]) : DateTime.Now;
                employee.Position = reader["Position"]?.ToString() ?? "";
                employee.Department = reader["Department"]?.ToString() ?? "";
                employee.Salary = reader["Salary"] != DBNull.Value ? Convert.ToDecimal(reader["Salary"]) : 0;
                employee.IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToInt32(reader["IsActive"]) : 1;
            }
            reader.Close();

            return employee;
        }

        public static int Add(Employee employee)
        {
            OracleCommand command = new OracleCommand("EmployeeAdd", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            int newId = 0;
            command.Parameters.Add("P_EmployeeName", employee.EmployeeName ?? (object)DBNull.Value);
            command.Parameters.Add("P_Sex", employee.Sex ?? (object)DBNull.Value);
            command.Parameters.Add("P_DoB", employee.DOB);
            command.Parameters.Add("P_Address", employee.Address ?? (object)DBNull.Value);
            command.Parameters.Add("P_MaritalStatus", employee.MaritalStatus ?? (object)DBNull.Value);
            command.Parameters.Add("P_HaveSpouse", employee.HaveSpouse);
            command.Parameters.Add("P_NumberOfChildren", employee.NumberOfChildren);
            command.Parameters.Add("P_HiredDate", employee.HiredDate);
            command.Parameters.Add("P_Position", employee.Position ?? (object)DBNull.Value);
            command.Parameters.Add("P_Department", employee.Department ?? (object)DBNull.Value);
            command.Parameters.Add("P_Salary", employee.Salary);
            command.Parameters.Add("P_IsActive", employee.IsActive);

            OracleParameter outId = new OracleParameter("P_EmployeeId", OracleDbType.Int32);
            outId.Direction = ParameterDirection.Output;
            command.Parameters.Add(outId);

            command.ExecuteNonQuery();

            if (outId.Value != null && outId.Value != DBNull.Value)
            {
                newId = Convert.ToInt32(outId.Value.ToString());
            }
            return newId;
        }

        public static void Update(Employee employee)
        {
            OracleCommand command = new OracleCommand("EmployeeUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_EmployeeId", employee.EmployeeId);
            command.Parameters.Add("P_EmployeeName", employee.EmployeeName ?? (object)DBNull.Value);
            command.Parameters.Add("P_Sex", employee.Sex ?? (object)DBNull.Value);
            command.Parameters.Add("P_DoB", employee.DOB);
            command.Parameters.Add("P_Address", employee.Address ?? (object)DBNull.Value);
            command.Parameters.Add("P_MaritalStatus", employee.MaritalStatus ?? (object)DBNull.Value);
            command.Parameters.Add("P_HaveSpouse", employee.HaveSpouse);
            command.Parameters.Add("P_NumberOfChildren", employee.NumberOfChildren);
            command.Parameters.Add("P_HiredDate", employee.HiredDate);
            command.Parameters.Add("P_Position", employee.Position ?? (object)DBNull.Value);
            command.Parameters.Add("P_Department", employee.Department ?? (object)DBNull.Value);
            command.Parameters.Add("P_Salary", employee.Salary);
            command.Parameters.Add("P_IsActive", employee.IsActive);

            command.ExecuteNonQuery();
        }

        public static int Delete(int employeeid)
        {
            OracleCommand command = new OracleCommand("EmployeeDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_EmployeeId", employeeid);
            return command.ExecuteNonQuery();
        }
    }
}