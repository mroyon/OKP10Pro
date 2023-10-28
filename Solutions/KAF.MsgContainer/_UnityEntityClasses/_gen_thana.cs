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
    
    public  class _gen_thana : _Common
    {
         private static IResourceProvider resourceProvider_gen_thana = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_thana.xml"));//DbResourceProvider(); //  
         
         
        public static string thanaList
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("thanaList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string thanaCreate
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("thanaCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string thanaUpdate
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("thanaUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string thanaDetails
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("thanaDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string thananame
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("thananame", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string thananameRequired
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("thananameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string districtid
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("districtid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string districtidRequired
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("districtidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_thana.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
