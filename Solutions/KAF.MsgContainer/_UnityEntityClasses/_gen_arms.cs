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
    
    public  class _gen_arms : _Common
    {
         private static IResourceProvider resourceProvider_gen_arms = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_arms.xml"));//DbResourceProvider(); //  
         
         
        public static string armsList
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("armsList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string armsCreate
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("armsCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string armsUpdate
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("armsUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string armsDetails
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("armsDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string forceid
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("forceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string forceidRequired
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("forceidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string armsname
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("armsname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string armsnameRequired
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("armsnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_arms.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
