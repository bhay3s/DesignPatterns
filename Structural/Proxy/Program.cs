using System;

namespace DesignPatterns.Structural.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new DataRetrieverProxy();
            proxy.Credentials = "abc123";
            var results = proxy.GetData();

            Console.WriteLine(results);
        }
    }
}
