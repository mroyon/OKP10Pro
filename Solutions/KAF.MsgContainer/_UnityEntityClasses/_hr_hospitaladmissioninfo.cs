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
    
    public  class _hr_hospitaladmissioninfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_hospitaladmissioninfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_hospitaladmissioninfo.xml"));//DbResourceProvider(); //  
         
         
        public static string hospitaladmissioninfoList
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitaladmissioninfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissioninfoCreate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitaladmissioninfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissioninfoUpdate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitaladmissioninfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissioninfoDetails
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitaladmissioninfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitalname
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitalname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitalnameRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitalnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string diseasename
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("diseasename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string diseasenameRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("diseasenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitaladmissiondate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitaladmissiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitaladmissiondateRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitaladmissiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitalreleasedate
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitalreleasedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hospitalcountryid
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitalcountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hospitalcountryidRequired
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("hospitalcountryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_hospitaladmissioninfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

         public static string releasenote
        {
             get
             {
                 return resourceProvider_hr_hospitaladmissioninfo.GetResource("releasenote", CultureInfo.CurrentUICulture.Name) as String;
             }
         }


    }
}
