using System;

namespace DesignPatterns.Creational.Factory_Method
{
    public class Factory
    {
        public static AbstractBaseClass GetConcreteType(string type)
        {
            switch(type)
            {
                case "foo":
                    return new foo();
                case "bar":
                    return new bar();
                default:
                    throw new Exception("");
            }
        }

        public static IGreetable GetGreetableItem(string type)
        {
            switch (type)
            {
                case "foo":
                    return new foo();
                case "bar":
                    return new bar();
                default:
                    throw new Exception("");
            }
        }
    }

    public interface IGreetable
    {
        void Greet();
    }

    public abstract class AbstractBaseClass
    {
        public string Name;
    }

    public class foo : AbstractBaseClass, IGreetable
    {
        public foo()
        {
            Name = "foo";
        }
        public void Greet() { Console.WriteLine("Hello, I'm foo"); }
    }

    public class bar : AbstractBaseClass, IGreetable
    {
        public bar()
        {
            Name = "bar";
        }
        public void Greet() { Console.WriteLine("Hello, I'm bar"); }
    }
}
