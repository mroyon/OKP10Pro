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
    
    public  class _hr_ptareceiveddetl : _Common
    {
         private static IResourceProvider resourceProvider_hr_ptareceiveddetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_ptareceiveddetl.xml"));//DbResourceProvider(); //  
         
         
        public static string ptareceiveddetlList
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptareceiveddetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptareceiveddetlCreate
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptareceiveddetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptareceiveddetlUpdate
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptareceiveddetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptareceiveddetlDetails
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptareceiveddetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string ptidemanddetlid
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptidemanddetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptidemanddetlidRequired
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptidemanddetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptademandid
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptademandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademandidRequired
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("ptademandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterstatus
        {
            get
            {
                return resourceProvider_hr_ptareceiveddetl.GetResource("letterstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
