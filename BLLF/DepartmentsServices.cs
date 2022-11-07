using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL
{
    public class DepartmentsServices
    {
        DatabaseLayer database = new DatabaseLayer();

        public List<Departments> GetAllDepts()
        {
            List<Departments> departments = new List<Departments>();
            foreach(DataRow row in database.GetDepartments().Rows)
            {
                Departments d = new Departments();
                d.ID = (int)row["Dnum"];
                d.Name = row["Dname"].ToString();
                departments.Add(d);
            }
            return departments;
        }
    }
}
