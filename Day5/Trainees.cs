using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Trainees
    {
        static int cnt = 0;
        int id = 0;
        public int ID { get { return id; } set { id = value; } }
        public string Name { get; set; }
        public int Phone { get; set; }
        public DateTime Birthdate { get; set; }
        public Trainees() : this("*", 0, DateTime.Now) { }
        public Trainees(string name, int phone, DateTime birthdate)
        {
            cnt++;
            ID = cnt;
            Name = name;
            Phone = phone;
            Birthdate = birthdate;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
