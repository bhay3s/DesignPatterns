using System;

namespace DesignPatterns.Structural.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new LegacyProductsAdapter();
            
            foreach (var item in adapter.GetProducts(123))
            {
                Console.WriteLine(item);
            }

            foreach (var item in adapter.GetIDs())
            {
                Console.WriteLine(item);
            }
        }
    }
}
