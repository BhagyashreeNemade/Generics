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
            Console.WriteLine($"Maximum float is {program.findMaxFloat(5.8F, 8.5F, 5.6F)}");
        }
        public float findMaxFloat(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num3) > 0 && num2.CompareTo(num1) > 0)
            {
                return num2;
            }
            else
            {
                return num3;
            }
        }
    }
}