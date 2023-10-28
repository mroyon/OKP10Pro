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
    
    public  class _gen_religion : _Common
    {
         private static IResourceProvider resourceProvider_gen_religion = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_religion.xml"));//DbResourceProvider(); //  
         
         
        public static string religionList
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionCreate
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionUpdate
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionDetails
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string religion
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religion", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionRequired
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("religionRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_religion.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
