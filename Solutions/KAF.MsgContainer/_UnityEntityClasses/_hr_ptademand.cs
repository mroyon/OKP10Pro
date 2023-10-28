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
    
    public  class _hr_ptademand : _Common
    {
         private static IResourceProvider resourceProvider_hr_ptademand = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_ptademand.xml"));//DbResourceProvider(); //  
         
         
        public static string ptademandList
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptademandList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademandCreate
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptademandCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademandUpdate
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptademandUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademandDetails
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptademandDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string visasentid
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("visasentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visasentidRequired
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("visasentidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptidate
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptidate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptidateRequired
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptidateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptiletterdate
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptiletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptiletterdateRequired
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptiletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptiletterno
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptiletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptiletternoRequired
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("ptiletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterstatus
        {
            get
            {
                return resourceProvider_hr_ptademand.GetResource("letterstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
