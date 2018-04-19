using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public class Invoker
    {
        public CommandBase Command { get; set; }
        public Invoker()
        {

        }

        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
