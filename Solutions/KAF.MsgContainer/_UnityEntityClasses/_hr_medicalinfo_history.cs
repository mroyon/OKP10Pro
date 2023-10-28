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
    
    public  class _hr_medicalinfo_history : _Common
    {
         private static IResourceProvider resourceProvider_hr_medicalinfo_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_medicalinfo_history.xml"));//DbResourceProvider(); //  
         
         
        public static string medicalinfoList
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medicalinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medicalinfoCreate
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medicalinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medicalinfoUpdate
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medicalinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medicalinfoDetails
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medicalinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string miltmedicalid
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("miltmedicalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string miltmedicalidRequired
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("miltmedicalidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissionno
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medcommissionnoRequired
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommsisiondate
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommsisiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string medcommsisiondateRequired
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommsisiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissionfiledescription
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissionfilepath
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissionfilename
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissionfiletype
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissionextension
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissionfileno
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissionfileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medcommissiondesc
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medcommissiondesc", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docno
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docdate
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docfiledescription
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docfilepath
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docfilename
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docfiletype
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docextension
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string docfileno
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("docfileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string medaction
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("medaction", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_medicalinfo_history.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
