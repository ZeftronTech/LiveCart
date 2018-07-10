using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace LiveKart.Entities
{
	
	public partial class User 
	{

		[NotMapped]
		public string Language { get; set; }

		[NotMapped]
		public string Image { get; set; }

		[NotMapped]
		public string UpdatedBy { get; set; }

		[NotMapped]
		public DateTime UpdatedDate { get; set; }

		[Display(Name = " I have read and agree with the Terms of Use.")]
		[NotMapped]
		public bool Terms { get; set; }

		[Display(Name = "Enter your email")]
		[NotMapped]
		public bool RememberMe { get; set; }

		[NotMapped]
		public string CultureCode { get; set; }

		[Display(Name = "Company Name")]
		[NotMapped]
		public string CompanyName { get; set; }
	}
}