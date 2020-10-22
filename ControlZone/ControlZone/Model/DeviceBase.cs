using System;

namespace ControlZone.Model
{
    public class DeviceBase
    {
        public int Id { get; set; }
        public int DeviceType { get; set; }
        public string IconImageSource { get; set; } = String.Empty;
        public string Model { get; set; } = String.Empty;
        public string Color { get; set; } = String.Empty;
        public DateTime ManufactorDate { get; set; }
        public double Weight { get; set; }
        public float OverallProcess { get; set; }
        public bool PowerStatus { get; set; }
    }
}
