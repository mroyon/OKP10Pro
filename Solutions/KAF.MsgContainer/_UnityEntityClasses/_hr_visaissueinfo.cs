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
    
    public  class _hr_visaissueinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_visaissueinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_visaissueinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string visaissueinfoList
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueinfoCreate
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueinfoUpdate
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueinfoDetails
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string visademandid
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visademandid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visademandidRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visademandidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visaissuedate
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissuedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissuedateRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissuedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visaissueletterdate
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueletterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueletterdateRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueletterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string visaissueletterno
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueletterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string visaissueletternoRequired
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("visaissueletternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_visaissueinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
