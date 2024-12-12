namespace SmartHomeSystem
{
    public class SmartLight : SmartDevice
    {
        public int Brightness {get; private set;}
        public SmartLight(string device, int brightness) : base(device)
        {
            Brightness = brightness;
        }
        public SmartLight(string device) : base(device)
        {
            Brightness = 0;
        }
        public void SetBrightness(int level)
        {
            if(level >= 0 && level <= 100)
            {
                Brightness = level;
                return;
            }
            throw new ArgumentOutOfRangeException("Cannot go beyond!");
        }
    }
}