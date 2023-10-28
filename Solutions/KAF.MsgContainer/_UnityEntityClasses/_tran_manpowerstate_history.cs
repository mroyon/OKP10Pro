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
    
    public  class _tran_manpowerstate_history : _Common
    {
         private static IResourceProvider resourceProvider_tran_manpowerstate_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_tran_manpowerstate_history.xml"));//DbResourceProvider(); //  
         
         
        public static string manpowerstateList
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstateList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateCreate
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstateCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateUpdate
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstateUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateDetails
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstateDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string manpowerstateid
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string okpid
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("okpid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string okpidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("okpidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string manpowerstatedate
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstatedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstatedateRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("manpowerstatedateRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isprepared
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("isprepared", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string prepareddate
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("prepareddate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string preparedby
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("preparedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isreviewed
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("isreviewed", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewdate
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("reviewdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewedby
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("reviewedby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reviewremarks
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("reviewremarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string isapproved
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("isapproved", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string approvedate
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("approvedate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string approveby
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("approveby", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string approveremarks
        {
            get
            {
                return resourceProvider_tran_manpowerstate_history.GetResource("approveremarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
