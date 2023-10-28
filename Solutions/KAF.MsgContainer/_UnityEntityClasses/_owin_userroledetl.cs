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
    
    public  class _owin_userroledetl : _Common
    {
         private static IResourceProvider resourceProvider_owin_userroledetl = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_userroledetl.xml"));//DbResourceProvider(); //  
         
         
        public static string userroledetlList
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("userroledetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlCreate
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("userroledetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlUpdate
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("userroledetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroledetlDetails
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("userroledetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userroleid
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("userroleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string userroleidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("userroleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string userid
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string roleid
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("roleid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string roleidRequired
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("roleidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fromdate
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("fromdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fromdateRequired
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("fromdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string todate
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("todate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscurrent
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("iscurrent", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string iscentraladmin
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("iscentraladmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string allchild
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("allchild", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isunitadmin
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("isunitadmin", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_owin_userroledetl.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
