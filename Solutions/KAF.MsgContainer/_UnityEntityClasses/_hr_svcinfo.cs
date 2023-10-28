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
    
    public  class _hr_svcinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_svcinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_svcinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string svcinfoList
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("svcinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string svcinfoCreate
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("svcinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string svcinfoUpdate
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("svcinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string svcinfoDetails
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("svcinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportno
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("passportno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string joindatekw
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("joindatekw", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string expectedretiredatekw
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("expectedretiredatekw", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitykey
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("entitykey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string armsid
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("armsid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string okpid
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankidkw
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("rankidkw", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankidbd
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("rankidbd", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tradeidbd
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("tradeidbd", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tradeidkw
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("tradeidkw", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string groupid
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("groupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string status
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("status", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_svcinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
