
using DataTables.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials.MenuModel;
using KAF.WebFramework;
using System.Threading.Tasks;
using KAF.CustomHelper.HelperClasses;
using KAF.CustomFilters.Filters;
using KAF.MVC.Common;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;		
using KAF.CustomHelper;
    
namespace KAFWebAdmin.Controllers.HR
{
    public class OwinUserController : BaseController
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
        public async Task<ActionResult> OwinUser()
        {
            return View("OwinUserLanding");
        }


        //Datatable load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_userEntity input)
        {
            owin_userEntity objowin_owin_user = new owin_userEntity();
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

                if (search != "")
                {
                    input.strCommonSerachParam = "%" + search + "%";
                }
           
                List<owin_userEntity> data = this.GetAllOwinUserData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.applicationid,
									 t.userid,
									 t.masteruserid,
									 t.username,
									 t.emailaddress,
									 t.loweredusername,
									 t.mobilenumber,
									 t.userprofilephoto,
									 t.isanonymous,
									 t.ischildenable,
									 t.masprivatekey,
									 t.maspublickey,
									 t.password,
									 t.passwordsalt,
									 t.passwordkey,
									 t.passwordvector,
									 t.mobilepin,
									 t.passwordquestion,
									 t.passwordanswer,
									 t.approved,
									 t.locked,
									 t.lastlogindate,
									 t.lastpasschangeddate,
									 t.lastlockoutdate,
									 t.failedpasswordattemptcount,
									 t.comment,
									 t.lastactivitydate,
									 t.isapproved,
									 t.approvedby,
									 t.approvedbyusername,
									 t.approveddate,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.masteruserid.GetValueOrDefault(-99), "masteruserid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "OwinUser/OwinUserEdit", "OwinUserEdit", 
                                   "OwinUser/OwinUserDelete", "OwinUserDelete",
                                   "OwinUser/OwinUserDetail", "OwinUserDetail")
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
        
        
        List<owin_userEntity> GetAllOwinUserData(owin_userEntity objowin_userEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<owin_userEntity> listobjowin_userEntity = new List<owin_userEntity>();
            try
            {
                listobjowin_userEntity = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GAPgListView((objowin_userEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjowin_userEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "applicationid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "userid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "masteruserid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "username" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "emailaddress" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "loweredusername" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "mobilenumber" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "userprofilephoto" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "isanonymous" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "ischildenable" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "masprivatekey" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "maspublickey" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "password" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "passwordsalt" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "passwordkey" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "passwordvector" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "mobilepin" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "passwordquestion" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "passwordanswer" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "approved" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "locked" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "lastlogindate" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "lastpasschangeddate" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "lastlockoutdate" + " " + orderDir;
							 break;
					 case "24":
							 sortingVal = "failedpasswordattemptcount" + " " + orderDir;
							 break;
					 case "25":
							 sortingVal = "comment" + " " + orderDir;
							 break;
					 case "26":
							 sortingVal = "lastactivitydate" + " " + orderDir;
							 break;
					 case "27":
							 sortingVal = "isapproved" + " " + orderDir;
							 break;
					 case "28":
							 sortingVal = "approvedby" + " " + orderDir;
							 break;
					 case "29":
							 sortingVal = "approvedbyusername" + " " + orderDir;
							 break;
					 case "30":
							 sortingVal = "approveddate" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "applicationid" + " " + orderDir;
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
        
        
        
         #region Create OwinUser

        //Create Page Load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserNew(owin_userEntity input)
        {
            try
            {
                ModelState.Clear();
                owin_userEntity model = new owin_userEntity();
                return PartialView("_OwinUserNew", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


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
        public async Task<ActionResult> OwinUserInsert(owin_userEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("applicationid");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("username");
				 ModelState.Remove("emailaddress");
				 ModelState.Remove("loweredusername");
				 ModelState.Remove("mobilenumber");
				 ModelState.Remove("userprofilephoto");
				 ModelState.Remove("isanonymous");
				 ModelState.Remove("ischildenable");
				 ModelState.Remove("masprivatekey");
				 ModelState.Remove("maspublickey");
				 ModelState.Remove("password");
				 ModelState.Remove("passwordsalt");
				 ModelState.Remove("passwordkey");
				 ModelState.Remove("passwordvector");
				 ModelState.Remove("mobilepin");
				 ModelState.Remove("passwordquestion");
				 ModelState.Remove("passwordanswer");
				 ModelState.Remove("approved");
				 ModelState.Remove("locked");
				 ModelState.Remove("lastlogindate");
				 ModelState.Remove("lastpasschangeddate");
				 ModelState.Remove("lastlockoutdate");
				 ModelState.Remove("failedpasswordattemptcount");
				 ModelState.Remove("comment");
				 ModelState.Remove("lastactivitydate");
				 ModelState.Remove("isapproved");
				 ModelState.Remove("approvedby");
				 ModelState.Remove("approvedbyusername");
				 ModelState.Remove("approveddate");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().Add(input);
                    if (ret > 0)
                    {
                        ModelState.Clear();
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._saveInformation });
                    }
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
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
        
        #region update OwinUser

        //Update Page Load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserEdit(owin_userEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.masteruserid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("masteruserid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity { userid = input.userid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
               

                ModelState.Clear();
                return PartialView("_OwinUserEdit", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        //Update Page Update Action
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserUpdate(owin_userEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("applicationid");
				 ModelState.Remove("userid");
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("username");
				 ModelState.Remove("emailaddress");
				 ModelState.Remove("loweredusername");
				 ModelState.Remove("mobilenumber");
				 ModelState.Remove("userprofilephoto");
				 ModelState.Remove("isanonymous");
				 ModelState.Remove("ischildenable");
				 ModelState.Remove("masprivatekey");
				 ModelState.Remove("maspublickey");
				 ModelState.Remove("password");
				 ModelState.Remove("passwordsalt");
				 ModelState.Remove("passwordkey");
				 ModelState.Remove("passwordvector");
				 ModelState.Remove("mobilepin");
				 ModelState.Remove("passwordquestion");
				 ModelState.Remove("passwordanswer");
				 ModelState.Remove("approved");
				 ModelState.Remove("locked");
				 ModelState.Remove("lastlogindate");
				 ModelState.Remove("lastpasschangeddate");
				 ModelState.Remove("lastlockoutdate");
				 ModelState.Remove("failedpasswordattemptcount");
				 ModelState.Remove("comment");
				 ModelState.Remove("lastactivitydate");
				 ModelState.Remove("isapproved");
				 ModelState.Remove("approvedby");
				 ModelState.Remove("approvedbyusername");
				 ModelState.Remove("approveddate");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().Update(input);
                 
                    if (ret > 0)
                    {
                        ModelState.Clear();
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._saveInformation });
                    }
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
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

        #region delete OwinUser

        //Delete Page Delete Action
        [HttpPost]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserDelete(owin_userEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 ModelState.Remove("applicationid");
				 /* ModelState.Remove("userid"); */
				 ModelState.Remove("masteruserid");
				 ModelState.Remove("username");
				 ModelState.Remove("emailaddress");
				 ModelState.Remove("loweredusername");
				 ModelState.Remove("mobilenumber");
				 ModelState.Remove("userprofilephoto");
				 ModelState.Remove("isanonymous");
				 ModelState.Remove("ischildenable");
				 ModelState.Remove("masprivatekey");
				 ModelState.Remove("maspublickey");
				 ModelState.Remove("password");
				 ModelState.Remove("passwordsalt");
				 ModelState.Remove("passwordkey");
				 ModelState.Remove("passwordvector");
				 ModelState.Remove("mobilepin");
				 ModelState.Remove("passwordquestion");
				 ModelState.Remove("passwordanswer");
				 ModelState.Remove("approved");
				 ModelState.Remove("locked");
				 ModelState.Remove("lastlogindate");
				 ModelState.Remove("lastpasschangeddate");
				 ModelState.Remove("lastlockoutdate");
				 ModelState.Remove("failedpasswordattemptcount");
				 ModelState.Remove("comment");
				 ModelState.Remove("lastactivitydate");
				 ModelState.Remove("isapproved");
				 ModelState.Remove("approvedby");
				 ModelState.Remove("approvedbyusername");
				 ModelState.Remove("approveddate");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.masteruserid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("masteruserid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().Delete(input);
                 
                    if (ret > 0)
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = KAF.MsgContainer._Common._deleteInformation });
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
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            finally
            {

            }
        }
        #endregion

        #region detail OwinUser

        //Detail Page Load
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> OwinUserDetail(owin_userEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.masteruserid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("masteruserid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity { userid = input.userid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
              
                ModelState.Clear();
                return PartialView("_OwinUserDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



