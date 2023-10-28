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
    
    public  class _gen_camp : _Common
    {
         private static IResourceProvider resourceProvider_gen_camp = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_camp.xml"));//DbResourceProvider(); //  
         
         
        public static string campList
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("campList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string campCreate
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("campCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string campUpdate
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("campUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string campDetails
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("campDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string campname
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("campname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string campnameRequired
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("campnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string okpid
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpidRequired
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("okpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_camp.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
