using System;

namespace AbstractFactory.Products
{
    public abstract class DumbPhone
    {
        public virtual void DoSomething()
        {
            Console.WriteLine("Zun zun");
        }
    }
}