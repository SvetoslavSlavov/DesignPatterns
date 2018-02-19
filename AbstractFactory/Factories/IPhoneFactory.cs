using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public interface IPhoneFactory
    {
        SmartPhone GetSmartPhone();
        DumbPhone GetDumbPhone();
    }
}