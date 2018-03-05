using System;
/*
Pozvolqva ni da sazdadem darvovidna struktura
za da representirame part-whole hierarchies.
 */
namespace Composite
{
    class Program
    {
        /*
        V klientskiq kod ne se interesuvame dali shte bade dobavena
        kompoziciq ili nqkakvo listo. Izkluchitelno udobno zashtoto cqloto
        saobrazqvane dali rabotim s edin obekt ili grupa ot obekti otpada 
        napalno ot klientskiq kod. Dava ni vazmojnost da se fokusirame varhu
        sashtinskata logika vmesto tova da se chudim dali sega e playlist ili 
        song.
         */
        static void Main(string[] args)
        {
            Playlist topHits = new Playlist("Top Hits", "All Top Hits");
            // ISongComponent popHits = new Playlist("Pop Hits", "All Pop Hits");
            Playlist popHits = new Playlist("Pop Hits", "All Pop Hits");
            Playlist rapHits = new Playlist("Rap Hits", "All Rap Hits");

            Playlist all = new Playlist("All", "All Hits");
            all.Add(topHits);
            all.Add(rapHits);
            // moje da dobavim i otdelna pesen taka i playlist
            
            

            topHits.Add(new Song("My top hits", "Performer 1", 2016));
            topHits.Add(new Song("My top hit 2", "Performer 1", 2017));
            topHits.Add(popHits);

            popHits.Add(new Song("My pop hit 1", "Pop performer 1", 2001));
            all.DisplayInfo();
        }
    }
}
