using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Command
{
    class DoYetOtherWorkCommand : CommandBase
    {
        public DoYetOtherWorkCommand(Reciever reciever) : 
            base(reciever)
        {
        }

        public override void Execute()
        {
            _reciever.DoYetOtherWork();
        }
    }
}
