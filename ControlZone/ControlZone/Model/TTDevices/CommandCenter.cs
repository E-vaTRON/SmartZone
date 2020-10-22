using System;
using System.Collections.Generic;
using System.Text;

namespace ControlZone.Model.TTDevices
{
    public class CommandCenter : DeviceBase
    {
        public string CPUName { get; set; }
        public string GPUName { get; set; }
        public float CPUTemp { get; set; }
        public float CPUPercentage { get; set; }
        public float RamConsuming { get; set; }
        public ICollection<DeviceBase> Devices { get; set; }
    }
}
