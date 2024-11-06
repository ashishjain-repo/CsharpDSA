using System;

public abstract class Vehicle
{
    public abstract void Start();

    public void Stop()
    {
        Console.WriteLine("The Vehicle has stopped");
    }
}