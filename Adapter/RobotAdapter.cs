using System;

namespace Adapter
{
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
