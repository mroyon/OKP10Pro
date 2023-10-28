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
    
    public  class _hr_okptransferinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_okptransferinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_okptransferinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string okptransferinfoList
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("okptransferinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okptransferinfoCreate
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("okptransferinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okptransferinfoUpdate
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("okptransferinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okptransferinfoDetails
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("okptransferinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromkopid
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("fromkopid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromkopidRequired
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("fromkopidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tookpid
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("tookpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tookpidRequired
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("tookpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string subunitid
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("subunitid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subunitidRequired
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("subunitidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string campid
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("campid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string campidRequired
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("campidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string transferdate
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("transferdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string transferdateRequired
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("transferdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reason
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("reason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_okptransferinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
