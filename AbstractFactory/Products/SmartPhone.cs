using System;

namespace AbstractFactory.Products
{
    public abstract class SmartPhone
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("I can do a lot of things and by the way - Zun zun");
        }
    }
}