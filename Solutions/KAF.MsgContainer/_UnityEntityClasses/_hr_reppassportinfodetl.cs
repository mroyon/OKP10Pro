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
    
    public  class _hr_reppassportinfodetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_reppassportinfodetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_reppassportinfodetl.xml"));//DbResourceProvider(); //  
         
         
        public static string reppassportinfodetlList
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("reppassportinfodetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reppassportinfodetlCreate
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("reppassportinfodetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reppassportinfodetlUpdate
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("reppassportinfodetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reppassportinfodetlDetails
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("reppassportinfodetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string reppassportid
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("reppassportid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reppassportidRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("reppassportidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string replacementdetlid
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("replacementdetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementdetlidRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("replacementdetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newhrbasicid
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("newhrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newhrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("newhrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newhrsvcid
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("newhrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newhrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("newhrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newpassportno
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("newpassportno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newpassportnoRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("newpassportnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_reppassportinfodetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
