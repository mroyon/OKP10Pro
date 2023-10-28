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
    
    public  class _gen_language : _Common
    {
         private static IResourceProvider resourceProvider_gen_language = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_language.xml"));//DbResourceProvider(); //  
         
         
        public static string languageList
        {
            get
            {
                return resourceProvider_gen_language.GetResource("languageList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageCreate
        {
            get
            {
                return resourceProvider_gen_language.GetResource("languageCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageUpdate
        {
            get
            {
                return resourceProvider_gen_language.GetResource("languageUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageDetails
        {
            get
            {
                return resourceProvider_gen_language.GetResource("languageDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string languagename
        {
            get
            {
                return resourceProvider_gen_language.GetResource("languagename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languagenameRequired
        {
            get
            {
                return resourceProvider_gen_language.GetResource("languagenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_language.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
