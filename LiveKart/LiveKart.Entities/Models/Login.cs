using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;
using System.ComponentModel.DataAnnotations;

namespace LiveKart.Entities.Models
{
	public partial class Login : Entity
	{
		public long LoginID { get; set; }

		[Display(Name = "Email")]
		public string UserName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public int RoleType { get; set; }

		public Nullable<System.DateTime> LastLogin { get; set; }

		public Nullable<short> IsLocked { get; set; }

		public int InvalidAttempts { get; set; }

		public virtual Company Company { get; set; }
	}
}
