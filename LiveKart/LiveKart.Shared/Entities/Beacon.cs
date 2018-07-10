using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiveKart.Shared.Entities
{
    public class Beacon
    {
        #region Properties

        [Display(Name = "Beacon Id")]
        public string BeaconId { get; set; }

        [Display(Name = "Beacon Name")]
        public string BeaconName { get; set; }

        public string Description { get; set; }

        [Display(Name = "Battery Status")]
        public string BatteryLevel { get; set; }

        public bool Active { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public long CompanyId { get; set; }

        public bool IsDeployed { get; set; }

        #endregion
    }

    public class BeaconDeployment
    {
        #region Properties

        public long BeaconDeploymentId { get; set; }

        [Display(Name = "Beacon Id")]
        public string BeaconId { get; set; }

        public string BeaconName { get; set; }

        [Display(Name = "Battery Status")]
        public string BatteryLevel { get; set; }

        [Display(Name = "Asset")]
        public long AssetId { get; set; }

        [Display(Name = "Asset")]
        public string AssetName { get; set; }

        [Display(Name = "Asset Category")]
        public string CategoryName { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        public string Address { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public bool Active { get; set; }

        public string DeployedBy { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public long CompanyId { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        #endregion
    }
}
