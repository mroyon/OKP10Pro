﻿using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.OutputCache.Core.Cache;
using KAF.WebApiOutCache;

namespace KAF.WebAPICommon.HelperClass
{
    public class CustomCacheProvider : IApiOutputCache
    {
        private static readonly ICache CacheManagerCache = new CacheManagerProvider();
        private static readonly IList<string> Keys = new List<string>();

        public void RemoveStartsWith(string key)
        {
            IList<string> keys = Keys.Where(k => k.StartsWith(key)).ToList();
            foreach (var k in keys)
            {
                Remove(k);
            }
        }

        public T Get<T>(string key) where T : class
        {
            return CacheManagerCache.Get<T>(key);
        }

        public object Get(string key)
        {
            return CacheManagerCache.Get<object>(key);
        }

        public void Remove(string key)
        {
            Keys.Remove(key);
            CacheManagerCache.Remove(key);
        }

        public bool Contains(string key)
        {
            return CacheManagerCache.Exists(key);
        }

        public void Add(string key, object o, DateTimeOffset expiration, string dependsOnKey = null)
        {
            Keys.Add(key);
            CacheManagerCache.Set(key, o, expiration);
        }

        public IEnumerable<string> AllKeys => Keys;
    }
}