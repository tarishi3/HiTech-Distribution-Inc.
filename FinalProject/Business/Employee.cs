using FinalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Business
{
    public class Employee
    {
        private int employeeId;
        private string firstName;
        private string lastName;
        private string designation;
        
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Designation { get => designation; set => designation = value; }
        

        public DataTable ReadEmployee()
        {
            return EmployeeDB.ReadEmployee();
        }

        public bool SaveRecord(Employee emp)
        {
            return EmployeeDB.SaveRecord(emp);
        }

        public bool UpdateRecord(Employee emp)
        {
            return EmployeeDB.UpdateRecord(emp);
        }

        public bool DeleteRecord(Employee emp)
        {
            return EmployeeDB.DeleteRecord(emp);
        }

        public DataTable SearchEmployee(Employee emp)
        {
            return EmployeeDB.SearchEmployee(emp);
        }
    }
}
