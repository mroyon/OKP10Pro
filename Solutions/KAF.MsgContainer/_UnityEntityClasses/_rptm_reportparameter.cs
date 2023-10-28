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
    
    public  class _rptm_reportparameter : _Common
    {
         private static IResourceProvider resourceProvider_rptm_reportparameter = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_rptm_reportparameter.xml"));//DbResourceProvider(); //  
         
         
        public static string reportparameterList
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparameterList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportparameterCreate
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparameterCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportparameterUpdate
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparameterUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportparameterDetails
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparameterDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         
     
         public static string reportid
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportidRequired
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportparamname
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparamname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportparamnameRequired
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparamnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportparamdatatype
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparamdatatype", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportparamdescription
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparamdescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
         public static string reportparamoptionalid
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparamoptionalid", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportparamoptionalidRequired
        {
            get
            {
                return resourceProvider_rptm_reportparameter.GetResource("reportparamoptionalidRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        
      
    }
}
