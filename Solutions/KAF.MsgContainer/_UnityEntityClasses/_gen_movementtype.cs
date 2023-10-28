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
    
    public  class _gen_movementtype : _Common
    {
         private static IResourceProvider resourceProvider_gen_movementtype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_movementtype.xml"));//DbResourceProvider(); //  
         
         
        public static string movementtypeList
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("movementtypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string movementtypeCreate
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("movementtypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string movementtypeUpdate
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("movementtypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string movementtypeDetails
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("movementtypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string movementtype
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("movementtype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string movementtypeRequired
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("movementtypeRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string movementfor
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("movementfor", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_movementtype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
