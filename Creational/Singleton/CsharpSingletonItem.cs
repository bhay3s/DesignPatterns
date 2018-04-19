using System;

namespace DesignPatterns.Creational.Singleton
{
    class CsharpSingletonItem
    {
        private static readonly CsharpSingletonItem _instance = new CsharpSingletonItem();

        private CsharpSingletonItem() { }

        public static CsharpSingletonItem Instance => _instance;

        public void Method1() { Console.WriteLine("method1 called"); }

        public void Method2() { Console.WriteLine("Method2 called"); }
    }
}
