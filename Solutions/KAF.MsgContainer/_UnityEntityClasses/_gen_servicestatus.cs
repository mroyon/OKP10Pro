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
    
    public  class _gen_servicestatus : _Common
    {
         private static IResourceProvider resourceProvider_gen_servicestatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_servicestatus.xml"));//DbResourceProvider(); //  
         
         
        public static string servicestatusList
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusCreate
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusUpdate
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusDetails
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string servicestatusname
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string servicestatusnameRequired
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("servicestatusnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_servicestatus.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
