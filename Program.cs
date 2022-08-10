using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine($"Maximum String is {program.findMaxString("A", "P", "B")}");
        }
        public string findMaxString(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) > 0)
            {
                return str1;
            }
            else if (str2.CompareTo(str3) > 0 && str2.CompareTo(str1) > 0)
            {
                return str2;
            }
            else
            {
                return str3;
            }
        }
    }
}