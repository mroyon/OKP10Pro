
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
    public class StpOrganizationEntityController : BaseController
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
        public async Task<ActionResult> StpOrganizationEntity()
        {
            return View("StpOrganizationEntityLanding");
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
        public async Task<ActionResult> StpOrganizationEntityTableData([ModelBinder(typeof(DataTablesBinder))] IDataTablesRequest requestModel, stp_organizationentityEntity input)
        {
            stp_organizationentityEntity objowin_stp_organizationentity = new stp_organizationentityEntity();
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
           
                List<stp_organizationentityEntity> data = this.GetAllStpOrganizationEntityData(input);

                if (data != null && data.Count > 0)
                {
                    long totalRecords = data.FirstOrDefault().RETURN_KEY;

                    var tut = (from t in data
                               select new
                               {
									 t.entitykey,
									 t.organizationkey,
									 t.parentkey,
									 t.entirytypekey,
									 t.entitylevel,
									 t.seqfirstindex,
									 t.seqfullindex,
									 t.entitycode,
									 t.entityname,
									 t.entitynamear,
									 t.description,
									 t.isactive,
									 t.entitystatus,
									 t.entityseniority,
									 t.entityidentitycode,
									 t.adidentitycode,
									 t.remarks,
									 t.entitylogo,
									 t.entitylogofiledescription,
									 t.entitylogofilepath,
									 t.entitylogofilename,
									 t.entitylogofiletype,
									 t.entitylogoextension,
									 t.entitylogofileno,
                                   
                                   ex_nvarchar1 = objSecPanel.genButtonPanel(t.entitykey.GetValueOrDefault(-99), "entitykey", this.HttpContext.User.Identity as ClaimsIdentity,
                                   "StpOrganizationEntity/StpOrganizationEntityEdit", "StpOrganizationEntityEdit", 
                                   "StpOrganizationEntity/StpOrganizationEntityDelete", "StpOrganizationEntityDelete",
                                   "StpOrganizationEntity/StpOrganizationEntityDetail", "StpOrganizationEntityDetail")
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
        
        
        List<stp_organizationentityEntity> GetAllStpOrganizationEntityData(stp_organizationentityEntity objstp_organizationentityEntity)
        {
            string str = string.Empty;
            var urlBuilder = new UrlHelper(Request.RequestContext);
            List<stp_organizationentityEntity> listobjstp_organizationentityEntity = new List<stp_organizationentityEntity>();
            try
            {
                listobjstp_organizationentityEntity = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GAPgListView((objstp_organizationentityEntity)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listobjstp_organizationentityEntity;
        }
        
        private string SortByColumnWithOrder(string order, string orderDir)
        {
            string sortingVal = string.Empty;
            try
            {
                switch (order)
                {
					 case "0":
							 sortingVal = "entitykey" + " " + orderDir;
							 break;
					 case "1":
							 sortingVal = "organizationkey" + " " + orderDir;
							 break;
					 case "2":
							 sortingVal = "parentkey" + " " + orderDir;
							 break;
					 case "3":
							 sortingVal = "entirytypekey" + " " + orderDir;
							 break;
					 case "4":
							 sortingVal = "entitylevel" + " " + orderDir;
							 break;
					 case "5":
							 sortingVal = "seqfirstindex" + " " + orderDir;
							 break;
					 case "6":
							 sortingVal = "seqfullindex" + " " + orderDir;
							 break;
					 case "7":
							 sortingVal = "entitycode" + " " + orderDir;
							 break;
					 case "8":
							 sortingVal = "entityname" + " " + orderDir;
							 break;
					 case "9":
							 sortingVal = "entitynamear" + " " + orderDir;
							 break;
					 case "10":
							 sortingVal = "description" + " " + orderDir;
							 break;
					 case "11":
							 sortingVal = "isactive" + " " + orderDir;
							 break;
					 case "12":
							 sortingVal = "entitystatus" + " " + orderDir;
							 break;
					 case "13":
							 sortingVal = "entityseniority" + " " + orderDir;
							 break;
					 case "14":
							 sortingVal = "entityidentitycode" + " " + orderDir;
							 break;
					 case "15":
							 sortingVal = "adidentitycode" + " " + orderDir;
							 break;
					 case "16":
							 sortingVal = "remarks" + " " + orderDir;
							 break;
					 case "17":
							 sortingVal = "entitylogo" + " " + orderDir;
							 break;
					 case "18":
							 sortingVal = "entitylogofiledescription" + " " + orderDir;
							 break;
					 case "19":
							 sortingVal = "entitylogofilepath" + " " + orderDir;
							 break;
					 case "20":
							 sortingVal = "entitylogofilename" + " " + orderDir;
							 break;
					 case "21":
							 sortingVal = "entitylogofiletype" + " " + orderDir;
							 break;
					 case "22":
							 sortingVal = "entitylogoextension" + " " + orderDir;
							 break;
					 case "23":
							 sortingVal = "entitylogofileno" + " " + orderDir;
							 break;
						 default:
							 sortingVal = "entitykey" + " " + orderDir;
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
        
        
        
         #region Create StpOrganizationEntity

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
        public async Task<ActionResult> StpOrganizationEntityNew(stp_organizationentityEntity input)
        {
            try
            {
                ModelState.Clear();
                stp_organizationentityEntity model = new stp_organizationentityEntity();
				model.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                return PartialView("_StpOrganizationEntityNew", model);
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
        public async Task<ActionResult> StpOrganizationEntityInsert(stp_organizationentityEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                Int64 ret = 0;
                SecurityCapsule sec = new SecurityCapsule();
                /*				 ModelState.Remove("entitykey");
                                 ModelState.Remove("organizationkey");
                                 ModelState.Remove("parentkey");
                                 ModelState.Remove("entirytypekey");
                                 ModelState.Remove("entitylevel");
                                 ModelState.Remove("seqfirstindex");
                                 ModelState.Remove("seqfullindex");
                                 ModelState.Remove("entitycode");
                                 ModelState.Remove("entityname");
                                 ModelState.Remove("entitynamear");
                                 ModelState.Remove("description");
                                 ModelState.Remove("isactive");
                                 ModelState.Remove("entitystatus");
                                 ModelState.Remove("entityseniority");
                                 ModelState.Remove("entityidentitycode");
                                 ModelState.Remove("adidentitycode");
                                 ModelState.Remove("remarks");
                                 ModelState.Remove("entitylogo");
                                 ModelState.Remove("entitylogofiledescription");
                                 ModelState.Remove("entitylogofilepath");
                                 ModelState.Remove("entitylogofilename");
                                 ModelState.Remove("entitylogofiletype");
                                 ModelState.Remove("entitylogoextension");
                                 ModelState.Remove("entitylogofileno");
                */
                ModelState.Remove("entirytypekey");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    //RN: OPEN THIS LINE IF HR INVOLDED
                    //input.hrbasicid = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("hrbasicid", input.strAdditionalPrimaryKey));

                    //START OF NO CHANGE REGION
                    //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    //input.strValue6 = userid;
                    //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    //Int64 ret = 0;
                    //List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
                    //objFileList = input.cor_foldercontentsList;
                    //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    //END OF NO CHANGE REGION
                    // CHANGE ThiS LINE TO MAKE A SAVE
                    //retArray = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().Add_WithFiles(input).ToList();
                    input.entirytypekey = 1;
                    ret = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().Add(input);

      //              //START OF NO CHANGE REGION
      //              if (retArray != null && retArray.Count > 0)
					 //{
						// ret = 0;
						// KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
						// if (objFileList != null && objFileList.Count > 0)
						// {
						//	 foreach (cor_foldercontentsEntity file in objFileList)
						//	 {
						//		 byte[] imageBytes = Convert.FromBase64String(file.comment);
						//		 objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
						//	 }
						// }
					 //ret = 1;
					 //}
					 ////END OF NO CHANGE REGION
					 
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
        
        
        #region update StpOrganizationEntity

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
        public async Task<ActionResult> StpOrganizationEntityEdit(stp_organizationentityEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.entitykey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("entitykey", input.strModelPrimaryKey).ToString());
                var model = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity { entitykey = input.entitykey }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;
                //PN: LOAD DATA FOR PRE-SELECT2 DROP DOWN

                var Cachestp_organization = new DataCacheController().GetCacheData(clsDataCache.stp_organizationEntity[0].ToString());
                if (model.organizationkey != null)
                {
                    var objstp_organization = Cachestp_organization.Where(p => p.comId == model.organizationkey).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedstp_organization = JsonConvert.SerializeObject(objstp_organization);
                }

                if (model.parentkey != null)
                {
                    var liststp_organizationentity = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity { entitykey = model.parentkey }).ToList();
                    var objstp_organizationentity = (from t in liststp_organizationentity
                                                     select new
                                                     {
                                                         Id = t.entitykey,
                                                         Text = t.entityname
                                                     }).ToList();
                    ViewBag.preloadedstp_organizationentity = JsonConvert.SerializeObject(objstp_organizationentity);
                }

                var Cachestp_organizationtype = new DataCacheController().GetCacheData(clsDataCache.stp_organizationentitytypeEntity[0].ToString());
                if (model.entirytypekey != null)
                {
                    var objstp_organizationtype = Cachestp_organizationtype.Where(p => p.comId == model.entirytypekey).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preStp_OrganizationEntityType = JsonConvert.SerializeObject(objstp_organizationtype);
                }

                ModelState.Clear();
                return PartialView("_StpOrganizationEntityEdit", model);
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
        public async Task<ActionResult> StpOrganizationEntityUpdate(stp_organizationentityEntity input)
        {
            try
            {
                string redirectURL = "";
                string str = string.Empty;
                SecurityCapsule sec = new SecurityCapsule();
                Int64 ret = 0;

                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
                /*				 ModelState.Remove("entitykey");
                                 ModelState.Remove("organizationkey");
                                 ModelState.Remove("parentkey");
                                 ModelState.Remove("entirytypekey");
                                 ModelState.Remove("entitylevel");
                                 ModelState.Remove("seqfirstindex");
                                 ModelState.Remove("seqfullindex");
                                 ModelState.Remove("entitycode");
                                 ModelState.Remove("entityname");
                                 ModelState.Remove("entitynamear");
                                 ModelState.Remove("description");
                                 ModelState.Remove("isactive");
                                 ModelState.Remove("entitystatus");
                                 ModelState.Remove("entityseniority");
                                 ModelState.Remove("entityidentitycode");
                                 ModelState.Remove("adidentitycode");
                                 ModelState.Remove("remarks");
                                 ModelState.Remove("entitylogo");
                                 ModelState.Remove("entitylogofiledescription");
                                 ModelState.Remove("entitylogofilepath");
                                 ModelState.Remove("entitylogofilename");
                                 ModelState.Remove("entitylogofiletype");
                                 ModelState.Remove("entitylogoextension");
                                 ModelState.Remove("entitylogofileno");
                */
                ModelState.Remove("entirytypekey");
                if (input != null && ModelState.IsValid == true)
                {
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;

                    ////START OF NO CHANGE REGION
                    // string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    // input.strValue6 = userid;
                    // input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    // //Int64 ret = 0;
                    // List<cor_foldercontentsEntity> objFileList = new List<cor_foldercontentsEntity>();
                    // objFileList = input.cor_foldercontentsList.Where(p=> p.strValue1 == "deleted" || p.strValue1 == "added").ToList();
                    // input.cor_foldercontentsList = objFileList;
                    // List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    // //END OF NO CHANGE REGION
                    // // CHANGE ThiS LINE TO MAKE A SAVE
                    // //retArray = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().Update_WithFiles(input).ToList();

                    // //START OF NO CHANGE REGION
                    //  if (retArray != null && retArray.Count > 0)
                    // {
                    //	 ret = 0;
                    //	 KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
                    //	 if (objFileList != null && objFileList.Count > 0)
                    //	 {
                    //	 List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
                    //	 List<cor_foldercontentsEntity> objFileAddList = new List<cor_foldercontentsEntity>();
                    //	 objFileDeleteList = objFileList.Where(p => p.strValue1 == "deleted").ToList();
                    //	 objFileAddList = objFileList.Where(p => p.strValue1 == "added").ToList();
                    //	 foreach (cor_foldercontentsEntity file in objFileAddList)
                    //	 {
                    //	    byte[] imageBytes = Convert.FromBase64String(file.comment);
                    //	    objFTP.UploadFileFTP(imageBytes, userid + "/Upload/", file.filename, file.extension);
                    //	 }


                    //	 foreach (cor_foldercontentsEntity file in objFileDeleteList)
                    //	 {
                    //	 objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
                    //	 }
                    //	 }
                    // ret = 1;
                    // }
                    // //END OF NO CHANGE REGION
                    input.entirytypekey = 1;
                    ret = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().Update(input);
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

        #region delete StpOrganizationEntity

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
        public async Task<ActionResult> StpOrganizationEntityDelete(stp_organizationentityEntity input)
        {
            string str = string.Empty;
            string redirectURL = "";
                Int64 ret = 0;
            try
            {
                //PN: KEEP THE REQUIRED LINE AND REMOVE REST
				 /* ModelState.Remove("entitykey"); */
				 ModelState.Remove("organizationkey");
				 ModelState.Remove("parentkey");
				 ModelState.Remove("entirytypekey");
				 ModelState.Remove("entitylevel");
				 ModelState.Remove("seqfirstindex");
				 ModelState.Remove("seqfullindex");
				 ModelState.Remove("entitycode");
				 ModelState.Remove("entityname");
				 ModelState.Remove("entitynamear");
				 ModelState.Remove("description");
				 ModelState.Remove("isactive");
				 ModelState.Remove("entitystatus");
				 ModelState.Remove("entityseniority");
				 ModelState.Remove("entityidentitycode");
				 ModelState.Remove("adidentitycode");
				 ModelState.Remove("remarks");
				 ModelState.Remove("entitylogo");
				 ModelState.Remove("entitylogofiledescription");
				 ModelState.Remove("entitylogofilepath");
				 ModelState.Remove("entitylogofilename");
				 ModelState.Remove("entitylogofiletype");
				 ModelState.Remove("entitylogoextension");
				 ModelState.Remove("entitylogofileno");

                if (input != null && ModelState.IsValid == true)
                {
                    SecurityCapsule sec = new SecurityCapsule();
                    sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                    input.BaseSecurityParam = sec;
                    input.entitykey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("entitykey", input.strModelPrimaryKey).ToString());


                    //START OF NO CHANGE REGION
                    //string userid = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).userid.GetValueOrDefault().ToString() : "";
                    //input.strValue6 = userid;
                    //input.strValue5 = Session["selectedprofile"] != null ? ((hr_basicprofileEntity)Session["selectedprofile"]).hr_folderobj.folderid.GetValueOrDefault().ToString() : "";
                    //input.cor_foldercontentsList = new List<cor_foldercontentsEntity>();
                    //input.cor_foldercontentsList = KAF.FacadeCreatorObjects.cor_foldercontentsFCC.GetFacadeCreate().GetAll(new cor_foldercontentsEntity
                    //{
                    // tablename = "Stp_OrganizationEntity",
                    // folderid = long.Parse(input.strValue5),
                    // columnpkid = input.qualificationid
                    //}).ToList();

                    //List<KAFGenericComboEntity> retArray = new List<KAFGenericComboEntity>();
                    //END OF NO CHANGE REGION
                    // CHANGE ThiS LINE TO MAKE A SAVE
                    //retArray = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().Delete_WithFiles(input).ToList();

                    //START OF NO CHANGE REGION
                    // if (retArray != null && retArray.Count > 0)
                    //{
                    // ret = 0;
                    // KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
                    // if (input.cor_foldercontentsList != null && input.cor_foldercontentsList.Count > 0)
                    // {
                    //  List<cor_foldercontentsEntity> objFileDeleteList = new List<cor_foldercontentsEntity>();
                    // objFileDeleteList = input.cor_foldercontentsList;

                    // foreach (cor_foldercontentsEntity file in objFileDeleteList)
                    // {
                    // objFTP.DeleteFileFTP(userid + "/Upload/", file.filename, file.extension);
                    // }
                    // }
                    //ret = 1;
                    //}
                    //END OF NO CHANGE REGION

                    ret = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().Delete(input);
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

        #region detail StpOrganizationEntity

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
        public async Task<ActionResult> StpOrganizationEntityDetail(stp_organizationentityEntity input)
        {
            SecurityCapsule sec = new SecurityCapsule();
            try
            {
                sec = (SecurityCapsule)Request.RequestContext.HttpContext.Items["CurrentSec"];
                input.entitykey = long.Parse(objClsPrivate.GetUrlParamValMVCOnlyParam("entitykey", input.strModelPrimaryKey).ToString());
               
                var model = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity { entitykey = input.entitykey }).SingleOrDefault();
                model.strModelPrimaryKey = input.strModelPrimaryKey;

                var Cachestp_organization = new DataCacheController().GetCacheData(clsDataCache.stp_organizationEntity[0].ToString());
                if (model.organizationkey != null)
                {
                    var objstp_organization = Cachestp_organization.Where(p => p.comId == model.organizationkey).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preloadedstp_organization = JsonConvert.SerializeObject(objstp_organization);
                }

                if (model.parentkey != null)
                {
                    var liststp_organizationentity = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity { entitykey = model.parentkey }).ToList();
                    var objstp_organizationentity = (from t in liststp_organizationentity
                                                     select new
                                                     {
                                                         Id = t.entitykey,
                                                         Text = t.entityname
                                                     }).ToList();
                    ViewBag.preloadedstp_organizationentity = JsonConvert.SerializeObject(objstp_organizationentity);
                }

                var Cachestp_organizationtype = new DataCacheController().GetCacheData(clsDataCache.stp_organizationentitytypeEntity[0].ToString());
                if (model.entirytypekey != null)
                {
                    var objstp_organizationtype = Cachestp_organizationtype.Where(p => p.comId == model.entirytypekey).Select(x => new { x.comId, x.comText }).ToList();
                    ViewBag.preStp_OrganizationEntityType = JsonConvert.SerializeObject(objstp_organizationtype);
                }

                ModelState.Clear();
                return PartialView("_StpOrganizationEntityDetail", model);
            }
            catch (Exception ex)
            {
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }
        #endregion
        
    }
}



