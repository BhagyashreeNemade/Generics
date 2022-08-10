using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaxByGeneric<T>
    {
        public T[] arrayofElement;

        public FindMaxByGeneric(T[] arrayofElement)
        {
            this.arrayofElement = arrayofElement;
        }
        public T[] Sorting(T[] arrayofElements)
        {
            Array.Sort(arrayofElements);
            return arrayofElements;
        }
        public T MaxarrayofElement(T[] arrayofElements)
        {
            var sorted_arrayofElements = Sorting(arrayofElements);
            return sorted_arrayofElements[^1];
        }
        public T MaxMethod()
        {
            var max = MaxarrayofElement(arrayofElement);
            return max;
        }
    }
}

