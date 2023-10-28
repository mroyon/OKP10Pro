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
    
    public  class _hr_residentvisa : _Common
    {
         private static IResourceProvider resourceProvider_hr_residentvisa = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_residentvisa.xml"));//DbResourceProvider(); //  
         
         
        public static string residentvisaList
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("residentvisaList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residentvisaCreate
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("residentvisaCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residentvisaUpdate
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("residentvisaUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residentvisaDetails
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("residentvisaDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportid
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("passportid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportidRequired
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("passportidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string residencynumber
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("residencynumber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string residencynumberRequired
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("residencynumberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string issuedate
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("issuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issuedateRequired
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("issuedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string expirydate
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("expirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string expirydateRequired
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("expirydateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isfamilyvisa
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("isfamilyvisa", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filedescription
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("filedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fileno
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("fileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_residentvisa.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
