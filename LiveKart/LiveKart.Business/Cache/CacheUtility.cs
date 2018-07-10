using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;
using LiveKart.Shared;

namespace LiveKart.Business
{
    public static class CacheUtility
    {
        public static T GetCacheItem<T>(string cacheKey)
        {
            return (T)HttpContext.Current.Cache[cacheKey];
        }

        public static void CacheItem(string cacheKey, object value)
        {
            HttpContext.Current.Cache.Insert(cacheKey, value, null, DateTime.UtcNow.AddHours(12), Cache.NoSlidingExpiration);
        }
    }
}
