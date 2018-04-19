using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter
{
    public class LegacyProducts
    {
        public LegacyProducts() { }

        public List<string> GetProducts(int id)
        {
            return new List<string> { "Product1", "Product2", "Product3" };
        }

        public List<int> GetIDs()
        {
            return new List<int> { 1, 2, 4, 5, 6 };
        }
    }
}
