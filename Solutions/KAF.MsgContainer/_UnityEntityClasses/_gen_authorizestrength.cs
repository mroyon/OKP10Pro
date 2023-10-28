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
    
    public  class _gen_authorizestrength : _Common
    {
         private static IResourceProvider resourceProvider_gen_authorizestrength = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_authorizestrength.xml"));//DbResourceProvider(); //  
         
         
        public static string authorizestrengthList
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("authorizestrengthList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string authorizestrengthCreate
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("authorizestrengthCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string authorizestrengthUpdate
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("authorizestrengthUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string authorizestrengthDetails
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("authorizestrengthDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string okpid
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpidRequired
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("okpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankid
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("rankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankidRequired
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("rankidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string groupid
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("groupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string groupidRequired
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("groupidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string authstrength
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("authstrength", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string authstrengthRequired
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("authstrengthRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_authorizestrength.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
