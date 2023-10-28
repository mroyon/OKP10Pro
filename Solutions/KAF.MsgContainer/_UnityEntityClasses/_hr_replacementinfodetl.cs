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
    
    public  class _hr_replacementinfodetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_replacementinfodetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_replacementinfodetl.xml"));//DbResourceProvider(); //  
         
         
        public static string replacementinfodetlList
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("replacementinfodetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementinfodetlCreate
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("replacementinfodetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementinfodetlUpdate
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("replacementinfodetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementinfodetlDetails
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("replacementinfodetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string replacementid
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("replacementid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementidRequired
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("replacementidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_replacementinfodetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
