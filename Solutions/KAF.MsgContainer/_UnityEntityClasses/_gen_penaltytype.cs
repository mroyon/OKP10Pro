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
    
    public  class _gen_penaltytype : _Common
    {
         private static IResourceProvider resourceProvider_gen_penaltytype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_penaltytype.xml"));//DbResourceProvider(); //  
         
         
        public static string penaltytypeList
        {
            get
            {
                return resourceProvider_gen_penaltytype.GetResource("penaltytypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string penaltytypeCreate
        {
            get
            {
                return resourceProvider_gen_penaltytype.GetResource("penaltytypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string penaltytypeUpdate
        {
            get
            {
                return resourceProvider_gen_penaltytype.GetResource("penaltytypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string penaltytypeDetails
        {
            get
            {
                return resourceProvider_gen_penaltytype.GetResource("penaltytypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string penaltytype
        {
            get
            {
                return resourceProvider_gen_penaltytype.GetResource("penaltytype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string penaltytypeRequired
        {
            get
            {
                return resourceProvider_gen_penaltytype.GetResource("penaltytypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_penaltytype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
