using System;

public class Car
{
    private string _make;
    private int _year;
    public string Make
    {
        get { return _make; }
        set { _make = value; }
    }
    public int Year
    {
        get { return _year; }
        set
        {
            if (value > 1900 && value < 2024)
            {
                _year = value;
            }
            else
            {
                Console.WriteLine("Invalid Year");
            }
        }
    }
    public void Start()
    {
        Console.WriteLine("The car is starting");
    }
}