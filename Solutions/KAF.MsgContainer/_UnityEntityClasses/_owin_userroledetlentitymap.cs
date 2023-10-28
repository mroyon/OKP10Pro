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
    
    public  class _owin_userroledetlentitymap : _Common
    {
         private static IResourceProvider resourceProvider_owin_userroledetlentitymap = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_userroledetlentitymap.xml"));//DbResourceProvider(); //  
         
         
        public static string userroledetlentitymapList
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroledetlentitymapList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlentitymapCreate
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroledetlentitymapCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlentitymapUpdate
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroledetlentitymapUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlentitymapDetails
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroledetlentitymapDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userroledetlid
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroledetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroledetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userroleid
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroleidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userroleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string roleid
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("roleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string roleidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("roleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitykey
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("entitykey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string allchild
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("allchild", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isunitadmin
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("isunitadmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string allunit
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("allunit", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string allprofile
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("allprofile", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_owin_userroledetlentitymap.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
