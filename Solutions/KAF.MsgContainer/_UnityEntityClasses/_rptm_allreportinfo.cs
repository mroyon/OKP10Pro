using KAF.MsgContainer.Abstract;
using KAF.MsgContainer.Concrete;
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

    public class _rptm_allreportinfo : _Common
    {
        private static IResourceProvider resourceProvider_rptm_allreportinfo = new XmlResourceProvider(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"bin\LanguagesFiles\_rptm_allreportinfo.xml"));//DbResourceProvider(); //  


        public static string allreportinfoList
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("allreportinfoList", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string allreportinfoCreate
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("allreportinfoCreate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string allreportinfoUpdate
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("allreportinfoUpdate", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string allreportinfoDetails
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("allreportinfoDetails", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string modulename
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("modulename", CultureInfo.CurrentUICulture.Name) as String;
            }
        }

        public static string reportname
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reportname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportnameRequired
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reportnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportnameeng
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reportnameeng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reporturl
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reporturl", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportspname
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reportspname", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportspnameRequired
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reportspnameRequired", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportspnameeng
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reportspnameeng", CultureInfo.CurrentUICulture.Name) as String;
            }
        }
        public static string reportdescription
        {
            get
            {
                return resourceProvider_rptm_allreportinfo.GetResource("reportdescription", CultureInfo.CurrentUICulture.Name) as String;
            }
        }


    }
}
