using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveKart.Shared
{
    public static class ConstantUtil
    {
        public const string MessageCreate = "Record created successfully.";

        public const string MessageEdit = "Record updated successfully.";

        public const string MessageDelete = "Record deleted successfully.";

        public const string MessageError = "Something went wrong. Please try again";

        public const string StatusOk = "Ok";

        public const string StatusFail = "Error";

        public const string StatusInfo = "Info";

        public const string UaernameExist = "Provided user name already exist. Please provide some other user name.";

        public const string DefaultTheme = "primary";

        public class Cache
        {
            public const string CampaignTypes = "CampaignTypes";
            public const string AgeGroups = "AgeGroups";
            public const string Countries = "Countries";
        }
    }

}
