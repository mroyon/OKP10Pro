using DataTables.Mvc;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.CustomHelper.HelperClasses;
using KAF.MVC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KAFWebAdmin.Controllers
{
    public class CacheTestController : Controller
    {
        // GET: CacheTest
        public ActionResult Index()
        {
            return View("LoadCache");
        }

       

    }
}