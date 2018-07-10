using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class Beacon : Entity
    {
        public Beacon()
        {
            this.BeaconDeployments = new List<BeaconDeployment>();
            this.BeaconSchedules = new List<BeaconSchedule>();
            this.NotificationBeaconMaps = new List<NotificationBeaconMap>();
        }

        public string BeaconID { get; set; }
        public string BeaconName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public string BatteryLevel { get; set; }
        public long Id { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<BeaconDeployment> BeaconDeployments { get; set; }
        public virtual ICollection<BeaconSchedule> BeaconSchedules { get; set; }
        public virtual ICollection<NotificationBeaconMap> NotificationBeaconMaps { get; set; }
    }
}
