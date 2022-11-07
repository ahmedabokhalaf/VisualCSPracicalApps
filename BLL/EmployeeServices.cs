using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL
{
    public class EmployeeServices
    {
        DatabaseLayer database = new DatabaseLayer();

        public List<Employee> GetAllEmployees(int did)
        {
            List<Employee> employees = new List<Employee>();
            foreach(DataRow row in database.GetEmployees(did).Rows)
            {
                Employee e = new Employee();
                e.FirstName = row["Fname"].ToString();
                e.LastName = row["Lname"].ToString();
                e.Salary = (int)row["Salary"];
                e.Birthdate = (DateTime)row["Bdate"];
                employees.Add(e);
            }
            return employees;
        }

        public void AddEmployee(int ssn, string fname, string lname, int salary, DateTime bdate)
        {
            database.NewEmployee(ssn, fname, lname, salary, bdate);
        }
        public void EditEmployee(int ssn, string fname, string lname, int salary, DateTime bdate)
        {
            database.UpdateEmployee(ssn, fname, lname, salary, bdate);
        }
        public void DeleteEmployee(int ssn)
        {
            database.DelEmployee(ssn);
        }
    }
}
