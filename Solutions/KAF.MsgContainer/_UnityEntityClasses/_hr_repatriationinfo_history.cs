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
    
    public  class _hr_repatriationinfo_history : _Common
    {
         private static IResourceProvider resourceProvider_hr_repatriationinfo_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_repatriationinfo_history.xml"));//DbResourceProvider(); //  
         
         
        public static string repatriationinfoList
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("repatriationinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationinfoCreate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("repatriationinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationinfoUpdate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("repatriationinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationinfoDetails
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("repatriationinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string repatriationid
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("repatriationid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationidRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("repatriationidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string soddate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("soddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string soddateRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("soddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string flightdate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("flightdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string salaryreceivedtilldate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("salaryreceivedtilldate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rewardavaildate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("rewardavaildate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letterdateRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("letterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letternoRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("letternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_repatriationinfo_history.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
