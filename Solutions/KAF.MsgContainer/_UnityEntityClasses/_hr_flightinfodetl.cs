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
    
    public  class _hr_flightinfodetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_flightinfodetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_flightinfodetl.xml"));//DbResourceProvider(); //  
         
         
        public static string flightinfodetlList
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("flightinfodetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightinfodetlCreate
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("flightinfodetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightinfodetlUpdate
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("flightinfodetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightinfodetlDetails
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("flightinfodetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string flightid
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("flightid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightidRequired
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("flightidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptidetlid
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("ptidetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptidetlidRequired
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("ptidetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscancel
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("iscancel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string canceldate
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("canceldate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string cancelletterdate
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("cancelletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string cancelletterno
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("cancelletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reason
        {
            get
            {
                return resourceProvider_hr_flightinfodetl.GetResource("reason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
