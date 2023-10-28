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
    
    public  class _owin_userroledetlentityprofilemap : _Common
    {
         private static IResourceProvider resourceProvider_owin_userroledetlentityprofilemap = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_userroledetlentityprofilemap.xml"));//DbResourceProvider(); //  
         
         
        public static string userroledetlentityprofilemapList
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetlentityprofilemapList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlentityprofilemapCreate
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetlentityprofilemapCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlentityprofilemapUpdate
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetlentityprofilemapUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlentityprofilemapDetails
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetlentityprofilemapDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userroledetentitymaplid
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetentitymaplid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetentitymaplidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetentitymaplidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userroledetlid
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroledetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userroleid
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroleidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userroleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string roleid
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("roleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string roleidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("roleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string profiletype
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("profiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_owin_userroledetlentityprofilemap.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
