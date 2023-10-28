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
    
    public  class _gen_trade : _Common
    {
         private static IResourceProvider resourceProvider_gen_trade = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_trade.xml"));//DbResourceProvider(); //  
         
         
        public static string tradeList
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("tradeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tradeCreate
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("tradeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tradeUpdate
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("tradeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tradeDetails
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("tradeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string forceid
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("forceid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string countryid
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("countryid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string tradename
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("tradename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string tradenameRequired
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("tradenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_trade.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
