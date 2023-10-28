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
    
    public  class _rptm_reportdatasource : _Common
    {
         private static IResourceProvider resourceProvider_rptm_reportdatasource = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_rptm_reportdatasource.xml"));//DbResourceProvider(); //  
         
         
        public static string reportdatasourceList
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourceList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportdatasourceCreate
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourceCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportdatasourceUpdate
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourceUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportdatasourceDetails
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourceDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string reportid
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportidRequired
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportdatasourcename
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourcename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportdatasourcenameRequired
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourcenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportdatasourcespname
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourcespname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportdatasourcespnameRequired
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourcespnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportdatasourcedescription
        {
            get
            {
                return resourceProvider_rptm_reportdatasource.GetResource("reportdatasourcedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
