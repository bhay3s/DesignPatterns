namespace DesignPatterns.Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            CsharpSingletonItem.Instance.Method1();
            CsharpSingletonItem.Instance.Method2();
            CsharpSingletonItem.Instance.Method1();
        }
    }
}
