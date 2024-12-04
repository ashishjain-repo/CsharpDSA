public class Plane : Vehicle
{
    public int NumberOfDoors {get; set;}

    public override void Start()
    {
        System.Console.WriteLine("Plane is starting...!");
    }
    public override void Stop()
    {
        System.Console.WriteLine("Plane is stopping...!");
    }
}