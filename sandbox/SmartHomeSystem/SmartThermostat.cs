namespace SmartHomeSystem
{
    public class SmartThermostat : SmartDevice
    {
        public double Temperature {get; private set;}
        public SmartThermostat(string device, double temperature) : base(device)
        {
            Temperature = temperature;
        }
        public SmartThermostat(string device) : base(device)
        {
            Temperature = 0.0;
        }
        public void SetTemperature(double temp)
        {
            Temperature = temp;
        }
    }
}