using System;

namespace FactoryMethod
{
    public class AssusFactory : ILaptopFactory
    {
        public Laptop CreateLaptop()
        {
            return new Assus();
        }
    }
}
