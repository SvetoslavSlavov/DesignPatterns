using System;

namespace Bridge
{
    public class IpTvService : IVideoSource
    {
        public string GetTvGuide()
        {
            return "Getting Tv Guide from ip tv";
        }

        public void PlayVideo()
        {
            System.Console.WriteLine("Playing video from ip Tv");
        }
    }
}
