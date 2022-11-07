using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day9
{
    static class MyExtension
    {
        public static int Reverse(this int x)
        {
            string s = x.ToString(),
                newS = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
                newS += s[i];
            return int.Parse(newS);
        }

        public static int NoOfDigits(this int x)
        {
            string s = x.ToString();
            return s.Length;
        }

        public static string RemoveSpecialChar(this string str)
        {
            string spChar = "+-_/@*^&%$#!";
            string newStr = string.Empty;
            foreach(char ch in str)
            {
                if (!spChar.Contains(ch))
                {
                    newStr += ch;
                }
            }
            return newStr;
        }

        public static int MyMax(this IEnumerable<int> list)
        {
            int max = 0;
            foreach (int i in list)
            {
                if (i >= max)
                    max = i;
            }
            return max;
        }

        //public static T MyMax<T>(this IEnumerable<T> list)
        //{
        //    var max = list.FirstOrDefault();
        //    foreach (var item in list)
        //    {
        //        if (item >= max)
        //        {
        //            max = item;
        //        }
        //    }
        //    return max;
        //}

        //public static T MyMax<T>(this IEnumerable<T> list)
        //{
        //    var max = list.Max();
        //    return max;
        //}
    }
}
