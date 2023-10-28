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
    
    public  class _gen_leavetype : _Common
    {
         private static IResourceProvider resourceProvider_gen_leavetype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_leavetype.xml"));//DbResourceProvider(); //  
         
         
        public static string leavetypeList
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("leavetypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeCreate
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("leavetypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeUpdate
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("leavetypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeDetails
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("leavetypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string leavetype
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("leavetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string leavetypeRequired
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("leavetypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string isactive
        {
            get
            {
                return resourceProvider_gen_leavetype.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
    }
}
