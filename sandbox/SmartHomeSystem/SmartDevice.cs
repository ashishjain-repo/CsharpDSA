namespace SmartHomeSystem
{
    public class SmartDevice : ISmartDevice
    {
        public string DeviceName {get; private set;}
        public bool Status {get; private set;} = false;
        public SmartDevice(string device)
        {
            DeviceName = device;
        }
        public void TurnOn()
        {
            if(Status == false)
            {
                Status = true;
                Console.WriteLine($"{DeviceName} is now ON.");
                return;
            }
            TurnOff();
        }
        public void TurnOff()
        {
            if(Status == true)
            {
                Status = false;
                Console.WriteLine($"{DeviceName} is now OFF.");
                return;
            }
            TurnOn();
        }
        public virtual void DeviceInfo()
        {
            Console.WriteLine("Must be overridden!");
            return;
        }
    }
}