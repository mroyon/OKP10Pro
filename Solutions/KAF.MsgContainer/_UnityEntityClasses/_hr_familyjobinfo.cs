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
    
    public  class _hr_familyjobinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_familyjobinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_familyjobinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string familyjobinfoList
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("familyjobinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyjobinfoCreate
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("familyjobinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyjobinfoUpdate
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("familyjobinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string familyjobinfoDetails
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("familyjobinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrfamilyid
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("hrfamilyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrfamilyidRequired
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("hrfamilyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string jobtype
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("jobtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string jobtypeRequired
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("jobtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string organization
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("organization", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationRequired
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("organizationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string designation
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("designation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string designationRequired
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("designationRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string joiningdate
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("joiningdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string joiningdateRequired
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("joiningdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string workplaceaddress
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("workplaceaddress", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_familyjobinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
