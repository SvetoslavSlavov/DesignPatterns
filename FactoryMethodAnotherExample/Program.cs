using System;

namespace FactoryMethodAnotherExample
{
    // Simple Factory Method
    // Избягваме създаване на нови инстанции преизползваме
    // switch case-а може да стане много голям и инстанциите са по сложни няма да бъде много четим!!!

    public class Program
    {
        static void Main(string[] args)
        {
            Laptop dell = LaptopFactory.Get(LaptopTypeEnum.Dell);
            dell.TurnOn();
            dell.TurnOff();
        }
    }
}
