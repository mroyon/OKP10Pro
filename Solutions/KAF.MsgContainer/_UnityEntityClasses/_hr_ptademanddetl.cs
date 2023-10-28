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
    
    public  class _hr_ptademanddetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_ptademanddetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_ptademanddetl.xml"));//DbResourceProvider(); //  
         
         
        public static string ptademanddetlList
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("ptademanddetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademanddetlCreate
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("ptademanddetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademanddetlUpdate
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("ptademanddetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademanddetlDetails
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("ptademanddetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string visasentdetlid
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("visasentdetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentdetlidRequired
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("visasentdetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptademandid
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("ptademandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademandidRequired
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("ptademandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterstatus
        {
            get
            {
                return resourceProvider_hr_ptademanddetl.GetResource("letterstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
