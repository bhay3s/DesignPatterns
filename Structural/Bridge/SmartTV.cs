using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public interface ISmartTV
    {
        IVideoSource VideoSource { get; set; }
        void ShowTVGuide();
        void WatchTV();
    }
    class SamsungSmartTV : ISmartTV
    {
        // IVideoSource is the Bridge/Implementer between SmartTV and concrete Video Source Classes
        public IVideoSource VideoSource { get; set; }

        public readonly string Name = "Samsung SmartTv";
        public SamsungSmartTV() { }

        public void ShowTVGuide()
        {
            string message = VideoSource == null ? "Please Select a Video Source for TV Guide" : VideoSource.GetTvGuide();
            Console.WriteLine($"Message From {Name}: {message}");
        }

        public void WatchTV() 
        {
            string message = VideoSource == null ? "Please Select a Video Source to Play" : VideoSource.PlayVideo();
            Console.WriteLine($"Message From {Name}: {message}");
        }
    }

    class LGSmartTV : ISmartTV
    {
        public IVideoSource VideoSource { get ; set; }

        public readonly string Name = "LG SmartTv";

        public void ShowTVGuide()
        {
            string message = VideoSource == null ? "Please Select a Video Source for TV Guide" : VideoSource.GetTvGuide();
            Console.WriteLine($"Message From {Name}: {message}");
        }
        
        public void WatchTV()
        {
            string message = VideoSource == null ? "Please Select a Video Source to Play" : VideoSource.PlayVideo();
            Console.WriteLine($"Message From {Name}: {message}");
        }
    }
}
