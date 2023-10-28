using KAF.CustomFilters.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using KAF.MVC.Common;


namespace KAFWebAdmin.Controllers
{
    //[NoCacheAttribute]
    public class UnAuthorizeAccessController : BaseController
    {
        public async Task<ActionResult> UnAuthView()
        {
            return View();
        } 
    }
}