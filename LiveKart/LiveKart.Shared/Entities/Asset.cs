using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiveKart.Shared.Entities
{
    public class AssetCategory
    {
        [Display(Name = "Asset Category")]
        public long AssetCategoryId { get; set; }

        public long CompanyId { get; set; }

        [Display(Name = "Asset Category")]
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }

    public class Asset
    {
        public long AssetId { get; set; }

        [Display(Name = "Asset Category")]
        public long AssetCategoryId { get; set; }

        public long CompanyId { get; set; }

        [Display(Name = "Asset Category")]
        public string CategoryName { get; set; }

        [Display(Name = "Asset Name")]
        public string AssetName { get; set; } 

        public string Description { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        public bool Active { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
