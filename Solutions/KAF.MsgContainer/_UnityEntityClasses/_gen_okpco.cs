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
    
    public  class _gen_okpco : _Common
    {
         private static IResourceProvider resourceProvider_gen_okpco = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_okpco.xml"));//DbResourceProvider(); //  
         
         
        public static string okpcoList
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("okpcoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpcoCreate
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("okpcoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpcoUpdate
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("okpcoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpcoDetails
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("okpcoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string okpid
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpidRequired
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("okpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromdate
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("fromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromdateRequired
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("fromdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string todate
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("todate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscurrent
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("iscurrent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_okpco.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
