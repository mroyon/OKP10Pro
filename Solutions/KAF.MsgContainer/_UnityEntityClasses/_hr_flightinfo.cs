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
    
    public  class _hr_flightinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_flightinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_flightinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string flightinfoList
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightinfoCreate
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightinfoUpdate
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightinfoDetails
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string ptademandid
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("ptademandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademandidRequired
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("ptademandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string flightdate
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightdateRequired
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string flightletterdate
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightletterdateRequired
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string flightletterno
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightletternoRequired
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("flightletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string airlinesid
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("airlinesid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string airlinesidRequired
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("airlinesidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_flightinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
