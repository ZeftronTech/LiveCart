using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class Offer : Entity
    {
        public long OfferID { get; set; }
        public long NotificationID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string OfferImage { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public long CompanyID { get; set; }
        public Nullable<bool> Active { get; set; }
        public virtual Company Company { get; set; }
        public virtual Notification Notification { get; set; }
    }
}
