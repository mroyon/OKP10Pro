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
    
    public  class _gen_okp : _Common
    {
         private static IResourceProvider resourceProvider_gen_okp = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_okp.xml"));//DbResourceProvider(); //  
         
         
        public static string okpList
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("okpList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpCreate
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("okpCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpUpdate
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("okpUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpDetails
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("okpDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string okpname
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("okpname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpnameRequired
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("okpnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string raisingdate
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("raisingdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_okp.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
