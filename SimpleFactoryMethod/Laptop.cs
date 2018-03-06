using System;

namespace SimpleFactoryMethod
{
    public abstract class Laptop
    {
        // virtual - davat bazova functionalnost. ako ne ovveridenat shte se darjat po sashtiq nachin
        // kakto v abstrakniq klas
        public virtual void TurnOn()
        {
            System.Console.WriteLine("Laptop is on.");
        }
        public virtual void TournOff()
        {
            System.Console.WriteLine("Laptop is off.");
        }
    }
}
