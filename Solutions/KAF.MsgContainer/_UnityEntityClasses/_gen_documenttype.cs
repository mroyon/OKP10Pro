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
    
    public  class _gen_documenttype : _Common
    {
         private static IResourceProvider resourceProvider_gen_documenttype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_documenttype.xml"));//DbResourceProvider(); //  
         
         
        public static string documenttypeList
        {
            get
            {
                return resourceProvider_gen_documenttype.GetResource("documenttypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string documenttypeCreate
        {
            get
            {
                return resourceProvider_gen_documenttype.GetResource("documenttypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string documenttypeUpdate
        {
            get
            {
                return resourceProvider_gen_documenttype.GetResource("documenttypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string documenttypeDetails
        {
            get
            {
                return resourceProvider_gen_documenttype.GetResource("documenttypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string doctypename
        {
            get
            {
                return resourceProvider_gen_documenttype.GetResource("doctypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string doctypenameRequired
        {
            get
            {
                return resourceProvider_gen_documenttype.GetResource("doctypenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_documenttype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
