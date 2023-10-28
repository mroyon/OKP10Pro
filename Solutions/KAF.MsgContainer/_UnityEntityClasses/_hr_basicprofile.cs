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
    
    public  class _hr_basicprofile : _Common
    {
         private static IResourceProvider resourceProvider_hr_basicprofile = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_basicprofile.xml"));//DbResourceProvider(); //  
         
         
        public static string basicprofileList
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("basicprofileList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicprofileCreate
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("basicprofileCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicprofileUpdate
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("basicprofileUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicprofileDetails
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("basicprofileDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string civilid
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string civilidexpiredate
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("civilidexpiredate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportno
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("passportno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string nationalid
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("nationalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bdsmartcardid
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("bdsmartcardid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name1
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name1Required
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name2
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name2Required
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name2Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name3
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameRequired
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("fullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name1ar
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name1ar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name2ar
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name2ar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name3ar
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("name3ar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullnamear
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("fullnamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string dateofbirth
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("dateofbirth", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string joindatebd
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("joindatebd", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string profilephoto
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("profilephoto", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string profilephotofilepath
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("profilephotofilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string profilephotofilename
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("profilephotofilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string profilephotofiletype
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("profilephotofiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string profilephotofileextension
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("profilephotofileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string forreview
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("forreview", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string status
        {
            get
            {
                return resourceProvider_hr_basicprofile.GetResource("status", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
