
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
    public class HrBankAccountInfoController : BaseController
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
        public async Task<ActionResult> HrBankAccountInfo()
        {
            return View("HrBankAccountInfoLanding");
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
        public async Task<ActionResult> HrBankAccountInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_bankaccountinfoEntity input)
        {
            hr_bankaccountinfoEntity objowin_hr_bankaccountinfo = new hr_bankaccountinfoEntity();
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
           
                List<hr_bankaccountinfoEntity> data = this.GetAllHrBankAccountInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.hrbankaccountid,
									 t.hrbasicid,
									 t.bankid,
									 t.branchid,
									 t.accountno,
									 t.accountname,
									 t.accountdescription,
									 t.remarks,
									 t.forreview,
                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.hrbankaccountid.GetValueOrDefault(-99), "hrbankaccountid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrBankAccountInfo/HrBankAccountInfoEdit", "HrBankAccountInfoEdit", 
                                   "HrBankAccountInfo/HrBankAccountInfoDelete", "HrBankAccountInfoDelete",
                                   "HrBankAccountInfo/HrBankAccountInfoDetail", "HrBankAccountInfoDetail")
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
        
        
        List<hr_bankaccountinfoEntity> GetAllHrBankAccountInfoData(hr_bankaccountinfoEntity objhr_bankaccountinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_bankaccountinfoEntity> listobjhr_bankaccountinfoEntity = new List<hr_bankaccountinfoEntity>();
            try
            {
                listobjhr_bankaccountinfoEntity = KAF.FacadeCreatorObjects.hr_bankaccountinfoFCC.GetFacadeCreate().GAPgListView((objhr_bankaccountinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_bankaccountinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "hrbankaccountid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "bankid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "branchid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "accountno" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "accountname" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "accountdescription" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "forreview" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "hrbankaccountid" + " " + orderDir;
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
        
        
        
         #region Create HrBankAccountInfo

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
        public async Task<ActionResult> HrBankAccountInfoNew(hr_bankaccountinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_bankaccountinfoEntity model = new hr_bankaccountinfoEntity();
                return PartialView("_HrBankAccountInfoNew", model);
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
        public async Task<ActionResult> HrBankAccountInfoInsert(hr_bankaccountinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("hrbankaccountid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("bankid");
				 ModelState.Remove("branchid");
				 ModelState.Remove("accountno");
				 ModelState.Remove("accountname");
				 ModelState.Remove("accountdescription");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_bankaccountinfoFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrBankAccountInfo

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
        public async Task<ActionResult> HrBankAccountInfoEdit(hr_bankaccountinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrbankaccountid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbankaccountid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_bankaccountinfoFCC.GetFacadeCreate().GetAll(new hr_bankaccountinfoEntity { hrbankaccountid = input.hrbankaccountid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 List<gen_bankEntity> listgen_bank = KAF.FacadeCreatorObjects.gen_bankFCC.GetFacadeCreate().GetAll(new gen_bankEntity { bankid = model.bankid }).ToList();
					 var objgen_bank = (from t in listgen_bank
					 select new
					 {
								 Id = t.bankid ,
								 Text = t.bankname 
					  }).ToList();
					 ViewBag.preloadedGen_Bank = JsonConvert.SerializeObject(objgen_bank);

					 List<gen_bankbranchEntity> listgen_bankbranch = KAF.FacadeCreatorObjects.gen_bankbranchFCC.GetFacadeCreate().GetAll(new gen_bankbranchEntity { branchid = model.branchid }).ToList();
					 var objgen_bankbranch = (from t in listgen_bankbranch
					 select new
					 {
								 Id = t.branchid ,
								 Text = t.branchname 
					  }).ToList();
					 ViewBag.preloadedGen_BankBranch = JsonConvert.SerializeObject(objgen_bankbranch);

                
                

                ModelState.Clear();
                return PartialView("_HrBankAccountInfoEdit", model);
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
        public async Task<ActionResult> HrBankAccountInfoUpdate(hr_bankaccountinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("hrbankaccountid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("bankid");
				 ModelState.Remove("branchid");
				 ModelState.Remove("accountno");
				 ModelState.Remove("accountname");
				 ModelState.Remove("accountdescription");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_bankaccountinfoFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrBankAccountInfo

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
        public async Task<ActionResult> HrBankAccountInfoDelete(hr_bankaccountinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("hrbankaccountid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("bankid");
				 ModelState.Remove("branchid");
				 ModelState.Remove("accountno");
				 ModelState.Remove("accountname");
				 ModelState.Remove("accountdescription");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.hrbankaccountid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbankaccountid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_bankaccountinfoFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrBankAccountInfo

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
        public async Task<ActionResult> HrBankAccountInfoDetail(hr_bankaccountinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrbankaccountid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbankaccountid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_bankaccountinfoFCC.GetFacadeCreate().GetAll(new hr_bankaccountinfoEntity { hrbankaccountid = input.hrbankaccountid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 List<gen_bankEntity> listgen_bank = KAF.FacadeCreatorObjects.gen_bankFCC.GetFacadeCreate().GetAll(new gen_bankEntity { bankid = model.bankid }).ToList();
					 var objgen_bank = (from t in listgen_bank
					 select new
					 {
								 Id = t.bankid ,
								 Text = t.bankname 
					  }).ToList();
					 ViewBag.preloadedGen_Bank = JsonConvert.SerializeObject(objgen_bank);

					 List<gen_bankbranchEntity> listgen_bankbranch = KAF.FacadeCreatorObjects.gen_bankbranchFCC.GetFacadeCreate().GetAll(new gen_bankbranchEntity { branchid = model.branchid }).ToList();
					 var objgen_bankbranch = (from t in listgen_bankbranch
					 select new
					 {
								 Id = t.branchid ,
								 Text = t.branchname 
					  }).ToList();
					 ViewBag.preloadedGen_BankBranch = JsonConvert.SerializeObject(objgen_bankbranch);

                
                
                ModelState.Clear();
                return PartialView("_HrBankAccountInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



