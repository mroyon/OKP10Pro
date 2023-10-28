using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace KAF.WebFramework
{
  public static  class DomainUrl
    {
        public static string GetDomainUrl()
        {
            return HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + HttpContext.Current.Request.ApplicationPath.TrimEnd('/') + "/";
        }

        public static string GetCookeDomain()
        {
            return HttpContext.Current.Request.Url.Authority;
        }
    }
}
