﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveKart.Shared
{
    public class OAuth
    {
        public string token_type { get; set; }
        public string refresh_token { get; set; }
        public string access_token { get; set; }
        public string expires_in { get; set; }
    }
}
