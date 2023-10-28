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
    
    public  class _hr_demanddetlpassport : _Common
    {
         private static IResourceProvider resourceProvider_hr_demanddetlpassport = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_demanddetlpassport.xml"));//DbResourceProvider(); //  
         
         
        public static string demanddetlpassportList
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("demanddetlpassportList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string demanddetlpassportCreate
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("demanddetlpassportCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string demanddetlpassportUpdate
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("demanddetlpassportUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string demanddetlpassportDetails
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("demanddetlpassportDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string newdemanddetlid
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("newdemanddetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string newdemanddetlidRequired
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("newdemanddetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string serialno
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("serialno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string serialnoRequired
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("serialnoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportrecvdate
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("passportrecvdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string passportrecvdateRequired
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("passportrecvdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letternoRequired
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("letternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letterdateRequired
        {
            get
            {
                return resourceProvider_hr_demanddetlpassport.GetResource("letterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

    }
}
