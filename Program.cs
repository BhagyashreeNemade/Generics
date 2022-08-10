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
            Console.WriteLine($"Maximum integer in the list is {program.findMax<int>(10, 5, 6)}");
            Console.WriteLine($"Maximum float in the list is {program.findMax<float>(4.5F, 5.9F, 6.9F)}");
            Console.WriteLine($"Maximum string in the list is {program.findMax<string>("A", "Z", "F")}");
        }
        public T findMax<T>(T element1, T element2, T element3)
        {
            if (Comparer<T>.Default.Compare(element1, element2) > 0 && Comparer<T>.Default.Compare(element1, element3) > 0)
            {
                return element1;
            }
            else if (Comparer<T>.Default.Compare(element2, element1) > 0 && Comparer<T>.Default.Compare(element2, element3) > 0)
            {
                return element2;
            }
            else
            {
                return element3;
            }
        }
    }
}