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
    
    public  class _gen_airlines : _Common
    {
         private static IResourceProvider resourceProvider_gen_airlines = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_airlines.xml"));//DbResourceProvider(); //  
         
         
        public static string airlinesList
        {
            get
            {
                return resourceProvider_gen_airlines.GetResource("airlinesList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string airlinesCreate
        {
            get
            {
                return resourceProvider_gen_airlines.GetResource("airlinesCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string airlinesUpdate
        {
            get
            {
                return resourceProvider_gen_airlines.GetResource("airlinesUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string airlinesDetails
        {
            get
            {
                return resourceProvider_gen_airlines.GetResource("airlinesDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string airlinesname
        {
            get
            {
                return resourceProvider_gen_airlines.GetResource("airlinesname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string airlinesnameRequired
        {
            get
            {
                return resourceProvider_gen_airlines.GetResource("airlinesnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_airlines.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
