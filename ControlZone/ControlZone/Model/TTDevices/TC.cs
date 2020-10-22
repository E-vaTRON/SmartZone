using System;
using System.Collections.Generic;
using System.Text;

namespace ControlZone.Model.TTDevices
{
    public class TC : DeviceBase
    {
        public float TrashCapacity { get; set; }
        public float CurrentCapacity { get; set; }
        public int NumOfOpen { get; set; }
    }
}
