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
    
    public  class _hr_addresschange : _Common
    {
         private static IResourceProvider resourceProvider_hr_addresschange = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_addresschange.xml"));//DbResourceProvider(); //  
         
         
        public static string addresschangeList
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("addresschangeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string addresschangeCreate
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("addresschangeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string addresschangeUpdate
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("addresschangeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string addresschangeDetails
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("addresschangeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string buildingid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("buildingid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwgovid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwgovid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwareaid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwareaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwblockno
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwblockno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwstreet
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwhouseno
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwhouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwflatno
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwmobile
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwmobile", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwviber
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwviber", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string kwviberRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("kwviberRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string personalemail
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("personalemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string officialemail
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("officialemail", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurdivid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurdivid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdcurdividRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurdividRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurcityid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurcityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdcurcityidRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurcityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurthanaid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurthanaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdcurthanaidRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurthanaidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurpostoffice
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurpostoffice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurroad
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurroad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurhouse
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurhouse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdcurflatno
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdcurflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdmob1
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdmob1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdmob2
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdmob2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdhomephone
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdhomephone", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperdivid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperdivid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdperdividRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperdividRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdpercityid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdpercityid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdpercityidRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdpercityidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperthanaid
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperthanaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bdperthanaidRequired
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperthanaidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperpostoffice
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperpostoffice", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperroad
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperroad", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperhouse
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperhouse", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdperflatno
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("bdperflatno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_addresschange.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
