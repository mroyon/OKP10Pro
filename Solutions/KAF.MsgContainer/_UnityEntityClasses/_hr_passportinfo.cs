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
    
    public  class _hr_passportinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_passportinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_passportinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string passportinfoList
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportinfoCreate
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportinfoUpdate
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportinfoDetails
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportno
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportnoRequired
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportissuedate
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportissuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportexpirydate
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportissuecountryid
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportissuecountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isfamilypassport
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("isfamilypassport", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportfiledescription
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportfilepath
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportfilename
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportfiletype
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportextension
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportfileid
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("passportfileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscurrent
        {
            get
            {
                return resourceProvider_hr_passportinfo.GetResource("iscurrent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
