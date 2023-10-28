using  KAF.MsgContainer.Abstract;
using  KAF.MsgContainer.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KAF.MsgContainer;

namespace KAF.MsgContainer
{
    
    public  class _hr_rewardinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_rewardinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_rewardinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string rewardinfoList
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rewardinfoCreate
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rewardinfoUpdate
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rewardinfoDetails
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rewarddate
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewarddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rewarddateRequired
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewarddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rewardevent
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardevent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rewardeventRequired
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardeventRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reward
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("reward", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rewardRequired
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rewardcountryid
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("rewardcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_rewardinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
