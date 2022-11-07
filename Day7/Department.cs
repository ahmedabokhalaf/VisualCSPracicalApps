using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Department
    {
        List<int> Id = new List<int>();
        List<Employee> employees = new List<Employee>();
        public bool Added { get; set; }
        public Department()
        {
            Id.Add(1);
            Id.Add(2);
            Id.Add(3);
            Id.Add(4);
            Added = false;
        }
        public void AddEmp(Employee e)
        {
            //bool IsAdded = false;
            foreach(int i in Id)
            {
                if (i == e.DeptId)
                {
                    employees.Add(e);
                    Added = true;
                    Console.WriteLine("Employee Added Successfully");
                }
            }
            //if (!IsAdded)
            //{
            //    Id.Add(e.DeptId);
            //    employees.Add(e);
            //}
        }
        public void AddDept(Employee e)
        {
            if (!Added)
            {
                Id.Add(e.DeptId);
                employees.Add(e);
            }
            Console.WriteLine("Employee Added Successfully in New Department");
        }
    }
}