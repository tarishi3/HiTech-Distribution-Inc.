using FinalProject.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataAccess
{
    public class EmployeeDB
    {
        public static SqlConnection connDB = UtilityDB.ConnectDB();
        public static SqlCommand cmd = new SqlCommand();

        public static DataTable ReadEmployee()
        {
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }
            cmd.Connection = connDB;
            cmd.CommandText = "select * from Employees";
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cmd.Dispose();
            connDB.Close();
            return dt;
        }

        public static bool SaveRecord(Employee emp)
        {
            bool result = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("Insert into Employees(FirstName, LastName, Designation) values('{0}','{1}', '{2}')", emp.FirstName, emp.LastName, emp.Designation);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }

        public static bool UpdateRecord(Employee emp)
        {
            bool result = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("Update Employees set FirstName = '{1}', LastName = '{2}', Designation = '{3}' where EmployeeID = {0}", emp.EmployeeId, emp.FirstName, emp.LastName, emp.Designation);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }

        public static bool DeleteRecord(Employee emp)
        {
            bool result = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                    cmd = new SqlCommand();
                }
                cmd.Connection = connDB;
                cmd.CommandText = string.Format("Delete from Employees where EmployeeID = {0}", emp.EmployeeId);
                cmd.ExecuteNonQuery();
                connDB.Close();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }

        public static DataTable SearchEmployee(Employee emp)
        {
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
                cmd = new SqlCommand();
            }
            cmd.Connection = connDB;
            cmd.CommandText = String.Format("select * from Employees where Firstname = '{0}'", emp.FirstName);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            cmd.Dispose();
            connDB.Close();
            return dt;
        }
    }
}
