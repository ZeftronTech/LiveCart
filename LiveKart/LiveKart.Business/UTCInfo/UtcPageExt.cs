using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

namespace LiveKart.Business.UTCInfo
{
    public static class UtcPageExt
    {
        private const string CookieName = "TimeZoneOffset";

        public static DateTime LocalTimeFromTimeOffset(DateTime utcTime)
        {
            HttpContext ctx = HttpContext.Current;
            if (IsCookieDefined(ctx.Request))
            {
                var offset = GetUtcOffset(ctx.Request);
                return utcTime.AddMinutes(offset);
            }
            return utcTime;
        }

        public static int UtcOffset()
        {
            HttpContext ctx = HttpContext.Current;
            if (IsCookieDefined(ctx.Request))
            {
                var minOffset = GetUtcOffset(ctx.Request);
                return minOffset * -1; // return offset in minutes
            }
            return 0;
        }

        private static bool IsCookieDefined(HttpRequest request)
        {
            return request.Cookies[CookieName] != null;
        }

        private static int GetUtcOffset(HttpRequest request)
        {
            var cookie = request.Cookies[CookieName];
            var offset = (cookie == null) ? 0 : int.Parse(cookie.Value);
            return offset * -1;
        }
    }
}
