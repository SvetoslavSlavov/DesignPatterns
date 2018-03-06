using System;

namespace SimpleFactoryMethod
{
    public class Dell : Laptop
    {
        public override void TurnOn()
        {
            System.Console.WriteLine("Dell is on.");
        }
    }
}
