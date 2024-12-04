public class Program
{
    public static void Main(string[] args)
    {
        Car car = new Car();
        Bike bike = new Bike();
        // Shared
        car.Brand = "Brand";
        car.Start();
        car.Stop();

        bike.Brand = "Kawasaki";
        bike.Start();
        bike.Stop();

        // Unique
        car.NumberOfDoors = 4;
        bike.NumberOfWheels = 2;
    }
}