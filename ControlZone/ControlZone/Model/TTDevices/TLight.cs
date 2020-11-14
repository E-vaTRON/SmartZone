using System;
using System.Collections.Generic;
using System.Text;

namespace ControlZone.Model.TTDevices
{
    public class TLight : DeviceBase
    {
        public float Brightness { get; set; }
        public string LightColor { get; set; }
        public string LightGradientColor1 { get; set; }
        public string LightGradientColor2 { get; set; }
    }
}
