using SmartHomeSystem;
public class Program
{
    public static void Main(string[] args)
    {
        List<SmartDevice> devices = new List<SmartDevice>();
        devices.Add(new SmartLight("Living Room Light"));
        devices.Add(new SmartThermostat("Bedroom Thermostat"));
        devices.Add(new SmartSpeaker("Kitchen Speaker"));
        foreach(var device in devices)
        {
            device.TurnOn();
            switch (device)
            {
                case SmartLight light:
                    light.SetBrightness(80);
                    Console.WriteLine($"Brightness: {light.Brightness}");
                    break;
                case SmartThermostat thermostat:
                    thermostat.SetTemperature(22.5);
                    Console.WriteLine($"Temperature: {thermostat.Temperature}\u00B0C");
                    break;
                case SmartSpeaker speaker:
                    speaker.SetVolume(50);
                    Console.WriteLine($"Volume: {speaker.Volume}");
                    speaker.PlayMusic("Bohemian Rhapsody");
                return;
            }
            device.TurnOff();
        }
    }
}