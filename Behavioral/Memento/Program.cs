using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MultiChangeCustomer("Brian", "123", "email@domain.com");
            c1.Display();

            c1.Name = "Jon";
            c1.Display();
            c1.SaveMomento();

            c1.Name = "Bob";
            c1.Display();
            c1.SaveMomento();

            c1.Name = "Jim";
            c1.Display();

            c1.RevertToLast();
            c1.Display();

            c1.RevertToOriginal();
            c1.Display();
        }
    }
}
