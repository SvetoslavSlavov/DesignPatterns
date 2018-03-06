using System;

namespace SimpleFactoryMethod
{
    public static class LaptopFactory
    {
        public static Laptop Get(LaptopTypeEnum type)
        {
            switch (type)
            {
                case LaptopTypeEnum.Dell:
                    return new Dell();
                case LaptopTypeEnum.Assus:
                    return new Assus();
                default:
                    return new Acer();
            }
        }
    }
}

