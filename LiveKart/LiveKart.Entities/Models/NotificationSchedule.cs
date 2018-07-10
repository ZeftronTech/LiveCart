using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class NotificationSchedule : Entity
    {
        public long NotificationScheduleID { get; set; }
        public Nullable<long> NotificationID { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public string NotificationType { get; set; }
        public string ScheduleDays { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
		[UIHint("UTCTime")]
		[DataType(DataType.DateTime)]
        public Nullable<System.DateTime> StartDate { get; set; }
		[UIHint("UTCTime")]
		[DataType(DataType.DateTime)]
        public Nullable<System.DateTime> EndDate { get; set; }
        public virtual Company Company { get; set; }
        public virtual Notification Notification { get; set; }
    }
}
