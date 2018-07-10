using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveKart.Shared.Entities
{
    public class RestUser:RestResponse
    {
        public User user { get; set; }
    }
}
