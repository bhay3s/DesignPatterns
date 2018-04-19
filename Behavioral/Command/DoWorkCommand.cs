using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    class DoWorkCommand : CommandBase
    {// class that implements the Execute operation by invoking operation(s) on the Receiver
        public DoWorkCommand(Reciever reciever) : 
            base(reciever)
        {
        } 

        public override void Execute()
        {
            _reciever.DoWork();
        }
    }
}
