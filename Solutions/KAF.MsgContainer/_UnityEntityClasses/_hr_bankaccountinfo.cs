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
    
    public  class _hr_bankaccountinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_bankaccountinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_bankaccountinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string bankaccountinfoList
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("bankaccountinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankaccountinfoCreate
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("bankaccountinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankaccountinfoUpdate
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("bankaccountinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankaccountinfoDetails
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("bankaccountinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bankid
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("bankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankidRequired
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("bankidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string branchid
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("branchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string branchidRequired
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("branchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string accountno
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("accountno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string accountnoRequired
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("accountnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string accountname
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("accountname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string accountnameRequired
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("accountnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string accountdescription
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("accountdescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_bankaccountinfo.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
