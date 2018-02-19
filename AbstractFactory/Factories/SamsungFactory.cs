using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class SamsungFactory : IPhoneFactory
    {
        public DumbPhone GetDumbPhone()
        {
            return new GuruPlus();
        }

        public SmartPhone GetSmartPhone()
        {
            return new GalaxyS7();
        }
    }
}