using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class AssetCategory : Entity
    {
        public AssetCategory()
        {
            this.Assets = new List<Asset>();
        }

        public long AssetCategoryID { get; set; }
        public long CompanyID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Active { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
        public virtual Company Company { get; set; }
    }
}
