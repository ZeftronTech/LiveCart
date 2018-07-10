using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class User : Entity
    {
        public long LoginID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleType { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<short> IsLocked { get; set; }
        public int InvalidAttempts { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual Company Company { get; set; }
    }
}
