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
    
    public  class _gen_issuetype : _Common
    {
         private static IResourceProvider resourceProvider_gen_issuetype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_issuetype.xml"));//DbResourceProvider(); //  
         
         
        public static string issuetypeList
        {
            get
            {
                return resourceProvider_gen_issuetype.GetResource("issuetypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issuetypeCreate
        {
            get
            {
                return resourceProvider_gen_issuetype.GetResource("issuetypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issuetypeUpdate
        {
            get
            {
                return resourceProvider_gen_issuetype.GetResource("issuetypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issuetypeDetails
        {
            get
            {
                return resourceProvider_gen_issuetype.GetResource("issuetypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string issuetype
        {
            get
            {
                return resourceProvider_gen_issuetype.GetResource("issuetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string issuetypeRequired
        {
            get
            {
                return resourceProvider_gen_issuetype.GetResource("issuetypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_issuetype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
