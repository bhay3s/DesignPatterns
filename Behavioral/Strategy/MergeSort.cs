using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    class MergeSort : ISortable
    {
        public void Sort<T>(IEnumerable<T> items)
        {
            Console.WriteLine($"Sorting {nameof(items)} using {GetType().Name}.");
        }
    }
}
