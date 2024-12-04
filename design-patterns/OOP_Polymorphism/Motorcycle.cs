public class Motorcycle : Vehicle
{
    public int NumberOfWheels {get; set;}

    public override void Start()
    {
        System.Console.WriteLine("Motorcycle is starting...!");
    }
    public override void Stop()
    {
        System.Console.WriteLine("Motorcycle is stopping...!");
    }
}