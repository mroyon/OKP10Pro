
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
    public class HrHospitalAdmissionInfoController : BaseController
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
        public async Task<ActionResult> HrHospitalAdmissionInfo()
        {
            return View("HrHospitalAdmissionInfoLanding");
        }


        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> HrHospitalAdmissionInfoAdmit()
        {
            return View("HrHospitalAdmissionInfoAdmitLanding");
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
        public async Task<ActionResult> HrHospitalAdmissionInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_hospitaladmissioninfoEntity input)
        {
            hr_hospitaladmissioninfoEntity objowin_hr_hospitaladmissioninfoEntity = new hr_hospitaladmissioninfoEntity();
            JsonResult result = new JsonResult();
            try
            {
                //string search = Request.Form.GetValues("search[value]")[0];
                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                #region Check if Military person exists
                hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
                objhr_svcinfo.militarynokw = input.militarynokw;
                objhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).FirstOrDefault();

                if (objhr_svcinfo != null)
                {
                    if (sec.okpid != null && sec.okpid != objhr_svcinfo.okpid)
                    {
                        result = this.Json(new { recordsTotal = 0, recordsFiltered = 0, data = "", responsetext = "Warning! Unauthorized search." }, JsonRequestBehavior.AllowGet);
                        return result;
                    }
                }

                #endregion
                string search = Request.Form.GetValues("search[value]")[0];
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
                input.hrbasicid = objhr_svcinfo.hrbasicid;
                //input.strCommonSerachParam= $"%{objhr_svcinfo.hrbasicid.ToString()}%";
                List<hr_hospitaladmissioninfoEntity> data = this.GetAllHrHospitalAdmissionInfoData(input).OrderByDescending(p=> p.hospitaladmissionid).ToList();


                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   objhr_svcinfo.militarynokw,
                                   objhr_svcinfo.militarynobd,
                                   objhr_svcinfo.civilid,
                                   objhr_svcinfo.fullname,
                                   objhr_svcinfo.dateofbirth,
                                   t.hospitaladmissionid,
                                   objhr_svcinfo.hrbasicid,
                                   t.hospitalname,
                                   t.diseasename,
                                   t.hospitaladmissiondate,
                                   t.hospitalreleasedate,
                                   t.hospitalcountryid,
                                   t.description,
                                   t.releasenote,
                                   t.remarks,

                                   ex_nvarchar1 = genButtonPanel(input.pageInfo== "release"?true:false, t.hospitaladmissionid.GetValueOrDefault(-99), "hospitaladmissionid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   t.hospitalreleasedate==null ? "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoEdit":"", t.hospitalreleasedate == null ? "HrHospitalAdmissionInfoEdit" : "",
                                   t.hospitalreleasedate == null && input.pageInfo != "release" ? "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoDelete" : "", t.hospitalreleasedate == null ? "HrHospitalAdmissionInfoDelete" : "",
                                   "HrHospitalAdmissionInfo/HrHospitalAdmissionInfoDetail", "HrHospitalAdmissionInfoDetail")
                               }).ToList();

                    result = this.Json(new { recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut, responsetext = "" }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { recordsTotal = 0, recordsFiltered = 0, data = "", responsetext = "Data not found." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }


        public string genButtonPanel(bool IsRelease, long menuId, string menuName, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
           string actionNameDelete, string deleteMethodName, string actionNameView, string viewMethodName, string actionNameDownload = "", Int64? letterstatus = -99)
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
                               if(IsRelease==true)
                                    strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> Release </button> ";

                                else
                                    strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";
                                
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDelete))
                        {
                            if (itemList.Exists(p => p.ActionName.Contains(actionNameDelete)))
                            {
                                strValue += "<button class='btn btn-danger btn-md' onclick='" + deleteMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-trash'></i> " + KAF.MsgContainer._Common._btnDelete + "</button>  ";

                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameView))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {
                                if (actionNameView == "GenOSInfo/GenOSInfoDetails")
                                {
                                    strValue += "<button  data-target='#DisplayOSInformation' data-toggle='modal' class='btn btn-primary btn-md' data-ng-click=" + viewMethodName + "(&apos;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&apos;)> <i class='fa fa-info-circle'> </i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                                else
                                {
                                    strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                }
                            }
                        }
                        if (!String.IsNullOrEmpty(actionNameDownload))
                        {

                            if (itemList.Exists(p => p.ActionName.Contains(actionNameView)))
                            {

                                strValue += "<button class='btn btn-info btn-md' onclick='DownloadData(&quot;" + menuId.ToString() + "&quot;,&quot;" + letterstatus.ToString() + "&quot;)'><i class='fa fa-info-circle'></i>Download Report</button>";

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

        List<hr_hospitaladmissioninfoEntity> GetAllHrHospitalAdmissionInfoData(hr_hospitaladmissioninfoEntity objhr_hospitaladmissioninfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_hospitaladmissioninfoEntity> listobjhr_hospitaladmissioninfoEntity = new List<hr_hospitaladmissioninfoEntity>();
            try
            {
                listobjhr_hospitaladmissioninfoEntity = KAF.FacadeCreatorObjects.hr_hospitaladmissioninfoFCC.GetFacadeCreate().GAPgListView((objhr_hospitaladmissioninfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_hospitaladmissioninfoEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "hospitaladmissionid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "hrbasicid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "hospitalname" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "diseasename" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "hospitaladmissiondate" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "hospitalreleasedate" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "hospitalcountryid" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "description" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "releasenote" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "hospitaladmissionid" + " " + orderDir;
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



        #region Create HrHospitalAdmissionInfo

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
        public async Task<ActionResult> HrHospitalAdmissionInfoNew(hr_hospitaladmissioninfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_hospitaladmissioninfoEntity model = new hr_hospitaladmissioninfoEntity();
                return PartialView("_HrHospitalAdmissionInfoNew", model);
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
        public async Task<ActionResult> HrHospitalAdmissionInfoInsert(hr_hospitaladmissioninfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                //ModelState.Remove("hrbasicid");
                //ModelState.Remove("hospitalname");
                //ModelState.Remove("diseasename");
                //ModelState.Remove("hospitaladmissiondate");
                //ModelState.Remove("hospitalreleasedate");
                //ModelState.Remove("hospitalcountryid");
                //ModelState.Remove("description");
                //ModelState.Remove("releasenote");


                ModelState.Remove("hospitaladmissionid");
                ModelState.Remove("hospitalreleasedate");
                ModelState.Remove("remarks");
                ModelState.Remove("fullname");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    ret = KAF.FacadeCreatorObjects.hr_hospitaladmissioninfoFCC.GetFacadeCreate().Add(input);
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


        #region update HrHospitalAdmissionInfo

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
        public async Task<ActionResult> HrHospitalAdmissionInfoEdit(hr_hospitaladmissioninfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hospitaladmissionid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hospitaladmissionid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_hospitaladmissioninfoFCC.GetFacadeCreate().GetAll(new hr_hospitaladmissioninfoEntity { hospitaladmissionid = input.hospitaladmissionid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.pageInfo = input.pageInfo;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                if (model.hospitalcountryid != null)
                {
                    List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.hospitalcountryid }).ToList();
                    var objgen_country = (from t in listgen_country
                                          select new
                                          {
                                              Id = t.countryid,
                                              Text = t.countryname
                                          }).ToList();
                    ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);

                }



                ModelState.Clear();
                return PartialView("_HrHospitalAdmissionInfoEdit", model);
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
        public async Task<ActionResult> HrHospitalAdmissionInfoUpdate(hr_hospitaladmissioninfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("hospitaladmissionid");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("hospitalname");
                                 ModelState.Remove("diseasename");
                                 ModelState.Remove("hospitaladmissiondate");
                                 ModelState.Remove("hospitalreleasedate");
                                 ModelState.Remove("hospitalcountryid");
                                 ModelState.Remove("description");
                                 ModelState.Remove("releasenote");
                                 ModelState.Remove("remarks");
                */
                ModelState.Remove("hospitaladmissionid");
                ModelState.Remove("hospitalreleasedate");
                ModelState.Remove("remarks");
                ModelState.Remove("fullname");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    ret = KAF.FacadeCreatorObjects.hr_hospitaladmissioninfoFCC.GetFacadeCreate().Update(input);

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

        #region delete HrHospitalAdmissionInfo

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
        public async Task<ActionResult> HrHospitalAdmissionInfoDelete(hr_hospitaladmissioninfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("hospitaladmissionid"); */
                ModelState.Remove("hrbasicid");
                ModelState.Remove("hospitalname");
                ModelState.Remove("diseasename");
                ModelState.Remove("hospitaladmissiondate");
                ModelState.Remove("hospitalreleasedate");
                ModelState.Remove("hospitalcountryid");
                ModelState.Remove("description");
                ModelState.Remove("releasenote");
                ModelState.Remove("remarks");
                ModelState.Remove("hospitalreleasedate");
                ModelState.Remove("remarks");
                ModelState.Remove("fullname");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.hospitaladmissionid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hospitaladmissionid", input.strModelPrimaryKey).ToString());


                    var model = KAF.FacadeCreatorObjects.hr_hospitaladmissioninfoFCC.GetFacadeCreate().Delete(input);

                    if (model > 0)
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

        #region detail HrHospitalAdmissionInfo

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
        public async Task<ActionResult> HrHospitalAdmissionInfoDetail(hr_hospitaladmissioninfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hospitaladmissionid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hospitaladmissionid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.hr_hospitaladmissioninfoFCC.GetFacadeCreate().GetAll(new hr_hospitaladmissioninfoEntity { hospitaladmissionid = input.hospitaladmissionid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                if (model.hospitalcountryid != null)
                {
                    List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.hospitalcountryid }).ToList();
                    var objgen_country = (from t in listgen_country
                                          select new
                                          {
                                              Id = t.countryid,
                                              Text = t.countryname
                                          }).ToList();
                    ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);

                }


                ModelState.Clear();
                return PartialView("_HrHospitalAdmissionInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        #region Get Basic Profile Data
        [SecurityFillerAttribute]
        public async Task<ActionResult> GetAllHrBasicProfileData(long? militaryNo)
        {
            JsonResult result = new JsonResult();
            SecurityCapsule sec = new SecurityCapsule();
            sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
            hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
            objhr_svcinfo.militarynokw = militaryNo;

            try
            {
                var data = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).ToList();


                if (data != null && data.Count > 0)
                {
                    if (sec.okpid != null && sec.okpid != data.FirstOrDefault().okpid)
                    {
                        return Json(new { data = data, status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Warning! Unauthorized search for Military No: " + militaryNo });
                    }

                    long totalRecords = data.FirstOrDefault().RETURN_KEY;
                    hr_hospitaladmissioninfoEntity objHospital = new hr_hospitaladmissioninfoEntity();
                    objHospital.hrbasicid = data.FirstOrDefault().hrbasicid;
                    objHospital.hospitalreleasedate = null;
                    objHospital.strCommonSerachParam = objHospital.hrbasicid.ToString();
                    var dataCurrentHspital = KAF.FacadeCreatorObjects.hr_hospitaladmissioninfoFCC.GetFacadeCreate().GetCurrentActive(objHospital);
                    var tut = (from t in data
                               select new
                               {
                                   t.hrbasicid,
                                   t.militarynokw,
                                   t.militarynobd,
                                   t.civilid,
                                   t.passportno,
                                   t.fullname,
                                   dataCurrentHspital.hospitalname,
                                   dataCurrentHspital.diseasename,
                                   dataCurrentHspital.hospitaladmissiondate,
                                   dataCurrentHspital.hospitaladmissionid,
                                   dataCurrentHspital.hospitalreleasedate
                               }).ToList();

                    result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut, responsetext = "" }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { status = KAF.MsgContainer._Status._statusFailed, recordsTotal = 0, recordsFiltered = 0, data = "", responsetext = "Data not found" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        #endregion
    }
}



