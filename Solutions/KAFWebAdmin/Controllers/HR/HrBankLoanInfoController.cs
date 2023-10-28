
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
    public class HrBankLoanInfoController : BaseController
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
        public async Task<ActionResult> HrBankLoanInfo()
        {
            return View("HrBankLoanInfoLanding");
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
        public async Task<ActionResult> HrBankLoanInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_bankloaninfoEntity input)
        {
            hr_bankloaninfoEntity objowin_hr_bankloaninfo = new hr_bankloaninfoEntity();
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
           
                List<hr_bankloaninfoEntity> data = this.GetAllHrBankLoanInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.hrbankloanid,
									 t.hrbasicid,
									 t.bankid,
									 t.branchid,
									 t.loanamount,
									 t.lastpaiddate,
									 t.islastinstallmentpaid,
									 t.description,
									 t.remarks,
									 t.forreview,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.hrbankloanid.GetValueOrDefault(-99), "hrbankloanid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrBankLoanInfo/HrBankLoanInfoEdit", "HrBankLoanInfoEdit", 
                                   "HrBankLoanInfo/HrBankLoanInfoDelete", "HrBankLoanInfoDelete",
                                   "HrBankLoanInfo/HrBankLoanInfoDetail", "HrBankLoanInfoDetail")
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
        
        
        List<hr_bankloaninfoEntity> GetAllHrBankLoanInfoData(hr_bankloaninfoEntity objhr_bankloaninfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_bankloaninfoEntity> listobjhr_bankloaninfoEntity = new List<hr_bankloaninfoEntity>();
            try
            {
                listobjhr_bankloaninfoEntity = KAF.FacadeCreatorObjects.hr_bankloaninfoFCC.GetFacadeCreate().GAPgListView((objhr_bankloaninfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_bankloaninfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "hrbankloanid" + " " + orderDir;
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
							 sortingVal = "loanamount" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "lastpaiddate" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "islastinstallmentpaid" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "description" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "forreview" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "hrbankloanid" + " " + orderDir;
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
        
        
        
         #region Create HrBankLoanInfo

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
        public async Task<ActionResult> HrBankLoanInfoNew(hr_bankloaninfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_bankloaninfoEntity model = new hr_bankloaninfoEntity();
                return PartialView("_HrBankLoanInfoNew", model);
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
        public async Task<ActionResult> HrBankLoanInfoInsert(hr_bankloaninfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("hrbankloanid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("bankid");
				 ModelState.Remove("branchid");
				 ModelState.Remove("loanamount");
				 ModelState.Remove("lastpaiddate");
				 ModelState.Remove("islastinstallmentpaid");
				 ModelState.Remove("description");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_bankloaninfoFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrBankLoanInfo

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
        public async Task<ActionResult> HrBankLoanInfoEdit(hr_bankloaninfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrbankloanid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbankloanid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_bankloaninfoFCC.GetFacadeCreate().GetAll(new hr_bankloaninfoEntity { hrbankloanid = input.hrbankloanid }).SingleOrDefault();
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
                return PartialView("_HrBankLoanInfoEdit", model);
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
        public async Task<ActionResult> HrBankLoanInfoUpdate(hr_bankloaninfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("hrbankloanid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("bankid");
				 ModelState.Remove("branchid");
				 ModelState.Remove("loanamount");
				 ModelState.Remove("lastpaiddate");
				 ModelState.Remove("islastinstallmentpaid");
				 ModelState.Remove("description");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_bankloaninfoFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrBankLoanInfo

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
        public async Task<ActionResult> HrBankLoanInfoDelete(hr_bankloaninfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("hrbankloanid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("bankid");
				 ModelState.Remove("branchid");
				 ModelState.Remove("loanamount");
				 ModelState.Remove("lastpaiddate");
				 ModelState.Remove("islastinstallmentpaid");
				 ModelState.Remove("description");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.hrbankloanid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbankloanid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_bankloaninfoFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrBankLoanInfo

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
        public async Task<ActionResult> HrBankLoanInfoDetail(hr_bankloaninfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrbankloanid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbankloanid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_bankloaninfoFCC.GetFacadeCreate().GetAll(new hr_bankloaninfoEntity { hrbankloanid = input.hrbankloanid }).SingleOrDefault();
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
                return PartialView("_HrBankLoanInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



