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
    
    public  class _gen_govcity : _Common
    {
         private static IResourceProvider resourceProvider_gen_govcity = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_govcity.xml"));//DbResourceProvider(); //  
         
         
        public static string govcityList
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("govcityList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string govcityCreate
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("govcityCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string govcityUpdate
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("govcityUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string govcityDetails
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("govcityDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentid
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string cityname
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("cityname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string citynameRequired
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("citynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string citynamear
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("citynamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isgov
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("isgov", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string area_code_paci
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("area_code_paci", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_govcity.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
