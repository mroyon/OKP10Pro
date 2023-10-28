
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
    public class HrAddressChangeController : BaseController
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
        public async Task<ActionResult> HrAddressChange()
        {
            return View("HrAddressChangeLanding");
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
        public async Task<ActionResult> HrAddressChangeTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_addresschangeEntity input)
        {
            hr_addresschangeEntity objowin_hr_addresschange = new hr_addresschangeEntity();
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
           
                List<hr_addresschangeEntity> data = this.GetAllHrAddressChangeData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.addresschangeid,
									 t.hrbasicid,
									 t.buildingid,
									 t.kwgovid,
									 t.kwareaid,
									 t.kwblockno,
									 t.kwstreet,
									 t.kwhouseno,
									 t.kwflatno,
									 t.kwmobile,
									 t.kwviber,
									 t.personalemail,
									 t.officialemail,
									 t.bdcurdivid,
									 t.bdcurcityid,
									 t.bdcurthanaid,
									 t.bdcurpostoffice,
									 t.bdcurroad,
									 t.bdcurhouse,
									 t.bdcurflatno,
									 t.bdmob1,
									 t.bdmob2,
									 t.bdhomephone,
									 t.bdperdivid,
									 t.bdpercityid,
									 t.bdperthanaid,
									 t.bdperpostoffice,
									 t.bdperroad,
									 t.bdperhouse,
									 t.bdperflatno,
									 t.remarks,                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.addresschangeid.GetValueOrDefault(-99), "addresschangeid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrAddressChange/HrAddressChangeEdit", "HrAddressChangeEdit", 
                                   "HrAddressChange/HrAddressChangeDelete", "HrAddressChangeDelete",
                                   "HrAddressChange/HrAddressChangeDetail", "HrAddressChangeDetail")
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
        
        
        List<hr_addresschangeEntity> GetAllHrAddressChangeData(hr_addresschangeEntity objhr_addresschangeEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_addresschangeEntity> listobjhr_addresschangeEntity = new List<hr_addresschangeEntity>();
            try
            {
                listobjhr_addresschangeEntity = KAF.FacadeCreatorObjects.hr_addresschangeFCC.GetFacadeCreate().GAPgListView((objhr_addresschangeEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_addresschangeEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "addresschangeid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "buildingid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "kwgovid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "kwareaid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "kwblockno" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "kwstreet" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "kwhouseno" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "kwflatno" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "kwmobile" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "kwviber" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "personalemail" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "officialemail" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "bdcurdivid" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "bdcurcityid" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "bdcurthanaid" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "bdcurpostoffice" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "bdcurroad" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "bdcurhouse" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "bdcurflatno" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "bdmob1" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "bdmob2" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "bdhomephone" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "bdperdivid" + " " + orderDir;
							 break;
					 case "24":
							 sortingVal = "bdpercityid" + " " + orderDir;
							 break;
					 case "25":
							 sortingVal = "bdperthanaid" + " " + orderDir;
							 break;
					 case "26":
							 sortingVal = "bdperpostoffice" + " " + orderDir;
							 break;
					 case "27":
							 sortingVal = "bdperroad" + " " + orderDir;
							 break;
					 case "28":
							 sortingVal = "bdperhouse" + " " + orderDir;
							 break;
					 case "29":
							 sortingVal = "bdperflatno" + " " + orderDir;
							 break;
					 case "30":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "addresschangeid" + " " + orderDir;
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
        
        
        
         #region Create HrAddressChange

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
        public async Task<ActionResult> HrAddressChangeNew(hr_addresschangeEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_addresschangeEntity model = new hr_addresschangeEntity();
                return PartialView("_HrAddressChangeNew", model);
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
        public async Task<ActionResult> HrAddressChangeInsert(hr_addresschangeEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
/*				 ModelState.Remove("addresschangeid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("buildingid");
				 ModelState.Remove("kwgovid");
				 ModelState.Remove("kwareaid");
				 ModelState.Remove("kwblockno");
				 ModelState.Remove("kwstreet");
				 ModelState.Remove("kwhouseno");
				 ModelState.Remove("kwflatno");
				 ModelState.Remove("kwmobile");
				 ModelState.Remove("kwviber");
				 ModelState.Remove("personalemail");
				 ModelState.Remove("officialemail");
				 ModelState.Remove("bdcurdivid");
				 ModelState.Remove("bdcurcityid");
				 ModelState.Remove("bdcurthanaid");
				 ModelState.Remove("bdcurpostoffice");
				 ModelState.Remove("bdcurroad");
				 ModelState.Remove("bdcurhouse");
				 ModelState.Remove("bdcurflatno");
				 ModelState.Remove("bdmob1");
				 ModelState.Remove("bdmob2");
				 ModelState.Remove("bdhomephone");
				 ModelState.Remove("bdperdivid");
				 ModelState.Remove("bdpercityid");
				 ModelState.Remove("bdperthanaid");
				 ModelState.Remove("bdperpostoffice");
				 ModelState.Remove("bdperroad");
				 ModelState.Remove("bdperhouse");
				 ModelState.Remove("bdperflatno");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_addresschangeFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrAddressChange

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
        public async Task<ActionResult> HrAddressChangeEdit(hr_addresschangeEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.addresschangeid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("addresschangeid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_addresschangeFCC.GetFacadeCreate().GetAll(new hr_addresschangeEntity { addresschangeid = input.addresschangeid }).SingleOrDefault();
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

					 List<gen_buildingEntity> listgen_building = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().GetAll(new gen_buildingEntity { buildingid = model.buildingid }).ToList();
					 var objgen_building = (from t in listgen_building
					 select new
					 {
								 Id = t.buildingid ,
								 Text = t.buildingname 
					  }).ToList();
					 ViewBag.preloadedGen_Building = JsonConvert.SerializeObject(objgen_building);

					 List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwgovid }).ToList();
					 var objgen_govcity = (from t in listgen_govcity
					 select new
					 {
								 Id = t.cityid ,
								 Text = t.cityname 
					  }).ToList();
					 ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

					 //List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwareaid }).ToList();
					 //var objgen_govcity = (from t in listgen_govcity
					 //select new
					 //{
						//		 Id = t.cityid ,
						//		 Text = t.cityname 
					 // }).ToList();
					 //ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

					 List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurdivid }).ToList();
					 var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 select new
					 {
								 Id = t.districtid ,
								 Text = t.districtname 
					  }).ToList();
					 ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurcityid }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdcurthanaid }).ToList();
					 var objgen_thana = (from t in listgen_thana
					 select new
					 {
								 Id = t.thanaid ,
								 Text = t.thananame 
					  }).ToList();
					 ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdperdivid }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdpercityid }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdperthanaid }).ToList();
					 //var objgen_thana = (from t in listgen_thana
					 //select new
					 //{
						//		 Id = t.thanaid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

                
                

                ModelState.Clear();
                return PartialView("_HrAddressChangeEdit", model);
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
        public async Task<ActionResult> HrAddressChangeUpdate(hr_addresschangeEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("addresschangeid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("buildingid");
				 ModelState.Remove("kwgovid");
				 ModelState.Remove("kwareaid");
				 ModelState.Remove("kwblockno");
				 ModelState.Remove("kwstreet");
				 ModelState.Remove("kwhouseno");
				 ModelState.Remove("kwflatno");
				 ModelState.Remove("kwmobile");
				 ModelState.Remove("kwviber");
				 ModelState.Remove("personalemail");
				 ModelState.Remove("officialemail");
				 ModelState.Remove("bdcurdivid");
				 ModelState.Remove("bdcurcityid");
				 ModelState.Remove("bdcurthanaid");
				 ModelState.Remove("bdcurpostoffice");
				 ModelState.Remove("bdcurroad");
				 ModelState.Remove("bdcurhouse");
				 ModelState.Remove("bdcurflatno");
				 ModelState.Remove("bdmob1");
				 ModelState.Remove("bdmob2");
				 ModelState.Remove("bdhomephone");
				 ModelState.Remove("bdperdivid");
				 ModelState.Remove("bdpercityid");
				 ModelState.Remove("bdperthanaid");
				 ModelState.Remove("bdperpostoffice");
				 ModelState.Remove("bdperroad");
				 ModelState.Remove("bdperhouse");
				 ModelState.Remove("bdperflatno");
				 ModelState.Remove("remarks");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_addresschangeFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrAddressChange

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
        public async Task<ActionResult> HrAddressChangeDelete(hr_addresschangeEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("addresschangeid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("buildingid");
				 ModelState.Remove("kwgovid");
				 ModelState.Remove("kwareaid");
				 ModelState.Remove("kwblockno");
				 ModelState.Remove("kwstreet");
				 ModelState.Remove("kwhouseno");
				 ModelState.Remove("kwflatno");
				 ModelState.Remove("kwmobile");
				 ModelState.Remove("kwviber");
				 ModelState.Remove("personalemail");
				 ModelState.Remove("officialemail");
				 ModelState.Remove("bdcurdivid");
				 ModelState.Remove("bdcurcityid");
				 ModelState.Remove("bdcurthanaid");
				 ModelState.Remove("bdcurpostoffice");
				 ModelState.Remove("bdcurroad");
				 ModelState.Remove("bdcurhouse");
				 ModelState.Remove("bdcurflatno");
				 ModelState.Remove("bdmob1");
				 ModelState.Remove("bdmob2");
				 ModelState.Remove("bdhomephone");
				 ModelState.Remove("bdperdivid");
				 ModelState.Remove("bdpercityid");
				 ModelState.Remove("bdperthanaid");
				 ModelState.Remove("bdperpostoffice");
				 ModelState.Remove("bdperroad");
				 ModelState.Remove("bdperhouse");
				 ModelState.Remove("bdperflatno");
				 ModelState.Remove("remarks");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.addresschangeid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("addresschangeid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_addresschangeFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrAddressChange

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
        public async Task<ActionResult> HrAddressChangeDetail(hr_addresschangeEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.addresschangeid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("addresschangeid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_addresschangeFCC.GetFacadeCreate().GetAll(new hr_addresschangeEntity { addresschangeid = input.addresschangeid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
					 //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
					 //var objhr_basicprofile = (from t in listhr_basicprofile
					 //select new
					 //{
						//		 Id = t.hrbasicid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

					 List<gen_buildingEntity> listgen_building = KAF.FacadeCreatorObjects.gen_buildingFCC.GetFacadeCreate().GetAll(new gen_buildingEntity { buildingid = model.buildingid }).ToList();
					 var objgen_building = (from t in listgen_building
					 select new
					 {
								 Id = t.buildingid ,
								 Text = t.buildingname 
					  }).ToList();
					 ViewBag.preloadedGen_Building = JsonConvert.SerializeObject(objgen_building);

					 List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwgovid }).ToList();
					 var objgen_govcity = (from t in listgen_govcity
					 select new
					 {
								 Id = t.cityid ,
								 Text = t.cityname 
					  }).ToList();
					 ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

					 //List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwareaid }).ToList();
					 //var objgen_govcity = (from t in listgen_govcity
					 //select new
					 //{
						//		 Id = t.cityid ,
						//		 Text = t.cityname 
					 // }).ToList();
					 //ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

					 List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurdivid }).ToList();
					 var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 select new
					 {
								 Id = t.districtid ,
								 Text = t.districtname 
					  }).ToList();
					 ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurcityid }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdcurthanaid }).ToList();
					 var objgen_thana = (from t in listgen_thana
					 select new
					 {
								 Id = t.thanaid ,
								 Text = t.thananame 
					  }).ToList();
					 ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdperdivid }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_divisiondistrictEntity> listgen_divisiondistrict = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdpercityid }).ToList();
					 //var objgen_divisiondistrict = (from t in listgen_divisiondistrict
					 //select new
					 //{
						//		 Id = t.districtid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_DivisionDistrict = JsonConvert.SerializeObject(objgen_divisiondistrict);

					 //List<gen_thanaEntity> listgen_thana = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdperthanaid }).ToList();
					 //var objgen_thana = (from t in listgen_thana
					 //select new
					 //{
						//		 Id = t.thanaid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedGen_Thana = JsonConvert.SerializeObject(objgen_thana);

                
                
                ModelState.Clear();
                return PartialView("_HrAddressChangeDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



