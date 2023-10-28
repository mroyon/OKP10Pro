﻿using  KAF.MsgContainer.Abstract;
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
    
    public  class _hr_extensioninfo_history : _Common
    {
         private static IResourceProvider resourceProvider_hr_extensioninfo_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_hr_extensioninfo_history.xml"));//DbResourceProvider(); //  
         
         
        public static string extensioninfoList
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("extensioninfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string extensioninfoCreate
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("extensioninfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string extensioninfoUpdate
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("extensioninfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string extensioninfoDetails
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("extensioninfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string hrextensionid
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("hrextensionid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrextensionidRequired
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("hrextensionidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string repatriationdate
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("repatriationdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string repatriationdateRequired
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("repatriationdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string extensiontill
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("extensiontill", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string extensiontillRequired
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("extensiontillRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterdate
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letterdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letterdateRequired
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letterdateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letterno
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letterno", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string letternoRequired
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letternoRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letternofilepath
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letternofilepath", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letternofilename
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letternofilename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letternofiletype
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letternofiletype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string letternofileextension
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("letternofileextension", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_hr_extensioninfo_history.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
