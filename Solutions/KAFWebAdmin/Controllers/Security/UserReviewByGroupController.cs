using DataTables.Mvc;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.WebFramework;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using KAF.MVC.Common;

namespace KAFWebAdmin.Controllers.Security
{
    public class UserReviewByGroupController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        clsSecurityPanel objSecPanel = new clsSecurityPanel();
        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();


        #region LANDING LOAD
        //Landing page caller

        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> UserReviewByGroup()
        {
            return View("UserReviewByGroupLanding");
        }

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> UserReviewByGroupTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_userEntity input)
        {
            owin_userEntity objowin_rbasicprofile = new owin_userEntity();
            // Initialization.  
            JsonResult result = new JsonResult();
            try
            {

                string search = Request.Form.GetValues("search[value]")[0];

                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                int CurrentPage = 0;
                if (requestModel.Start == 0)
                {
                    CurrentPage = 1;
                }
                else
                {
                    CurrentPage = requestModel.Start / requestModel.Length + 1;
                }
                input.CurrentPage = CurrentPage;
                input.PageSize = requestModel.Length;
                input.SortExpression = SortByColumnWithOrder((Request.Form.GetValues("order[0][column]"))[0], (Request.Form.GetValues("order[0][dir]"))[0]);
                input.BaseSecurityParam = new SecurityCapsule();
                input.BaseSecurityParam = sec;


                if (search != "")
                {
                    input.strCommonSerachParam = "%" + search + "%";
                }

                List<owin_userEntity> data = this.GetUserReviewByGroup(input);
                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.masteruserid,
                                   t.userid,
                                   t.UserProfilePhoto,
                                   t.loweredusername,
                                   t.username,
                                   t.emailaddress,
                                   t.mobilenumber,
                                   t.locked
                               }).ToList();

                    result = this.Json(new { draw = requestModel.Draw, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { draw = requestModel.Draw, recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }

        List<owin_userEntity> GetUserReviewByGroup(owin_userEntity objowin_rbasicprofile)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_userEntity> listobjowin_rbasicprofile = new List<owin_userEntity>();
            try
            {
                listobjowin_rbasicprofile = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().GetUserReviewByGroupData(objowin_rbasicprofile).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjowin_rbasicprofile;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "username" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "emailaddress" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "mobilenumber" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "locked" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "approved" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "isreviewed" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "reviewedbyusername" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "revieweddate" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "username" + " " + orderDir;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sortingVal;
        }
        #endregion



        #region Create UserReviewByGroup


        //Create Page Create Action
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> UserReviewByGroupInsert(owin_userEntity input)
        {
            string str = string.Empty;
            try
            {
                ModelState.Remove("username");
                ModelState.Remove("password");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordvector");
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordkey");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {
                   

                        SecurityCapsule sec = new SecurityCapsule();
                        sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                        input.BaseSecurityParam = sec;
                        input.CurrentState = BaseEntity.EntityState.Changed;
                        

                        Int64 ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().UserReviewedByGroupUpdate(input);
                        if (ret > 0)
                            return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Common._updateInformation });
                        else
                            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
                    }
                    
                
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInvalidData, redirectUrl = "", responsetext = str });
                }
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion






    }
}
