namespace SmartHomeSystem
{
    public class SmartSpeaker : SmartDevice
    {
        public int Volume {get; private set;}
        public SmartSpeaker(string device, int volume) : base(device)
        {
            Volume = volume;
        }
        public SmartSpeaker(string device) : base(device)
        {
            Volume = 0;
        }
        public void SetVolume(int level)
        {
            if(level >= 0 && level <= 100)
            {
                Volume = level;
                return;
            }
        }
        public void PlayMusic(string song)
        {
            Console.WriteLine($"Playing song: {song}.");
        }
    }
}