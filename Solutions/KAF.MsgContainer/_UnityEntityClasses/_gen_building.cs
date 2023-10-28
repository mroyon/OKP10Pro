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
    
    public  class _gen_building : _Common
    {
         private static IResourceProvider resourceProvider_gen_building = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_building.xml"));//DbResourceProvider(); //  
         
         
        public static string buildingList
        {
            get
            {
                return resourceProvider_gen_building.GetResource("buildingList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string buildingCreate
        {
            get
            {
                return resourceProvider_gen_building.GetResource("buildingCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string buildingUpdate
        {
            get
            {
                return resourceProvider_gen_building.GetResource("buildingUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string buildingDetails
        {
            get
            {
                return resourceProvider_gen_building.GetResource("buildingDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string buildingname
        {
            get
            {
                return resourceProvider_gen_building.GetResource("buildingname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string buildingnameRequired
        {
            get
            {
                return resourceProvider_gen_building.GetResource("buildingnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwgovid
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwgovid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string kwgovidRequired
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwgovidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwareaid
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwareaid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string kwareaidRequired
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwareaidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwblockno
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwblockno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string kwblocknoRequired
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwblocknoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwstreet
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwstreet", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string kwstreetRequired
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwstreetRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string kwhouseno
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwhouseno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string kwhousenoRequired
        {
            get
            {
                return resourceProvider_gen_building.GetResource("kwhousenoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_gen_building.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_building.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
