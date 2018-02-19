using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class NokiaFactory : IPhoneFactory
    {
        public DumbPhone GetDumbPhone()
        {
            return new Nokia103();
        }

        public SmartPhone GetSmartPhone()
        {
            return new Lumia920();
        }
    }
}