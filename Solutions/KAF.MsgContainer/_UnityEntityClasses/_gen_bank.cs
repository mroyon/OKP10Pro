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
    
    public  class _gen_bank : _Common
    {
         private static IResourceProvider resourceProvider_gen_bank = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_bank.xml"));//DbResourceProvider(); //  
         
         
        public static string bankList
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("bankList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankCreate
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("bankCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankUpdate
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("bankUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankDetails
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("bankDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string bankname
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("bankname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string banknameRequired
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("banknameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_bank.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
