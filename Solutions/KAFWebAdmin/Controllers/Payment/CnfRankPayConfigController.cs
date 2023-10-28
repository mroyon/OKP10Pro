
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
    public class CnfRankPayConfigController : BaseController
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
        public async Task<ActionResult> CnfRankPayConfig()
        {
            return View("CnfRankPayConfigLanding");
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
        public async Task<ActionResult> CnfRankPayConfigTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, cnf_rankpayconfigEntity input)
        {
            cnf_rankpayconfigEntity objowin_cnf_rankpayconfig = new cnf_rankpayconfigEntity();
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

                List<cnf_rankpayconfigEntity> data = this.GetAllCnfRankPayConfigData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.payconfigid,
                                   t.rankid,
                                   t.basicsalary,
                                   strrank = t.ex_nvarchar1,
                                   strpaymentitem = t.ex_nvarchar2,
                                   strdrpgroup = @"<select disabled='disabled' class='form-control groupid'   name='groupid'><option value=''>Please Select</option>
                                                    <option value='1' " + (t.groupid == 1 ? " selected='selected' " : "") + @">Technical</option>
                                                    <option value='2' " + (t.groupid == 2 ? " selected='selected' " : "") + @">Support</option>
                                                   </select>",
                                   t.remarks,
                                   txtgovtcutting = t.govtcutting != null ? "<input payconfigid='" + t.payconfigid.ToString() + "'  type='number' class='form-control txtgovtcutting' value='" + t.govtcutting.ToString() + "' placeholder='Amount'>"
                                   : "<input type='number' payconfigid='" + t.payconfigid.ToString() + "'  value='' class='form-control txtgovtcutting' placeholder='Amount'>",

                                   ex_nvarchar1 = genButtonPanel(t.payconfigid.GetValueOrDefault(-99), "payconfigid", t.rankid.GetValueOrDefault(-99), "rankid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "CnfRankPayConfig/CnfRankPayConfigEdit", "CnfRankPayConfigEdit",

                                   "", "CnfRankPayConfigDelete",
                                   "", "CnfRankPayConfigDetail")
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

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AllowCrossSiteJsonAttribute]
        [ValidateAntiForgeryToken]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> CnfGroupRankTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, KAF_GetRankByGroupEntity input)
        {
            cnf_rankpayconfigEntity objowin_cnf_rankpayconfig = new cnf_rankpayconfigEntity();
            JsonResult result = new JsonResult();
            try
            {
                string search = Request.Form.GetValues("search[value]")[0];
                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];


                var data = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetRankByGroup(
                    new KAF_GetRankByGroupEntity { GroupID = input.GroupID });

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {

                                   t.RankID,
                                   t.RankName,
                                   strgroup = t.GroupID == 2 ? "Support" : "Technical",

                                   txtamount = "<input  type='number' rankid='" + t.RankID + "' groupid='" + t.GroupID + "' class='form-control txtamount' value='' placeholder='Amount'>",

                                   ex_nvarchar1 = genButtonPanel(t.RankID.GetValueOrDefault(-99), "rankid", t.GroupID.GetValueOrDefault(-99), "groupid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "", "CnfRankPayConfigEdit",
                                   "", "CnfRankPayConfigDelete",
                                   "", "CnfRankPayConfigDetail")
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

        private string genButtonPanel(long menuId, string menuName, long rankid, string strrankid, ClaimsIdentity claimsIdentity, string actionNameEdit, string editMethodName,
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

                                strValue += "<button class='btn btn-primary btn-md' onclick ='" + editMethodName + "(&quot;" + objClsPrivate.BuildUrlMVCOnlyParams(menuName, menuId.ToString(), strrankid, rankid.ToString()) + "&quot;,this)'> <i class='fa fa-edit'> </i> " + KAF.MsgContainer._Common._btnUpdate + "</button> ";

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

        List<cnf_rankpayconfigEntity> GetAllCnfRankPayConfigData(cnf_rankpayconfigEntity objcnf_rankpayconfigEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<cnf_rankpayconfigEntity> listobjcnf_rankpayconfigEntity = new List<cnf_rankpayconfigEntity>();
            try
            {
                //objcnf_rankpayconfigEntity.isconfig = true;
                listobjcnf_rankpayconfigEntity = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().GAPgListView((objcnf_rankpayconfigEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjcnf_rankpayconfigEntity;
        }

        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
                    case "0":
                        sortingVal = "rankid" + " " + orderDir;
                        break;
                    case "1":
                        sortingVal = "rankid" + " " + orderDir;
                        break;
                    case "2":
                        sortingVal = "basicsalary" + " " + orderDir;
                        break;
                    case "3":
                        sortingVal = "regimentalcutting" + " " + orderDir;
                        break;
                    case "4":
                        sortingVal = "remarks" + " " + orderDir;
                        break;
                    default:
                        sortingVal = "payconfigid" + " " + orderDir;
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



        #region Create CnfRankPayConfig

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
        public async Task<ActionResult> CnfRankPayConfigNew(cnf_rankpayconfigEntity input)
        {
            try
            {
                ModelState.Clear();
                cnf_rankpayconfigEntity model = new cnf_rankpayconfigEntity();
                model.payallceid = input.payallceid;
                return PartialView("_CnfRankPayConfigNew", model);
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
        public async Task<ActionResult> CnfRankPayConfigInsert(cnf_rankpayconfigEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;

                ModelState.Remove("govtcutting");
                ModelState.Remove("rankid");

                SecurityCapsule sec = new SecurityCapsule();
                /*				 ModelState.Remove("payconfigid");
                                 ModelState.Remove("rankid");
                                 ModelState.Remove("basicsalary");
                                 ModelState.Remove("regimentalcutting");
                                 ModelState.Remove("remarks");
                */
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));


                    //var objmappedranks = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().GetAll(new cnf_rankpayconfigEntity { 
                    //    rankid=input.rankid,groupid=input.groupid
                    //}).ToList();

                    //if(objmappedranks.Count()>0)
                    //{
                    //    ModelState.Clear();
                    //    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = redirectURL, responsetext = "Rank is already configured for this Group" });

                    //}

                    var list = new List<cnf_rankpayconfigEntity>();
                    foreach (var objsingle in input.RankByGroupList)
                    {
                        cnf_rankpayconfigEntity obj = new cnf_rankpayconfigEntity();
                        obj.payallceid = input.payallceid;
                        obj.rankid = objsingle.RankID;
                        obj.groupid = input.groupid;
                        obj.govtcutting = objsingle.ex_decimal1;
                        obj.BaseSecurityParam = sec;
                        obj.CurrentState = BaseEntity.EntityState.Added;

                        list.Add(obj);
                    }

                    ret = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().SaveList(list);
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


        #region update CnfRankPayConfig

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
        public async Task<ActionResult> CnfRankPayConfigEdit(cnf_rankpayconfigEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.payconfigid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("payconfigid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().GetAll(new cnf_rankpayconfigEntity { payconfigid = input.payconfigid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN



                ModelState.Clear();
                return PartialView("_CnfRankPayConfigEdit", model);
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
        public async Task<ActionResult> CnfRankPayConfigUpdate(cnf_rankpayconfigEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                ModelState.Remove("rankid");
                ModelState.Remove("groupid");
                ModelState.Remove("govtcutting");
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("payconfigid");
                                 ModelState.Remove("rankid");
                                 ModelState.Remove("basicsalary");
                                 ModelState.Remove("regimentalcutting");
                                 ModelState.Remove("remarks");
                */
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    var objmodel = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().GetAll(new cnf_rankpayconfigEntity
                    {
                        payconfigid = input.payconfigid
                    }).FirstOrDefault();

                    objmodel.govtcutting = input.govtcutting;

                    //input.payconfigid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("payconfigid", input.strModelPrimaryKey).ToString());
                    //input.rankid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("rankid", input.strModelPrimaryKey).ToString());


                    ret = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().Update(objmodel);


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

        #region delete CnfRankPayConfig

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
        public async Task<ActionResult> CnfRankPayConfigDelete(cnf_rankpayconfigEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
            Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /* ModelState.Remove("payconfigid"); */
                ModelState.Remove("rankid");
                ModelState.Remove("basicsalary");
                ModelState.Remove("regimentalcutting");
                ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.payconfigid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("payconfigid", input.strModelPrimaryKey).ToString());


                    var model = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().Delete(input);

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

        #region detail CnfRankPayConfig

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
        public async Task<ActionResult> CnfRankPayConfigDetail(cnf_rankpayconfigEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.payconfigid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("payconfigid", input.strModelPrimaryKey).ToString());

                var model = KAF.FacadeCreatorObjects.cnf_rankpayconfigFCC.GetFacadeCreate().GetAll(new cnf_rankpayconfigEntity { payconfigid = input.payconfigid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;


                ModelState.Clear();
                return PartialView("_CnfRankPayConfigDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion

    }
}



