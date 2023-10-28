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
    
    public  class _hr_promotioninfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_promotioninfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_promotioninfo.xml"));//DbResourceProvider(); //  
         
         
        public static string promotioninfoList
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotioninfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotioninfoCreate
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotioninfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotioninfoUpdate
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotioninfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotioninfoDetails
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotioninfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiondate
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotiondateRequired
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiontypeid
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiontypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string promotiontypeidRequired
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiontypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string torankid
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("torankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string torankidRequired
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("torankidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotionno
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotionno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiondesignation
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondesignation", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiondelayreason
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondelayreason", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiondelaydocno
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondelaydocno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiondelaydocdate
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondelaydocdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiondelaystartdate
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondelaystartdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string promotiondelayperiod
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("promotiondelayperiod", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderno
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderdate
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderfiledescription
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderfiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderfilepath
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderfilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderfilename
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderfilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderfiletype
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderfiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderextension
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string orderfileno
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("orderfileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_promotioninfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
