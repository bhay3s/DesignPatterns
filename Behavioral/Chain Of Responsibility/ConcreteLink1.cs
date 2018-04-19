using System;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public class ConcreteLink1 : LinkBase<DataType>
    {
        protected override void Process(DataType obj)
        {
            Console.WriteLine($"{GetType().Name} did some work.");
        }
    }
}
