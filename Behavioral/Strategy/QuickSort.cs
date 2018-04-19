using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    internal class QuickSort : ISortable
    {
        public void Sort<T>(IEnumerable<T> items)
        {
            Console.WriteLine($"Sorting {nameof(items)} using {GetType().Name}.");
        }
    }
}