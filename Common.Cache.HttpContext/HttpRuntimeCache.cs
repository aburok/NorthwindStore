using System;
using System.Web;
using NorthwindStore.Common.Cache;

namespace Common.Cache.HttpContext
{
    public class HttpRuntimeCache : ICache
    {
        private System.Web.Caching.Cache _cache
        {
            get { return HttpRuntime.Cache; }
        }

        public bool IsInCache(string key)
        {
            return _cache[key] == null;
        }

        public T Get<T>(string key) where T : class
        {
            try
            {
                if (_cache[key] != null)
                {
                    return _cache[key] as T;
                }

                return default(T);
            }
            catch
            {
                return default(T);
            }
        }

        private int defaultCacheDurationInMinutes = 30;

        public void Put<T>(string key, T value, int? cacheDurationInMinutes = null )
        {
            var expiresAt = cacheDurationInMinutes ?? defaultCacheDurationInMinutes;

            _cache.Insert(key, 
                value, 
                null,
               DateTime.Now.AddMinutes(expiresAt),
               TimeSpan.Zero);
        }

        public void PutOrUpdate<T>(string key, T value)
        {
            throw new NotImplementedException();
        }

        public void Clear(string key)
        {
            _cache.Remove(key);
        }
    }
}
