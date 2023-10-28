
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
    public class HrEmergencyContactController : BaseController
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
        public async Task<ActionResult> HrEmergencyContact()
        {
            return View("HrEmergencyContactLanding");
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
        public async Task<ActionResult> HrEmergencyContactTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_emergencycontactEntity input)
        {
            hr_emergencycontactEntity objowin_hr_emergencycontact = new hr_emergencycontactEntity();
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
           
                List<hr_emergencycontactEntity> data = this.GetAllHrEmergencyContactData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.emergencycontactid,
									 t.hrbasicid,
									 t.relationshipid,
									 t.name1,
									 t.name2,
									 t.name3,
									 t.name4,
									 t.name5,
									 t.fullname,
									 t.curbdaddressflatno,
									 t.curbdaddresshouseno,
									 t.curbdaddressstreet,
									 t.curbdadrresspo,
									 t.curbdadrressps,
									 t.curbdaddressdist,
									 t.curbdaddressdivision,
									 t.mobilebd,
									 t.telephonebd,
									 t.perbdaddressflatno,
									 t.perbdaddresshouseno,
									 t.perbdaddressstreet,
									 t.perbdadrresspo,
									 t.perbdadrressps,
									 t.perbdaddressdivision,
									 t.perbdaddressdist,
									 t.curkwaddressflatno,
									 t.curkwaddresshouseno,
									 t.curkwaddressstreet,
									 t.curkwadrressblock,
									 t.curkwadrressavenue,
									 t.curkwgovnerid,
									 t.curkwareaid,
									 t.curkwpacino,
									 t.mobilekw,
									 t.telephonekw,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.emergencycontactid.GetValueOrDefault(-99), "emergencycontactid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrEmergencyContact/HrEmergencyContactEdit", "HrEmergencyContactEdit", 
                                   "HrEmergencyContact/HrEmergencyContactDelete", "HrEmergencyContactDelete",
                                   "HrEmergencyContact/HrEmergencyContactDetail", "HrEmergencyContactDetail")
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
        
        
        List<hr_emergencycontactEntity> GetAllHrEmergencyContactData(hr_emergencycontactEntity objhr_emergencycontactEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_emergencycontactEntity> listobjhr_emergencycontactEntity = new List<hr_emergencycontactEntity>();
            try
            {
                listobjhr_emergencycontactEntity = KAF.FacadeCreatorObjects.hr_emergencycontactFCC.GetFacadeCreate().GAPgListView((objhr_emergencycontactEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_emergencycontactEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "emergencycontactid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "relationshipid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "name1" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "name2" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "name3" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "name4" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "name5" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "fullname" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "curbdaddressflatno" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "curbdaddresshouseno" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "curbdaddressstreet" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "curbdadrresspo" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "curbdadrressps" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "curbdaddressdist" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "curbdaddressdivision" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "mobilebd" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "telephonebd" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "perbdaddressflatno" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "perbdaddresshouseno" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "perbdaddressstreet" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "perbdadrresspo" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "perbdadrressps" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "perbdaddressdivision" + " " + orderDir;
							 break;
					 case "24":
							 sortingVal = "perbdaddressdist" + " " + orderDir;
							 break;
					 case "25":
							 sortingVal = "curkwaddressflatno" + " " + orderDir;
							 break;
					 case "26":
							 sortingVal = "curkwaddresshouseno" + " " + orderDir;
							 break;
					 case "27":
							 sortingVal = "curkwaddressstreet" + " " + orderDir;
							 break;
					 case "28":
							 sortingVal = "curkwadrressblock" + " " + orderDir;
							 break;
					 case "29":
							 sortingVal = "curkwadrressavenue" + " " + orderDir;
							 break;
					 case "30":
							 sortingVal = "curkwgovnerid" + " " + orderDir;
							 break;
					 case "31":
							 sortingVal = "curkwareaid" + " " + orderDir;
							 break;
					 case "32":
							 sortingVal = "curkwpacino" + " " + orderDir;
							 break;
					 case "33":
							 sortingVal = "mobilekw" + " " + orderDir;
							 break;
					 case "34":
							 sortingVal = "telephonekw" + " " + orderDir;
							 break;
					 case "35":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "emergencycontactid" + " " + orderDir;
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
        
        
        
         #region Create HrEmergencyContact

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
        public async Task<ActionResult> HrEmergencyContactNew(hr_emergencycontactEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_emergencycontactEntity model = new hr_emergencycontactEntity();
                return PartialView("_HrEmergencyContactNew", model);
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
        public async Task<ActionResult> HrEmergencyContactInsert(hr_emergencycontactEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("emergencycontactid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("relationshipid");
				 ModelState.Remove("name1");
				 ModelState.Remove("name2");
				 ModelState.Remove("name3");
				 ModelState.Remove("name4");
				 ModelState.Remove("name5");
				 ModelState.Remove("fullname");
				 ModelState.Remove("curbdaddressflatno");
				 ModelState.Remove("curbdaddresshouseno");
				 ModelState.Remove("curbdaddressstreet");
				 ModelState.Remove("curbdadrresspo");
				 ModelState.Remove("curbdadrressps");
				 ModelState.Remove("curbdaddressdist");
				 ModelState.Remove("curbdaddressdivision");
				 ModelState.Remove("mobilebd");
				 ModelState.Remove("telephonebd");
				 ModelState.Remove("perbdaddressflatno");
				 ModelState.Remove("perbdaddresshouseno");
				 ModelState.Remove("perbdaddressstreet");
				 ModelState.Remove("perbdadrresspo");
				 ModelState.Remove("perbdadrressps");
				 ModelState.Remove("perbdaddressdivision");
				 ModelState.Remove("perbdaddressdist");
				 ModelState.Remove("curkwaddressflatno");
				 ModelState.Remove("curkwaddresshouseno");
				 ModelState.Remove("curkwaddressstreet");
				 ModelState.Remove("curkwadrressblock");
				 ModelState.Remove("curkwadrressavenue");
				 ModelState.Remove("curkwgovnerid");
				 ModelState.Remove("curkwareaid");
				 ModelState.Remove("curkwpacino");
				 ModelState.Remove("mobilekw");
				 ModelState.Remove("telephonekw");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_emergencycontactFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrEmergencyContact

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
        public async Task<ActionResult> HrEmergencyContactEdit(hr_emergencycontactEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.emergencycontactid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("emergencycontactid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_emergencycontactFCC.GetFacadeCreate().GetAll(new hr_emergencycontactEntity { emergencycontactid = input.emergencycontactid }).SingleOrDefault();
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

					 List<gen_relationshipEntity> listgen_relationship = KAF.FacadeCreatorObjects.gen_relationshipFCC.GetFacadeCreate().GetAll(new gen_relationshipEntity { relationshipid = model.relationshipid }).ToList();
					 var objgen_relationship = (from t in listgen_relationship
					 select new
					 {
								 Id = t.relationshipid ,
								 Text = t.relationshipname 
					  }).ToList();
					 ViewBag.preloadedGen_Relationship = JsonConvert.SerializeObject(objgen_relationship);

					 List<gen_postofficeEntity> listgen_postoffice = KAF.FacadeCreatorObjects.gen_postofficeFCC.GetFacadeCreate().GetAll(new gen_postofficeEntity { postofficeid = model.curbdadrresspo }).ToList();
					 var objgen_postoffice = (from t in listgen_postoffice
					 select new
					 {
								 Id = t.postofficeid ,
								 Text = t.postofficename 
					  }).ToList();
					 ViewBag.preloadedGen_PostOffice = JsonConvert.SerializeObject(objgen_postoffice);

					 List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.curbdadrressps }).ToList();
					 var objgen_thana = (from t in listgen_thana
					 select new
					 {
								 Id = t.thanaid ,
								 Text = t.thananame 
					  }).ToList();
					 ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

					 List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.curbdaddressdist }).ToList();
					 var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 select new
					 {
								 Id = t.districtid ,
								 Text = t.districtname 
					  }).ToList();
					 ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.curbdaddressdivision }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_postofficeEntity> listgen_postoffice = KAF.FacadeCreatorObjects.gen_postofficeFCC.GetFacadeCreate().GetAll(new gen_postofficeEntity { postofficeid = model.perbdadrresspo }).ToList();
					 //var objgen_postoffice = (from t in listgen_postoffice
					 //select new
					 //{
						//		 Id = t.postofficeid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_PostOffice = JsonConvert.SerializeObject(objgen_postoffice);

					 //List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.perbdadrressps }).ToList();
					 //var objgen_thana = (from t in listgen_thana
					 //select new
					 //{
						//		 Id = t.thanaid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.perbdaddressdivision }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.perbdaddressdist }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.curkwgovnerid }).ToList();
					 var objgen_govcity = (from t in listgen_govcity
					 select new
					 {
								 Id = t.cityid ,
								 Text = t.cityname 
					  }).ToList();
					 ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

					 //List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.curkwareaid }).ToList();
					 //var objgen_govcity = (from t in listgen_govcity
					 //select new
					 //{
						//		 Id = t.cityid ,
						//		 Text = t.cityname 
					 // }).ToList();
					 //ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

                
                

                ModelState.Clear();
                return PartialView("_HrEmergencyContactEdit", model);
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
        public async Task<ActionResult> HrEmergencyContactUpdate(hr_emergencycontactEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("emergencycontactid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("relationshipid");
				 ModelState.Remove("name1");
				 ModelState.Remove("name2");
				 ModelState.Remove("name3");
				 ModelState.Remove("name4");
				 ModelState.Remove("name5");
				 ModelState.Remove("fullname");
				 ModelState.Remove("curbdaddressflatno");
				 ModelState.Remove("curbdaddresshouseno");
				 ModelState.Remove("curbdaddressstreet");
				 ModelState.Remove("curbdadrresspo");
				 ModelState.Remove("curbdadrressps");
				 ModelState.Remove("curbdaddressdist");
				 ModelState.Remove("curbdaddressdivision");
				 ModelState.Remove("mobilebd");
				 ModelState.Remove("telephonebd");
				 ModelState.Remove("perbdaddressflatno");
				 ModelState.Remove("perbdaddresshouseno");
				 ModelState.Remove("perbdaddressstreet");
				 ModelState.Remove("perbdadrresspo");
				 ModelState.Remove("perbdadrressps");
				 ModelState.Remove("perbdaddressdivision");
				 ModelState.Remove("perbdaddressdist");
				 ModelState.Remove("curkwaddressflatno");
				 ModelState.Remove("curkwaddresshouseno");
				 ModelState.Remove("curkwaddressstreet");
				 ModelState.Remove("curkwadrressblock");
				 ModelState.Remove("curkwadrressavenue");
				 ModelState.Remove("curkwgovnerid");
				 ModelState.Remove("curkwareaid");
				 ModelState.Remove("curkwpacino");
				 ModelState.Remove("mobilekw");
				 ModelState.Remove("telephonekw");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_emergencycontactFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrEmergencyContact

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
        public async Task<ActionResult> HrEmergencyContactDelete(hr_emergencycontactEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("emergencycontactid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("relationshipid");
				 ModelState.Remove("name1");
				 ModelState.Remove("name2");
				 ModelState.Remove("name3");
				 ModelState.Remove("name4");
				 ModelState.Remove("name5");
				 ModelState.Remove("fullname");
				 ModelState.Remove("curbdaddressflatno");
				 ModelState.Remove("curbdaddresshouseno");
				 ModelState.Remove("curbdaddressstreet");
				 ModelState.Remove("curbdadrresspo");
				 ModelState.Remove("curbdadrressps");
				 ModelState.Remove("curbdaddressdist");
				 ModelState.Remove("curbdaddressdivision");
				 ModelState.Remove("mobilebd");
				 ModelState.Remove("telephonebd");
				 ModelState.Remove("perbdaddressflatno");
				 ModelState.Remove("perbdaddresshouseno");
				 ModelState.Remove("perbdaddressstreet");
				 ModelState.Remove("perbdadrresspo");
				 ModelState.Remove("perbdadrressps");
				 ModelState.Remove("perbdaddressdivision");
				 ModelState.Remove("perbdaddressdist");
				 ModelState.Remove("curkwaddressflatno");
				 ModelState.Remove("curkwaddresshouseno");
				 ModelState.Remove("curkwaddressstreet");
				 ModelState.Remove("curkwadrressblock");
				 ModelState.Remove("curkwadrressavenue");
				 ModelState.Remove("curkwgovnerid");
				 ModelState.Remove("curkwareaid");
				 ModelState.Remove("curkwpacino");
				 ModelState.Remove("mobilekw");
				 ModelState.Remove("telephonekw");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.emergencycontactid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("emergencycontactid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_emergencycontactFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrEmergencyContact

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
        public async Task<ActionResult> HrEmergencyContactDetail(hr_emergencycontactEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.emergencycontactid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("emergencycontactid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_emergencycontactFCC.GetFacadeCreate().GetAll(new hr_emergencycontactEntity { emergencycontactid = input.emergencycontactid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 List<gen_relationshipEntity> listgen_relationship = KAF.FacadeCreatorObjects.gen_relationshipFCC.GetFacadeCreate().GetAll(new gen_relationshipEntity { relationshipid = model.relationshipid }).ToList();
					 var objgen_relationship = (from t in listgen_relationship
					 select new
					 {
								 Id = t.relationshipid ,
								 Text = t.relationshipname 
					  }).ToList();
					 ViewBag.preloadedGen_Relationship = JsonConvert.SerializeObject(objgen_relationship);

					 List<gen_postofficeEntity> listgen_postoffice = KAF.FacadeCreatorObjects.gen_postofficeFCC.GetFacadeCreate().GetAll(new gen_postofficeEntity { postofficeid = model.curbdadrresspo }).ToList();
					 var objgen_postoffice = (from t in listgen_postoffice
					 select new
					 {
								 Id = t.postofficeid ,
								 Text = t.postofficename 
					  }).ToList();
					 ViewBag.preloadedGen_PostOffice = JsonConvert.SerializeObject(objgen_postoffice);

					 List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.curbdadrressps }).ToList();
					 var objgen_thana = (from t in listgen_thana
					 select new
					 {
								 Id = t.thanaid ,
								 Text = t.thananame 
					  }).ToList();
					 ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

					 List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.curbdaddressdist }).ToList();
					 var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 select new
					 {
								 Id = t.districtid ,
								 Text = t.districtname 
					  }).ToList();
					 ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.curbdaddressdivision }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_postofficeEntity> listgen_postoffice = KAF.FacadeCreatorObjects.gen_postofficeFCC.GetFacadeCreate().GetAll(new gen_postofficeEntity { postofficeid = model.perbdadrresspo }).ToList();
					 //var objgen_postoffice = (from t in listgen_postoffice
					 //select new
					 //{
						//		 Id = t.postofficeid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_PostOffice = JsonConvert.SerializeObject(objgen_postoffice);

					 //List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.perbdadrressps }).ToList();
					 //var objgen_thana = (from t in listgen_thana
					 //select new
					 //{
						//		 Id = t.thanaid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.perbdaddressdivision }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.perbdaddressdist }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.curkwgovnerid }).ToList();
					 var objgen_govcity = (from t in listgen_govcity
					 select new
					 {
								 Id = t.cityid ,
								 Text = t.cityname 
					  }).ToList();
					 ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

					 //List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.curkwareaid }).ToList();
					 //var objgen_govcity = (from t in listgen_govcity
					 //select new
					 //{
						//		 Id = t.cityid ,
						//		 Text = t.cityname 
					 // }).ToList();
					 //ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

                
                
                ModelState.Clear();
                return PartialView("_HrEmergencyContactDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



