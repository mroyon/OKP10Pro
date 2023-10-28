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
    
    public  class _reg_basicinfo : _Common
    {
         private static IResourceProvider resourceProvider_reg_basicinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_reg_basicinfo.xml"));//DbResourceProvider(); //  
         
         
        public static string basicinfoList
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoCreate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoUpdate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string basicinfoDetails
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("basicinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string civilid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("civilid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string civilidRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("civilidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passportno
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("passportno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string fullname
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("fullname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string fullnameRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("fullnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name1Required
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name2
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string name2Required
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name2Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name3
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name3", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name4
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name4", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string name5
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("name5", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string dob
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("dob", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string joindate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("joindate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string joindateRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("joindateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mob1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("mob1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string mob1Required
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("mob1Required", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string mob2
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("mob2", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string email
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("email", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string studentid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("studentid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string studentcode
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("studentcode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filetype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("extension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string batchid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("batchid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string batchidRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("batchidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string platoonid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("platoonid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string platoonidRequired
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("platoonidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string armsid
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("armsid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isgraduated
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("isgraduated", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string graduationdate
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("graduationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filedescription
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filedescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filepath1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filepath1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filename1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filename1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string filetype1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("filetype1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extension1
        {
            get
            {
                return resourceProvider_reg_basicinfo.GetResource("extension1", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
