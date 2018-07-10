using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class Country : Entity
    {
        public long CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
