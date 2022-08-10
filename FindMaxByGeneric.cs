using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaxByGeneric<T>
    {
        //FIELD
        public T[] arrayofElement;
        //CONSTRUCTOR
        public FindMaxByGeneric(T[] arrayofElement)
        {
            this.arrayofElement = arrayofElement;
        }
        //SORTING ELEMENTS & RETURNING IT IN ARRAY FORM
        public T[] Sorting(T[] arrayofElements)
        {
            Array.Sort(arrayofElements);
            return arrayofElements;
        }
        //RTURNING MAX VALUE BY CALLING SORTING METHOD INSIDE
        public T MaxarrayofElement(T[] arrayofElements)
        {
            var sorted_arrayofElements = Sorting(arrayofElements);
            return sorted_arrayofElements[^1];
        }
        //FINDING MAX VALUE AMONG THE ARRAY WHICH WE ARE PASSING IN CONSTRUCTOR
        public T MaxMethod()
        {
            var max = MaxarrayofElement(arrayofElement);
            return max;
        }
    }
}

