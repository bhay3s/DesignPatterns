using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var reciever = new Reciever(); // class that does the actual work

            
            // object which encapsulates worker object
            var dowork = new DoWorkCommand(reciever);
            var doOtherWork = new DoOtherWorkCommand(reciever);
            var doYetOtherWork = new DoYetOtherWorkCommand(reciever);

            
            var invoker = new Invoker();
            // dynamically update the receiver class
            var cmdList = new List<string>() { "do work", "do yet other work", "do other work" };

            foreach (var cmd in cmdList)
            {

                switch (cmd)
                {
                    case "do work":
                        invoker.Command = dowork;
                        break;
                    case "do yet other work":
                        invoker.Command = doYetOtherWork;
                        break;
                    case "do other work":
                    default:
                        invoker.Command = doOtherWork;
                        break;
                }

                invoker.ExecuteCommand();
            }
        }
    }
}
