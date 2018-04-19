using System;

namespace DesignPatterns.Creational.Singleton
{
    class Singleton
    {
        private static Singleton _instance;
        private static object _locker = new object();
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                lock(_locker)
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        public void Method1() { Console.WriteLine("Method1() called."); }

        public void Method2() { Console.WriteLine("Method2() called."); }
    }
}
