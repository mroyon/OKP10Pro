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
    
    public  class _hr_arrivalinfodetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_arrivalinfodetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_arrivalinfodetl.xml"));//DbResourceProvider(); //  
         
         
        public static string arrivalinfodetlList
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("arrivalinfodetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalinfodetlCreate
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("arrivalinfodetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalinfodetlUpdate
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("arrivalinfodetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalinfodetlDetails
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("arrivalinfodetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string arrivalld
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("arrivalld", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string arrivalldRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("arrivalldRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string flightdetlid
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("flightdetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string flightdetlidRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("flightdetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_arrivalinfodetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
