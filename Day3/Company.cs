using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    delegate bool Filter(int age);
    delegate void Notify(double s);
    class Company
    {
        //public event Notify Notify;
        public string Name { get; set; }
        public double Budget { get; set; }
        public List<Employee> Employees { get; set; }
        public Company()
        {
            Employees = new List<Employee>();
        }
        public List<Employee> FilterEmployees(List<Employee> employees, Filter filter)
        {
            List<Employee> FilteredEmps = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if(Employee.IsRealEmp(employee.Age))
                {
                    FilteredEmps.Add(employee);
                }
            }
            return FilteredEmps;
        }
        public void DecreaseBudget(double amount)
        {
            Budget-=amount;
        }
    }
    class Employee
    {
        public event Notify Notify;
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public Employee(string _Name, int _Age, double _Salary)
        {
            Name = _Name;
            Age = _Age;
            Salary = _Salary;
        }
        public static bool IsRealEmp(int age)
        {
            if (age > 20 && age < 60)
            {
                return true;
            }
            return false;
        }
        public void IncreaseSalary(double amount)
        {
            Notify.Invoke(amount);
            Salary += amount;
            Console.WriteLine($"{Name} Salary increased by {amount}");
        }
        public override string ToString()
        {
            return $"{Name} is {Age} years old and take {Salary} EGP monthly";
        }
    }
}
