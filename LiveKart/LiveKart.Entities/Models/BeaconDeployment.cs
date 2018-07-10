using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class BeaconDeployment : Entity
    {
        public long BeaconDeploymentID { get; set; }
        public long AssetID { get; set; }
        public bool Active { get; set; }
        public long CompanyID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<long> BeaconID { get; set; }
        public virtual Asset Asset { get; set; }
        public virtual Beacon Beacon { get; set; }
        public virtual Company Company { get; set; }
    }
}
