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
    
    public  class _hr_visademandinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_visademandinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_visademandinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string visademandinfoList
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandinfoCreate
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandinfoUpdate
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandinfoDetails
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string demandtype
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("demandtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string demandtypeRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("demandtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportinfoid
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("passportinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportinfoidRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("passportinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visademanddate
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademanddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademanddateRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademanddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visademandletterdate
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandletterdateRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visademandletterno
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandletternoRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("visademandletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_visademandinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
