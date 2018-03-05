using System;

/* 
Bridgle -> decople a abstraction from implementation
so that the two can vary independetly.
*/
namespace Bridge
{
    /*
    Interface za video source, 
    koito shte definira dva metoda
    vzimane na tvguide i puskane na video.
    Klasovete, koito shte implementirat 
    shte badat razlichni tv sourcove.
    Ot drugata strana ISmartTv, koito v
    sebe si shte darji video source i shte ima
    metodi za tv guide i za play tv. Smart
    tv shte bade interfaica, koito shte implementira
    ISmartTv i toi shte impementira i samite mu klasove.
    ShowTvGuide() i PlayTv(). Tova koeto trqbva da se poluchi v
    klientskiq kod e klienta da moje da si sazdade instanciq na
    tozi smart televizor da moje da mu podade tochno kakav video
    source iska i sled tova izvikvaiki nqkoi metod na televizora
    tozi televizor da ne se interesuva kakav tochno source se izpolzva
    i po kakav nachin toi raboti edinstveno da izpalni play tv
    metoda.
     */
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv tv = new SmartTv();
            tv.VideoSource = new IpTvService();

            tv.ShowTvGuide();
            tv.PlayTv();

            tv.VideoSource = new LocalCableTv();
            tv.ShowTvGuide();
            tv.PlayTv();
        }
    }
}
