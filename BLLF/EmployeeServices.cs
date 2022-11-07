using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

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
                e.ID = (int)row["SSN"];
                e.FirstName = row["Fname"].ToString();
                e.LastName = row["Lname"].ToString();
                e.Salary = (int)row["Salary"];
                e.Birthdate = (DateTime)row["Bdate"];
                e.Did = (int)row["Dno"];
                employees.Add(e);
            }
            return employees;
        }

        public void AddEmployee(int ssn, string fname, string lname, int salary, DateTime bdate, int did)
        {
            if(database.NewEmployee(ssn, fname, lname, salary, bdate, did))
            {
                MessageBox.Show($"Inserting Process Succeeded");
            }
            else
            {
                MessageBox.Show($"Inserting Process Failed");
            }
        }
        public void EditEmployee(int ssn, string fname, string lname, int salary, DateTime bdate, int did)
        {
            if(database.UpdateEmployee(ssn, fname, lname, salary, bdate, did))
            {
                MessageBox.Show($"Updating Process Succeeded");
            }
            else
            {
                MessageBox.Show($"Deleteing Process Failed");
            }
        }
        public void DeleteEmployee(int ssn)
        {
            if (database.DelEmployee(ssn))
            {
                MessageBox.Show($"Deleteing Process Succeeded");
            }
            else
            {
                MessageBox.Show($"Deleteing Process Faild");
            }
        }
    }
}
