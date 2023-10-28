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
    
    public  class _hr_visaissueinfodetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_visaissueinfodetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_visaissueinfodetl.xml"));//DbResourceProvider(); //  
         
         
        public static string visaissueinfodetlList
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visaissueinfodetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueinfodetlCreate
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visaissueinfodetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueinfodetlUpdate
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visaissueinfodetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueinfodetlDetails
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visaissueinfodetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string visaissueid
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visaissueid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueidRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visaissueidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visademanddetlid
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visademanddetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademanddetlidRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("visademanddetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_visaissueinfodetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
