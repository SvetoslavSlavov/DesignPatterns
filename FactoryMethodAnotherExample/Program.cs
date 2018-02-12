using System;

namespace FactoryMethodAnotherExample
{
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
