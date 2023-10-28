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
    
    public  class _hr_newdemanddetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_newdemanddetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_newdemanddetl.xml"));//DbResourceProvider(); //  
         
         
        public static string newdemanddetlList
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("newdemanddetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemanddetlCreate
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("newdemanddetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemanddetlUpdate
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("newdemanddetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemanddetlDetails
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("newdemanddetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string newdemandid
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("newdemandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemandidRequired
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("newdemandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankid
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("rankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankidRequired
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("rankidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tradeid
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("tradeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tradeidRequired
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("tradeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string groupid
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("groupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string groupidRequired
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("groupidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string okpid
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpidRequired
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("okpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string noofvacancies
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("noofvacancies", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string noofvacanciesRequired
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("noofvacanciesRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_newdemanddetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
