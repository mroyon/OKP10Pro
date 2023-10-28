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
    
    public  class _owin_tsv : _Common
    {
         private static IResourceProvider resourceProvider_owin_tsv = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_owin_tsv.xml"));//DbResourceProvider(); //  
         
         
        public static string tsvList
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tsvCreate
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tsvUpdate
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tsvDetails
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string userid
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("userid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useridRequired
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("useridRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tsvtokenrequestdate
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvtokenrequestdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tsvtokenrequestdateRequired
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvtokenrequestdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tsvtoken
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvtoken", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tsvtokenRequired
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("tsvtokenRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isvalid
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("isvalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string isvalidRequired
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("isvalidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string varificationtried
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("varificationtried", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string varificationtriedRequired
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("varificationtriedRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string validdate
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("validdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string usersessionid
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("usersessionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string usersessionidRequired
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("usersessionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string _requestaft
        {
            get
            {
                return resourceProvider_owin_tsv.GetResource("_requestaft", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
