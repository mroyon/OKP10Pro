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
    
    public  class _gen_maritalstatus : _Common
    {
         private static IResourceProvider resourceProvider_gen_maritalstatus = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_maritalstatus.xml"));//DbResourceProvider(); //  
         
         
        public static string maritalstatusList
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusCreate
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusUpdate
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusDetails
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string maritalstatus
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusRequired
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("maritalstatusRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_maritalstatus.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
