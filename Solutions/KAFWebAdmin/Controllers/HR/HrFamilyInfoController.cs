
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
    public class HrFamilyInfoController : BaseController
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
        public async Task<ActionResult> HrFamilyInfo()
        {
            return View("HrFamilyInfoLanding");
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
        public async Task<ActionResult> HrFamilyInfoTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, hr_familyinfoEntity input)
        {
            hr_familyinfoEntity objowin_hr_familyinfo = new hr_familyinfoEntity();
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
           
                List<hr_familyinfoEntity> data = this.GetAllHrFamilyInfoData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.hrfamilyid,
									 t.hrbasicid,
									 t.relationshipid,
									 t.parenthrfamilyid,
									 t.familycivilid,
									 t.familynationalid,
									 t.familyname1,
									 t.familyname2,
									 t.familyname3,
									 t.familyname4,
									 t.familyname5,
									 t.familyfullname,
									 t.familygenderid,
									 t.familyreligionid,
									 t.familybloodgroupid,
									 t.familybirthdate,
									 t.familybirthdocno,
									 t.familybirthdocdate,
									 t.familycountryid,
									 t.familynationalityid,
									 t.familymaritalstatusid,
									 t.familycuraddressflatno,
									 t.familycuraddresshouseno,
									 t.familycuraddressstreet,
									 t.familycuradrressblock,
									 t.familycurcountryid,
									 t.familycurgovnerid,
									 t.familycurareaid,
									 t.familymobile1,
									 t.familytelephone1,
									 t.familyperaddressflatno,
									 t.familyperaddresshouseno,
									 t.familyperaddressstreet,
									 t.familyperadrresspo,
									 t.familyperadrressps,
									 t.familyperaddressdist,
									 t.familyperaddresscountryid,
									 t.familymarriagedate,
									 t.familymarriagedocno,
									 t.familymarriagedocdate,
									 t.marriagefiledescription,
									 t.marriagefilepath,
									 t.marriagefilename,
									 t.marriagefiletype,
									 t.marriagefileextension,
									 t.marriageserialno,
									 t.divorcedate,
									 t.divorcedocno,
									 t.divorcedocdate,
									 t.divorcefiledescription,
									 t.divorcefilepath,
									 t.divorcefilename,
									 t.divorcefiletype,
									 t.divorcefileextension,
									 t.fatherstatusid,
									 t.isservedinmilitary,
									 t.fathermilitarynokw,
									 t.fathermilitarynobd,
									 t.workplace,
									 t.workdesignation,
									 t.familydeathdate,
									 t.familydeathdocno,
									 t.familydeathdocdate,
									 t.familydeathfiledescription,
									 t.familydeathfilepath,
									 t.familydeathfilename,
									 t.familydeathfiletype,
									 t.familydeathfileextension,
									 t.separetiondate,
									 t.separetionreason,
									 t.separetiondocno,
									 t.separetiondocdate,
									 t.remarks,
									 t.forreview,
                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.hrfamilyid.GetValueOrDefault(-99), "hrfamilyid", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "HrFamilyInfo/HrFamilyInfoEdit", "HrFamilyInfoEdit", 
                                   "HrFamilyInfo/HrFamilyInfoDelete", "HrFamilyInfoDelete",
                                   "HrFamilyInfo/HrFamilyInfoDetail", "HrFamilyInfoDetail")
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
        
        
        List<hr_familyinfoEntity> GetAllHrFamilyInfoData(hr_familyinfoEntity objhr_familyinfoEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<hr_familyinfoEntity> listobjhr_familyinfoEntity = new List<hr_familyinfoEntity>();
            try
            {
                listobjhr_familyinfoEntity = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().GAPgListView((objhr_familyinfoEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjhr_familyinfoEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "hrfamilyid" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "hrbasicid" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "relationshipid" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "parenthrfamilyid" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "familycivilid" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "familynationalid" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "familyname1" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "familyname2" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "familyname3" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "familyname4" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "familyname5" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "familyfullname" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "familygenderid" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "familyreligionid" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "familybloodgroupid" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "familybirthdate" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "familybirthdocno" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "familybirthdocdate" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "familycountryid" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "familynationalityid" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "familymaritalstatusid" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "familycuraddressflatno" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "familycuraddresshouseno" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "familycuraddressstreet" + " " + orderDir;
							 break;
					 case "24":
							 sortingVal = "familycuradrressblock" + " " + orderDir;
							 break;
					 case "25":
							 sortingVal = "familycurcountryid" + " " + orderDir;
							 break;
					 case "26":
							 sortingVal = "familycurgovnerid" + " " + orderDir;
							 break;
					 case "27":
							 sortingVal = "familycurareaid" + " " + orderDir;
							 break;
					 case "28":
							 sortingVal = "familymobile1" + " " + orderDir;
							 break;
					 case "29":
							 sortingVal = "familytelephone1" + " " + orderDir;
							 break;
					 case "30":
							 sortingVal = "familyperaddressflatno" + " " + orderDir;
							 break;
					 case "31":
							 sortingVal = "familyperaddresshouseno" + " " + orderDir;
							 break;
					 case "32":
							 sortingVal = "familyperaddressstreet" + " " + orderDir;
							 break;
					 case "33":
							 sortingVal = "familyperadrresspo" + " " + orderDir;
							 break;
					 case "34":
							 sortingVal = "familyperadrressps" + " " + orderDir;
							 break;
					 case "35":
							 sortingVal = "familyperaddressdist" + " " + orderDir;
							 break;
					 case "36":
							 sortingVal = "familyperaddresscountryid" + " " + orderDir;
							 break;
					 case "37":
							 sortingVal = "familymarriagedate" + " " + orderDir;
							 break;
					 case "38":
							 sortingVal = "familymarriagedocno" + " " + orderDir;
							 break;
					 case "39":
							 sortingVal = "familymarriagedocdate" + " " + orderDir;
							 break;
					 case "40":
							 sortingVal = "marriagefiledescription" + " " + orderDir;
							 break;
					 case "41":
							 sortingVal = "marriagefilepath" + " " + orderDir;
							 break;
					 case "42":
							 sortingVal = "marriagefilename" + " " + orderDir;
							 break;
					 case "43":
							 sortingVal = "marriagefiletype" + " " + orderDir;
							 break;
					 case "44":
							 sortingVal = "marriagefileextension" + " " + orderDir;
							 break;
					 case "45":
							 sortingVal = "marriageserialno" + " " + orderDir;
							 break;
					 case "46":
							 sortingVal = "divorcedate" + " " + orderDir;
							 break;
					 case "47":
							 sortingVal = "divorcedocno" + " " + orderDir;
							 break;
					 case "48":
							 sortingVal = "divorcedocdate" + " " + orderDir;
							 break;
					 case "49":
							 sortingVal = "divorcefiledescription" + " " + orderDir;
							 break;
					 case "50":
							 sortingVal = "divorcefilepath" + " " + orderDir;
							 break;
					 case "51":
							 sortingVal = "divorcefilename" + " " + orderDir;
							 break;
					 case "52":
							 sortingVal = "divorcefiletype" + " " + orderDir;
							 break;
					 case "53":
							 sortingVal = "divorcefileextension" + " " + orderDir;
							 break;
					 case "54":
							 sortingVal = "fatherstatusid" + " " + orderDir;
							 break;
					 case "55":
							 sortingVal = "isservedinmilitary" + " " + orderDir;
							 break;
					 case "56":
							 sortingVal = "fathermilitarynokw" + " " + orderDir;
							 break;
					 case "57":
							 sortingVal = "fathermilitarynobd" + " " + orderDir;
							 break;
					 case "58":
							 sortingVal = "workplace" + " " + orderDir;
							 break;
					 case "59":
							 sortingVal = "workdesignation" + " " + orderDir;
							 break;
					 case "60":
							 sortingVal = "familydeathdate" + " " + orderDir;
							 break;
					 case "61":
							 sortingVal = "familydeathdocno" + " " + orderDir;
							 break;
					 case "62":
							 sortingVal = "familydeathdocdate" + " " + orderDir;
							 break;
					 case "63":
							 sortingVal = "familydeathfiledescription" + " " + orderDir;
							 break;
					 case "64":
							 sortingVal = "familydeathfilepath" + " " + orderDir;
							 break;
					 case "65":
							 sortingVal = "familydeathfilename" + " " + orderDir;
							 break;
					 case "66":
							 sortingVal = "familydeathfiletype" + " " + orderDir;
							 break;
					 case "67":
							 sortingVal = "familydeathfileextension" + " " + orderDir;
							 break;
					 case "68":
							 sortingVal = "separetiondate" + " " + orderDir;
							 break;
					 case "69":
							 sortingVal = "separetionreason" + " " + orderDir;
							 break;
					 case "70":
							 sortingVal = "separetiondocno" + " " + orderDir;
							 break;
					 case "71":
							 sortingVal = "separetiondocdate" + " " + orderDir;
							 break;
					 case "72":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "73":
							 sortingVal = "forreview" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "hrfamilyid" + " " + orderDir;
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
        
        
        
         #region Create HrFamilyInfo

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
        public async Task<ActionResult> HrFamilyInfoNew(hr_familyinfoEntity input)
        {
            try
            {
                ModelState.Clear();
    //            hr_familyinfoEntity model = new hr_familyinfoEntity();
				//model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                return PartialView("_HrFamilyInfoNew", input);
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
        public async Task<ActionResult> HrFamilyInfoInsert(hr_familyinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("relationshipid");
				 ModelState.Remove("parenthrfamilyid");
				 ModelState.Remove("familycivilid");
				 ModelState.Remove("familynationalid");
				 ModelState.Remove("familyname1");
				 ModelState.Remove("familyname2");
				 ModelState.Remove("familyname3");
				 ModelState.Remove("familyname4");
				 ModelState.Remove("familyname5");
				 ModelState.Remove("familyfullname");
				 ModelState.Remove("familygenderid");
				 ModelState.Remove("familyreligionid");
				 ModelState.Remove("familybloodgroupid");
				 ModelState.Remove("familybirthdate");
				 ModelState.Remove("familybirthdocno");
				 ModelState.Remove("familybirthdocdate");
				 ModelState.Remove("familycountryid");
				 ModelState.Remove("familynationalityid");
				 ModelState.Remove("familymaritalstatusid");
				 ModelState.Remove("familycuraddressflatno");
				 ModelState.Remove("familycuraddresshouseno");
				 ModelState.Remove("familycuraddressstreet");
				 ModelState.Remove("familycuradrressblock");
				 ModelState.Remove("familycurcountryid");
				 ModelState.Remove("familycurgovnerid");
				 ModelState.Remove("familycurareaid");
				 ModelState.Remove("familymobile1");
				 ModelState.Remove("familytelephone1");
				 ModelState.Remove("familyperaddressflatno");
				 ModelState.Remove("familyperaddresshouseno");
				 ModelState.Remove("familyperaddressstreet");
				 ModelState.Remove("familyperadrresspo");
				 ModelState.Remove("familyperadrressps");
				 ModelState.Remove("familyperaddressdist");
				 ModelState.Remove("familyperaddresscountryid");
				 ModelState.Remove("familymarriagedate");
				 ModelState.Remove("familymarriagedocno");
				 ModelState.Remove("familymarriagedocdate");
				 ModelState.Remove("marriagefiledescription");
				 ModelState.Remove("marriagefilepath");
				 ModelState.Remove("marriagefilename");
				 ModelState.Remove("marriagefiletype");
				 ModelState.Remove("marriagefileextension");
				 ModelState.Remove("marriageserialno");
				 ModelState.Remove("divorcedate");
				 ModelState.Remove("divorcedocno");
				 ModelState.Remove("divorcedocdate");
				 ModelState.Remove("divorcefiledescription");
				 ModelState.Remove("divorcefilepath");
				 ModelState.Remove("divorcefilename");
				 ModelState.Remove("divorcefiletype");
				 ModelState.Remove("divorcefileextension");
				 ModelState.Remove("fatherstatusid");
				 ModelState.Remove("isservedinmilitary");
				 ModelState.Remove("fathermilitarynokw");
				 ModelState.Remove("fathermilitarynobd");
				 ModelState.Remove("workplace");
				 ModelState.Remove("workdesignation");
				 ModelState.Remove("familydeathdate");
				 ModelState.Remove("familydeathdocno");
				 ModelState.Remove("familydeathdocdate");
				 ModelState.Remove("familydeathfiledescription");
				 ModelState.Remove("familydeathfilepath");
				 ModelState.Remove("familydeathfilename");
				 ModelState.Remove("familydeathfiletype");
				 ModelState.Remove("familydeathfileextension");
				 ModelState.Remove("separetiondate");
				 ModelState.Remove("separetionreason");
				 ModelState.Remove("separetiondocno");
				 ModelState.Remove("separetiondocdate");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
              
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    ret = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().Add(input);
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
        
        
        #region update HrFamilyInfo

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
        public async Task<ActionResult> HrFamilyInfoEdit(hr_familyinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrfamilyid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrfamilyid", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().GetAll(new hr_familyinfoEntity { hrfamilyid = input.hrfamilyid }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                if (model != null)
                {
                    model.militarynokw = input.militarynokw;
                }

                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN
                //List<hr_basicprofileEntity> listhr_basicprofile = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll(new hr_basicprofileEntity { hrbasicid = model.hrbasicid }).ToList();
                //var objhr_basicprofile = (from t in listhr_basicprofile
                //select new
                //{
                //		 Id = t.hrbasicid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedHR_BasicProfile = JsonConvert.SerializeObject(objhr_basicprofile);

                //List<gen_relationshipEntity> listgen_relationship = KAF.FacadeCreatorObjects.gen_relationshipFCC.GetFacadeCreate().GetAll(new gen_relationshipEntity { relationshipid = model.relationshipid }).ToList();
                //var objgen_relationship = (from t in listgen_relationship
                //                           select new
                //                           {
                //                               Id = t.relationshipid,
                //                               Text = t.relationshipname
                //                           }).ToList();
                //ViewBag.preloadedGen_Relationship = JsonConvert.SerializeObject(objgen_relationship);

                var Cachegen_relationship = new DataCacheController().GetCacheData(clsDataCache.gen_relationshipEntity[0].ToString());
                if (model.familygenderid != null)
                {
                    var objgen_relationship = Cachegen_relationship.Where(p => p.comId == model.relationshipid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Relationship = JsonConvert.SerializeObject(objgen_relationship);
                }

                //List<hr_familyinfoEntity> listhr_familyinfo = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().GetAll(new hr_familyinfoEntity { hrfamilyid = model.parenthrfamilyid }).ToList();
                //var objhr_familyinfo = (from t in listhr_familyinfo
                //select new
                //{
                //		 Id = t.hrfamilyid ,
                //		 Text = t. 
                // }).ToList();
                //ViewBag.preloadedHr_FamilyInfo = JsonConvert.SerializeObject(objhr_familyinfo);

                //List<gen_genderEntity> listgen_gender = KAF.FacadeCreatorObjects.gen_genderFCC.GetFacadeCreate().GetAll(new gen_genderEntity { genderid = model.familygenderid }).ToList();
                //var objgen_gender = (from t in listgen_gender
                //select new
                //{
                //		 Id = t.genderid ,
                //		 Text = t.gender 
                // }).ToList();
                //ViewBag.preloadedGen_Gender = JsonConvert.SerializeObject(objgen_gender);
                var Cachegen_gender = new DataCacheController().GetCacheData(clsDataCache.gen_genderEntity[0].ToString());
                if (model.familygenderid != null)
                {
                    var objgen_gender = Cachegen_gender.Where(p => p.comId == model.familygenderid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Gender = JsonConvert.SerializeObject(objgen_gender);
                }
                var Cachegen_religion = new DataCacheController().GetCacheData(clsDataCache.gen_religionEntity[0].ToString());
                if (model.familyreligionid != null)
                {
                    var objgen_religion = Cachegen_religion.Where(p => p.comId == model.familyreligionid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_Religion = JsonConvert.SerializeObject(objgen_religion);
                }

                //          List<gen_religionEntity> listgen_religion = KAF.FacadeCreatorObjects.gen_religionFCC.GetFacadeCreate().GetAll(new gen_religionEntity { religionid = model.familyreligionid }).ToList();
                //var objgen_religion = (from t in listgen_religion
                //select new
                //{
                //		 Id = t.religionid ,
                //		 Text = t.religion 
                // }).ToList();
                //ViewBag.preloadedGen_Religion = JsonConvert.SerializeObject(objgen_religion);

                //List<gen_bloodgroupEntity> listgen_bloodgroup = KAF.FacadeCreatorObjects.gen_bloodgroupFCC.GetFacadeCreate().GetAll(new gen_bloodgroupEntity { bloodgroupid = model.familybloodgroupid }).ToList();
                //var objgen_bloodgroup = (from t in listgen_bloodgroup
                //select new
                //{
                //		 Id = t.bloodgroupid ,
                //		 Text = t.bloodgroup 
                // }).ToList();
                //ViewBag.preloadedGen_BloodGroup = JsonConvert.SerializeObject(objgen_bloodgroup);

                //List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.familycountryid }).ToList();
                //var objgen_country = (from t in listgen_country
                //select new
                //{
                //		 Id = t.countryid ,
                //		 Text = t.countryname 
                // }).ToList();
                //ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);

                //List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.familynationalityid }).ToList();
                //var objgen_country = (from t in listgen_country
                //select new
                //{
                //		 Id = t.countryid ,
                //		 Text = t.countryname 
                // }).ToList();
                //ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);
                var Cachegen_maritalstatus = new DataCacheController().GetCacheData(clsDataCache.gen_maritalstatusEntity[0].ToString());
                if (model.familymaritalstatusid != null)
                {
                    var objgen_maritalstatus = Cachegen_maritalstatus.Where(p => p.comId == model.familymaritalstatusid).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedGen_MaritalStatus = JsonConvert.SerializeObject(objgen_maritalstatus);
                }
                //List<gen_maritalstatusEntity> listgen_maritalstatus = KAF.FacadeCreatorObjects.gen_maritalstatusFCC.GetFacadeCreate().GetAll(new gen_maritalstatusEntity { maritalstatusid = model.familymaritalstatusid }).ToList();
                //var objgen_maritalstatus = (from t in listgen_maritalstatus
                //select new
                //{
                //		 Id = t.maritalstatusid ,
                //		 Text = t.maritalstatus 
                // }).ToList();
                //ViewBag.preloadedGen_MaritalStatus = JsonConvert.SerializeObject(objgen_maritalstatus);

                ModelState.Clear();
                return PartialView("_HrFamilyInfoEdit", model);
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
        public async Task<ActionResult> HrFamilyInfoUpdate(hr_familyinfoEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;
                
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
/*				 ModelState.Remove("hrfamilyid");
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("relationshipid");
				 ModelState.Remove("parenthrfamilyid");
				 ModelState.Remove("familycivilid");
				 ModelState.Remove("familynationalid");
				 ModelState.Remove("familyname1");
				 ModelState.Remove("familyname2");
				 ModelState.Remove("familyname3");
				 ModelState.Remove("familyname4");
				 ModelState.Remove("familyname5");
				 ModelState.Remove("familyfullname");
				 ModelState.Remove("familygenderid");
				 ModelState.Remove("familyreligionid");
				 ModelState.Remove("familybloodgroupid");
				 ModelState.Remove("familybirthdate");
				 ModelState.Remove("familybirthdocno");
				 ModelState.Remove("familybirthdocdate");
				 ModelState.Remove("familycountryid");
				 ModelState.Remove("familynationalityid");
				 ModelState.Remove("familymaritalstatusid");
				 ModelState.Remove("familycuraddressflatno");
				 ModelState.Remove("familycuraddresshouseno");
				 ModelState.Remove("familycuraddressstreet");
				 ModelState.Remove("familycuradrressblock");
				 ModelState.Remove("familycurcountryid");
				 ModelState.Remove("familycurgovnerid");
				 ModelState.Remove("familycurareaid");
				 ModelState.Remove("familymobile1");
				 ModelState.Remove("familytelephone1");
				 ModelState.Remove("familyperaddressflatno");
				 ModelState.Remove("familyperaddresshouseno");
				 ModelState.Remove("familyperaddressstreet");
				 ModelState.Remove("familyperadrresspo");
				 ModelState.Remove("familyperadrressps");
				 ModelState.Remove("familyperaddressdist");
				 ModelState.Remove("familyperaddresscountryid");
				 ModelState.Remove("familymarriagedate");
				 ModelState.Remove("familymarriagedocno");
				 ModelState.Remove("familymarriagedocdate");
				 ModelState.Remove("marriagefiledescription");
				 ModelState.Remove("marriagefilepath");
				 ModelState.Remove("marriagefilename");
				 ModelState.Remove("marriagefiletype");
				 ModelState.Remove("marriagefileextension");
				 ModelState.Remove("marriageserialno");
				 ModelState.Remove("divorcedate");
				 ModelState.Remove("divorcedocno");
				 ModelState.Remove("divorcedocdate");
				 ModelState.Remove("divorcefiledescription");
				 ModelState.Remove("divorcefilepath");
				 ModelState.Remove("divorcefilename");
				 ModelState.Remove("divorcefiletype");
				 ModelState.Remove("divorcefileextension");
				 ModelState.Remove("fatherstatusid");
				 ModelState.Remove("isservedinmilitary");
				 ModelState.Remove("fathermilitarynokw");
				 ModelState.Remove("fathermilitarynobd");
				 ModelState.Remove("workplace");
				 ModelState.Remove("workdesignation");
				 ModelState.Remove("familydeathdate");
				 ModelState.Remove("familydeathdocno");
				 ModelState.Remove("familydeathdocdate");
				 ModelState.Remove("familydeathfiledescription");
				 ModelState.Remove("familydeathfilepath");
				 ModelState.Remove("familydeathfilename");
				 ModelState.Remove("familydeathfiletype");
				 ModelState.Remove("familydeathfileextension");
				 ModelState.Remove("separetiondate");
				 ModelState.Remove("separetionreason");
				 ModelState.Remove("separetiondocno");
				 ModelState.Remove("separetiondocdate");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");
*/               
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    //START OF NO CHANGE REGION
                    //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    //input.strValue6 = userid;
                    //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    ////Int64 ret = 0;
                    //List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
                    //objFileList = input.cor_foldercontentsList.Where(p=> p.strValue1 == "deleted" || p.strValue1 == "added").ToList();
                    //input.cor_foldercontentsList = objFileList;
                    //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    //END OF NO CHANGE REGION
                    // CHANGE ThiS LINE TO MAKE A SAVE
                    ret = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().Update(input);

                    //START OF NO CHANGE REGION
      //              if (retArray != null && retArray.Count > 0)
					 //{
						// ret = 0;
						// KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						// if (objFileList != null && objFileList.Count > 0)
						// {
						// List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
						// List<cor_foldercontentsEntity> objFileAddList = new List<cor_foldercontentsEntity>();
						// objFileDeleteList = objFileList.Where(p => p.strValue1 == "deleted").ToList();
						// objFileAddList = objFileList.Where(p => p.strValue1 == "added").ToList();
						// foreach (cor_foldercontentsEntity file in objFileAddList)
						// {
						//    byte[] imageBytes = Convert.FromBase64String(file.comment);
						//    objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
						// }
						 
						 
						// foreach (cor_foldercontentsEntity file in objFileDeleteList)
						// {
						// objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
						// }
						// }
					 //ret = 1;
					 //}
					 //END OF NO CHANGE REGION
					 
                 
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

        #region delete HrFamilyInfo

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
        public async Task<ActionResult> HrFamilyInfoDelete(hr_familyinfoEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("hrfamilyid"); */
				 ModelState.Remove("hrbasicid");
				 ModelState.Remove("relationshipid");
				 ModelState.Remove("parenthrfamilyid");
				 ModelState.Remove("familycivilid");
				 ModelState.Remove("familynationalid");
				 ModelState.Remove("familyname1");
				 ModelState.Remove("familyname2");
				 ModelState.Remove("familyname3");
				 ModelState.Remove("familyname4");
				 ModelState.Remove("familyname5");
				 ModelState.Remove("familyfullname");
				 ModelState.Remove("familygenderid");
				 ModelState.Remove("familyreligionid");
				 ModelState.Remove("familybloodgroupid");
				 ModelState.Remove("familybirthdate");
				 ModelState.Remove("familybirthdocno");
				 ModelState.Remove("familybirthdocdate");
				 ModelState.Remove("familycountryid");
				 ModelState.Remove("familynationalityid");
				 ModelState.Remove("familymaritalstatusid");
				 ModelState.Remove("familycuraddressflatno");
				 ModelState.Remove("familycuraddresshouseno");
				 ModelState.Remove("familycuraddressstreet");
				 ModelState.Remove("familycuradrressblock");
				 ModelState.Remove("familycurcountryid");
				 ModelState.Remove("familycurgovnerid");
				 ModelState.Remove("familycurareaid");
				 ModelState.Remove("familymobile1");
				 ModelState.Remove("familytelephone1");
				 ModelState.Remove("familyperaddressflatno");
				 ModelState.Remove("familyperaddresshouseno");
				 ModelState.Remove("familyperaddressstreet");
				 ModelState.Remove("familyperadrresspo");
				 ModelState.Remove("familyperadrressps");
				 ModelState.Remove("familyperaddressdist");
				 ModelState.Remove("familyperaddresscountryid");
				 ModelState.Remove("familymarriagedate");
				 ModelState.Remove("familymarriagedocno");
				 ModelState.Remove("familymarriagedocdate");
				 ModelState.Remove("marriagefiledescription");
				 ModelState.Remove("marriagefilepath");
				 ModelState.Remove("marriagefilename");
				 ModelState.Remove("marriagefiletype");
				 ModelState.Remove("marriagefileextension");
				 ModelState.Remove("marriageserialno");
				 ModelState.Remove("divorcedate");
				 ModelState.Remove("divorcedocno");
				 ModelState.Remove("divorcedocdate");
				 ModelState.Remove("divorcefiledescription");
				 ModelState.Remove("divorcefilepath");
				 ModelState.Remove("divorcefilename");
				 ModelState.Remove("divorcefiletype");
				 ModelState.Remove("divorcefileextension");
				 ModelState.Remove("fatherstatusid");
				 ModelState.Remove("isservedinmilitary");
				 ModelState.Remove("fathermilitarynokw");
				 ModelState.Remove("fathermilitarynobd");
				 ModelState.Remove("workplace");
				 ModelState.Remove("workdesignation");
				 ModelState.Remove("familydeathdate");
				 ModelState.Remove("familydeathdocno");
				 ModelState.Remove("familydeathdocdate");
				 ModelState.Remove("familydeathfiledescription");
				 ModelState.Remove("familydeathfilepath");
				 ModelState.Remove("familydeathfilename");
				 ModelState.Remove("familydeathfiletype");
				 ModelState.Remove("familydeathfileextension");
				 ModelState.Remove("separetiondate");
				 ModelState.Remove("separetionreason");
				 ModelState.Remove("separetiondocno");
				 ModelState.Remove("separetiondocdate");
				 ModelState.Remove("remarks");
				 ModelState.Remove("forreview");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.hrfamilyid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrfamilyid", input.strModelPrimaryKey).ToString());
               
               
					//START OF NO CHANGE REGION
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 input.strValue6 = userid;
					 input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 // tablename = "Hr_FamilyInfo",
					 // folderid = long.Parse(input.strValue5),
					 // columnpkid = input.qualificationid
					 //}).ToList();
					 
					 List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
					 //END OF NO CHANGE REGION
					 // CHANGE ThiS LINE TO MAKE A SAVE
					 //retArray = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();
					 
					 //START OF NO CHANGE REGION
					  if (retArray != null && retArray.Count > 0)
					 {
						 ret = 0;
						 KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						 if (input.cor_foldercontentsList != null && input.cor_foldercontentsList.Count > 0)
						 {
						  List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
						 objFileDeleteList = input.cor_foldercontentsList;
						 
						 foreach (cor_foldercontentsEntity file in objFileDeleteList)
						 {
						 objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
						 }
						 }
					 ret = 1;
					 }
					 //END OF NO CHANGE REGION
					 
                 
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

        #region detail HrFamilyInfo

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
        public async Task<ActionResult> HrFamilyInfoDetail(hr_familyinfoEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.hrfamilyid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrfamilyid", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().GetAll(new hr_familyinfoEntity { hrfamilyid = input.hrfamilyid }).SingleOrDefault();
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

					 //List<hr_familyinfoEntity> listhr_familyinfo = KAF.FacadeCreatorObjects.hr_familyinfoFCC.GetFacadeCreate().GetAll(new hr_familyinfoEntity { hrfamilyid = model.parenthrfamilyid }).ToList();
					 //var objhr_familyinfo = (from t in listhr_familyinfo
					 //select new
					 //{
						//		 Id = t.hrfamilyid ,
						//		 Text = t. 
					 // }).ToList();
					 //ViewBag.preloadedHr_FamilyInfo = JsonConvert.SerializeObject(objhr_familyinfo);

					 List<gen_genderEntity> listgen_gender = KAF.FacadeCreatorObjects.gen_genderFCC.GetFacadeCreate().GetAll(new gen_genderEntity { genderid = model.familygenderid }).ToList();
					 var objgen_gender = (from t in listgen_gender
					 select new
					 {
								 Id = t.genderid ,
								 Text = t.gender 
					  }).ToList();
					 ViewBag.preloadedGen_Gender = JsonConvert.SerializeObject(objgen_gender);

					 List<gen_religionEntity> listgen_religion = KAF.FacadeCreatorObjects.gen_religionFCC.GetFacadeCreate().GetAll(new gen_religionEntity { religionid = model.familyreligionid }).ToList();
					 var objgen_religion = (from t in listgen_religion
					 select new
					 {
								 Id = t.religionid ,
								 Text = t.religion 
					  }).ToList();
					 ViewBag.preloadedGen_Religion = JsonConvert.SerializeObject(objgen_religion);

					 List<gen_bloodgroupEntity> listgen_bloodgroup = KAF.FacadeCreatorObjects.gen_bloodgroupFCC.GetFacadeCreate().GetAll(new gen_bloodgroupEntity { bloodgroupid = model.familybloodgroupid }).ToList();
					 var objgen_bloodgroup = (from t in listgen_bloodgroup
					 select new
					 {
								 Id = t.bloodgroupid ,
								 Text = t.bloodgroup 
					  }).ToList();
					 ViewBag.preloadedGen_BloodGroup = JsonConvert.SerializeObject(objgen_bloodgroup);

					 List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.familycountryid }).ToList();
					 var objgen_country = (from t in listgen_country
					 select new
					 {
								 Id = t.countryid ,
								 Text = t.countryname 
					  }).ToList();
					 ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);

					 //List<gen_countryEntity> listgen_country = KAF.FacadeCreatorObjects.gen_countryFCC.GetFacadeCreate().GetAll(new gen_countryEntity { countryid = model.familynationalityid }).ToList();
					 //var objgen_country = (from t in listgen_country
					 //select new
					 //{
						//		 Id = t.countryid ,
						//		 Text = t.countryname 
					 // }).ToList();
					 //ViewBag.preloadedGen_Country = JsonConvert.SerializeObject(objgen_country);

					 List<gen_maritalstatusEntity> listgen_maritalstatus = KAF.FacadeCreatorObjects.gen_maritalstatusFCC.GetFacadeCreate().GetAll(new gen_maritalstatusEntity { maritalstatusid = model.familymaritalstatusid }).ToList();
					 var objgen_maritalstatus = (from t in listgen_maritalstatus
					 select new
					 {
								 Id = t.maritalstatusid ,
								 Text = t.maritalstatus 
					  }).ToList();
					 ViewBag.preloadedGen_MaritalStatus = JsonConvert.SerializeObject(objgen_maritalstatus);

					 List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.familycurgovnerid }).ToList();
					 var objgen_govcity = (from t in listgen_govcity
					 select new
					 {
								 Id = t.cityid ,
								 Text = t.cityname 
					  }).ToList();
					 ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

					 //List<gen_govcityEntity> listgen_govcity = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity { cityid = model.familycurareaid }).ToList();
					 //var objgen_govcity = (from t in listgen_govcity
					 //select new
					 //{
						//		 Id = t.cityid ,
						//		 Text = t.cityname 
					 // }).ToList();
					 //ViewBag.preloadedGen_GovCity = JsonConvert.SerializeObject(objgen_govcity);

                
					 string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
					 model.strValue6 = userid;
					 model.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
					 model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
					 //model.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
					 //{
					 //     tablename = "Hr_FamilyInfo",
					 //     folderid = long.Parse(model.strValue5),
					 //     columnpkid = model.hrfamilyid
					 //}).ToList();
					 //END OF NO CHANGE REGION
                
                ModelState.Clear();
                return PartialView("_HrFamilyInfoDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion


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
    }
}



