using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    public abstract class CommandBase
    {// interface which specifies the Execute operation
        protected Reciever _reciever;

        public CommandBase(Reciever reciever)
        {
            _reciever = reciever;
        }

        public abstract void Execute();
    }
}
