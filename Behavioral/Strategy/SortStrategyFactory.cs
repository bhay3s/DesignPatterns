using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public enum SortType
    {
        Bubble,
        Merge,
        Quick
    }
    class SortStrategyFactory
    {
        public static ISortable GetSortStrategy(SortType sortType)
        {
            ISortable strategy = null;
            switch (sortType)
            {
                case SortType.Bubble:
                    strategy = new BubbleSort();
                    break;
                case SortType.Merge:
                    strategy = new MergeSort();
                    break;
                case SortType.Quick:
                default:
                    strategy = new QuickSort();
                    break;
            }

            return strategy;
        }
    }
}
