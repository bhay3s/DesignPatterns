using System.Collections.Generic;

namespace DesignPatterns.Creational.Prototype
{
    class ProtoCache
    {
        private static Dictionary<string, AbstractType> _cache;

        public static AbstractType GetObject(string key)
        {
            if (_cache == null)
                LoadCache();

            if (!_cache.ContainsKey(key))
                return null;

            return _cache[key].Clone() as AbstractType;
        }

        public static void LoadCache()
        {
            _cache = new Dictionary<string, AbstractType>();

            var type1 = new ConcreteType1() { ID = 1 }; // blah blah construct something that has an expensive set up
            _cache.Add("type1", type1);

            var type2 = new ConcreteType2() { ID = 2 };
            _cache.Add("type2", type2);
        }
    }
}
