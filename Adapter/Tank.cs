using System;

namespace Adapter
{
    /* 
    Tagets -> specifichni 
    requesti i na vsqko edno
    enemy, koeto imame predvideno v nashata sistema. 
    */
    public class Tank : IEnemyAtacker
    {
        Random rand;
        public Tank()
        {
            rand = new Random();
        }
        public void AssignDriver(string DriverName)
        {
            System.Console.WriteLine(DriverName + "");
        }

        public void DriveForward()
        {
            int spaces = rand.Next(1, 10);
            System.Console.WriteLine("Tank move {0} spaces forward", spaces);
        }

        public void FireWeapen()
        {
            int damages = rand.Next(5,100);
            System.Console.WriteLine("Tank damaged opponent with {0}",damages);
        }
    }
}
