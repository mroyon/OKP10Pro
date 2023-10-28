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
    
    public  class _gen_freedomfighttype : _Common
    {
         private static IResourceProvider resourceProvider_gen_freedomfighttype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_freedomfighttype.xml"));//DbResourceProvider(); //  
         
         
        public static string freedomfighttypeList
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("freedomfighttypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string freedomfighttypeCreate
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("freedomfighttypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string freedomfighttypeUpdate
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("freedomfighttypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string freedomfighttypeDetails
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("freedomfighttypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string freedomfight
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("freedomfight", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string freedomfightRequired
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("freedomfightRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_freedomfighttype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
