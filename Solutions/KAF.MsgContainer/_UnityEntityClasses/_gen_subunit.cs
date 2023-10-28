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
    
    public  class _gen_subunit : _Common
    {
         private static IResourceProvider resourceProvider_gen_subunit = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_subunit.xml"));//DbResourceProvider(); //  
         
         
        public static string subunitList
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("subunitList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subunitCreate
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("subunitCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subunitUpdate
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("subunitUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subunitDetails
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("subunitDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string subunit
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("subunit", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subunitRequired
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("subunitRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string okpid
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpidRequired
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("okpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string outsidekuwait
        {
            get
            {
                return resourceProvider_gen_subunit.GetResource("outsidekuwait", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
