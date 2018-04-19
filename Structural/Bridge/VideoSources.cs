using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public interface IVideoSource
    {
        string PlayVideo();
        string GetTvGuide();
    }

    public class LocalCableTv : IVideoSource
    {
        private readonly string _sourceName = "Local Cable TV";
        public string GetTvGuide()
        {
            return $"Getting TV Guide From {_sourceName}";
        }

        public string PlayVideo()
        {
            return $"Playing Video on {_sourceName}";
        }
    }

    public class LocalDishTV : IVideoSource
    {
        private readonly string _sourceName = "Local DISH TV";
        public string GetTvGuide()
        {
            return $"Getting TV Guide From {_sourceName}";
        }

        public string PlayVideo()
        {
            return $"Playing Video on {_sourceName}";
        }
    }
}
