using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class PhoneBook
    {
        int key = 0;
        Dictionary<int, string> phoneBook = new Dictionary<int, string>();
        public string this[int i]
        {
            set
            {
                phoneBook.Add(i, value);
                phoneBook[i] = value;
            }
            get
            {
                return phoneBook[i];
            }
        }
        public int this[string strkey]
        {
            set
            {
                phoneBook.Add(value, strkey);
                phoneBook[value] = strkey;
            }
            get
            {
                foreach(int item in phoneBook.Keys)
                {
                    if (phoneBook[item] == strkey)
                    {
                        key = item;
                    }
                }
                return key;
            }
        }
    }
}
