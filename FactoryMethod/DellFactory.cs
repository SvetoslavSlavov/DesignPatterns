using System;

namespace FactoryMethod
{
    public class DellFactory : ILaptopFactory
    {
        public Laptop CreateLaptop()
        {
            return new Dell();
        }
    }
}
