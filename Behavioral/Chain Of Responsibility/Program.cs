using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var link1 = new ConcreteLink1();
            link1.HandleWhen(data => data.Name.StartsWith("Brian"));

            var link2 = new ConcreteLink2();
            link2.HandleWhen(data => data.Name.EndsWith("Hayes"));

            var link3 = new ConcreteLink3();
            link3.HandleWhen(data => true);
              
            link1.SetNextLink(link2);
            link2.SetNextLink(link3);

            var obj = new DataType() { Name = "Brian Hayes" };

            link1.Handle(obj);
        }
    }
}
