using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPhoneFactory samsungFactory = new SamsungFactory();
            IPhoneFactory nokiaFactory = new NokiaFactory();

            var samsungSmartFactory = samsungFactory.GetSmartPhone();
            var samsungDumbPhone = samsungFactory.GetDumbPhone();
            var nokiaSmartPhone = nokiaFactory.GetSmartPhone();
            var nokiaDumbPhone = nokiaFactory.GetSmartPhone();

            samsungSmartFactory.DoSomething();
            samsungDumbPhone.DoSomething();

            // Dvata metoda trqbva da varvqt zaedno v IPhoneFactory
            // Taka vsqka konkretna fabrika trqbva da sazdava i smartphones i dumbphone
        }
    }
}
