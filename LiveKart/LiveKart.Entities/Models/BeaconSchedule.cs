using System;
using System.ComponentModel.DataAnnotations.Schema;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class BeaconSchedule : Entity
    {
        public long BeaconScheduleID { get; set; }
		[ForeignKey("Notification")]
        public long NotificationID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string Days { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> CompanyID { get; set; }
		[ForeignKey("Beacon")]
        public Nullable<long> BeaconID { get; set; }
        public virtual Beacon Beacon { get; set; }
        public virtual Company Company { get; set; }
        public virtual Notification Notification { get; set; }
    }
}
