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
    public class UserReviewController : BaseController
    {
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();


        [LoggingFilterAttribute]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        [AllowCrossSiteJsonAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> UserReviewView()
        {
            return View();
        }


        [HttpPost]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [RequestValidationAttribute]
        [LoggingFilterAttribute]
        [ValidateAntiForgeryToken]
        [SecurityFillerAttribute]
        [AuthorizeFilterAttribute]
        public async Task<ActionResult> LoadUserDataTable([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, owin_userEntity input)
        {
            string str = string.Empty;
            List<owin_userEntity> listobjUser = new List<owin_userEntity>();
            string totalRecords = string.Empty;
            try
            {
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordsalt");
                ModelState.Remove("passwordvector");
                ModelState.Remove("password");
                ModelState.Remove("emailaddress");
                ModelState.Remove("passwordkey");
                ModelState.Remove("username");
                ModelState.Remove("mobilenumber");
                ModelState.Remove("passwordquestion");
                ModelState.Remove("passwordanswer");
                ModelState.Remove("loweredusername");
                ModelState.Remove("locked");
                ModelState.Remove("approved");
                if (this.ModelState.IsValid)
                {

                    string search = Request.Form.GetValues("search[value]")[0];
                    input.SortExpression = SortByColumnWithOrder((Request.Form.GetValues("order[0][column]"))[0], (Request.Form.GetValues("order[0][dir]"))[0]);

                    if (search != "")
                        input.username = search;
                    input.isreviewed = input.password != "-99" ? (input.password == "1" ? true : false) : (bool?)null;


                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    listobjUser = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().UserReviewGet(input).ToList();

                    if (listobjUser != null && listobjUser.Count > 0)
                    {
                        var dl = (from d in listobjUser
                                  select new
                                  {
                                      d.userid,
                                      d.masteruserid,
                                      d.username,
                                      d.loweredusername,
                                      d.emailaddress,
                                      d.mobilenumber,
                                      d.locked,
                                      d.approved,
                                      d.isreviewed,
                                      d.reviewedbyusername,
                                      revieweddate = d.revieweddate.GetValueOrDefault().ToShortDateString() + " " + d.revieweddate.GetValueOrDefault().ToShortTimeString(),
                                      comment = d.comment == null ? string.Empty : d.comment,
                                      UserProfilePhoto = d.UserProfilePhoto == null ? string.Empty : d.UserProfilePhoto,
                                      ex_nvarchar1 = "<button class='btn btn-primary btn-md' id='btnProcess'>" + KAF.MsgContainer._Common._btnProcess + " <i class='fa fa-save'></i></button>",
                                      ex_nvarchar2 = "<button class='btn btn-primary btn-md' id='btnProcessCancel'>"+ KAF.MsgContainer._Common._btnCancel +" <i class='fa fa-times'></i></button>"

                                  }).ToList();

                        totalRecords = dl.Count.ToString();
                        return this.Json(new { draw = requestModel.Draw, recordsTotal = totalRecords, recordsFiltered = totalRecords, status = KAF.MsgContainer._Status._statusSuccess, data = dl, title = "User Review Status", redirectUrl = "", responsetext = "Data found" }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        var result = this.Json(new { draw = requestModel.Draw, recordsTotal = "0", recordsFiltered = "0", status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", data = "", responsetext = "User not found as per search." }, JsonRequestBehavior.AllowGet);
                        return result;
                    }
                }
                else
                {
                    str = objModelVal.GetModelStateValidate(ModelState);
                    var result = new JsonResult
                    {
                        Data = str
                    };
                    return Json(new { draw = requestModel.Draw, recordsTotal = "0", recordsFiltered = "0", status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", data = "", responsetext = str });
                }
            }

            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
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

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<ActionResult> ReviewUserInfo(owin_userEntity input)
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
                    var detailObject = JsonConvert.DeserializeObject<List<owin_userEntity>>(input.ex_nvarchar1);

                    if (detailObject != null && detailObject.Count > 0)
                    {
                        //select* from[Split3]('1|aaa1|aaaa,2|aaa2|bbbb,3|aaa3|cccc', ',')
                        string strdet = string.Empty;
                        foreach (owin_userEntity objSingle in detailObject)
                        {
                            strdet += objSingle.masteruserid.GetValueOrDefault().ToString() + "|" + objSingle.isreviewed.GetValueOrDefault(false).ToString() + "|" + objSingle.ex_nvarchar2 + ",";
                        }
                        strdet = strdet.Remove(strdet.Length - 1);

                        SecurityCapsule sec = new SecurityCapsule();
                        sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                        input.BaseSecurityParam = sec;
                        input.CurrentState = BaseEntity.EntityState.Changed;
                        input.masprivatekey = strdet;
                        input.ex_nvarchar1 = string.Empty;

                        Int64 ret = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().UserReviewedUpdate(input);
                        if (ret > 0)
                            return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = "", responsetext = KAF.MsgContainer._Common._updateInformation });
                        else
                            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = KAF.MsgContainer._Common._generalErrorInformation });
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
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, data = "", redirectUrl = "", responsetext = ex.Message });
            }
        }
    }
}