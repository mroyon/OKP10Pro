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
    
    public  class _hr_basicfile : _Common
    {
         private static IResourceProvider resourceProvider_hr_basicfile = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_basicfile.xml"));//DbResourceProvider(); //  
         
         
        public static string basicfileList
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("basicfileList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicfileCreate
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("basicfileCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicfileUpdate
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("basicfileUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicfileDetails
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("basicfileDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetypeid
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetypeidRequired
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filedescription
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filepathRequired
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filepathRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filenameRequired
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetypeRequired
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("filetypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string extensionRequired
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("extensionRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_basicfile.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
