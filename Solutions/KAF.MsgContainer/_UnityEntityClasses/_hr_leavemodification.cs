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
    
    public  class _hr_leavemodification : _Common
    {
         private static IResourceProvider resourceProvider_hr_leavemodification = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_leavemodification.xml"));//DbResourceProvider(); //  
         
         
        public static string leavemodificationList
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavemodificationList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavemodificationCreate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavemodificationCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavemodificationUpdate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavemodificationUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavemodificationDetails
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavemodificationDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string leaveinfoid
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leaveinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoidRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leaveinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavetypeid
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeidRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string modificationdate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("modificationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string modificationdateRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("modificationdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string startdate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string enddate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddateRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("enddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string noofdays
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("noofdays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string noofdaysRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("noofdaysRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavestartdate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavestartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavestartdateRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavestartdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leaveenddate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leaveenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveenddateRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leaveenddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavedays
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavedays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavedaysRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("leavedaysRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string withgovtticket
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("withgovtticket", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string withgovtticketRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("withgovtticketRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string modificationtype
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("modificationtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string modificationtypeRequired
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("modificationtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_leavemodification.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
