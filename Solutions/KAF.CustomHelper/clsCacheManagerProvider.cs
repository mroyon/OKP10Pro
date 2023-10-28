using CacheManager.Core;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KAF.CustomHelper.HelperClasses
{
    public class CacheManagerProvider : CacheProviderBase<ICacheManager<object>>
    {
        protected override ICacheManager<object> InitCache()
        {
            return CacheFactory.FromConfiguration<object>("Redis");
        }

        public override T Get<T>(string key)
        {
            ICache cacheManagerCache = new CacheManagerProvider();
            T obj = Cache.Get<T>(KeyPrefix + key);
            if (obj == null)
            {
                switch (KeyPrefix + key)
                {
                    case "set_owin_role":
                        clsDataCache.set_owin_roleList();
                        break;                    
                    case "set_owin_formaction":
                        clsDataCache.set_owin_formaction();
                        break;
                    case "set_owin_forminfo":
                        clsDataCache.set_owin_forminfo();
                        break;

                    case "set_gen_airlines":
                        clsDataCache.set_gen_airlines();
                        break;
                    case "set_gen_building":
                        clsDataCache.set_gen_building();
                        break;
                    case "set_gen_okp":
                        clsDataCache.set_gen_okp();
                        break;

                    case "set_gen_arms":
                        clsDataCache.set_gen_arms();
                        break;
                    case "set_stp_organization":
                        clsDataCache.set_stp_organization();
                        break;
                    case "set_stp_organizationentitytype":
                        clsDataCache.set_stp_organizationentitytype();
                        break;
                    case "set_gen_bankbranch":
                        clsDataCache.set_gen_bankbranch();
                        break;
                    case "set_gen_bank":
                        clsDataCache.set_gen_bank();
                        break;
                    case "set_gen_filetype":
                        clsDataCache.set_gen_filetype();
                        break;
                    case "set_gen_relationship":
                        clsDataCache.set_gen_relationship();
                        break;
                        
                    case "set_gen_bloodgroup":
                        clsDataCache.set_gen_bloodgroup();
                        break;
                    case "set_gen_freedomfighttype":
                        clsDataCache.set_gen_freedomfighttype();
                        break;
                    case "set_gen_gender":
                        clsDataCache.set_gen_gender();
                        break;
                    case "set_gen_issuetype":
                        clsDataCache.set_gen_issuetype();
                        break;
                    case "set_gen_language":
                        clsDataCache.set_gen_language();
                        break;
                    case "set_gen_languageproficiency":
                        clsDataCache.set_gen_languageproficiency();
                        break;
                    case "set_gen_maritalstatus":
                        clsDataCache.set_gen_maritalstatus();
                        break;
                    case "set_gen_movementtype":
                        clsDataCache.set_gen_movementtype();
                        break;
                    case "set_gen_penaltytype":
                        clsDataCache.set_gen_penaltytype();
                        break;
                    case "set_gen_promotiontype":
                        clsDataCache.set_gen_promotiontype();
                        break;
                    case "set_gen_ranktype":
                        clsDataCache.set_gen_ranktype();
                        break;
                    case "set_gen_religion":
                        clsDataCache.set_gen_religion();
                        break;

                    case "set_gen_servicestatus":
                        clsDataCache.set_gen_servicestatus();
                        break;
                    case "set_gen_leavetype":
                        clsDataCache.set_gen_leavetype();
                        break;

                    case "set_gen_subunit":
                        clsDataCache.set_gen_subunit();
                        break;
                    case "set_gen_camp":
                        clsDataCache.set_gen_camp();
                        break;

                    #region General Setup

                    #endregion


                    default: break;
                }
            }
            obj = Cache.Get<T>(KeyPrefix + key);
            return obj;
        }

        public override void Set<T>(string key, T value, int duration)
        {
            Cache.Put(KeyPrefix + key, value);
            Cache.Expire(KeyPrefix + key, DateTime.Now.AddMinutes(duration));
        }

        public override void SetSliding<T>(string key, T value, int duration)
        {
            Cache.Put(KeyPrefix + key, value);
            Cache.Expire(KeyPrefix + key, new TimeSpan(0, duration, 0));
        }

        public override void Set<T>(string key, T value, DateTimeOffset expiration)
        {
            Cache.Put(KeyPrefix + key, value);
            Cache.Expire(KeyPrefix + key, expiration);
        }

        public override bool Exists(string key)
        {
            return Cache.Exists(KeyPrefix + key);
        }

        public override void Remove(string key)
        {
            Cache.Remove(KeyPrefix + key);
        }
    }
}