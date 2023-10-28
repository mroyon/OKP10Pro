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
    
    public  class _tran_manpowerstate : _Common
    {
         private static IResourceProvider resourceProvider_tran_manpowerstate = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_tran_manpowerstate.xml"));//DbResourceProvider(); //  
         
         
        public static string manpowerstateList
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("manpowerstateList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateCreate
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("manpowerstateCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateUpdate
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("manpowerstateUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateDetails
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("manpowerstateDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string okpid
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("okpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string manpowerstatedate
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("manpowerstatedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstatedateRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("manpowerstatedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isprepared
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("isprepared", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string prepareddate
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("prepareddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preparedby
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("preparedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isreviewed
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("isreviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewdate
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("reviewdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewedby
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("reviewedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewremarks
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("reviewremarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isapproved
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("isapproved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string approvedate
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("approvedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string approveby
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("approveby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string approveremarks
        {
            get
            {
                return resourceProvider_tran_manpowerstate.GetResource("approveremarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
