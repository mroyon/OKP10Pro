
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
    public class HRBasicProfileController : BaseController
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
        public async Task<ActionResult> HRBasicProfile()
        {
            return View("HRBasicProfileLanding");
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
        public async Task<ActionResult> HRBasicProfileTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_basicprofileEntity input)
        {
            hr_basicprofileEntity objowin_hr_basicprofile = new hr_basicprofileEntity();
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
           
                List<hr_basicprofileEntity> data = this.GetAllHRBasicProfileData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.hrbasicid,
									 t.civilid,
									 t.civilidexpiredate,
									 t.passportno,
									 t.nationalid,
									 t.bdsmartcardid,
									 t.name1,
									 t.name2,
									 t.name3,
									 t.fullname,
									 t.name1ar,
									 t.name2ar,
									 t.name3ar,
									 t.fullnamear,
									 t.dateofbirth,
									 t.joindatebd,
									 t.remarks,
									 t.profilephoto,
									 t.profilephotofilepath,
									 t.profilephotofilename,
									 t.profilephotofiletype,
									 t.profilephotofileextension,
									 t.forreview,
									 t.status,
                                   
                                   //ex_nvarchar1 = objSecPanel.genButtonPanel(t.hrbasicid.GetValueOrDefault(-99), "hrbasicid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   //"HRBasicProfile/HRBasicProfileEdit", "HRBasicProfileEdit", 
                                   //"HRBasicProfile/HRBasicProfileDelete", "HRBasicProfileDelete",
                                   //"HRBasicProfile/HRBasicProfileDetail", "HRBasicProfileDetail"),

                                   ex_nvarchar1 = (t.status == 3 || t.status == 5) ?
                                       (objSecPanel.genButtonPanel(t.hrbasicid.GetValueOrDefault(-99), "hrbasicid", this.HttpContext.User.Identity as ClaimsIdentity,
                                       "HRBasicProfile/HRBasicProfileEdit", "HRBasicProfileEdit",
                                       "", "",
                                       "HRBasicProfile/HRBasicProfileDetail", "HRBasicProfileDetail"))
                                       :
                                       (objSecPanel.genButtonPanel(t.hrbasicid.GetValueOrDefault(-99), "hrbasicid", this.HttpContext.User.Identity as ClaimsIdentity,
                                       "", "",
                                       "", "",
                                       "HRBasicProfile/HRBasicProfileDetail", "HRBasicProfileDetail"))
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
        
        
        List<hr_basicprofileEntity> GetAllHRBasicProfileData(hr_basicprofileEntity objhr_basicprofileEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_basicprofileEntity> listobjhr_basicprofileEntity = new List<hr_basicprofileEntity>();
            try
            {
                listobjhr_basicprofileEntity = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GAPgListView((objhr_basicprofileEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_basicprofileEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "civilid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "civilidexpiredate" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "passportno" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "nationalid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "bdsmartcardid" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "name1" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "name2" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "name3" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "fullname" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "name1ar" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "name2ar" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "name3ar" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "fullnamear" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "dateofbirth" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "joindatebd" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "profilephoto" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "profilephotofilepath" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "profilephotofilename" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "profilephotofiletype" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "profilephotofileextension" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "forreview" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "status" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "hrbasicid" + " " + orderDir;
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
        
        
        
         #region Create HRBasicProfile

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
        public async Task<ActionResult> HRBasicProfileNew(hr_basicprofileEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_basicprofileEntity model = new hr_basicprofileEntity();
                return PartialView("_HRBasicProfileNew", model);
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
        public async Task<ActionResult> HRBasicProfileInsert(hr_basicprofileEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("civilid");
				 ModelState.Remove("civilidexpiredate");
				 ModelState.Remove("passportno");
				 ModelState.Remove("nationalid");
				 ModelState.Remove("bdsmartcardid");
				 ModelState.Remove("name1");
				 ModelState.Remove("name2");
				 ModelState.Remove("name3");
				 ModelState.Remove("fullname");
				 ModelState.Remove("name1ar");
				 ModelState.Remove("name2ar");
				 ModelState.Remove("name3ar");
				 ModelState.Remove("fullnamear");
				 ModelState.Remove("dateofbirth");
				 ModelState.Remove("joindatebd");
				 ModelState.Remove("remarks");
				 ModelState.Remove("profilephoto");
				 ModelState.Remove("profilephotofilepath");
				 ModelState.Remove("profilephotofilename");
				 ModelState.Remove("profilephotofiletype");
				 ModelState.Remove("profilephotofileextension");
				 ModelState.Remove("forreview");
				 ModelState.Remove("status");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HRBasicProfile

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
        public async Task<ActionResult> HRBasicProfileEdit(hr_basicprofileEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = input.hrbasicid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                
                

                ModelState.Clear();
                return PartialView("_HRBasicProfileEdit", model);
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
        public async Task<ActionResult> HRBasicProfileUpdate(hr_basicprofileEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("civilid");
				 ModelState.Remove("civilidexpiredate");
				 ModelState.Remove("passportno");
				 ModelState.Remove("nationalid");
				 ModelState.Remove("bdsmartcardid");
				 ModelState.Remove("name1");
				 ModelState.Remove("name2");
				 ModelState.Remove("name3");
				 ModelState.Remove("fullname");
				 ModelState.Remove("name1ar");
				 ModelState.Remove("name2ar");
				 ModelState.Remove("name3ar");
				 ModelState.Remove("fullnamear");
				 ModelState.Remove("dateofbirth");
				 ModelState.Remove("joindatebd");
				 ModelState.Remove("remarks");
				 ModelState.Remove("profilephoto");
				 ModelState.Remove("profilephotofilepath");
				 ModelState.Remove("profilephotofilename");
				 ModelState.Remove("profilephotofiletype");
				 ModelState.Remove("profilephotofileextension");
				 ModelState.Remove("forreview");
				 ModelState.Remove("status");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HRBasicProfile

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
        public async Task<ActionResult> HRBasicProfileDelete(hr_basicprofileEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("hrbasicid"); */
				 ModelState.Remove("civilid");
				 ModelState.Remove("civilidexpiredate");
				 ModelState.Remove("passportno");
				 ModelState.Remove("nationalid");
				 ModelState.Remove("bdsmartcardid");
				 ModelState.Remove("name1");
				 ModelState.Remove("name2");
				 ModelState.Remove("name3");
				 ModelState.Remove("fullname");
				 ModelState.Remove("name1ar");
				 ModelState.Remove("name2ar");
				 ModelState.Remove("name3ar");
				 ModelState.Remove("fullnamear");
				 ModelState.Remove("dateofbirth");
				 ModelState.Remove("joindatebd");
				 ModelState.Remove("remarks");
				 ModelState.Remove("profilephoto");
				 ModelState.Remove("profilephotofilepath");
				 ModelState.Remove("profilephotofilename");
				 ModelState.Remove("profilephotofiletype");
				 ModelState.Remove("profilephotofileextension");
				 ModelState.Remove("forreview");
				 ModelState.Remove("status");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HRBasicProfile

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
        public async Task<ActionResult> HRBasicProfileDetail(hr_basicprofileEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = input.hrbasicid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                
                
                ModelState.Clear();
                return PartialView("_HRBasicProfileDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



