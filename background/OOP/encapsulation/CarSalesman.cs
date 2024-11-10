using System;
public class CarSalesman : Salesman
{
    public CarSalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    
    protected override void Engage()
    {
        Console.WriteLine("Hello!");
    }
    protected override void EstablishTrust()
    {
        Console.WriteLine("Just wanted to quickly help you.");
    }
    protected override void AddressConcerns()
    {
        Console.WriteLine("Everything is 10% discounted!");
    }

    protected override void DemoValue()
    {
        Console.WriteLine("Our customers love it.");
    }
    protected override void Close()
    {
        Console.WriteLine("Buy this car");
    }
}