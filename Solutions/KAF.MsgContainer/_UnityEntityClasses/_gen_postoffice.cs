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
    
    public  class _gen_postoffice : _Common
    {
         private static IResourceProvider resourceProvider_gen_postoffice = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_postoffice.xml"));//DbResourceProvider(); //  
         
         
        public static string postofficeList
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("postofficeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string postofficeCreate
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("postofficeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string postofficeUpdate
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("postofficeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string postofficeDetails
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("postofficeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string postofficename
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("postofficename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string postofficenameRequired
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("postofficenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string thanaid
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("thanaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string thanaidRequired
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("thanaidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string postofficecode
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("postofficecode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_postoffice.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
