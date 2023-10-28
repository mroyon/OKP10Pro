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
    
    public  class _stp_organizationentity : _Common
    {
         private static IResourceProvider resourceProvider_stp_organizationentity = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_stp_organizationentity.xml"));//DbResourceProvider(); //  
         
         
        public static string organizationentityList
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentityCreate
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentityUpdate
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationentityDetails
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationentityDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string organizationkey
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string organizationkeyRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("organizationkeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string parentkey
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("parentkey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entirytypekey
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entirytypekey", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entirytypekeyRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entirytypekeyRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylevel
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylevel", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitylevelRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylevelRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string seqfirstindex
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("seqfirstindex", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string seqfullindex
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("seqfullindex", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitycode
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitycode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entityname
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entityname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string entitynameRequired
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitynameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitynamear
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitynamear", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string description
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("description", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isactive
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("isactive", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitystatus
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitystatus", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entityseniority
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entityseniority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entityidentitycode
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entityidentitycode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string adidentitycode
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("adidentitycode", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylogo
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylogo", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylogofiledescription
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylogofiledescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylogofilepath
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylogofilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylogofilename
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylogofilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylogofiletype
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylogofiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylogoextension
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylogoextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string entitylogofileno
        {
            get
            {
                return resourceProvider_stp_organizationentity.GetResource("entitylogofileno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
