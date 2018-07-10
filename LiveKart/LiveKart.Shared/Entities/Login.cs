using System;
using System.ComponentModel.DataAnnotations;

namespace LiveKart.Shared.Entities
{
	public class Login
	{
		public long LoginId { get; set; }

		[Display(Name = "Email")]
		public string UserName { get; set; }

		public string Password { get; set; }

		public int RoleType { get; set; }

		public string Language { get; set; }

		public string Image { get; set; }

		public string UpdatedBy { get; set; }

		public DateTime UpdatedDate { get; set; }

		[Display(Name = " I have read and agree with the Terms of Use.")]
		public bool Terms { get; set; }

		[Display(Name = "Enter your email")]
		public bool RememberMe { get; set; }

		public string CultureCode { get; set; }

		[Display(Name = "Company Name")]
		public string CompanyName { get; set; }
	}
}
