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
    
    public  class _gen_rank : _Common
    {
         private static IResourceProvider resourceProvider_gen_rank = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_rank.xml"));//DbResourceProvider(); //  
         
         
        public static string rankList
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankCreate
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankUpdate
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string rankDetails
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string rankname
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("rankname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ranknameRequired
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("ranknameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string ranktypeid
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("ranktypeid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string ranktypeidRequired
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("ranktypeidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string countryidRequired
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("countryidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string typepriority
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("typepriority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string priority
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("priority", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string comments
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("comments", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_rank.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
