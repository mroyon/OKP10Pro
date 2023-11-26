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
    
    public  class _hr_familyresidentvisa : _Common
    {
         private static IResourceProvider resourceProvider_hr_familyresidentvisa = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_familyresidentvisa.xml"));//DbResourceProvider(); //  
         
         
        public static string familyresidentvisaList
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("familyresidentvisaList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyresidentvisaCreate
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("familyresidentvisaCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyresidentvisaUpdate
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("familyresidentvisaUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyresidentvisaDetails
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("familyresidentvisaDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrfamilyid
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("hrfamilyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrfamilyidRequired
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("hrfamilyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportid
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("familypassportid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familypassportidRequired
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("familypassportidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string residencynumber
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("residencynumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residencynumberRequired
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("residencynumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issuedate
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("issuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issuedateRequired
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("issuedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string expirydate
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("expirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expirydateRequired
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("expirydateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isfamilyvisa
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("isfamilyvisa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filedescription
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("filedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileno
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("fileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_familyresidentvisa.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
