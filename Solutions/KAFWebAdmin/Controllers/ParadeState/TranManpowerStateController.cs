
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

/// <summary>
/// 
/// </summary>
namespace KAFWebAdmin.Controllers.HR
{
    /// <summary>
    /// Man Power State
    /// </summary>
    /// <seealso cref="KAF.MVC.Common.BaseController" />
    public class TranManpowerStateController : BaseController
    {
        /// <summary>
        /// The object model value
        /// </summary>
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        /// <summary>
        /// The object CLS private
        /// </summary>
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        /// <summary>
        /// The object sec panel
        /// </summary>
        clsSecurityPanel objSecPanel = new clsSecurityPanel();
        /// <summary>
        /// The object FTP
        /// </summary>
        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();


        #region LANDING LOAD

        /// <summary>
        /// Trans the state of the manpower Landing Page
        /// </summary>
        /// <returns></returns>
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerState()
        {
            SecurityCapsule sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
            ViewBag.okpid = sec.okpid;
            return View("TranManpowerStateLanding");
        }

        //Datatable load
        /// <summary>
        /// Gets the processed data detail.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> GetProcessedDataDetail(rpt_ManpoewrStateByStatusEntity input)
        {

            tran_manpowerstateEntity objowin_tran_manpowerstate = new tran_manpowerstateEntity();
            JsonResult result = new JsonResult();
            try
            {


                var data = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().
                    GET_rpt_ManpoewrStateByStatus(input).ToList();

                if (data != null && data.Count > 0)
                {

                    return PartialView("_ProcessedDataDetail", data);
                }
                else
                    result = this.Json(new { recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
            return result;
        }

        //Datatable load
        /// <summary>
        /// Trans the manpower state table data.
        /// </summary>
        /// <param name="requestModel">The request model.</param>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, tran_manpowerstateEntity input)
        {
            tran_manpowerstateEntity objowin_tran_manpowerstate = new tran_manpowerstateEntity();
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

                List<tran_manpowerstateEntity> data = this.GetAllTranManpowerStateData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.manpowerstateid,
                                   t.okpid,
                                   t.manpowerstatedate,
                                   t.isprepared,
                                   t.prepareddate,
                                   t.preparedby,
                                   t.reviewdate,
                                   t.reviewremarks,
                                   t.isapproved,
                                   t.approvedate,
                                   t.approveby,
                                   t.approveremarks,
                                   strisprepared = t.isprepared == true ? "Yes" : "No",
                                   strisreviewed = t.isreviewed == true ? "Yes" : "No",
                                   strisapproved = t.isapproved == true ? "Yes" : "No",
                                   strprepareddate = t.prepareddate != null ? t.prepareddate.Value.ToString("dd-MMM-yyyy") : "",
                                   strmanpowerstatedate = t.manpowerstatedate != null ? t.manpowerstatedate.Value.ToString("dd-MMM-yyyy") : "",

                                   ex_nvarchar1 = genButtonPanel(t.manpowerstateid.GetValueOrDefault(-99), "manpowerstateid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   t.isreviewed != true ? "TranManpowerState/TranManpowerStateEdit" : "", "TranManpowerStateEdit",
                                   "", "TranManpowerStateDelete",
                                   "TranManpowerState/TranManpowerStateDetail", "TranManpowerStateDetail")
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

        /// <summary>
        /// Gens the button panel.
        /// </summary>
        /// <param name="menuId">The menu identifier.</param>
        /// <param name="menuName">Name of the menu.</param>
        /// <param name="claimsIdentity">The claims identity.</param>
        /// <param name="actionNameEdit">The action name edit.</param>
        /// <param name="editMethodName">Name of the edit method.</param>
        /// <param name="actionNameDelete">The action name delete.</param>
        /// <param name="deleteMethodName">Name of the delete method.</param>
        /// <param name="actionNameView">The action name view.</param>
        /// <param name="viewMethodName">Name of the view method.</param>
        /// <param name="actionNameDownload">The action name download.</param>
        /// <param name="letterstatus">The letterstatus.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">Login required</exception>
        public string genButtonPanel(long menuId, string menuName, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
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

                                strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'> <i class='fa fa-edit'> </i> Process</button> ";

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

                                strValue += "<button class='btn btn-info btn-md' onclick='" + viewMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i> " + KAF.MsgContainer._Common._btnDetail + "</button>";
                                strValue += "<button class='btn btn-info btn-md' onclick='DownloadData(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString()) + "&quot;)'><i class='fa fa-info-circle'></i>Download Report</button>";

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


        /// <summary>
        /// Gets all tran manpower state data.
        /// </summary>
        /// <param name="objtran_manpowerstateEntity">The objtran manpowerstate entity.</param>
        /// <returns></returns>
        List<tran_manpowerstateEntity> GetAllTranManpowerStateData(tran_manpowerstateEntity objtran_manpowerstateEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<tran_manpowerstateEntity> listobjtran_manpowerstateEntity = new List<tran_manpowerstateEntity>();
            try
            {
                listobjtran_manpowerstateEntity = KAF.FacadeCreatorObjects.tran_manpowerstateFCC.GetFacadeCreate().GAPgListView((objtran_manpowerstateEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjtran_manpowerstateEntity;
        }

        /// <summary>
        /// Sorts the by column with order.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <param name="orderDir">The order dir.</param>
        /// <returns></returns>
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "manpowerstateid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "okpid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "manpowerstatedate" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "isprepared" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "prepareddate" + " " + orderDir;
                        break;
                    case "5":
                        sortingVal = "preparedby" + " " + orderDir;
                        break;
                    case "6":
                        sortingVal = "reviewdate" + " " + orderDir;
                        break;
                    case "7":
                        sortingVal = "reviewremarks" + " " + orderDir;
                        break;
                    case "8":
                        sortingVal = "isapproved" + " " + orderDir;
                        break;
                    case "9":
                        sortingVal = "approvedate" + " " + orderDir;
                        break;
                    case "10":
                        sortingVal = "approveby" + " " + orderDir;
                        break;
                    case "11":
                        sortingVal = "approveremarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "manpowerstateid" + " " + orderDir;
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



        #region Create TranManpowerState

        //Create Page Load
        /// <summary>
        /// Trans the manpower state new.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateNew(KAFProcess_ManpoewrStateEntity input)
        {
            try
            {
                ModelState.Clear();
                return PartialView("_TranManpowerStateNew", input);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        //Create Page Create Action
        /// <summary>
        /// Trans the manpower state insert.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateInsert(KAFProcess_ManpoewrStateEntity input)
        {
            try
            {
                JsonResult result = new JsonResult();
                string redirectURL = "";
                string str = string.Empty;
                //Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("manpowerstateid");



                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.IsProcess = 1;

                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    var ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAFProcess_ManpoewrState(input);
                    if (ret.Count > 0)
                    {
                        ModelState.Clear();

                        return PartialView("_ProcessedData", ret);
                        //return this.Json(new { recordsTotal = ret.Count, data = ret, status = KAF.MsgContainer._Status._statusSuccess }, JsonRequestBehavior.AllowGet);
                    }
                    else
                        return this.Json(new { recordsTotal = 0, data = "", status = KAF.MsgContainer._Status._statusFailed, }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    result = new JsonResult
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


        //Create Page Create Action
        /// <summary>
        /// Trans the manpower state view processed detail.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateViewProcessedDetail(KAFProcess_ManpoewrStateEntity input)
        {
            try
            {
                JsonResult result = new JsonResult();
                string redirectURL = "";
                string str = string.Empty;
                //Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                ModelState.Remove("manpowerstateid");



                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.IsProcess = 0;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    var ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAFProcess_ManpoewrState(input);
                    if (ret.Count > 0)
                    {
                        ModelState.Clear();

                        return PartialView("_ProcessedData", ret);
                        //return this.Json(new { recordsTotal = ret.Count, data = ret, status = KAF.MsgContainer._Status._statusSuccess }, JsonRequestBehavior.AllowGet);
                    }
                    else
                        return this.Json(new { recordsTotal = 0, data = "", status = KAF.MsgContainer._Status._statusFailed, }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    result = new JsonResult
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

        #region update TranManpowerState

        //Update Page Load
        /// <summary>
        /// Trans the manpower state edit.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [SecurityFillerAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateEdit(tran_manpowerstateEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.manpowerstateid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("manpowerstateid", input.strModelPrimaryKey).ToString());

                input = KAF.FacadeCreatorObjects.tran_manpowerstateFCC.GetFacadeCreate().GetAll(new tran_manpowerstateEntity { manpowerstateid = input.manpowerstateid }).SingleOrDefault();

                var model = new KAFProcess_ManpoewrStateEntity
                {
                    OkpID = input.okpid,
                    ManpowerStateDate = input.manpowerstatedate,
                    IsProcess = 1,
                    ex_nvarchar1 = input.reviewremarks,
                    ex_nvarchar2 = input.approveremarks
                };

                ModelState.Clear();
                return PartialView("_TranManpowerStateEdit", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }


        //Update Page Update Action
        /// <summary>
        /// Trans the manpower state update.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateUpdate(tran_manpowerstateEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("manpowerstateid");
                                 ModelState.Remove("okpid");
                                 ModelState.Remove("manpowerstatedate");
                                 ModelState.Remove("isprepared");
                                 ModelState.Remove("prepareddate");
                                 ModelState.Remove("preparedby");
                                 ModelState.Remove("reviewdate");
                                 ModelState.Remove("reviewremarks");
                                 ModelState.Remove("isapproved");
                                 ModelState.Remove("approvedate");
                                 ModelState.Remove("approveby");
                                 ModelState.Remove("approveremarks");
                */
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    input.isprepared = true;
                    input.preparedby = sec.createdby;
                    input.prepareddate = DateTime.Now;

                    ret = KAF.FacadeCreatorObjects.tran_manpowerstateFCC.GetFacadeCreate().Update(input);

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

        #region delete TranManpowerState

        //Delete Page Delete Action
        /// <summary>
        /// Trans the manpower state delete.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateDelete(tran_manpowerstateEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("manpowerstateid"); */
                ModelState.Remove("okpid");
                ModelState.Remove("manpowerstatedate");
                ModelState.Remove("isprepared");
                ModelState.Remove("prepareddate");
                ModelState.Remove("preparedby");
                ModelState.Remove("reviewdate");
                ModelState.Remove("reviewremarks");
                ModelState.Remove("isapproved");
                ModelState.Remove("approvedate");
                ModelState.Remove("approveby");
                ModelState.Remove("approveremarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.manpowerstateid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("manpowerstateid", input.strModelPrimaryKey).ToString());


                    var model = KAF.FacadeCreatorObjects.tran_manpowerstateFCC.GetFacadeCreate().Delete(input);

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

        #region detail TranManpowerState

        //Detail Page Load
        /// <summary>
        /// Trans the manpower state detail.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [RequestValidationAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> TranManpowerStateDetail(tran_manpowerstateEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.manpowerstateid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("manpowerstateid", input.strModelPrimaryKey).ToString());

                input = KAF.FacadeCreatorObjects.tran_manpowerstateFCC.GetFacadeCreate().GetAll(new tran_manpowerstateEntity { manpowerstateid = input.manpowerstateid }).SingleOrDefault();

                var model = new KAFProcess_ManpoewrStateEntity
                {
                    OkpID = input.okpid,
                    ManpowerStateDate = input.manpowerstatedate,
                    IsProcess = 0,
                    ex_nvarchar1 = input.reviewremarks,
                    ex_nvarchar2 = input.approveremarks
                };

                ModelState.Clear();
                return PartialView("_TranManpowerStateDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



