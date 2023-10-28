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
    
    public  class _hr_documentupload : _Common
    {
         private static IResourceProvider resourceProvider_hr_documentupload = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_documentupload.xml"));//DbResourceProvider(); //  
         
         
        public static string documentuploadList
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("documentuploadList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string documentuploadCreate
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("documentuploadCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string documentuploadUpdate
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("documentuploadUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string documentuploadDetails
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("documentuploadDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string doctypeid
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("doctypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string doctypeidRequired
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("doctypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetypeid
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("filetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docname
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("docname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderno
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("orderno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderdate
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("orderdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filedescription
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("filedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_documentupload.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
