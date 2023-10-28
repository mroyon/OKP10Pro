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
    
    public  class _hr_bankloaninfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_bankloaninfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_bankloaninfo.xml"));//DbResourceProvider(); //  
         
         
        public static string bankloaninfoList
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("bankloaninfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankloaninfoCreate
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("bankloaninfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankloaninfoUpdate
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("bankloaninfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankloaninfoDetails
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("bankloaninfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bankid
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("bankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankidRequired
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("bankidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string branchid
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("branchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string branchidRequired
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("branchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string loanamount
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("loanamount", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string loanamountRequired
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("loanamountRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string lastpaiddate
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("lastpaiddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastpaiddateRequired
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("lastpaiddateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string islastinstallmentpaid
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("islastinstallmentpaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_bankloaninfo.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
