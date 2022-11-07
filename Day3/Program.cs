using System;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Employees.Add(new Employee("Ahmed", 25, 3500));
            company.Employees.Add(new Employee("Ali", 19, 1000));
            company.Employees.Add(new Employee("Mona", 40, 5000));
            company.Employees.Add(new Employee("Hasan", 35, 4000));
            List<Employee> list = new List<Employee>();
            list = company.FilterEmployees(company.Employees, Employee.IsRealEmp);
            company.Budget = 30000;
            foreach(Employee employee in list)
            {
                if (employee.Age == 40)
                {
                    employee.Notify += company.DecreaseBudget;
                    employee.IncreaseSalary(500);
                }
                Console.WriteLine(employee.ToString());
            }
            Console.WriteLine(company.Budget);
        }
    }
}
