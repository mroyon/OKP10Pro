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
    
    public  class _hr_familypassportinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_familypassportinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_familypassportinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string familypassportinfoList
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familypassportinfoCreate
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familypassportinfoUpdate
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familypassportinfoDetails
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrfamilyid
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("hrfamilyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrfamilyidRequired
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("hrfamilyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportno
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familypassportnoRequired
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportissuedate
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportissuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportexpirydate
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportissuecountryid
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportissuecountryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isfamilyfamilypassport
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("isfamilyfamilypassport", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportfiledescription
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportfilepath
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportfilename
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportfiletype
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportextension
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familypassportfileid
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("familypassportfileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscurrent
        {
            get
            {
                return resourceProvider_hr_familypassportinfo.GetResource("iscurrent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
