using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Employee
    {
        Department d = new Department();
        public int DeptId { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            Name = name;
            DeptId = id;
        }
        public void Add()
        {
            d.AddEmp(this);
            if (!d.Added)
            {
                d.AddDept(this);
            }
        }
    }
}
