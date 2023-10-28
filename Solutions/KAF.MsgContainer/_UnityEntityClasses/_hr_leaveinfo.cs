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
    
    public  class _hr_leaveinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_leaveinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_leaveinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string leaveinfoList
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leaveinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoCreate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leaveinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoUpdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leaveinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveinfoDetails
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leaveinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavetypeid
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leavetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeidRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leavetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string startdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string enddate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string enddateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("enddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string noofdays
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("noofdays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string noofdaysRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("noofdaysRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavestartdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leavestartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavestartdateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leavestartdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leaveenddate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leaveenddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveenddateRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leaveenddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string leavedays
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leavedays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavedaysRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("leavedaysRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string withgovtticket
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("withgovtticket", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string withgovtticketRequired
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("withgovtticketRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscancel
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("iscancel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ismodified
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("ismodified", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isreturn
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("isreturn", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returndate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("returndate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returnletterno
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("returnletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string returnletterdate
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("returnletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_leaveinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
