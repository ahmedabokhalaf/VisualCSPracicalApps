using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1234;
            Console.WriteLine(x.Reverse());
            Console.WriteLine(x.NoOfDigits());
            string s = "Ahmed-_Khalaf^H@as$san";
            Console.WriteLine(s.RemoveSpecialChar());
            IEnumerable<int> list = new List<int> { 4, 5, 6, 7, 2, 3, 1 };
            int res = list.MyMax();
            Console.WriteLine(res);
            //IEnumerable<string> listStr = new List<string> { "Ahmed", "Ali", "Hassan" };
            //Console.WriteLine(listStr.MyMax());

        }
    }
}
