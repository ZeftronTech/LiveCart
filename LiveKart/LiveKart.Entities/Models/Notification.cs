using System;
using System.Collections.Generic;
using System.ComponentModel;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class Notification : Entity
    {
        public Notification()
        {
            this.BeaconSchedules = new List<BeaconSchedule>();
            this.NotificationAlerts = new List<NotificationAlert>();
            this.NotificationSchedules = new List<NotificationSchedule>();
            this.NotificationMessages = new List<NotificationMessage>();
            this.NotificationProducts = new List<NotificationProduct>();
            this.NotificationRatings = new List<NotificationRating>();
            this.Offers = new List<Offer>();
        }

        public long NotificationID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<byte> NotificationType { get; set; }
		[DisplayName("Campaign Title")]
        public string NotificationTitle { get; set; }
        public string Description { get; set; }
        public string NotificationImage { get; set; }
        public virtual ICollection<BeaconSchedule> BeaconSchedules { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<NotificationAlert> NotificationAlerts { get; set; }
        public virtual ICollection<NotificationSchedule> NotificationSchedules { get; set; }
        public virtual ICollection<NotificationMessage> NotificationMessages { get; set; }
        public virtual ICollection<NotificationProduct> NotificationProducts { get; set; }
        public virtual ICollection<NotificationRating> NotificationRatings { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
