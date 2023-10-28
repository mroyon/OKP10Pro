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
    
    public  class _hr_deathinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_deathinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_deathinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string deathinfoList
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathinfoCreate
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathinfoUpdate
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathinfoDetails
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string deathdate
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathdateRequired
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string deathreason
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathreason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string deathreasonRequired
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("deathreasonRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_deathinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
