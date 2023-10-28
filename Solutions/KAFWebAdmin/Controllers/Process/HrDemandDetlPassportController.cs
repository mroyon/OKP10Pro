
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
    public class HrDemandDetlPassportController : BaseController
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
        public async Task<ActionResult> HrDemandDetlPassport()
        {
            return View("HrDemandDetlPassportLanding");
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
        public async Task<ActionResult> HrDemandDetlPassportTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_demanddetlpassportEntity input)
        {
            hr_demanddetlpassportEntity objowin_hr_demanddetlpassport = new hr_demanddetlpassportEntity();
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
           
                List<hr_demanddetlpassportEntity> data = this.GetAllHrDemandDetlPassportData(input);

                if (data != null && data.Count > 0)
                {
                    
                    long totalRecords = data.FirstOrDefault().RETURN_KEY; 
                    var tut = (from t in data
                               select new
                               {
                                   t.newdemandpassportid,
                                   t.newdemanddetlid,
                                   t.serialno,
                                   t.hrbasicid,
                                   t.hrsvcid,
                                   t.remarks,
                                   t.passportrecvdate,
                                   t.letterno,
                                   t.letterdate,
                                   totalperson = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll_Ext(new hr_demanddetlpassportEntity { letterno=t.letterno,newdemandid=t.newdemandid,isall=1}).ToList().Where(p=>p.hrbasicid!=0).ToList().Count(),
                                   t.LetterStatus,
                                   ex_nvarchar1 = genButtonPanel(t.newdemandid.GetValueOrDefault(-99), t.newdemandpassportid.GetValueOrDefault(-99),  this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrDemandDetlPassport/HrDemandDetlPassportEdit", "HrDemandDetlPassportEdit",
                                   "", "",
                                   "HrDemandDetlPassport/HrDemandDetlPassportDetail", "HrDemandDetlPassportDetail", "", 14,t.letterno)
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
        public string genButtonPanel(long menuId, long menuId2, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
        string actionNameDelete, string deleteMethodName, string actionNameView, string viewMethodName, string actionNameDownload = "", Int64 letterstatus = -99,string letterno="")
        {
            clsPrivateKeys objClsPrivate = new clsPrivateKeys();
            string strValue = string.Empty;
            string strJson = string.Empty;
            try
            {

                if (claimsIdentity != null)
                {
                    List<Owin_ProcessGetFormActionistEntity_Ext> itemList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Owin_ProcessGetFormActionistEntity_Ext>>(Session["jsonList"].ToString());
                    if (itemList != null && itemList.Count > 0)
                    {
                        strValue += "<div class='btn-toolbar pull-right' role='toolbar'>";
                        if (!String.IsNullOrEmpty(actionNameEdit))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameEdit)))
                            {
                                if (actionNameEdit == "GenOSInfo/GenOSInfoUpdate")
                                {
                                    strValue += "<button  data-target='#EditOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + editMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams("newdemandpassportid", menuId.ToString()) + "&apos;)> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button>";
                                }

                                else
                                {
                                    strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams("newdemandpassportid", menuId2.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDelete))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameDelete)))
                            {
                                strValue += "<button class='btn btn-danger btn-md' onclick='" + deleteMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams("newdemandpassportid", menuId2.ToString()) + "&quot;)'><i class='fa fa-trash'></i> " + KAF.MsgContainer._Common._btnDelete + "</button>  ";

                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameView))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {
                                if (actionNameView == "GenOSInfo/GenOSInfoDetails")
                                {
                                    strValue += "<button  data-target='#DisplayOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + viewMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams("newdemandpassportid", menuId.ToString()) + "&apos;)> <i class='fa fa-info-circle'> </i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                                else
                                {
                                    strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams("newdemandpassportid", menuId2.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDownload))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {

                                //strValue += "<button class='btn btn-info btn-md' onclick='DownloadData(&quot;" + menuId.ToString() + "&quot;,&quot;" + letterstatus.ToString() + "&quot;,&quot;" + letterno+"&quot;)'><i class='fa fa-info-circle'></i>Download Report</button>";

                            }
                        }
                        strValue += "</div>";
                    }
                }
                else
                    throw new Exception("Login required");
            }
            catch (Exception ex)
            {
                strValue = ex.Message;
            }
            return strValue;
        }


        List<hr_demanddetlpassportEntity> GetAllHrDemandDetlPassportData(hr_demanddetlpassportEntity objhr_demanddetlpassportEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_demanddetlpassportEntity> listobjhr_demanddetlpassportEntity = new List<hr_demanddetlpassportEntity>();
            try
            {
                listobjhr_demanddetlpassportEntity = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GAPgListView_Ext((objhr_demanddetlpassportEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_demanddetlpassportEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "newdemandpassportid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "newdemanddetlid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "serialno" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "hrsvcid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "passportrecvdate" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "letterno" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "letterdate" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "newdemandpassportid" + " " + orderDir;
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
        
        
        
         #region Create HrDemandDetlPassport

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
        public async Task<ActionResult> HrDemandDetlPassportNew(hr_demanddetlpassportEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_demanddetlpassportEntity model = new hr_demanddetlpassportEntity();
                return PartialView("_HrDemandDetlPassportNew", model);
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
        //[RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> HrDemandDetlPassportInsert(List<hr_demanddetlpassportEntity> input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                /*				 ModelState.Remove("newdemandpassportid");
                                 ModelState.Remove("newdemanddetlid");
                                 ModelState.Remove("serialno");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("hrsvcid");
                                 ModelState.Remove("remarks");
                                 ModelState.Remove("passportrecvdate");
                                 ModelState.Remove("letterno");
                                 ModelState.Remove("letterdate");
                */
                ModelState.Remove("newdemanddetlid");
                ModelState.Remove("serialno");
                ModelState.Remove("hrbasicid");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.Select(m => { m.BaseSecurityParam = sec; return m; }).ToList();
                    input.Where(k=> k.hrbasicid == 0).Select(m => { m.hrbasicid = null; return m; }).ToList();
                    //input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    ret = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().SaveList_Ext(input);
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
        
        
        #region update HrDemandDetlPassport

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
        public async Task<ActionResult> HrDemandDetlPassportEdit(hr_demanddetlpassportEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.newdemandpassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("newdemandpassportid", input.strModelPrimaryKey).ToString());

                input.isall = 1;

                var objPassportdetail = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll_Ext(input).ToList();
                var model = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll(new hr_demanddetlpassportEntity { newdemandpassportid = input.newdemandpassportid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                if (objPassportdetail != null)
                {
                    model.demandletterdate = objPassportdetail[0].demandletterdate;
                    var objDemandletterNo = (from t in objPassportdetail
                                             select new
                                             {
                                                 Id = t.newdemandid,
                                                 Text = t.demandletterno
                                             }).ToList();
                    ViewBag.preHr_NewDemandLetterNo = JsonConvert.SerializeObject(objDemandletterNo);

                    var objPassportletterNo = (from t in objPassportdetail
                                               select new
                                               {
                                                   Id = t.letterno,
                                                   Text = t.letterno
                                               }).ToList();
                    ViewBag.preloaded_PassportLetterNo = JsonConvert.SerializeObject(objPassportletterNo);
                }

                ModelState.Clear();
                return PartialView("_HrDemandDetlPassportEdit", model);
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
        public async Task<ActionResult> HrDemandDetlPassportUpdate(List<hr_demanddetlpassportEntity> input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("newdemandpassportid");
                                 ModelState.Remove("newdemanddetlid");
                                 ModelState.Remove("serialno");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("hrsvcid");
                                 ModelState.Remove("remarks");
                                 ModelState.Remove("passportrecvdate");
                                 ModelState.Remove("letterno");
                                 ModelState.Remove("letterdate");
                */
               // ModelState.Remove("newdemanddetlid");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    //input.BaseSecurityParam = sec;
                    input.Select(m => { m.BaseSecurityParam = sec; return m; }).ToList();

                    ret = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().SaveList_Ext(input);
                 
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

        #region delete HrDemandDetlPassport

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
        public async Task<ActionResult> HrDemandDetlPassportDelete(hr_demanddetlpassportEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("newdemandpassportid"); */
				 ModelState.Remove("newdemanddetlid");
				 ModelState.Remove("serialno");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("hrsvcid");
				 ModelState.Remove("remarks");
				 ModelState.Remove("passportrecvdate");
				 ModelState.Remove("letterno");
				 ModelState.Remove("letterdate");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.newdemandpassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("newdemandpassportid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrDemandDetlPassport

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
        public async Task<ActionResult> HrDemandDetlPassportDetail(hr_demanddetlpassportEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.newdemandpassportid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("newdemandpassportid", input.strModelPrimaryKey).ToString());
                input.isall = 1;

                var objPassportdetail = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll_Ext(input).ToList();

                var model = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll(new hr_demanddetlpassportEntity { newdemandpassportid = input.newdemandpassportid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;

                if (objPassportdetail != null)
                {
                    model.demandletterdate = objPassportdetail[0].demandletterdate;
                    var objDemandletterNo = (from t in objPassportdetail
                                             select new
                                             {
                                                 Id = t.newdemandid,
                                                 Text = t.demandletterno
                                             }).ToList();
                    ViewBag.preHr_NewDemandLetterNo = JsonConvert.SerializeObject(objDemandletterNo);

                    var objPassportletterNo = (from t in objPassportdetail
                                               select new
                                               {
                                                   Id = t.letterno,
                                                   Text = t.letterno
                                               }).ToList();
                    ViewBag.preloaded_PassportLetterNo = JsonConvert.SerializeObject(objPassportletterNo);
                }

                ModelState.Clear();
                return PartialView("_HrDemandDetlPassportDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

        //[HttpPost]
        //[AuthorizeFilterAttribute]
        //[ValidateInput(true)]
        //[ValidateAntiForgeryToken]
        //[AllowCrossSiteJsonAttribute]
        //[SecurityFillerAttribute]
        //[LoggingFilterAttribute]
        //[RequestValidationAttribute]
        //[ExceptionFilterAttribute]
        public async Task<ActionResult> GetHrDemandDetlPassportDetail(hr_demanddetlpassportEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            JsonResult result = new JsonResult();

            try
            {
                var model = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll(input).ToList();
                return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = model, redirectUrl = "", totalrows = model.Count, responsetext = "Data found." });
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



