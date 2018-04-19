using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Reciever
    {// class that performs the Action associated with the request.
        public Reciever()
        {

        }

        public void DoWork()
        {
            Console.WriteLine("DoWork() called.");
        }

        public void DoOtherWork()
        {
            Console.WriteLine("DoOtherWork() called.");
        }

        public void DoYetOtherWork()
        {
            Console.WriteLine("DoYetOtherWork() called.");
        }
    }
}
