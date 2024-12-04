public class Program
{
    public static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        vehicles.Add(new Car {Brand = "Toyota", Model = "Camry", Year = 2020, NumberOfDoors = 4});
        vehicles.Add(new Motorcycle {Brand = "Harley", Model = "Street", Year = 2018, NumberOfWheels = 2});

        foreach(var vehicle in vehicles)
        {
            vehicle.Start();
            vehicle.Stop();
        }
    }
}