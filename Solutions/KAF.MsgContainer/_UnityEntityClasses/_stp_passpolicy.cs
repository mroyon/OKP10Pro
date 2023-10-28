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
    
    public  class _stp_passpolicy : _Common
    {
         private static IResourceProvider resourceProvider_stp_passpolicy = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_stp_passpolicy.xml"));//DbResourceProvider(); //  
         
         
        public static string passpolicyList
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passpolicyList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passpolicyCreate
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passpolicyCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passpolicyUpdate
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passpolicyUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string passpolicyDetails
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passpolicyDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string categoryid
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("categoryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string categoryidRequired
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("categoryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passexpiredays
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passexpiredays", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passexpiredaysis
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passexpiredaysis", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passmaxlength
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passmaxlength", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passminlength
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passminlength", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passmcontainchar
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passmcontainchar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passmcontainuchar
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passmcontainuchar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passmcontainnum
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passmcontainnum", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string passmcontainspchar
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("passmcontainspchar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string oldpasscom
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("oldpasscom", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string newpasscomoldpass
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("newpasscomoldpass", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string regpasscontainchar
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("regpasscontainchar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string regpasscontainuchar
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("regpasscontainuchar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string regpasscontainnum
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("regpasscontainnum", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string regpasscontainspchar
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("regpasscontainspchar", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string organizationkey
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("organizationkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationkeyRequired
        {
            get
            {
                return resourceProvider_stp_passpolicy.GetResource("organizationkeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
