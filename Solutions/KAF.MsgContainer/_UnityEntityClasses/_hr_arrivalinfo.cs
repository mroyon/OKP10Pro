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
    
    public  class _hr_arrivalinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_arrivalinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_arrivalinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string arrivalinfoList
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalinfoCreate
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalinfoUpdate
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalinfoDetails
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string flightid
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("flightid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightidRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("flightidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string arrivaldate
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivaldate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivaldateRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivaldateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string arrivalletterdate
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalletterdateRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string arrivalletterno
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalletternoRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("arrivalletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_arrivalinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
