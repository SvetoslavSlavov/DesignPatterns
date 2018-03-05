using System;

namespace Bridge
{
    public class LocalDishTv : IVideoSource
    {
        public string GetTvGuide()
        {
            return "Getting Tv Guide from local dish tv";
        }

        public void PlayVideo()
        {
            System.Console.WriteLine("Playing video from Local dish Tv");
        }
    }
}
