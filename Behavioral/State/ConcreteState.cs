using System;

namespace DesignPatterns.Behavioral.State
{
    public class LightOn : IState
    {
        public void Next(Context context)
        {
            Console.WriteLine("Turning Lights off...");
            context.State = new LightOff();
        }
    }

    public class LightOff : IState
    {
        public void Next(Context context)
        {
            Console.WriteLine("Turning Lights On...");
            context.State = new LightOn();
        }
    }
}
