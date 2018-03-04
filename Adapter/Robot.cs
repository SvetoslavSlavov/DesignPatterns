using System;

namespace Adapter
{   
    /*
     Robota ne moje da implementira IEnemyAtacker.
    Toi nqma takiva metodi. 
    */
    /* 
    nqma kak da mu assignem driver 
    nqma kak da mu kajem drive forward
    nqma kak da iztrelva s fireweapon
    to moje da pravi samo walk forward
    metod smash with hands
    */
    // Adaptee -> specifichni vidove deistviq
    public class Robot
    {
        Random rand;
        public Robot()
        {
            rand = new Random();
        }
        public void SmashWithHands()
        {
            int damages = rand.Next(2,8);
            System.Console.WriteLine("Tank damaged opponent with {0}",damages);
        }
        public void WalkForward()
        {
            int spaces = rand.Next(1, 2);
            System.Console.WriteLine("Tank walked {0} spaces forward", spaces);
        }
        public void ReactToHuman(string driverName)
        {
            System.Console.WriteLine("Robot slapped {0}", driverName);
        }
    }
}
