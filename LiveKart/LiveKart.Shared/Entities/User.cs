using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace LiveKart.Shared.Entities
{
    public class User
    {
        public long UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Country { get; set; }

        public DateTime? LastLogin { get; set; }

        public string Gender { get; set; }

        public DateTime? BirthDate { get; set; }

    }
}
