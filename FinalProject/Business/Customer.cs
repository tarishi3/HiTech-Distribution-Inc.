using FinalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string street;
        private string city;
        private string postal;
        private string phone;
        private string faxNumber;
        private double creditLimit;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string Postal { get => postal; set => postal = value; }
        public string Phone { get => phone; set => phone = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public double CreditLimit { get => creditLimit; set => creditLimit = value; }

        public DataTable ReadCustomer()
        {
            return CustomerDB.ReadCustomer();
        }

        public bool SaveRecord(Customer customer)
        {
           return CustomerDB.SaveRecord(customer);
        }

        public bool UpdateRecord(Customer customer)
        {
            return CustomerDB.UpdateRecord(customer);
        }

        public bool DeleteRecord(Customer customer)
        {
            return CustomerDB.DeleteRecord(customer);
        }

        public DataTable SearchCustomer(Customer customer)
        {
            return CustomerDB.SearchCustomer(customer);
        }
    }
}
