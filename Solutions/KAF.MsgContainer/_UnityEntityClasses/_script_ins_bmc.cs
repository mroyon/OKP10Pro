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
    
    public  class _script_ins_bmc : _Common
    {
         private static IResourceProvider resourceProvider_script_ins_bmc = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_script_ins_bmc.xml"));//DbResourceProvider(); //  
         
         
        public static string insList
        {
            get
            {
                return resourceProvider_script_ins_bmc.GetResource("insList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string insCreate
        {
            get
            {
                return resourceProvider_script_ins_bmc.GetResource("insCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string insUpdate
        {
            get
            {
                return resourceProvider_script_ins_bmc.GetResource("insUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string insDetails
        {
            get
            {
                return resourceProvider_script_ins_bmc.GetResource("insDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string script
        {
            get
            {
                return resourceProvider_script_ins_bmc.GetResource("script", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
