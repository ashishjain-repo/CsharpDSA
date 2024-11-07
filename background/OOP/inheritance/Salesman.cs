using System;
public abstract class Salesman
{
    private string _firstName;
    private string _lastName;
    public string FullName
    {
        get 
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }
    }
    public Salesman(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }
    public virtual void Sell()
    {
        Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this item!", this.FullName));
    }
}