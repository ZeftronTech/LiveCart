using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class NotificationBeaconMap : Entity
    {
        public long NotificationBeaconMappingID { get; set; }
        public long NotificationID { get; set; }
        public long CompanyID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<long> BeaconID { get; set; }
        public virtual Beacon Beacon { get; set; }
        public virtual Company Company { get; set; }
    }
}
