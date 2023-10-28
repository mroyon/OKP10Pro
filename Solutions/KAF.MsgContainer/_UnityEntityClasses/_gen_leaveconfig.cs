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
    
    public  class _gen_leaveconfig : _Common
    {
         private static IResourceProvider resourceProvider_gen_leaveconfig = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_leaveconfig.xml"));//DbResourceProvider(); //  
         
         
        public static string leaveconfigList
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("leaveconfigList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveconfigCreate
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("leaveconfigCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveconfigUpdate
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("leaveconfigUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leaveconfigDetails
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("leaveconfigDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string leavetypeid
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("leavetypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeidRequired
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("leavetypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string startdate
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("startdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string startdateRequired
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("startdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string enddate
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("enddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string noofdays
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("noofdays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string noofdaysRequired
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("noofdaysRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_leaveconfig.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
