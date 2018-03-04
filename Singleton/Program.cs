using System;

/*
Singleton - osigorqva edin klas
da ima samo edna instanciq i osigorqva
tochka na globalen dostap do neq.
 */
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            System.Console.WriteLine(s1 == s2);
        }
    }
}
