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
    
    public  class _gen_languageproficiency : _Common
    {
         private static IResourceProvider resourceProvider_gen_languageproficiency = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_languageproficiency.xml"));//DbResourceProvider(); //  
         
         
        public static string languageproficiencyList
        {
            get
            {
                return resourceProvider_gen_languageproficiency.GetResource("languageproficiencyList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageproficiencyCreate
        {
            get
            {
                return resourceProvider_gen_languageproficiency.GetResource("languageproficiencyCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageproficiencyUpdate
        {
            get
            {
                return resourceProvider_gen_languageproficiency.GetResource("languageproficiencyUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string languageproficiencyDetails
        {
            get
            {
                return resourceProvider_gen_languageproficiency.GetResource("languageproficiencyDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string proficiencyname
        {
            get
            {
                return resourceProvider_gen_languageproficiency.GetResource("proficiencyname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string proficiencynameRequired
        {
            get
            {
                return resourceProvider_gen_languageproficiency.GetResource("proficiencynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_languageproficiency.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
