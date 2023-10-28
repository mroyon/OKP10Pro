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
    
    public  class _useraccountsprof : _Common
    {
         private static IResourceProvider resourceProvider_useraccountsprof = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_useraccountsprof.xml"));//DbResourceProvider(); //  
         
         
        public static string useraccountsprofList
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("useraccountsprofList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useraccountsprofCreate
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("useraccountsprofCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useraccountsprofUpdate
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("useraccountsprofUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string useraccountsprofDetails
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("useraccountsprofDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string firstname
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("firstname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string firstnameRequired
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("firstnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string middlename
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("middlename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string lastname
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("lastname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string lastnameRequired
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("lastnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string photo
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("photo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string organizationkey
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("organizationkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationkeyRequired
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("organizationkeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitykey
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("entitykey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitykeyRequired
        {
            get
            {
                return resourceProvider_useraccountsprof.GetResource("entitykeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
