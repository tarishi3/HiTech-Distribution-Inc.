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
    public class CustomerDB
    {
        public static DataSet dsHiTechDB;
        public static DataTable dtCollege;
        public static SqlDataAdapter da;
        public static SqlConnection connDB = UtilityDB.ConnectDB();

        public static DataTable ReadCustomer() {


            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
            }
            
            dsHiTechDB = new DataSet("hiTechDB");
            dtCollege = new DataTable("Customer");
            DataColumn column = new DataColumn();
            column.ColumnName = "CustomerId";
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 4;
            column.AutoIncrementStep = 1;
            dtCollege.Columns.Add(column);
            dtCollege.Columns.Add("FirstName", typeof(String));
            dtCollege.Columns.Add("LastName", typeof(String));
            dtCollege.Columns.Add("Street", typeof(String));
            dtCollege.Columns.Add("City", typeof(String));
            dtCollege.Columns.Add("Postal", typeof(String));
            dtCollege.Columns.Add("Phone", typeof(String));
            dtCollege.Columns.Add("FaxNumber", typeof(String));
            dtCollege.Columns.Add("CreditLimit", typeof(Double));

            dtCollege.PrimaryKey = new DataColumn[] { dtCollege.Columns["CustomerId"] };
            dsHiTechDB.Tables.Add(dtCollege);
            da = new SqlDataAdapter("select * from Customers", connDB);
            da.Fill(dsHiTechDB.Tables["Customer"]);

            return dtCollege;
        }

        public static bool SaveRecord(Customer customer)
        {
            bool result = true;

            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                }
                string fname = customer.FirstName;
                string lname = customer.LastName;
                string street = customer.Street;
                string city = customer.City;
                string postal = customer.Postal;
                string phone = customer.Phone;
                string fax = customer.FaxNumber;
                double credit = customer.CreditLimit;
                dtCollege.Rows.Add(new object[] { null, fname, lname, street, city, postal, phone, fax, credit });
                string que = string.Format("Insert into Customers(FirstName, LastName, Street, City, Postal, Phone, FaxNumber, CreditLimit) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})", fname, lname, street, city, postal, phone, fax, Convert.ToDecimal(credit));
                da.InsertCommand = new SqlCommand(que, connDB);
                da.Update(dsHiTechDB, "Customer");
                connDB.Close();
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        
        }

        public static bool UpdateRecord(Customer customer)
        {
            bool result = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                }
                int customerId = customer.CustomerId;
                string fname = customer.FirstName;
                string lname = customer.LastName;
                string street = customer.Street;
                string city = customer.City;
                string postal = customer.Postal;
                string phone = customer.Phone;
                string fax = customer.FaxNumber;
                double credit = customer.CreditLimit;
                string que = string.Format("Update Customers set FirstName = '{1}', LastName = '{2}', Street = '{3}', City = '{4}', Postal = '{5}', Phone = '{6}', FaxNumber = '{7}', CreditLimit = {8} where CustomerID = {0}", customerId, fname, lname, street, city, postal, phone, fax, Convert.ToDecimal(credit));
                SqlCommand cmd = new SqlCommand(que, connDB);
                cmd.ExecuteNonQuery();
                connDB.Close();

            }
            catch (Exception)
            {
                result = false;
            }
            return result;

        }

        public static bool DeleteRecord(Customer customer)
        {
            bool result = true;
            try
            {
                if (connDB.State == ConnectionState.Closed)
                {
                    connDB = UtilityDB.ConnectDB();
                }
                int customerId = customer.CustomerId;
                DataRow dr = dtCollege.Rows.Find(customerId);
                dr.Delete();
                string que = string.Format("Delete from Customers where CustomerID = {0}", customerId);
                da.DeleteCommand = new SqlCommand(que, connDB);
                da.Update(dsHiTechDB, "Customer");
                connDB.Close();

            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public static DataTable SearchCustomer(Customer cutomer)
        {
            if (connDB.State == ConnectionState.Closed)
            {
                connDB = UtilityDB.ConnectDB();
            }
            DataTable newCustomer = new DataTable();
            DataTable dtCollege2 = new DataTable();

            dtCollege2 = dtCollege.Copy();
            newCustomer = dtCollege.Copy();

            newCustomer.Clear();
            if (dsHiTechDB.Tables.Contains("newCustomer") == false)
            {
                dsHiTechDB.Tables.Add("newCustomer");
            }
            foreach (DataRow row in dtCollege2.Rows)
            {
                if (row["Firstname"].ToString() == cutomer.FirstName)
                {
                    newCustomer.ImportRow(row);
                }
            }
            connDB.Close();
            return newCustomer;
        }

    }
}
