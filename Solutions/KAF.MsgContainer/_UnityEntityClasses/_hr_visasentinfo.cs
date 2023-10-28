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
    
    public  class _hr_visasentinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_visasentinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_visasentinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string visasentinfoList
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentinfoCreate
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentinfoUpdate
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentinfoDetails
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string visaissueid
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visaissueid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueidRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visaissueidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visasentdate
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentdateRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visasentletterdate
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentletterdateRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visasentletterno
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentletternoRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("visasentletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_visasentinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
