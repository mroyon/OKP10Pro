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
    
    public  class _owin_reportpermission : _Common
    {
         private static IResourceProvider resourceProvider_owin_reportpermission = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_reportpermission.xml"));//DbResourceProvider(); //  
         
         
        public static string reportpermissionList
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportpermissionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportpermissionCreate
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportpermissionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportpermissionUpdate
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportpermissionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportpermissionDetails
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportpermissionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string masteruserid
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("masteruserid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string masteruseridRequired
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("masteruseridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportroleid
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportroleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroleidRequired
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportroleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportid
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportidRequired
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("reportidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isaccessible
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("isaccessible", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isaccessibleRequired
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("isaccessibleRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isprintable
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("isprintable", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isprintableRequired
        {
            get
            {
                return resourceProvider_owin_reportpermission.GetResource("isprintableRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
