using KAF.CustomHelper.HelperClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace KAF.MVC.Common
{
    public class BaseController : Controller
    {
        public ActionResult ViewWithArea(string AreaName, string viewName,  string extension = "cshtml")
        {
            return View($"~/Areas/{AreaName}/Views/{viewName + "." + extension}" );
        }

        public ActionResult ViewWithArea(string AreaName, string viewName,  object Model, string extension = "cshtml")
        {
            return View($"~/Areas/{AreaName}/Views/{viewName + "." + extension}", Model);
        }

        public ActionResult PartialViewWithArea(string AreaName, string viewName, string extension = "cshtml")
        {
            return PartialView($"~/Areas/{AreaName}/Views/{viewName + "." + extension}");
        }
        public ActionResult PartialViewWithArea(string AreaName, string viewName, object Model, string extension = "cshtml")
        {
            return PartialView($"~/Areas/{AreaName}/Views/{viewName + "." + extension}", Model);
        }
        public static string RenderRazorViewToString(ControllerContext controllerContext, string viewName, object model)
        {
            controllerContext.Controller.ViewData.Model = model;
            using (var stringWriter = new StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);
                var viewContext = new ViewContext(controllerContext, viewResult.View, controllerContext.Controller.ViewData, controllerContext.Controller.TempData, stringWriter);
                viewResult.View.Render(viewContext, stringWriter);
                viewResult.ViewEngine.ReleaseView(controllerContext, viewResult.View);
                return stringWriter.GetStringBuilder().ToString();

            }
        }
        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            string cultureName = null;

            // Attempt to read the culture cookie from Request
            HttpCookie cultureCookie = Request.Cookies["_culture"];
            if (cultureCookie != null)
                cultureName = cultureCookie.Value;
            else
                cultureName = Request.UserLanguages != null && Request.UserLanguages.Length > 0 ?
                        Request.UserLanguages[0] :  // obtain it from HTTP header AcceptLanguages
                        null;
            // Validate culture name
            cultureName = "en-US";
            cultureName = CultureHelper.GetImplementedCulture(cultureName); // This is safe

            // Modify current thread's cultures           
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cultureName);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
    }
}