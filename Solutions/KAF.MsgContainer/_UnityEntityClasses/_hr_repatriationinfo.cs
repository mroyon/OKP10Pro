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
    
    public  class _hr_repatriationinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_repatriationinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_repatriationinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string repatriationinfoList
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("repatriationinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationinfoCreate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("repatriationinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationinfoUpdate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("repatriationinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationinfoDetails
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("repatriationinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string soddate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("soddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string soddateRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("soddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string flightdate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("flightdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string salaryreceivedtilldate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("salaryreceivedtilldate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rewardavaildate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("rewardavaildate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letterdateRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("letterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letternoRequired
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("letternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_repatriationinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
