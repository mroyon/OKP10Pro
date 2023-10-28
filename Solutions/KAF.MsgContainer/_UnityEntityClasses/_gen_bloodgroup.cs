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
    
    public  class _gen_bloodgroup : _Common
    {
         private static IResourceProvider resourceProvider_gen_bloodgroup = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_bloodgroup.xml"));//DbResourceProvider(); //  
         
         
        public static string bloodgroupList
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupCreate
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupUpdate
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupDetails
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string bloodgroup
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroup", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bloodgroupRequired
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("bloodgroupRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_bloodgroup.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
