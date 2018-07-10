using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace LiveKart.Shared.Entities
{
    public class Company2
    {
        public long CompanyId { get; set; }

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }

        [Display(Name = "Address1")]
        public string Address1 { get; set; }

        [Display(Name = "Address2")]
        public string Address2 { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Zip Code")]
        public string Zip { get; set; }

        [Display(Name = "Country")]
        public long CountryId { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }

        [Display(Name = "Created By")]
        public string createdBy { get; set; }

        [Display(Name = "Created Date")]
        public DateTime? createdDate { get; set; }

        [Display(Name = "Modified By")]
        public string ModifiedBy { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Image")]
        public string Image { get; set; }

        public int? RoleId { get; set; }

        [Display(Name = "Address")]
        public string Address
        {
            get { return Address1 + " " + Address2; }
        }

        [Display(Name = "Vuforia Server Access Key")]
        public string VuforiaServerAccessKey{get; set;}

        [Display(Name = "Vuforia Server Secret Key")]
        public string VuforiaServerSecretKey{get; set;}

        [Display(Name = "Vuforia Client Access Key")]
        public string VuforiaClientAccessKey{get; set;}

        [Display(Name = "Vuforia Client Secret Key")]
        public string VuforiaClientSecretKey{get; set;}
    }
}
