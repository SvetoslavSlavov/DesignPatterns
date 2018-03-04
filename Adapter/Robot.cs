using System;

namespace Adapter
{
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
