using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class NotificationRating : Entity
    {
        public long NotificationRatingId { get; set; }
        public long NotificationId { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Notification Notification { get; set; }
    }
}
