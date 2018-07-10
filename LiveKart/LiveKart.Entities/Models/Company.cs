using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class Company : Entity
    {
        public Company()
        {
            this.AssetCategories = new List<AssetCategory>();
            this.Beacons = new List<Beacon>();
            this.BeaconDeployments = new List<BeaconDeployment>();
            this.BeaconSchedules = new List<BeaconSchedule>();
            this.Notifications = new List<Notification>();
            this.NotificationAlerts = new List<NotificationAlert>();
            this.NotificationSchedules = new List<NotificationSchedule>();
            this.NotificationBeaconMaps = new List<NotificationBeaconMap>();
            this.NotificationProducts = new List<NotificationProduct>();
            this.Offers = new List<Offer>();
        }

        public long CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public long CountryID { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string VuforiaServerAccessKey { get; set; }
        public string VuforiaServerSecretKey { get; set; }
        public string VuforiaClientAccessKey { get; set; }
        public string VuforiaClientSecretKey { get; set; }
        public virtual ICollection<AssetCategory> AssetCategories { get; set; }
        public virtual ICollection<Beacon> Beacons { get; set; }
        public virtual ICollection<BeaconDeployment> BeaconDeployments { get; set; }
        public virtual ICollection<BeaconSchedule> BeaconSchedules { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<NotificationAlert> NotificationAlerts { get; set; }
        public virtual ICollection<NotificationSchedule> NotificationSchedules { get; set; }
		[JsonIgnore]
        public virtual User User { get; set; }
        public virtual ICollection<NotificationBeaconMap> NotificationBeaconMaps { get; set; }
        public virtual ICollection<NotificationProduct> NotificationProducts { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
