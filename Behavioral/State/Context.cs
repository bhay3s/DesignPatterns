using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public interface IState
    {
        void Next(Context context);
    }

    public class Context
    {
        public IState State { get; set; }
        
        public Context(IState newstate)
        {
            State = newstate;
        }

        public void Request()
        {
            State.Next(this);
        }
    }
}
