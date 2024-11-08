using System;

public class InsuraceBroker : Salesman
{
    public InsuraceBroker(string firstName, string lastName) : base(firstName, lastName)
    {

    }
    public override void Sell()
    {
        Console.WriteLine("Hi my name is {0}. I would recommend you to buy this insurace!", this.FullName);
    }
}