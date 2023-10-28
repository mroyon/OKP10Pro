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
    
    public  class _hr_newdemand : _Common
    {
         private static IResourceProvider resourceProvider_hr_newdemand = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_newdemand.xml"));//DbResourceProvider(); //  
         
         
        public static string newdemandList
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("newdemandList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemandCreate
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("newdemandCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemandUpdate
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("newdemandUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemandDetails
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("newdemandDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string demandletterno
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("demandletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string demandletternoRequired
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("demandletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string demandletterdate
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("demandletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string demandletterdateRequired
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("demandletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_newdemand.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
