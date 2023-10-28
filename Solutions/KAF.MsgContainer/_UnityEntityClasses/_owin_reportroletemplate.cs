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
    
    public  class _owin_reportroletemplate : _Common
    {
         private static IResourceProvider resourceProvider_owin_reportroletemplate = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_reportroletemplate.xml"));//DbResourceProvider(); //  
         
         
        public static string reportroletemplateList
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportroletemplateList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroletemplateCreate
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportroletemplateCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroletemplateUpdate
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportroletemplateUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroletemplateDetails
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportroletemplateDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string reportroleid
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportroleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroleidRequired
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportroleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportid
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportidRequired
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("reportidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string status
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("status", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string statusRequired
        {
            get
            {
                return resourceProvider_owin_reportroletemplate.GetResource("statusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
