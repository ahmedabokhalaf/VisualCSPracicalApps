using Day4;
using System;

namespace Day1
{
    class Program
    {
        //static Student GetByIndex(Student[] students, int i)
        //{
        //    return students[i];
        //}
        
        static (string Name, int Age, Gender _Gender) GetByIndex(Student[] students, int i)
        {
            return (Name: students[i].Name, Age: students[i].Age, _Gender: students[i].gender);
        }
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
                try
                {
                    Console.WriteLine("Enter Name: ");
                    string na = Console.ReadLine();
                    students[i].Name = na;
                    Console.WriteLine("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());
                    students[i].Age = age;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                Console.WriteLine("Enter Gender(M/F): ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'm' || ch == 'M') students[i].gender = Gender.Male;
                else students[i].gender = Gender.Female;
            }
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Print();
                Console.WriteLine("==========================================");
            }
            //Student s = GetByIndex(students, 1);
            //s.Print();

            var student = GetByIndex(students, 1);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student._Gender);

            Console.ReadKey();
        }

    }
}
