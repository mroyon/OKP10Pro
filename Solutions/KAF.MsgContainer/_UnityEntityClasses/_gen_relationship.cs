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
    
    public  class _gen_relationship : _Common
    {
         private static IResourceProvider resourceProvider_gen_relationship = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_relationship.xml"));//DbResourceProvider(); //  
         
         
        public static string relationshipList
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipCreate
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipUpdate
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipDetails
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string relationshipname
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipnameRequired
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("relationshipnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forself
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("forself", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_relationship.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
