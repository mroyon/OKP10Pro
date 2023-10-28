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
    
    public  class _owin_reportrole : _Common
    {
         private static IResourceProvider resourceProvider_owin_reportrole = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_reportrole.xml"));//DbResourceProvider(); //  
         
         
        public static string reportroleList
        {
            get
            {
                return resourceProvider_owin_reportrole.GetResource("reportroleList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroleCreate
        {
            get
            {
                return resourceProvider_owin_reportrole.GetResource("reportroleCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroleUpdate
        {
            get
            {
                return resourceProvider_owin_reportrole.GetResource("reportroleUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportroleDetails
        {
            get
            {
                return resourceProvider_owin_reportrole.GetResource("reportroleDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string reportrolename
        {
            get
            {
                return resourceProvider_owin_reportrole.GetResource("reportrolename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportrolenameRequired
        {
            get
            {
                return resourceProvider_owin_reportrole.GetResource("reportrolenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_owin_reportrole.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
