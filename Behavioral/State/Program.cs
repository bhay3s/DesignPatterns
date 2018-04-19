namespace DesignPatterns.Behavioral.State
{
    class Program
    {
        static Context ctx;
        static void Main(string[] args)
        {
            ctx = new Context(new LightOff());
            
            ButtonClick();
            ButtonClick();
            ButtonClick();
        }

        private static void ButtonClick()
        {
            ctx.Request();
        }
    }
}
