using System;

namespace Adapter
{
    /* 
    Obedinqvame metodite na robota s tezi
    na tanka. Veche ima sashtite metodi kakvito
    ima i tanka.
    */
    public class RobotAdapter : IEnemyAtacker
    {
        private Robot robot;
        public RobotAdapter(Robot robot)
        {
            this.robot = robot;
        }
        public void AssignDriver(string driverName)
        {
            this.robot.ReactToHuman(driverName);
        }

        public void DriveForward()
        {
            this.robot.WalkForward();
        }

        public void FireWeapen()
        {
            this.robot.SmashWithHands();
        }
    }
}
