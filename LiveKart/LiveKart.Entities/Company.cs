using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace LiveKart.Entities
{
	public partial class Company
	{

		[Display(Name = "Password")]
		[NotMapped]
		public string Password { get; set; }

		[NotMapped]
		public int? RoleId { get; set; }

		[Display(Name = "Address")]
		[NotMapped]
		public string Address
		{
			get { return Address1 + " " + Address2; }
		}
	}
}
