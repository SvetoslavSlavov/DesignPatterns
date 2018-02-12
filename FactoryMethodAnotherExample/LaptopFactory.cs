using System;
namespace FactoryMethodAnotherExample
{
public static class LaptopFactory
{
    // Simple Factory Method
    public static Laptop Get(LaptopTypeEnum type)
    {
        switch (type)
        {
            case LaptopTypeEnum.Dell:
                return new Dell();
            case LaptopTypeEnum.Mac:
                return new Mac();
            default:
                return new Acer();        
        }
    }
}
}