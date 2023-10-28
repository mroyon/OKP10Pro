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
    
    public  class _gen_filetype : _Common
    {
         private static IResourceProvider resourceProvider_gen_filetype = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_gen_filetype.xml"));//DbResourceProvider(); //  
         
         
        public static string filetypeList
        {
            get
            {
                return resourceProvider_gen_filetype.GetResource("filetypeList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetypeCreate
        {
            get
            {
                return resourceProvider_gen_filetype.GetResource("filetypeCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetypeUpdate
        {
            get
            {
                return resourceProvider_gen_filetype.GetResource("filetypeUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetypeDetails
        {
            get
            {
                return resourceProvider_gen_filetype.GetResource("filetypeDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string filetypename
        {
            get
            {
                return resourceProvider_gen_filetype.GetResource("filetypename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string filetypenameRequired
        {
            get
            {
                return resourceProvider_gen_filetype.GetResource("filetypenameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string remarks
        {
            get
            {
                return resourceProvider_gen_filetype.GetResource("remarks", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
