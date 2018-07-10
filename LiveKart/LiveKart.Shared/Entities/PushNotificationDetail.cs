using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveKart.Shared.Entities
{
    public class PushNotificationDetail
    {
        public long PushNotificationId { get; set; }

        public string DeviceToken { get; set; }

        public int Badge { get; set; }

        public string Sound { get; set; }

        public string GoogleAPIKey { get; set; }

        public string P12CertificateName { get; set; }

        public string P12CertificatePath { get; set; }

        public string NotificationFor { get; set; }

        public long CompanyId { get; set; }

        public bool IsActive { get; set; }

        public string P12Password { get; set; }
    }
}
