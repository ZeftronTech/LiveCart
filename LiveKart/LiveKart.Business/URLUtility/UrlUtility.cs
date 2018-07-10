using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;

namespace LiveKart.Business
{
    public static class UrlUtility
    {
        /// <summary>
        /// Converts the provided app-relative path into an absolute Url containing 
        /// the full host name
        /// </summary>
        /// <param name="relativeUrl">App-Relative path</param>
        /// <returns>Provided relativeUrl parameter as fully qualified Url</returns>
        /// <example>~/path/to/foo to http://www.web.com/path/to/foo</example>
        public static string GetAbsoluteUrl(string relativeUrl)
        {
            //VALIDATE INPUT
            if (String.IsNullOrEmpty(relativeUrl))
                return String.Empty;
            //VALIDATE INPUT FOR ALREADY ABSOLUTE URL
            if (relativeUrl.StartsWith("http://", StringComparison.OrdinalIgnoreCase)
            || relativeUrl.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                return relativeUrl;
            //VALIDATE CONTEXT
            if (HttpContext.Current == null)
                return relativeUrl;
            //GET CONTEXT OF CURRENT USER
            HttpContext context = HttpContext.Current;
            //FIX ROOT PATH TO APP ROOT PATH
            if (relativeUrl.StartsWith("/"))
                relativeUrl = relativeUrl.Insert(0, "~");
            //GET RELATIVE PATH
            Page page = context.Handler as Page;
            if (page != null)
            {
                //USE PAGE IN CASE RELATIVE TO USER'S CURRENT LOCATION IS NEEDED
                relativeUrl = page.ResolveUrl(relativeUrl);
            }
            else //OTHERWISE ASSUME WE WANT ROOT PATH
            {
                //PREPARE TO USE IN VIRTUAL PATH UTILITY
                if (!relativeUrl.StartsWith("~/"))
                    relativeUrl = relativeUrl.Insert(0, "~/");
                relativeUrl = VirtualPathUtility.ToAbsolute(relativeUrl);
            }

            var url = context.Request.Url;
            var port = url.Port != 80 ? (":" + url.Port) : String.Empty;
            //BUILD AND RETURN ABSOLUTE URL
            return String.Format("{0}://{1}{2}{3}",
                   url.Scheme, url.Host, port, relativeUrl);
        }

        /// <summary>
        /// Get absolute Url containing 
        /// the full host name
        /// </summary>
        /// <returns>fully qualified Url</returns>
        public static string GetApplicationUrl()
        {
            //VALIDATE CONTEXT
            if (HttpContext.Current == null)
                return string.Empty;
            //GET CONTEXT OF CURRENT USER
            HttpContext context = HttpContext.Current;

            var url = context.Request.Url;
            var port = url.Port != 80 ? (":" + url.Port) : String.Empty;
            //BUILD AND RETURN ABSOLUTE URL
            return String.Format("{0}://{1}{2}",
                   url.Scheme, url.Host, port);
        }
    }
}
