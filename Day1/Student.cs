using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Day4
{
    enum Gender
    {
        Male, Female
    }
    class Student
    {
        string StdName;
        int StdAge;
        public Gender gender { get; set; }
        public string Name
        {
            set
            {
                if (value.Length >= 6)
                    StdName = value;
                else
                    throw new Exception("The Name of Student must be bigger than 6 digits");
            }
            get
            {
                return StdName;
            }
        }
        public int Age
        {
            set
            {
                if (value < 20)
                    throw new Exception("This Student Not Allowed");
                else
                    StdAge = value;
            }
            get
            {
                return StdAge;
            }
        }
        public Student() : this("UserC#",20)
        {
        }
        public Student(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
        public void Print()
        {
            Console.WriteLine($"Student Info\nName: {Name}\nAge: {Age}");
            Console.WriteLine($"\nGender: {gender}");
        }
    }
}
