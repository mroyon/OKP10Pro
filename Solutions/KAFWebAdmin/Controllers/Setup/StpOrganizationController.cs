
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
    public class StpOrganizationController : BaseController
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
        public async Task<ActionResult> StpOrganization()
        {
            return View("StpOrganizationLanding");
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
        public async Task<ActionResult> StpOrganizationTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, stp_organizationEntity input)
        {
            stp_organizationEntity objowin_stp_organization = new stp_organizationEntity();
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
           
                List<stp_organizationEntity> data = this.GetAllStpOrganizationData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.organizationkey,
									 t.organizationnamear,
									 t.addresslineonear,
									 t.addresslinetwoar,
									 t.phonear,
									 t.emailar,
									 t.websitear,
									 t.domainar,
									 t.faxar,
									 t.organizationname,
									 t.addresslineone,
									 t.addresslinetwo,
									 t.phone,
									 t.email,
									 t.website,
									 t.domain,
									 t.fax,
									 t.ismailenable,
									 t.smtphost,
									 t.mailport,
									 t.smtpusername,
									 t.smtppassword,
									 t.mailssl,
									 t.fromemailaddress,
									 t.maildisplayname,
									 t.isftpenable,
									 t.ftpaddress,
									 t.ftpport,
									 t.ftpusername,
									 t.ftppassword,
									 t.isssl,
									 t.logoimg,
									 t.webheader,
									 t.folderpath,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.organizationkey.GetValueOrDefault(-99), "organizationkey", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "StpOrganization/StpOrganizationEdit", "StpOrganizationEdit", 
                                   "StpOrganization/StpOrganizationDelete", "StpOrganizationDelete",
                                   "StpOrganization/StpOrganizationDetail", "StpOrganizationDetail")
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
        
        
        List<stp_organizationEntity> GetAllStpOrganizationData(stp_organizationEntity objstp_organizationEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<stp_organizationEntity> listobjstp_organizationEntity = new List<stp_organizationEntity>();
            try
            {
                listobjstp_organizationEntity = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().GAPgListView((objstp_organizationEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjstp_organizationEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "organizationkey" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "organizationnamear" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "addresslineonear" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "addresslinetwoar" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "phonear" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "emailar" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "websitear" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "domainar" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "faxar" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "organizationname" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "addresslineone" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "addresslinetwo" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "phone" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "email" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "website" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "domain" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "fax" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "ismailenable" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "smtphost" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "mailport" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "smtpusername" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "smtppassword" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "mailssl" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "fromemailaddress" + " " + orderDir;
							 break;
					 case "24":
							 sortingVal = "maildisplayname" + " " + orderDir;
							 break;
					 case "25":
							 sortingVal = "isftpenable" + " " + orderDir;
							 break;
					 case "26":
							 sortingVal = "ftpaddress" + " " + orderDir;
							 break;
					 case "27":
							 sortingVal = "ftpport" + " " + orderDir;
							 break;
					 case "28":
							 sortingVal = "ftpusername" + " " + orderDir;
							 break;
					 case "29":
							 sortingVal = "ftppassword" + " " + orderDir;
							 break;
					 case "30":
							 sortingVal = "isssl" + " " + orderDir;
							 break;
					 case "31":
							 sortingVal = "logoimg" + " " + orderDir;
							 break;
					 case "32":
							 sortingVal = "webheader" + " " + orderDir;
							 break;
					 case "33":
							 sortingVal = "folderpath" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "organizationkey" + " " + orderDir;
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
        
        
        
         #region Create StpOrganization

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
        public async Task<ActionResult> StpOrganizationNew(stp_organizationEntity input)
        {
            try
            {
                ModelState.Clear();
                stp_organizationEntity model = new stp_organizationEntity();
                return PartialView("_StpOrganizationNew", model);
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
        public async Task<ActionResult> StpOrganizationInsert(stp_organizationEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("organizationkey");
				 ModelState.Remove("organizationnamear");
				 ModelState.Remove("addresslineonear");
				 ModelState.Remove("addresslinetwoar");
				 ModelState.Remove("phonear");
				 ModelState.Remove("emailar");
				 ModelState.Remove("websitear");
				 ModelState.Remove("domainar");
				 ModelState.Remove("faxar");
				 ModelState.Remove("organizationname");
				 ModelState.Remove("addresslineone");
				 ModelState.Remove("addresslinetwo");
				 ModelState.Remove("phone");
				 ModelState.Remove("email");
				 ModelState.Remove("website");
				 ModelState.Remove("domain");
				 ModelState.Remove("fax");
				 ModelState.Remove("ismailenable");
				 ModelState.Remove("smtphost");
				 ModelState.Remove("mailport");
				 ModelState.Remove("smtpusername");
				 ModelState.Remove("smtppassword");
				 ModelState.Remove("mailssl");
				 ModelState.Remove("fromemailaddress");
				 ModelState.Remove("maildisplayname");
				 ModelState.Remove("isftpenable");
				 ModelState.Remove("ftpaddress");
				 ModelState.Remove("ftpport");
				 ModelState.Remove("ftpusername");
				 ModelState.Remove("ftppassword");
				 ModelState.Remove("isssl");
				 ModelState.Remove("logoimg");
				 ModelState.Remove("webheader");
				 ModelState.Remove("folderpath");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update StpOrganization

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
        public async Task<ActionResult> StpOrganizationEdit(stp_organizationEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.organizationkey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("organizationkey", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().GetAll(new stp_organizationEntity { organizationkey = input.organizationkey }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
               

                ModelState.Clear();
                return PartialView("_StpOrganizationEdit", model);
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
        public async Task<ActionResult> StpOrganizationUpdate(stp_organizationEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("organizationkey");
				 ModelState.Remove("organizationnamear");
				 ModelState.Remove("addresslineonear");
				 ModelState.Remove("addresslinetwoar");
				 ModelState.Remove("phonear");
				 ModelState.Remove("emailar");
				 ModelState.Remove("websitear");
				 ModelState.Remove("domainar");
				 ModelState.Remove("faxar");
				 ModelState.Remove("organizationname");
				 ModelState.Remove("addresslineone");
				 ModelState.Remove("addresslinetwo");
				 ModelState.Remove("phone");
				 ModelState.Remove("email");
				 ModelState.Remove("website");
				 ModelState.Remove("domain");
				 ModelState.Remove("fax");
				 ModelState.Remove("ismailenable");
				 ModelState.Remove("smtphost");
				 ModelState.Remove("mailport");
				 ModelState.Remove("smtpusername");
				 ModelState.Remove("smtppassword");
				 ModelState.Remove("mailssl");
				 ModelState.Remove("fromemailaddress");
				 ModelState.Remove("maildisplayname");
				 ModelState.Remove("isftpenable");
				 ModelState.Remove("ftpaddress");
				 ModelState.Remove("ftpport");
				 ModelState.Remove("ftpusername");
				 ModelState.Remove("ftppassword");
				 ModelState.Remove("isssl");
				 ModelState.Remove("logoimg");
				 ModelState.Remove("webheader");
				 ModelState.Remove("folderpath");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete StpOrganization

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
        public async Task<ActionResult> StpOrganizationDelete(stp_organizationEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("organizationkey"); */
				 ModelState.Remove("organizationnamear");
				 ModelState.Remove("addresslineonear");
				 ModelState.Remove("addresslinetwoar");
				 ModelState.Remove("phonear");
				 ModelState.Remove("emailar");
				 ModelState.Remove("websitear");
				 ModelState.Remove("domainar");
				 ModelState.Remove("faxar");
				 ModelState.Remove("organizationname");
				 ModelState.Remove("addresslineone");
				 ModelState.Remove("addresslinetwo");
				 ModelState.Remove("phone");
				 ModelState.Remove("email");
				 ModelState.Remove("website");
				 ModelState.Remove("domain");
				 ModelState.Remove("fax");
				 ModelState.Remove("ismailenable");
				 ModelState.Remove("smtphost");
				 ModelState.Remove("mailport");
				 ModelState.Remove("smtpusername");
				 ModelState.Remove("smtppassword");
				 ModelState.Remove("mailssl");
				 ModelState.Remove("fromemailaddress");
				 ModelState.Remove("maildisplayname");
				 ModelState.Remove("isftpenable");
				 ModelState.Remove("ftpaddress");
				 ModelState.Remove("ftpport");
				 ModelState.Remove("ftpusername");
				 ModelState.Remove("ftppassword");
				 ModelState.Remove("isssl");
				 ModelState.Remove("logoimg");
				 ModelState.Remove("webheader");
				 ModelState.Remove("folderpath");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.organizationkey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("organizationkey", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail StpOrganization

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
        public async Task<ActionResult> StpOrganizationDetail(stp_organizationEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.organizationkey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("organizationkey", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.stp_organizationFCC.GetFacadeCreate().GetAll(new stp_organizationEntity { organizationkey = input.organizationkey }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
              
                ModelState.Clear();
                return PartialView("_StpOrganizationDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



