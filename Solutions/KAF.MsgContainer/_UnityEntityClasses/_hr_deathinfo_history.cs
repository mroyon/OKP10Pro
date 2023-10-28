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
    
    public  class _hr_deathinfo_history : _Common
    {
         private static IResourceProvider resourceProvider_hr_deathinfo_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_deathinfo_history.xml"));//DbResourceProvider(); //  
         
         
        public static string deathinfoList
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathinfoCreate
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathinfoUpdate
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathinfoDetails
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string deathinfoid
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathinfoidRequired
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string deathdate
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathdateRequired
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string deathreason
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathreason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathreasonRequired
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("deathreasonRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_deathinfo_history.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
