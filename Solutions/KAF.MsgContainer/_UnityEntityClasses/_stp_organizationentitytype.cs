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
    
    public  class _stp_organizationentitytype : _Common
    {
         private static IResourceProvider resourceProvider_stp_organizationentitytype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_stp_organizationentitytype.xml"));//DbResourceProvider(); //  
         
         
        public static string organizationentitytypeList
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("organizationentitytypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentitytypeCreate
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("organizationentitytypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentitytypeUpdate
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("organizationentitytypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentitytypeDetails
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("organizationentitytypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string organizationkey
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("organizationkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationkeyRequired
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("organizationkeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entirytypecode
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("entirytypecode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entirytypecodeRequired
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("entirytypecodeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entirytype
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("entirytype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entirytypeRequired
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("entirytypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entirytypeeng
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("entirytypeeng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylevel
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("entitylevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitylevelRequired
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("entitylevelRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_stp_organizationentitytype.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
