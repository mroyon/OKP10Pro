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
    
    public  class _hr_attachmentinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_attachmentinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_attachmentinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string attachmentinfoList
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("attachmentinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string attachmentinfoCreate
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("attachmentinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string attachmentinfoUpdate
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("attachmentinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string attachmentinfoDetails
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("attachmentinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromsubunitid
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("fromsubunitid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromsubunitidRequired
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("fromsubunitidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromcampid
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("fromcampid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromcampidRequired
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("fromcampidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string subunitid
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("subunitid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subunitidRequired
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("subunitidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string campid
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("campid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string campidRequired
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("campidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromdate
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("fromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromdateRequired
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("fromdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string todate
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("todate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reason
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("reason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returndate
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("returndate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returnletterno
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("returnletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returnletterdate
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("returnletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_attachmentinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
