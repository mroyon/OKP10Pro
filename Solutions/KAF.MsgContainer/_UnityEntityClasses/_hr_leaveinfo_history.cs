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
    
    public  class _hr_leaveinfo_history : _Common
    {
         private static IResourceProvider resourceProvider_hr_leaveinfo_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_leaveinfo_history.xml"));//DbResourceProvider(); //  
         
         
        public static string leaveinfoList
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoCreate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoUpdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoDetails
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string leaveinfoid
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveinfoid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoidRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveinfoidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavetypeid
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leavetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeidRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leavetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string startdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string enddate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("enddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string noofdays
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("noofdays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string noofdaysRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("noofdaysRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavestartdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leavestartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavestartdateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leavestartdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leaveenddate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveenddateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leaveenddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavedays
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leavedays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavedaysRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("leavedaysRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string withgovtticket
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("withgovtticket", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string withgovtticketRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("withgovtticketRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscancel
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("iscancel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ismodified
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("ismodified", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isreturn
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("isreturn", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returndate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("returndate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returnletterno
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("returnletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returnletterdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("returnletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_leaveinfo_history.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
