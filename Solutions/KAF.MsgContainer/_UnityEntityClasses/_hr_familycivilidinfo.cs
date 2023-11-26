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
    
    public  class _hr_familycivilidinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_familycivilidinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_familycivilidinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string familycivilidinfoList
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familycivilidinfoCreate
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familycivilidinfoUpdate
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familycivilidinfoDetails
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrfamilyid
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("hrfamilyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrfamilyidRequired
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("hrfamilyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidno
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familycivilidnoRequired
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serialno
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("serialno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidissuedate
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidissuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidexpirydate
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidexpirydate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfiledescription
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfilepath
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfilename
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfiletype
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidextension
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfileid
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfileid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfiledescription_2
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfiledescription_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfilepath_2
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfilepath_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfilename_2
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfilename_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfiletype_2
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfiletype_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidextension_2
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidextension_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string familycivilidfileid_2
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("familycivilidfileid_2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscurrent
        {
            get
            {
                return resourceProvider_hr_familycivilidinfo.GetResource("iscurrent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
