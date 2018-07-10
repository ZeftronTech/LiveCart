using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiveKart.Shared.Entities
{
    public class Alert
    {
        [Display(Name = "Message")]
        public string Messages { get; set; }

        [Display(Name = "BeaconId")]
        public string BeaconID { get; set; }

        [Display(Name="Battery Level")]
        public string BatteryLevel { get; set; }
    }
}
