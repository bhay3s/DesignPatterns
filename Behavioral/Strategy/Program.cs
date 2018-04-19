using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Names = new List<string> { "BOB", "JON", "BILL" };
            ISortable strategy = SortStrategyFactory.GetSortStrategy(SortType.Bubble);
            strategy.Sort(Names);

            var Ages = new List<int> { 23, 73, 88 };
            ISortable strategy2 = SortStrategyFactory.GetSortStrategy(SortType.Merge);
            strategy2.Sort(Ages);

            var Directions = new List<string> { "North", "South", "East", "West" };
            ISortable strategy3 = SortStrategyFactory.GetSortStrategy(SortType.Quick);
            strategy3.Sort(Directions);
        }
    }
}
