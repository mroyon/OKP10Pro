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
    
    public  class _gen_divisiondistrict : _Common
    {
         private static IResourceProvider resourceProvider_gen_divisiondistrict = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_divisiondistrict.xml"));//DbResourceProvider(); //  
         
         
        public static string divisiondistrictList
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("divisiondistrictList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string divisiondistrictCreate
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("divisiondistrictCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string divisiondistrictUpdate
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("divisiondistrictUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string divisiondistrictDetails
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("divisiondistrictDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string parentid
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("parentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string districtname
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("districtname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string districtnameRequired
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("districtnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isdivision
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("isdivision", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_divisiondistrict.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
