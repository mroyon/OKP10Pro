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
    
    public  class _hr_reppassportinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_reppassportinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_reppassportinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string reppassportinfoList
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("reppassportinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reppassportinfoCreate
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("reppassportinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reppassportinfoUpdate
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("reppassportinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reppassportinfoDetails
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("reppassportinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string replacementid
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("replacementid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementidRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("replacementidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportrecvdate
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("passportrecvdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportrecvdateRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("passportrecvdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportletterdate
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("passportletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportletterdateRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("passportletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportletterno
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("passportletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportletternoRequired
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("passportletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_reppassportinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
