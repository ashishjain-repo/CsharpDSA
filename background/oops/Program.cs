using System;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Year = 2020;
        Console.WriteLine($"Car Make: {myCar.Make}, Year: {myCar.Year}");
        myCar.Start();

        CarWithAbstraction car = new CarWithAbstraction();
        car.Start();
    }
}