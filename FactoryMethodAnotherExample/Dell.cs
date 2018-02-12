using System;
public class Dell : Laptop
{
    public override void TurnOn()
    {
        Console.WriteLine("Turn On Dell");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Turn Off Dell");
    }
}