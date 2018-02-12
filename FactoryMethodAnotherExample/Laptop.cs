using System;
public abstract class Laptop
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Laptop is on");
    }
    public virtual void TurnOff()
    {
        Console.WriteLine("Laptop is off");
    }
}