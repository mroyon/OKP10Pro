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
    
    public  class _hr_visademandinfodetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_visademandinfodetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_visademandinfodetl.xml"));//DbResourceProvider(); //  
         
         
        public static string visademandinfodetlList
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("visademandinfodetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandinfodetlCreate
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("visademandinfodetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandinfodetlUpdate
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("visademandinfodetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandinfodetlDetails
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("visademandinfodetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string visademandid
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("visademandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandidRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("visademandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string demandtype
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("demandtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string demandtypeRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("demandtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportdetlid
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("passportdetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passportdetlidRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("passportdetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_visademandinfodetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
