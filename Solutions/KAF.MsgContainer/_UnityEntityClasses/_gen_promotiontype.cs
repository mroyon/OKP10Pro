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
    
    public  class _gen_promotiontype : _Common
    {
         private static IResourceProvider resourceProvider_gen_promotiontype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_promotiontype.xml"));//DbResourceProvider(); //  
         
         
        public static string promotiontypeList
        {
            get
            {
                return resourceProvider_gen_promotiontype.GetResource("promotiontypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotiontypeCreate
        {
            get
            {
                return resourceProvider_gen_promotiontype.GetResource("promotiontypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotiontypeUpdate
        {
            get
            {
                return resourceProvider_gen_promotiontype.GetResource("promotiontypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotiontypeDetails
        {
            get
            {
                return resourceProvider_gen_promotiontype.GetResource("promotiontypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string promotiontype
        {
            get
            {
                return resourceProvider_gen_promotiontype.GetResource("promotiontype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotiontypeRequired
        {
            get
            {
                return resourceProvider_gen_promotiontype.GetResource("promotiontypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_promotiontype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
