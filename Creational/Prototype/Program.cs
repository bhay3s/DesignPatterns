using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ProtoCache.LoadCache();

            AbstractType item = ProtoCache.GetObject("type1");
            Console.WriteLine(item.ID);
            item.Process();

            AbstractType item2 = ProtoCache.GetObject("type2");
            Console.WriteLine(item2.ID);
            item2.Process();

            AbstractType item3 = ProtoCache.GetObject("type3");
            if (item3 == null)
                Console.WriteLine("type3 is null");

        }
    }
}
