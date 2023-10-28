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
    
    public  class _hr_emergencycontact : _Common
    {
         private static IResourceProvider resourceProvider_hr_emergencycontact = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_emergencycontact.xml"));//DbResourceProvider(); //  
         
         
        public static string emergencycontactList
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("emergencycontactList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactCreate
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("emergencycontactCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactUpdate
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("emergencycontactUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string emergencycontactDetails
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("emergencycontactDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string relationshipid
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("relationshipid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string relationshipidRequired
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("relationshipidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name1
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("name1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name1Required
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("name1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name2
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("name2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name2Required
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("name2Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name3
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("name3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name4
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("name4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name5
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("name5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curbdaddressflatno
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curbdaddressflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curbdaddresshouseno
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curbdaddresshouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curbdaddressstreet
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curbdaddressstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curbdadrresspo
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curbdadrresspo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curbdadrressps
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curbdadrressps", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curbdaddressdist
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curbdaddressdist", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curbdaddressdivision
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curbdaddressdivision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilebd
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("mobilebd", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mobilebdRequired
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("mobilebdRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string telephonebd
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("telephonebd", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perbdaddressflatno
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("perbdaddressflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perbdaddresshouseno
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("perbdaddresshouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perbdaddressstreet
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("perbdaddressstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perbdadrresspo
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("perbdadrresspo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perbdadrressps
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("perbdadrressps", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perbdaddressdivision
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("perbdaddressdivision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string perbdaddressdist
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("perbdaddressdist", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwaddressflatno
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwaddressflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwaddresshouseno
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwaddresshouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwaddressstreet
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwaddressstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwadrressblock
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwadrressblock", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwadrressavenue
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwadrressavenue", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwgovnerid
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwgovnerid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwareaid
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwareaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string curkwpacino
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("curkwpacino", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mobilekw
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("mobilekw", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string telephonekw
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("telephonekw", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_emergencycontact.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
