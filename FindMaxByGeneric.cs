using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class FindMaxByGeneric<T>
    {
        public T testMax(T element1, T element2, T element3)
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