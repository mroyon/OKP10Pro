
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
using System.IO;
using KAF.AppConfiguration.Configuration;

namespace KAFWebAdmin.Controllers.HR
{
    public class HrPersonalInfoController : BaseController
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
        public async Task<ActionResult> HrPersonalInfo()
        {
            return View("HrPersonalInfoLanding");
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
        public async Task<ActionResult> HrPersonalInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_personalinfoEntity input)
        {
            hr_personalinfoEntity objowin_hr_personalinfo = new hr_personalinfoEntity();
            JsonResult result = new JsonResult();
            try
            {
                string search = Request.Form.GetValues("search[value]")[0];
                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                //input.lonVal1 = sec.okpid;

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

                #region Check if Military person exists
                hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
                objhr_svcinfo.militarynokw = input.militarynokw;
                objhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).SingleOrDefault();

                if (objhr_svcinfo != null)
                {
                    input.hrbasicid = objhr_svcinfo.hrbasicid;
                    if (sec.okpid != null && sec.okpid != objhr_svcinfo.okpid)
                    {
                        result = this.Json(new { draw = requestModel.Draw, recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);
                        return result;
                    }
                }
                else
                {
                    result = this.Json(new { draw = requestModel.Draw, recordsTotal = 0, recordsFiltered = 0, data = "" }, JsonRequestBehavior.AllowGet);
                    return result;
                }

                #endregion

                List<hr_personalinfoEntity> data = this.GetAllHrPersonalInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.militarynokw,

                                   t.hrpersonalinfoid,
                                   t.hrbasicid,
                                   t.religionid,
                                   t.bloodgroupid,
                                   t.maritalstatusid,
                                   t.genderid,
                                   t.nationalityid,
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
                                   strstatus= KAF.ConstantTypes.clsSystemConstantTypes.GetStats(t.SvcStatus),

                                   //ex_nvarchar1 = objSecPanel.genButtonPanel(t.hrpersonalinfoid.GetValueOrDefault(-99), "hrpersonalinfoid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   //"HrPersonalInfo/HrPersonalInfoEdit", "HrPersonalInfoEdit",
                                   //"", "",
                                   //"HrPersonalInfo/HrPersonalInfoDetail", "HrPersonalInfoDetail"),
                                   ex_nvarchar1 = (t.SvcStatus == 3 || t.SvcStatus == 5) ?
                                       (objSecPanel.genButtonPanel(t.hrpersonalinfoid.GetValueOrDefault(-99), "hrpersonalinfoid", this.HttpContext.User.Identity as ClaimsIdentity,
                                       "HrPersonalInfo/HrPersonalInfoEdit", "HrPersonalInfoEdit",
                                       "", "",
                                       "HrPersonalInfo/HrPersonalInfoDetail", "HrPersonalInfoDetail",
                                       "",-99,
                                       "HrDocumentUpload/HrDocumentUpload", "HrDocumentUpload"))
                                       :
                                       (objSecPanel.genButtonPanel(t.hrpersonalinfoid.GetValueOrDefault(-99), "hrpersonalinfoid", this.HttpContext.User.Identity as ClaimsIdentity,
                                       "", "",
                                       "", "",
                                       "HrPersonalInfo/HrPersonalInfoDetail", "HrPersonalInfoDetail"))
                               }).ToList();

                    result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, draw = requestModel.Draw, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
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
        
        
        List<hr_personalinfoEntity> GetAllHrPersonalInfoData(hr_personalinfoEntity objhr_personalinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);

            //hr_personalinfoEntity objhr_personalinfo = new hr_personalinfoEntity();
            //hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
            //objhr_svcinfo.militarynokw = objhr_personalinfoEntity.militarynokw;
            //objhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).SingleOrDefault();
            
            List<hr_personalinfoEntity> listobjhr_personalinfoEntity = new List<hr_personalinfoEntity>();
            try
            {
                listobjhr_personalinfoEntity = KAF.FacadeCreatorObjects.hr_personalinfoFCC.GetFacadeCreate().GetAll_Ext((objhr_personalinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_personalinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "hrpersonalinfoid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "religionid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "bloodgroupid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "maritalstatusid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "genderid" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "nationalityid" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "buildingid" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "kwgovid" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "kwareaid" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "kwblockno" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "kwstreet" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "kwhouseno" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "kwflatno" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "kwmobile" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "kwviber" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "personalemail" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "officialemail" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "bdcurdivid" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "bdcurcityid" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "bdcurthanaid" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "bdcurpostoffice" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "bdcurroad" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "bdcurhouse" + " " + orderDir;
							 break;
					 case "24":
							 sortingVal = "bdcurflatno" + " " + orderDir;
							 break;
					 case "25":
							 sortingVal = "bdmob1" + " " + orderDir;
							 break;
					 case "26":
							 sortingVal = "bdmob2" + " " + orderDir;
							 break;
					 case "27":
							 sortingVal = "bdhomephone" + " " + orderDir;
							 break;
					 case "28":
							 sortingVal = "bdperdivid" + " " + orderDir;
							 break;
					 case "29":
							 sortingVal = "bdpercityid" + " " + orderDir;
							 break;
					 case "30":
							 sortingVal = "bdperthanaid" + " " + orderDir;
							 break;
					 case "31":
							 sortingVal = "bdperpostoffice" + " " + orderDir;
							 break;
					 case "32":
							 sortingVal = "bdperroad" + " " + orderDir;
							 break;
					 case "33":
							 sortingVal = "bdperhouse" + " " + orderDir;
							 break;
					 case "34":
							 sortingVal = "bdperflatno" + " " + orderDir;
							 break;
					 case "35":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "hrpersonalinfoid" + " " + orderDir;
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
        
        
        
         #region Create HrPersonalInfo

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
        public async Task<ActionResult> HrPersonalInfoNew(hr_personalinfoEntity input)
        {
            try
            {
                ModelState.Clear();
                hr_personalinfoEntity model = new hr_personalinfoEntity();

                hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
                objhr_svcinfo.militarynokw = input.militarynokw;
                objhr_svcinfo = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).SingleOrDefault();
                if (objhr_svcinfo != null)
                {
                    input.hrbasicid = objhr_svcinfo.hrbasicid;

                    return PartialView("_HrPersonalInfoNew", input);
                }
                else
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "No Data Found" });

                }
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
        public async Task<ActionResult> HrPersonalInfoInsert(hr_personalinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                /*				 ModelState.Remove("hrpersonalinfoid");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("religionid");
                                 ModelState.Remove("bloodgroupid");
                                 ModelState.Remove("maritalstatusid");
                                 ModelState.Remove("genderid");
                                 ModelState.Remove("nationalityid");
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
                ModelState.Remove("hrbasicid");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));
                    
					 ret = KAF.FacadeCreatorObjects.hr_personalinfoFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrPersonalInfo

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
        public async Task<ActionResult> HrPersonalInfoEdit(hr_personalinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrpersonalinfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrpersonalinfoid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_personalinfoFCC.GetFacadeCreate().GetAll(new hr_personalinfoEntity { hrpersonalinfoid = input.hrpersonalinfoid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.militarynokw = input.militarynokw;

                var Cachegen_religion = new DataCacheController().GetCacheData(clsDataCache.gen_religionEntity[0].ToString());
                if (model.religionid != null)
                {
                    var objgen_religion = Cachegen_religion.Where(p => p.comId == model.religionid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Religion = JsonConvert.SerializeObject(objgen_religion);
                }

                var Cachegen_bloodgroup = new DataCacheController().GetCacheData(clsDataCache.gen_bloodgroupEntity[0].ToString());
                if (model.bloodgroupid != null)
                {
                    var objgen_bloodgroup = Cachegen_bloodgroup.Where(p => p.comId == model.bloodgroupid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_BloodGroup = JsonConvert.SerializeObject(objgen_bloodgroup);
                }

                var Cachegen_maritalstatus = new DataCacheController().GetCacheData(clsDataCache.gen_maritalstatusEntity[0].ToString());
                if (model.maritalstatusid != null)
                {
                    var objgen_maritalstatus = Cachegen_maritalstatus.Where(p => p.comId == model.maritalstatusid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_MaritalStatus = JsonConvert.SerializeObject(objgen_maritalstatus);
                }

                var Cachegen_gender = new DataCacheController().GetCacheData(clsDataCache.gen_genderEntity[0].ToString());
                if (model.genderid != null)
                {
                    var objgen_gender = Cachegen_gender.Where(p => p.comId == model.genderid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Gender = JsonConvert.SerializeObject(objgen_gender);
                }
                
                List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.nationalityid }).ToList();
                var objgen_country = (from t in listgen_country
                                      select new
                                      {
                                          Id = t.countryid,
                                          Text = t.nationality
                                      }).ToList();
                ViewBag.preGen_Nationality = JsonConvert.SerializeObject(objgen_country);

                List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwgovid }).ToList();
                var objgen_govcity = (from t in listgen_govcity
                                      select new
                                      {
                                          Id = t.cityid,
                                          Text = t.cityname
                                      }).ToList();
                ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

                List<gen_govcityEntity> listgen_govArea = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwareaid }).ToList();
                var objgen_govArea = (from t in listgen_govArea
                                      select new
                                      {
                                          Id = t.cityid,
                                          Text = t.cityname
                                      }).ToList();
                ViewBag.preloadedGen_GovArea = JsonConvert.SerializeObject(objgen_govArea);

                var Cachegen_building = new DataCacheController().GetCacheData(clsDataCache.gen_buildingEntity[0].ToString());
                if (model.buildingid != null)
                {
                    var objgen_building = Cachegen_building.Where(p => p.comId == model.buildingid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Building = JsonConvert.SerializeObject(objgen_building);
                }

                List<gen_divisiondistrictEntity> listgen_divisioncurr = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurdivid }).ToList();
                var objgen_divisioncurr = (from t in listgen_divisioncurr
                                               select new
                                               {
                                                   Id = t.districtid,
                                                   Text = t.districtname
                                               }).ToList();
                ViewBag.preloadedGen_DivisionCurr = JsonConvert.SerializeObject(objgen_divisioncurr);

                List<gen_divisiondistrictEntity> listgen_districtcurr = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurcityid }).ToList();
                var objgen_districtcurr = (from t in listgen_districtcurr
                                           select new
                                               {
                                                   Id = t.districtid,
                                                   Text = t.districtname
                                               }).ToList();
                ViewBag.preloadedGen_DistrictCurr = JsonConvert.SerializeObject(objgen_districtcurr);

                List<gen_divisiondistrictEntity> listgen_divisionper = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdperdivid }).ToList();
                var objgen_divisionper = (from t in listgen_divisionper
                                           select new
                                           {
                                               Id = t.districtid,
                                               Text = t.districtname
                                           }).ToList();
                ViewBag.preloadedGen_DivisionPer = JsonConvert.SerializeObject(objgen_divisionper);

                List<gen_divisiondistrictEntity> listgen_districtper = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdpercityid }).ToList();
                var objgen_districtper = (from t in listgen_districtper
                                           select new
                                           {
                                               Id = t.districtid,
                                               Text = t.districtname
                                           }).ToList();
                ViewBag.preloadedGen_DistrictPer = JsonConvert.SerializeObject(objgen_districtper);
                
                List<gen_thanaEntity> listgen_thanacurr = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdcurthanaid }).ToList();
                var objgen_thanaCurr = (from t in listgen_thanacurr
                                        select new
                                    {
                                        Id = t.thanaid,
                                        Text = t.thananame
                                    }).ToList();
                ViewBag.preloadedGen_ThanaCurr = JsonConvert.SerializeObject(objgen_thanaCurr);

                List<gen_thanaEntity> listgen_thanaper = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdperthanaid }).ToList();
                var objgen_thanaper = (from t in listgen_thanaper
                                        select new
                                        {
                                            Id = t.thanaid,
                                            Text = t.thananame
                                        }).ToList();
                ViewBag.preloadedGen_Thanaper = JsonConvert.SerializeObject(objgen_thanaper);

                if (!string.IsNullOrEmpty(model.ex_nvarchar1))
                    ViewBag.userprofilephoto = Path.Combine(DomainUrl.GetDomainUrl(), model.ex_nvarchar1);


                ModelState.Clear();
                return PartialView("_HrPersonalInfoEdit", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }

       
       
        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ActionParameterInjector]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<JsonResult> UploadAttachment(HttpPostedFileBase attachment,
            string token,
            string userinfo,
            string useripaddress,
            string sessionid,
            string methodname,
            string currenturl,string militarynokw)
        {
            HttpPostedFileBase file = Request.Files[0];

            if (file != null && file.ContentLength > 0)
            {

                try
                {
                    transactioncodeGen obj = new transactioncodeGen();
                    var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                    if (claimsIdentity != null)
                    {

                        string fileUploadDir = System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString();// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";

                        if (fileUploadDir[fileUploadDir.Length - 1] != '/')
                            fileUploadDir = fileUploadDir + "/";

                        string  firstimage = "";

                        int iFileSize = file.ContentLength;
                        string fileName = file.FileName;
                        string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                        //string filetype = string.Empty;

                         string filepath = Server.MapPath("~"+fileUploadDir);

                        file.SaveAs(filepath + militarynokw + fileExtension);

                        firstimage = Path.Combine(DomainUrl.GetDomainUrl() ,System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"], militarynokw + fileExtension); ;

                        ViewBag.userprofilephoto = firstimage;

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = firstimage, redirectUrl = "", responsetext = militarynokw + fileExtension });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Bad Request! Upload Failed" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            else
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AuthorizeFilterAttribute]
        [ValidateAntiForgeryToken]
        [AllowCrossSiteJsonAttribute]
        [ActionParameterInjector]
        [ValidateInput(true)]
        [SecurityFillerAttribute]
        [LoggingFilterAttribute]
        [ExceptionFilterAttribute]
        [RequestValidationAttribute]
        public async Task<JsonResult> UploadAttachmentEdit(HttpPostedFileBase attachment,
            string token,
            string userinfo,
            string useripaddress,
            string sessionid,
            string methodname,
            string currenturl,
            string userid,
            string masteruserid)
        {
            HttpPostedFileBase file = Request.Files[0];

            if (file != null && file.ContentLength > 0)
            {
                transactioncodeGen obj = new transactioncodeGen();
                try
                {
                    var claimsIdentity = HttpContext.User.Identity as ClaimsIdentity;
                    if (claimsIdentity != null)
                    {
                        string HTMLString = ""; string firstimage = "";

                        int iFileSize = file.ContentLength;
                        string fileName = file.FileName;
                        string fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
                        string filetype = string.Empty;

                        string FileNamePrefix = obj.GetRandomAlphaNumericStringForTransactionActivity("UPLD", DateTime.Now);

                        string filepath = Server.MapPath("~/Uploads/");
                        file.SaveAs(filepath + userid + "/" + FileNamePrefix + fileExtension);

                        //objFTP.UploadFileFTP(buffer, fileUploadDir, FileNamePrefix, fileExtension);

                        firstimage = Path.Combine(DomainUrl.GetDomainUrl() + System.Configuration.ConfigurationManager.AppSettings["UploadFolder"], userid, FileNamePrefix + fileExtension); ;


                        ViewBag.userprofilephoto = firstimage;



                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = firstimage, redirectUrl = "", responsetext = FileNamePrefix + fileExtension });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Bad Request! Upload Failed" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            else
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", file = string.Empty, responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        //[ValidateInput(true)]
        //[AllowCrossSiteJsonAttribute]
        //[RequestValidationAttribute]
        //[LoggingFilterAttribute]
        //[ValidateAntiForgeryToken]
        //[SecurityFillerAttribute]
        //[AuthorizeFilterAttribute]
        [ExceptionFilterAttribute]
        public async Task<ActionResult> DeleteAttachment(hr_svcinfoEntity input)
        {
            string str = string.Empty;
            try
            {
                ModelState.Remove("name1");
                ModelState.Remove("name2");
                ModelState.Remove("fullname");
                ModelState.Remove("hrbasicid");
                if (this.ModelState.IsValid)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                    if (!string.IsNullOrEmpty(input.profilephotofilepath))
                    {
                        string domainURL = DomainUrl.GetDomainUrl();

                        if (System.IO.File.Exists(Path.Combine(domainURL, Server.MapPath(input.profilephotofilepath))))
                        {
                            System.IO.File.Delete(Path.Combine(domainURL, Server.MapPath(input.profilephotofilepath)));
                        }
                    }

                    ViewBag.UserProfilePhoto = DomainUrl.GetDomainUrl() + "DesignsAndScripts/Images/NoProfileImage.png";
                    return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, redirectUrl = ViewBag.UserProfilePhoto, responsetext = KAF.MsgContainer._Common._deleteInformation });
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
        public async Task<ActionResult> HrPersonalInfoUpdate(hr_personalinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                string fileName = "", fileExtension = "";

                if (!string.IsNullOrWhiteSpace( input.ex_nvarchar1))
                {
                    //string[] strImage = input.ex_nvarchar1.Split('/');
                    //fileName = strImage[3].ToString();
                    if (!input.ex_nvarchar1.Contains("NoProfileImage"))
                    {
                        var path = Server.MapPath(Path.Combine("~", input.ex_nvarchar1));

                        fileExtension = System.IO.Path.GetExtension(path).ToLower();
                        fileName = System.IO.Path.GetFileName(path).ToLower();

                        input.ex_nvarchar1 = System.Configuration.ConfigurationManager.AppSettings["ProfileImagesFolder"].ToString() + fileName;// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";
                    }
                    else
                    {
                        input.ex_nvarchar1 = "DesignsAndScripts/Images/NoProfileImage.png";// KAF.CustomHelper.HelperClasses.clsUtil.GetFolderDirectory(Convert.ToInt64(strfoldertype)) + "/" + strfoldername + "/";

                    }
                }

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("hrpersonalinfoid");
                                 ModelState.Remove("hrbasicid");
                                 ModelState.Remove("religionid");
                                 ModelState.Remove("bloodgroupid");
                                 ModelState.Remove("maritalstatusid");
                                 ModelState.Remove("genderid");
                                 ModelState.Remove("nationalityid");
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
                ModelState.Remove("hrbasicid");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

					 ret = KAF.FacadeCreatorObjects.hr_personalinfoFCC.GetFacadeCreate().Update(input);
                 
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

        #region delete HrPersonalInfo

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
        public async Task<ActionResult> HrPersonalInfoDelete(hr_personalinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("hrpersonalinfoid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("religionid");
				 ModelState.Remove("bloodgroupid");
				 ModelState.Remove("maritalstatusid");
				 ModelState.Remove("genderid");
				 ModelState.Remove("nationalityid");
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
                    input.hrpersonalinfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrpersonalinfoid", input.strModelPrimaryKey).ToString());
               
               
					 ret = KAF.FacadeCreatorObjects.hr_personalinfoFCC.GetFacadeCreate().Delete(input);
                 
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

        #region detail HrPersonalInfo

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
        public async Task<ActionResult> HrPersonalInfoDetail(hr_personalinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrpersonalinfoid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrpersonalinfoid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_personalinfoFCC.GetFacadeCreate().GetAll(new hr_personalinfoEntity { hrpersonalinfoid = input.hrpersonalinfoid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                model.militarynokw = input.militarynokw;

                var Cachegen_religion = new DataCacheController().GetCacheData(clsDataCache.gen_religionEntity[0].ToString());
                if (model.religionid != null)
                {
                    var objgen_religion = Cachegen_religion.Where(p => p.comId == model.religionid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Religion = JsonConvert.SerializeObject(objgen_religion);
                }

                var Cachegen_bloodgroup = new DataCacheController().GetCacheData(clsDataCache.gen_bloodgroupEntity[0].ToString());
                if (model.bloodgroupid != null)
                {
                    var objgen_bloodgroup = Cachegen_bloodgroup.Where(p => p.comId == model.bloodgroupid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_BloodGroup = JsonConvert.SerializeObject(objgen_bloodgroup);
                }

                var Cachegen_maritalstatus = new DataCacheController().GetCacheData(clsDataCache.gen_maritalstatusEntity[0].ToString());
                if (model.maritalstatusid != null)
                {
                    var objgen_maritalstatus = Cachegen_maritalstatus.Where(p => p.comId == model.maritalstatusid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_MaritalStatus = JsonConvert.SerializeObject(objgen_maritalstatus);
                }

                var Cachegen_gender = new DataCacheController().GetCacheData(clsDataCache.gen_genderEntity[0].ToString());
                if (model.genderid != null)
                {
                    var objgen_gender = Cachegen_gender.Where(p => p.comId == model.genderid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Gender = JsonConvert.SerializeObject(objgen_gender);
                }

                List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.nationalityid }).ToList();
                var objgen_country = (from t in listgen_country
                                      select new
                                      {
                                          Id = t.countryid,
                                          Text = t.nationality
                                      }).ToList();
                ViewBag.preGen_Nationality = JsonConvert.SerializeObject(objgen_country);

                var Cachegen_building = new DataCacheController().GetCacheData(clsDataCache.gen_buildingEntity[0].ToString());
                if (model.buildingid != null)
                {
                    var objgen_building = Cachegen_building.Where(p => p.comId == model.buildingid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Building = JsonConvert.SerializeObject(objgen_building);
                }

                List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwgovid }).ToList();
                var objgen_govcity = (from t in listgen_govcity
                                      select new
                                      {
                                          Id = t.cityid,
                                          Text = t.cityname
                                      }).ToList();
                ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

                List<gen_govcityEntity> listgen_govArea = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.kwareaid }).ToList();
                var objgen_govArea = (from t in listgen_govArea
                                      select new
                                      {
                                          Id = t.cityid,
                                          Text = t.cityname
                                      }).ToList();
                ViewBag.preloadedGen_GovArea = JsonConvert.SerializeObject(objgen_govArea);

                List<gen_divisiondistrictEntity> listgen_divisioncurr = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurdivid }).ToList();
                var objgen_divisioncurr = (from t in listgen_divisioncurr
                                           select new
                                           {
                                               Id = t.districtid,
                                               Text = t.districtname
                                           }).ToList();
                ViewBag.preloadedGen_DivisionCurr = JsonConvert.SerializeObject(objgen_divisioncurr);

                List<gen_divisiondistrictEntity> listgen_districtcurr = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdcurcityid }).ToList();
                var objgen_districtcurr = (from t in listgen_districtcurr
                                           select new
                                           {
                                               Id = t.districtid,
                                               Text = t.districtname
                                           }).ToList();
                ViewBag.preloadedGen_DistrictCurr = JsonConvert.SerializeObject(objgen_districtcurr);

                List<gen_divisiondistrictEntity> listgen_divisionper = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdperdivid }).ToList();
                var objgen_divisionper = (from t in listgen_divisionper
                                          select new
                                          {
                                              Id = t.districtid,
                                              Text = t.districtname
                                          }).ToList();
                ViewBag.preloadedGen_DivisionPer = JsonConvert.SerializeObject(objgen_divisionper);

                List<gen_divisiondistrictEntity> listgen_districtper = KAF.FacadeCreatorObjects.gen_divisiondistrictFCC.GetFacadeCreate().GetAll(new gen_divisiondistrictEntity { districtid = model.bdpercityid }).ToList();
                var objgen_districtper = (from t in listgen_districtper
                                          select new
                                          {
                                              Id = t.districtid,
                                              Text = t.districtname
                                          }).ToList();
                ViewBag.preloadedGen_DistrictPer = JsonConvert.SerializeObject(objgen_districtper);

                List<gen_thanaEntity> listgen_thanacurr = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdcurthanaid }).ToList();
                var objgen_thanaCurr = (from t in listgen_thanacurr
                                        select new
                                        {
                                            Id = t.thanaid,
                                            Text = t.thananame
                                        }).ToList();
                ViewBag.preloadedGen_ThanaCurr = JsonConvert.SerializeObject(objgen_thanaCurr);

                List<gen_thanaEntity> listgen_thanaper = KAF.FacadeCreatorObjects.gen_thanaFCC.GetFacadeCreate().GetAll(new gen_thanaEntity { thanaid = model.bdperthanaid }).ToList();
                var objgen_thanaper = (from t in listgen_thanaper
                                       select new
                                       {
                                           Id = t.thanaid,
                                           Text = t.thananame
                                       }).ToList();
                ViewBag.preloadedGen_Thanaper = JsonConvert.SerializeObject(objgen_thanaper);

                ModelState.Clear();
                return PartialView("_HrPersonalInfoDetail", model);
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

            hr_svcinfoEntity objhr_svcinfo = new hr_svcinfoEntity();
            objhr_svcinfo.militarynokw = militaryNo;

            try
            {
                SecurityCapsule sec = new SecurityCapsule();
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];

                var data = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objhr_svcinfo).ToList();

                //if (objhr_svcinfo != null)
                //{
                //    input.hrbasicid = objhr_svcinfo.hrbasicid;
                //    if (sec.okpid != null && sec.okpid != objhr_svcinfo.okpid)
                //    {
                //        return Json(new { data = "", status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Warning! Unauthorized search for Military No: " + input.militarynokw });
                //    }
                //}
                //else
                //{
                //    return Json(new { data = "", status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Warning! Invalid Military No: " + input.militarynokw });
                //}


                if (data != null && data.Count > 0)
                {

                    if (sec.okpid != null && sec.okpid != data.FirstOrDefault().okpid)
                    {
                        return Json(new { data = data, status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Warning! Unauthorized search for Military No: " + militaryNo });
                    }

                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
                                   t.hrbasicid,
                                   t.militarynokw,
                                   t.militarynobd,
                                   t.civilid,
                                   t.passportno,
                                   t.fullname
                               }).ToList();

                    result = this.Json(new { status = KAF.MsgContainer._Status._statusSuccess, recordsTotal = totalRecords, recordsFiltered = totalRecords, data = tut }, JsonRequestBehavior.AllowGet);
                }
                else
                    result = this.Json(new { status = KAF.MsgContainer._Status._statusFailed, recordsTotal = 0, recordsFiltered = 0, data = "", responsetext = "Data not found for Military No: " + militaryNo }, JsonRequestBehavior.AllowGet);
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



