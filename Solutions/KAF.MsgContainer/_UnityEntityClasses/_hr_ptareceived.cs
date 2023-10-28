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
    
    public  class _hr_ptareceived : _Common
    {
         private static IResourceProvider resourceProvider_hr_ptareceived = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_ptareceived.xml"));//DbResourceProvider(); //  
         
         
        public static string ptareceivedList
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptareceivedList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptareceivedCreate
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptareceivedCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptareceivedUpdate
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptareceivedUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptareceivedDetails
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptareceivedDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string ptademandid
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptademandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptademandidRequired
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptademandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptidate
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptidate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptidateRequired
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptidateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptiletterdate
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptiletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptiletterdateRequired
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptiletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ptiletterno
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptiletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ptiletternoRequired
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("ptiletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterstatus
        {
            get
            {
                return resourceProvider_hr_ptareceived.GetResource("letterstatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
