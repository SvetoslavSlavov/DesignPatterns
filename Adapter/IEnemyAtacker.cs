using System;

namespace Adapter
{
    public interface IEnemyAtacker
    {
        void FireWeapen();
        void DriveForward();
        void AssignDriver(string DriverName);
    }
}
