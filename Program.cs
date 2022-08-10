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
            int[] arrayOfIntegers = { 1, 2, 3, 4, 5, 6 };
            float[] arrayOfFloats = { 5.2f, 3.6f, 4.7f, 8.7f, 9.8f };
            string[] arrayOfStrings = { "a", "b", "c", "d", "e", "f" };

            //Making objects & passing arrays of different forms in the constructor of FindMaxByGeneric Class.
            FindMaxByGeneric<int> findMaxInt = new FindMaxByGeneric<int>(arrayOfIntegers);
            FindMaxByGeneric<float> findMaxDouble = new FindMaxByGeneric<float>(arrayOfFloats);
            FindMaxByGeneric<string> findMaxString = new FindMaxByGeneric<string>(arrayOfStrings);

            //Calling MaxMethod from FindMaxByGeneric Class.
            Console.WriteLine($"Max integer value is {findMaxInt.MaxMethod()}");
            Console.WriteLine($"Max Float value is {findMaxDouble.MaxMethod()}");
            Console.WriteLine($"Maximum string is {findMaxString.MaxMethod()}");
        }
    }
}