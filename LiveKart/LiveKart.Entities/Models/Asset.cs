using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class Asset : Entity
    {
        public Asset()
        {
            this.BeaconDeployments = new List<BeaconDeployment>();
        }

        public long AssetID { get; set; }
        public long AssetCategoryID { get; set; }
        public long CompanyID { get; set; }
        public string AssetName { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public Nullable<bool> Active { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
		[JsonIgnore]
        public virtual AssetCategory AssetCategory { get; set; }
        public virtual ICollection<BeaconDeployment> BeaconDeployments { get; set; }
    }
}
