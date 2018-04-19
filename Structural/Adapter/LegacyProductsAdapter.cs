using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter
{
    public class LegacyProductsAdapter
    {
        protected LegacyProducts _legacyProductsAPI;
        public LegacyProductsAdapter()
        {
            _legacyProductsAPI = new LegacyProducts();
        }

        public List<string> GetProducts(int id)
        {
            //no-marshall work needed here since just passing primitive types
            return _legacyProductsAPI.GetProducts(id);
        }

        public List<int> GetIDs()
        {
            // marshall work done here
            var results = _legacyProductsAPI.GetIDs();
            // more marshall work done here
            return results;
        }
    }
}
