using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    class DoOtherWorkCommand : CommandBase
    {
        public DoOtherWorkCommand(Reciever reciever) : 
            base(reciever)
        {
        }

        public override void Execute()
        {
            _reciever.DoOtherWork();
        }
    }
}
