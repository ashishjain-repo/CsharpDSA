public class Vehicle
{
    public string Brand {get; set;}
    public string Model {get; set;}
    public int Year {get; set;}

    public void Start()
    {
        System.Console.WriteLine("Vehicle is starting!");
    }
    public void Stop()
    {
        System.Console.WriteLine("Vehicle is stopping!");
    }
}