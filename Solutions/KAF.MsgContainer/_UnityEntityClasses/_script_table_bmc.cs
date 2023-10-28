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
    
    public  class _script_table_bmc : _Common
    {
         private static IResourceProvider resourceProvider_script_table_bmc = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_script_table_bmc.xml"));//DbResourceProvider(); //  
         
         
        public static string tableList
        {
            get
            {
                return resourceProvider_script_table_bmc.GetResource("tableList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tableCreate
        {
            get
            {
                return resourceProvider_script_table_bmc.GetResource("tableCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tableUpdate
        {
            get
            {
                return resourceProvider_script_table_bmc.GetResource("tableUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tableDetails
        {
            get
            {
                return resourceProvider_script_table_bmc.GetResource("tableDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string tablename
        {
            get
            {
                return resourceProvider_script_table_bmc.GetResource("tablename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
