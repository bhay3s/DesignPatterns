using System;

namespace DesignPatterns.Creational.Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            IGreetable item = Factory.GetGreetableItem("foo");
            item.Greet();

            IGreetable item2 = Factory.GetGreetableItem("bar");
            item2.Greet();

            AbstractBaseClass item3 = Factory.GetConcreteType("foo");
            Console.WriteLine(item3.Name);

            AbstractBaseClass item4 = Factory.GetConcreteType("bar");
            Console.WriteLine(item4.Name);
        }
    }
}
