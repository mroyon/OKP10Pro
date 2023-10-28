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
    
    public  class _hr_personalinfo : _Common
    {
         private static IResourceProvider resourceProvider_hr_personalinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_personalinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string personalinfoList
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("personalinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personalinfoCreate
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("personalinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personalinfoUpdate
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("personalinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string personalinfoDetails
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("personalinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string religionid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("religionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string religionidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("religionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bloodgroupid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bloodgroupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bloodgroupidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string maritalstatusid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("maritalstatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string maritalstatusidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("maritalstatusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string genderid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("genderid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("genderidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationalityid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("nationalityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string nationalityidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("nationalityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string buildingid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("buildingid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwgovid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwgovid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwareaid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwareaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwblockno
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwblockno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwstreet
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwhouseno
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwhouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwflatno
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwmobile
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwmobile", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwviber
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwviber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string kwviberRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("kwviberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string personalemail
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("personalemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string officialemail
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("officialemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurdivid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurdivid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdcurdividRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurdividRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurcityid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurcityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdcurcityidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurcityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurthanaid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurthanaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdcurthanaidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurthanaidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurpostoffice
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurpostoffice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurroad
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurroad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurhouse
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurhouse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurflatno
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdcurflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdmob1
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdmob1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdmob2
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdmob2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdhomephone
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdhomephone", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperdivid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperdivid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdperdividRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperdividRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdpercityid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdpercityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdpercityidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdpercityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperthanaid
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperthanaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdperthanaidRequired
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperthanaidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperpostoffice
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperpostoffice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperroad
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperroad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperhouse
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperhouse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperflatno
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("bdperflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_personalinfo.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
