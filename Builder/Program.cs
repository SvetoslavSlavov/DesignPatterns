using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder happyMenuBuilder = new HappyMenuBuilder();
            IBuilder kinderMenuBuilder = new KinderMenuBuilder();

            director.Construct(happyMenuBuilder);
            Menu happyMenu = happyMenuBuilder.GetMenu();
            /* Chasta s direktora palni menuto i 
                sled kato buildera darji napalnenoto menu
                moje da se vzeme s GetMenu()
            */

            director.Construct(kinderMenuBuilder);
            Menu kinderMenu = kinderMenuBuilder.GetMenu();

            /* console writeline vinagi vika skrito .ToString()
                nqma nujda da se dopisva
            */
            System.Console.WriteLine(happyMenu);
            System.Console.WriteLine(kinderMenu);

            /*
             Builder pozvolqva ni 
            na buildvame komponentite na chasti.
            */
        }
    }
}
