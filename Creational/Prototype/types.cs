using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public abstract class AbstractType : ICloneable
    {
        public int ID { get; set; }
        public abstract void Process();
        public abstract object Clone();
    }

    public class ConcreteType1 : AbstractType
    {
        public object Reference { get; set; }

        public ConcreteType1 DeepClone()
        {
            var deepClone = (ConcreteType1)Clone(); 
            // override references to non-<something> types 
            // ie create new objects instead of reference the original one
            deepClone.Reference = new object();

            return deepClone;
        }
        public override object Clone()
        {   // this will return copy of primitive types: int, bool, string, float
            // complex types will be given a reference to the original object
            return this.MemberwiseClone();
        }

        public override void Process()
        {
            Console.WriteLine($"{GetType().Name} is doing work.");
        }
    }

    public class ConcreteType2 : AbstractType
    {
        public string Name { get; set; }
        public override object Clone()
        {
            return this.MemberwiseClone();
       }

        public override void Process()
        {
            Console.WriteLine($"{GetType().Name} is doing work.");
        }
    }    
}
