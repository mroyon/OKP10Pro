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
    
    public  class _hr_civilidinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_civilidinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_civilidinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string civilidinfoList
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidinfoCreate
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidinfoUpdate
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidinfoDetails
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidno
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidnoRequired
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidissuedate
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidissuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidexpirydate
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfiledescription
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfilepath
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfilename
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfiletype
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidextension
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfileid
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfiledescription_2
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfiledescription_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfilepath_2
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfilepath_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfilename_2
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfilename_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfiletype_2
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfiletype_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidextension_2
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidextension_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidfileid_2
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("civilidfileid_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscurrent
        {
            get
            {
                return resourceProvider_hr_civilidinfo.GetResource("iscurrent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
