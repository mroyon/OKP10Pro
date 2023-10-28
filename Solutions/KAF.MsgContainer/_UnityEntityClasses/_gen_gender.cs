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
    
    public  class _gen_gender : _Common
    {
         private static IResourceProvider resourceProvider_gen_gender = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_gender.xml"));//DbResourceProvider(); //  
         
         
        public static string genderList
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderCreate
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderUpdate
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderDetails
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string gender
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("gender", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string genderRequired
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("genderRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_gender.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
