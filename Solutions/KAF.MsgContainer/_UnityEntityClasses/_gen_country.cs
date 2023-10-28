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
    
    public  class _gen_country : _Common
    {
         private static IResourceProvider resourceProvider_gen_country = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_country.xml"));//DbResourceProvider(); //  
         
         
        public static string countryList
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryCreate
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryUpdate
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryDetails
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string countryname
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countryname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countrynameRequired
        {
            get
            {
                return resourceProvider_gen_country.GetResource("countrynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationality
        {
            get
            {
                return resourceProvider_gen_country.GetResource("nationality", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_country.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
