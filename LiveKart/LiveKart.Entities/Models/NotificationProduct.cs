using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class NotificationProduct : Entity
    {
        public long NotificationProductID { get; set; }
        public long NotificationID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public string Sizes { get; set; }
        public string Prices { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> CompanyID { get; set; }
        public string BarCode { get; set; }
        public virtual Company Company { get; set; }
        public virtual Notification Notification { get; set; }
    }
}
