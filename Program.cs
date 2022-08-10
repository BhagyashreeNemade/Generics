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
            FindMaxByGeneric<int> findMaxInt = new FindMaxByGeneric<int>();
            FindMaxByGeneric<float> findMaxDouble = new FindMaxByGeneric<float>();
            FindMaxByGeneric<string> findMaxString = new FindMaxByGeneric<string>();

            Console.WriteLine($"Max integer value is {findMaxInt.testMax(25, 56, 59)}");
            Console.WriteLine($"Max Float value is {findMaxDouble.testMax(645.55F, 506.21F, 202.45F)}");
            Console.WriteLine($"Maximum string is {findMaxString.testMax("A", "Z", "B")}");
        }
    }
}