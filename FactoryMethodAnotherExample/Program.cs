using System;

namespace FactoryMethodAnotherExample
{
    // Simple Factory Method
    // Избягваме създаване на нови инстанции преизползваме
    // switch case-а може да стане много голям и инстанциите са по сложни няма да бъде много четим!!!
    // Предоставя Simple Factory class, който връща правилна конкретна инстанция от даден клас.
    // Клиентския код по никакъв начин не се интересува как се създава инстанция от съответния клас. Не го интересува дали нов дел се създава.
    // Променяме само на едно място.
    // Може да се добави конкретен модел на лаптопа процесори ...

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
