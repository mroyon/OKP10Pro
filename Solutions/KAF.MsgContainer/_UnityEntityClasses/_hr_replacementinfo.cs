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
    
    public  class _hr_replacementinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_replacementinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_replacementinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string replacementinfoList
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("replacementinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementinfoCreate
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("replacementinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementinfoUpdate
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("replacementinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string replacementinfoDetails
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("replacementinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letternoRequired
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("letternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letterdateRequired
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("letterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_replacementinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
