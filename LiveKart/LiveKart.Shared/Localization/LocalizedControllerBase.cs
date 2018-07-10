using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;

namespace LiveKart.Shared.Localization
{
    /// <summary>
    /// Extends the <see cref="Controller"/> by localization features.
    /// On the first request the browsers preferred language is used and stored in the session.
    /// On any further request the language from the session is used, unless a language is specified manually in the querystring.
    /// To make the localization feature work, all <see cref="Controller">Controllers</see> should derive from this class.
    /// <example>
    /// To switch the language manually perform a request with the following querystring:
    /// ?culture=TwoLetterISOLanguageName (e.g. ?culture=en).
    /// </example>
    /// </summary>
    public abstract class LocalizedControllerBase : Controller
    {
        /// <summary>
        /// Executes the specified request context.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        protected override void Execute(System.Web.Routing.RequestContext requestContext)
        {
            var culture = requestContext.HttpContext.Request.Params["culture"];

            /* First check if language has been set manually.
             * If not check if language is stored within the session.
             * If not (first request) use the browser's preferred language. */
            if (culture != null)
            {
                requestContext.HttpContext.Session["culture"] = culture;
                ApplyCulture(culture);
            }
            else if (requestContext.HttpContext.Session["culture"] != null)
            {
                ApplyCulture((string)requestContext.HttpContext.Session["culture"]);
            }
            else
            {
                try
                {
                    var userLanguages = requestContext.HttpContext.Request.UserLanguages;
                    if (userLanguages != null && userLanguages.Length > 0 && userLanguages[0].Length > 1)
                    {
                        var browserCulture = userLanguages[0].Substring(0, 2);
                        requestContext.HttpContext.Session["culture"] = browserCulture;
                    }
                    else
                    {
                        requestContext.HttpContext.Session["culture"] = "en";
                    }
                }
                catch (ArgumentException)
                {
                    requestContext.HttpContext.Session["culture"] = "en";
                }

                ApplyCulture((string)requestContext.HttpContext.Session["culture"]);
            }

            base.Execute(requestContext);
        }

        /// <summary>
        /// Applies the given culture.
        /// </summary>
        /// <param name="culture">The culture.</param>
        private static void ApplyCulture(string culture)
        {
            var cultureInfo = CultureInfo.InvariantCulture;
            cultureInfo = CultureInfo.CreateSpecificCulture(culture);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}
