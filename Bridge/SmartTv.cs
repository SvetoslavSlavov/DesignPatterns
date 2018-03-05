using System;

namespace Bridge
{
    public class SmartTv : ISmartTv
    {
        public IVideoSource VideoSource { get; set; }

        /*
         Ne se interesuvame po kakav
         nachin video source-a shte izpalni
         videoto.
         */
        public void PlayTv()
        {
            if (VideoSource != null)
            {
                VideoSource.PlayVideo();
            }
            else
            {
                System.Console.WriteLine("You should provide video source first.");
            }
        }

        public void ShowTvGuide()
        {
            if (VideoSource != null)
            {
                System.Console.WriteLine(VideoSource.GetTvGuide());
            }
            else
            {
                System.Console.WriteLine("You should provide a Video Source first.");
            }
        }
    }
}
