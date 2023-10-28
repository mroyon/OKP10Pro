﻿
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
    public class HrFlightInfoController : BaseController
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
        public async Task<ActionResult> HrFlightInfo()
        {
            return View("HrFlightInfoLanding");
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
        public async Task<ActionResult> HrFlightInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_flightinfoEntity input)
        {
            hr_flightinfoEntity objowin_hr_flightinfo = new hr_flightinfoEntity();
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

                List<hr_flightinfoEntity> data = this.GetAllHrFlightInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    //foreach (hr_flightinfoEntity objsingle in data)
                    //{
                    //    objsingle.totalperson = KAF.FacadeCreatorObjects.hr_flightinfodetlFCC.GetFacadeCreate().GetAll(new hr_flightinfodetlEntity { flightid = objsingle.flightid }).Where(p=>p.iscancel!=true && p.reissued!= true).ToList().Count().ToString();
                    //}

                    var tut = (from t in data
                               select new
                               {
                                   t.flightid,
                                   t.ptademandid,
                                   t.flightdate,
                                   t.flightletterdate,
                                   t.flightletterno,
                                   t.airlinesid,
                                   t.remarks,
                                  t.ex_bigint1,
                                   t.ex_nvarchar2,
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.flightid.GetValueOrDefault(-99), "flightid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrFlightInfo/HrFlightInfoEdit", "HrFlightInfoEdit",
                                   "", "HrFlightInfoDelete",
                                   "", "HrFlightInfoDetail", "DownloadReport", 8)
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


        List<hr_flightinfoEntity> GetAllHrFlightInfoData(hr_flightinfoEntity objhr_flightinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_flightinfoEntity> listobjhr_flightinfoEntity = new List<hr_flightinfoEntity>();
            try
            {
                listobjhr_flightinfoEntity = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().GAPgListView((objhr_flightinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_flightinfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "flightid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "ptademandid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "flightdate" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "flightletterdate" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "flightletterno" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "airlinesid" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "flightid" + " " + orderDir;
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



        #region Create HrFlightInfo

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
        public async Task<ActionResult> HrFlightInfoNew(hr_flightinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_flightinfoEntity model = new hr_flightinfoEntity();
                return PartialView("_HrFlightInfoNew", model);
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
        public async Task<ActionResult> HrFlightInfoInsert(hr_flightinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();

                for (int ind = 0; ind < input.hr_flightList.Count; ind++)
                {
                    ModelState.Remove("hr_flightList[" + ind + "].flightdetlid");
                    ModelState.Remove("hr_flightList[" + ind + "].flightid");
                }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    ret = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().SaveMasterDethr_flightinfodetl(input, input.hr_flightList);
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


        #region update HrFlightInfo

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
        public async Task<ActionResult> HrFlightInfoEdit(hr_flightinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.flightid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("flightid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().GetAll(new hr_flightinfoEntity { flightid = input.flightid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                //List<hr_ptademandEntity> listhr_ptademand = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().GetAll(new hr_ptademandEntity { ptademandid = model.ptademandid }).ToList();
                //var objhr_ptademand = (from t in listhr_ptademand
                //select new
                //{
                //		 Id = t.ptademandid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedhr_ptademand = JsonConvert.SerializeObject(objhr_ptademand);

                List<gen_airlinesEntity> listgen_airlines = KAF.FacadeCreatorObjects.gen_airlinesFCC.GetFacadeCreate().GetAll(new gen_airlinesEntity { airlinesid = model.airlinesid }).ToList();
                var objgen_airlines = (from t in listgen_airlines
                                       select new
                                       {
                                           Id = t.airlinesid,
                                           Text = t.airlinesname
                                       }).ToList();
                ViewBag.preloadedGen_Airlines = JsonConvert.SerializeObject(objgen_airlines);




                ModelState.Clear();
                return PartialView("_HrFlightInfoEdit", model);
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
        public async Task<ActionResult> HrFlightInfoUpdate(hr_flightinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                if (input.hr_flightList != null && input.hr_flightList.Count > 0)
                    for (int ind = 0; ind < input.hr_flightList.Count; ind++)
                    {
                        ModelState.Remove("hr_flightList[" + ind + "].flightdetlid");
                        ModelState.Remove("hr_flightList[" + ind + "].flightid");
                    }

                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    if (input.hr_flightList != null && input.hr_flightList.Count > 0)
                        ret = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().SaveMasterDethr_flightinfodetl(input, input.hr_flightList);
                    else
                        ret = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().Update(input);

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

        #region delete HrFlightInfo

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
        public async Task<ActionResult> HrFlightInfoDelete(hr_flightinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("flightid"); */
                ModelState.Remove("ptademandid");
                ModelState.Remove("flightdate");
                ModelState.Remove("flightletterdate");
                ModelState.Remove("flightletterno");
                ModelState.Remove("airlinesid");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.flightid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("flightid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().Delete(input);

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

        #region detail HrFlightInfo

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
        public async Task<ActionResult> HrFlightInfoDetail(hr_flightinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.flightid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("flightid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().GetAll(new hr_flightinfoEntity { flightid = input.flightid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //List<hr_ptademandEntity> listhr_ptademand = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().GetAll(new hr_ptademandEntity { ptademandid = model.ptademandid }).ToList();
                //var objhr_ptademand = (from t in listhr_ptademand
                //select new
                //{
                //		 Id = t.ptademandid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedhr_ptademand = JsonConvert.SerializeObject(objhr_ptademand);

                List<gen_airlinesEntity> listgen_airlines = KAF.FacadeCreatorObjects.gen_airlinesFCC.GetFacadeCreate().GetAll(new gen_airlinesEntity { airlinesid = model.airlinesid }).ToList();
                var objgen_airlines = (from t in listgen_airlines
                                       select new
                                       {
                                           Id = t.airlinesid,
                                           Text = t.airlinesname
                                       }).ToList();
                ViewBag.preloadedGen_Airlines = JsonConvert.SerializeObject(objgen_airlines);



                ModelState.Clear();
                return PartialView("_HrFlightInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



