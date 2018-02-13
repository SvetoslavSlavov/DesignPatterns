using System;

namespace FactoryMethod
{
    // Factory Method -> ползи че всеки един от класовете на специфична фабрика може да държи в себе си логиката за съответното фактори
    // Няма как да има един метод Get и кода там да се увеличава с увеличаването на всеки един вид лаптоп
    // Недостатука е в това че със създаването на нов тип лаптоп трябва да доведе до създаване на ново фактори
    // Което обаче е по добрия вариант в сравнение с това да дописваме нов case в switch-а на SimpleFactory
    
    class Program
    {
        static void Main(string[] args)
        {
            DellFactory dellFactory = new DellFactory();
            AssusFactory assusFactory = new AssusFactory();
            // Не се извикват нови инстанции на dell, assus, а те идват от техните Factory-та.
            // Faktory-тата имат създаване на нови инстанции, но те винаги са едни и същи.
            // Докато създаването на отделните модели може да бъде различно в различните имплементации на ILaptopFactory
            Laptop dell = dellFactory.CreateLaptop();
            Laptop assus = assusFactory.CreateLaptop();
        }
    }
}
