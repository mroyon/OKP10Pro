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
    
    public  class _hr_hospitaladmissioninfo_history : _Common
    {
         private static IResourceProvider resourceProvider_hr_hospitaladmissioninfo_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_hospitaladmissioninfo_history.xml"));//DbResourceProvider(); //  
         
         
        public static string hospitaladmissioninfoList
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissioninfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissioninfoCreate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissioninfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissioninfoUpdate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissioninfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissioninfoDetails
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissioninfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hospitaladmissionid
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissionidRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitalname
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitalname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitalnameRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitalnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string diseasename
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("diseasename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string diseasenameRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("diseasenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitaladmissiondate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissiondateRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitaladmissiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitalreleasedate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitalreleasedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitalcountryid
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitalcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitalcountryidRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("hospitalcountryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo_history.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
