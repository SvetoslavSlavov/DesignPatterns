using System;

// Concrete Implementor
namespace Bridge
{
    public class LocalCableTv : IVideoSource
    {
        public string GetTvGuide()
        {
            return "Getting Tv Guide from local tv";
        }

        public void PlayVideo()
        {
            System.Console.WriteLine("Playing video from Local Cable Tv");
        }
    }
}
