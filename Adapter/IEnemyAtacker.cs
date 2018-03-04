using System;

namespace Adapter
{
    // obosobqva metodi za nqkakvi ataki
    public interface IEnemyAtacker
    {
        void FireWeapen();
        void DriveForward();
        void AssignDriver(string DriverName);
    }
}
