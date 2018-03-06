using System;

namespace Decorator
{
    class Pizza : IPizza
    {
        public double GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Plain Pizza";
        }
    }
}

