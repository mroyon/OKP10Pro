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
    
    public  class _gen_bankbranch : _Common
    {
         private static IResourceProvider resourceProvider_gen_bankbranch = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_bankbranch.xml"));//DbResourceProvider(); //  
         
         
        public static string bankbranchList
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("bankbranchList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankbranchCreate
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("bankbranchCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankbranchUpdate
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("bankbranchUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankbranchDetails
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("bankbranchDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string bankid
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("bankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string bankidRequired
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("bankidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string branchname
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("branchname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string branchnameRequired
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("branchnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_bankbranch.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
