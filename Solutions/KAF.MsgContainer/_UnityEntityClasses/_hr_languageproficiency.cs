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
    
    public  class _hr_languageproficiency : _Common
    {
         private static IResourceProvider resourceProvider_hr_languageproficiency = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_languageproficiency.xml"));//DbResourceProvider(); //  
         
         
        public static string languageproficiencyList
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("languageproficiencyList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageproficiencyCreate
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("languageproficiencyCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageproficiencyUpdate
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("languageproficiencyUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageproficiencyDetails
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("languageproficiencyDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string languageid
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("languageid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageidRequired
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("languageidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string readingproficiencyid
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("readingproficiencyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string readingproficiencyidRequired
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("readingproficiencyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string writingproficiencyid
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("writingproficiencyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string writingproficiencyidRequired
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("writingproficiencyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string speakingproficiencyid
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("speakingproficiencyid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string speakingproficiencyidRequired
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("speakingproficiencyidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_languageproficiency.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
