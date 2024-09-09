using Exiled.API.Interfaces;

namespace AdrenalinRush
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        public int BoostDuration { get; set; } = 3;
        public byte BoostIntensity { get; set; } = 30;
    }
}
