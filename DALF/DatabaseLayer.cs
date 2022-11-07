using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL
{
    public class DatabaseLayer
    {
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        public DatabaseLayer()
        {
            sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=Company_SD;Integrated Security=True");
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
        }

        public DataTable GetDepartments()
        {
            sqlCommand.CommandText = "select * from Departments";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public DataTable GetEmployees(int deptId)
        {
            sqlCommand.CommandText = $"select * from Employee where Dno={deptId}";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
        public bool NewEmployee(int ssn, string fname, string lname, int salary, DateTime birthdate, int did)
        {
            sqlConnection.Open();
            sqlCommand.CommandText = $"Insert Into Employee(SSN, Fname, Lname, Salary, Bdate, Dno) values ({ssn},'{fname}','{lname}',{salary},'{birthdate}', {did})";
            int rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rows >= 1) return true;
            else return false;
        }
        public bool UpdateEmployee(int ssn, string fname, string lname, int salary, DateTime birthdate, int did)
        {
            sqlConnection.Open();
            sqlCommand.CommandText = $"update Employee set Fname = '{fname}', Lname = '{lname}',Salary = {salary}, Bdate = '{birthdate}', Dno = {did} where SSN = {ssn}";
            int rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rows >= 1) return true;
            else return false;
        }
        public bool DelEmployee(int ssn)
        {
            sqlConnection.Open();
            sqlCommand.CommandText = $"delete from Employee where SSN={ssn}";
            int rows = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (rows >= 1) return true;
            else return false;
        }
    }
}
