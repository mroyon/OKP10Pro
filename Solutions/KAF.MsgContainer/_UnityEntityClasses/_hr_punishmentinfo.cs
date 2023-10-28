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
    
    public  class _hr_punishmentinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_punishmentinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_punishmentinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string punishmentinfoList
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmentinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentinfoCreate
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmentinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentinfoUpdate
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmentinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentinfoDetails
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmentinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishmenttype
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmenttype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmenttypeRequired
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmenttypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishmentdate
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmentdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string punishmentdateRequired
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmentdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string offence
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("offence", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishment
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishment", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string punishmentdetails
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("punishmentdetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_punishmentinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
