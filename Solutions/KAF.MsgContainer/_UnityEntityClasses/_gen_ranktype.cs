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
    
    public  class _gen_ranktype : _Common
    {
         private static IResourceProvider resourceProvider_gen_ranktype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_ranktype.xml"));//DbResourceProvider(); //  
         
         
        public static string ranktypeList
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("ranktypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ranktypeCreate
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("ranktypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ranktypeUpdate
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("ranktypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ranktypeDetails
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("ranktypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string ranktype
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("ranktype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ranktypeRequired
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("ranktypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_ranktype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
