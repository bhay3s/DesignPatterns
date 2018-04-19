using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartTV myTv = new SamsungSmartTV();
            //no video source provided
            myTv.ShowTVGuide();
            myTv.WatchTV(); 
            Console.WriteLine();

            myTv.VideoSource = new LocalCableTv();
            myTv.ShowTVGuide();
            myTv.WatchTV();
            Console.WriteLine();

            myTv.VideoSource = new LocalDishTV();
            myTv.ShowTVGuide();
            myTv.WatchTV();
            Console.WriteLine();

            ISmartTV myOtherTv = new LGSmartTV();
            //no video source provided
            myTv.ShowTVGuide();
            myTv.WatchTV();
            Console.WriteLine();

            myTv.VideoSource = new LocalCableTv(); // assign to abstraction
            myTv.ShowTVGuide();
            myTv.WatchTV();
            Console.WriteLine();

            myTv.VideoSource = new LocalDishTV(); // assign to abstraction
            myTv.ShowTVGuide();
            myTv.WatchTV();
            Console.WriteLine();
        }
    }
}
