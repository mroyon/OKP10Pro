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
    
    public  class _hr_visasentinfodetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_visasentinfodetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_visasentinfodetl.xml"));//DbResourceProvider(); //  
         
         
        public static string visasentinfodetlList
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visasentinfodetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentinfodetlCreate
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visasentinfodetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentinfodetlUpdate
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visasentinfodetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentinfodetlDetails
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visasentinfodetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string visasentid
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visasentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentidRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visasentidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visaissuedetlid
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visaissuedetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissuedetlidRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("visaissuedetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_visasentinfodetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
