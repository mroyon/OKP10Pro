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
    
    public  class _tran_manpowerstatedetl_history : _Common
    {
         private static IResourceProvider resourceProvider_tran_manpowerstatedetl_history = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_tran_manpowerstatedetl_history.xml"));//DbResourceProvider(); //  
         
         
        public static string manpowerstatedetlList
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatedetlList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstatedetlCreate
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatedetlCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstatedetlUpdate
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatedetlUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstatedetlDetails
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatedetlDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string manpowerstatedetlid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatedetlid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstatedetlidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatedetlidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string manpowerstateid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstateid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstateidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstateidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrbasicid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("hrbasicid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrbasicidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("hrbasicidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string hrsvcid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("hrsvcid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string hrsvcidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("hrsvcidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string rankid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("rankid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("rankidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string groupid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("groupid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string groupidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("groupidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string subunitid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("subunitid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string subunitidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("subunitidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string campid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("campid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string campidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("campidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string manpowerstatusid
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatusid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string manpowerstatusidRequired
        {
            get
            {
                return resourceProvider_tran_manpowerstatedetl_history.GetResource("manpowerstatusidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
