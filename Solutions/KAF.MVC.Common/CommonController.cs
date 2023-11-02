
using KAF.AppConfiguration.Configuration;
using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.CustomFilters.Filters;
using KAF.CustomHelper.HelperClasses;
using KAF.WebFramework;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.PowerPoint;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using static KAF.CustomHelper.HelperClasses.clsUtil;

using System.Web.Script.Services;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using System.Text;
using Microsoft.Office.Core;

namespace KAF.MVC.Common
{
    public class CommonController : BaseController
    {
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        public clsModelStateValidation objModelVal = new clsModelStateValidation();
        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
        public IEnumerable<SelectListItem> ddlList { get; set; }

        [AllowAnonymous]
        public PartialViewResult LoadCombo(string ddlId, string[] ddlName, Type type, string selectedvalue, string cssclass = "", bool enable = true, bool validatedyn = false)
        {
            Type listType = typeof(List<>).MakeGenericType(new[] { type });
            IList list = (IList)Activator.CreateInstance(listType);

            if (HttpRuntime.Cache[ddlName[0]] != null)
                list = (IList)HttpRuntime.Cache[ddlName[0]];

            List<SelectListItem> dlList = new List<SelectListItem>();
            foreach (var p in list)
            {
                dlList.Add(GetPropertyValues(p, ddlName[2], ddlName[1], selectedvalue));
            }

            ViewBag.ddlTitle = ddlName[2];
            ViewBag.ddlName = dlList;
            ViewBag.ddlId = ddlId;
            ViewBag.ddlcss = cssclass;
            ViewBag.enable = enable;
            ViewBag.validatedyn = validatedyn;


            return PartialView("_DropDown");
        }

        [AllowAnonymous]
        public PartialViewResult LoadComboFromList(string ddlId, List<SelectListItem> objlist, string selectedvalue, string cssclass = "", bool enable = true, bool validatedyn = false)
        {

            List<SelectListItem> dlList = new List<SelectListItem>();
            dlList.Add(new SelectListItem { Text = "- اختر واحدة -", Value = "" });
            foreach (var p in objlist)
            {
                dlList.Add(p);
            }

            ViewBag.ddlTitle = "";
            ViewBag.ddlName = dlList;
            ViewBag.ddlId = ddlId;
            ViewBag.ddlcss = cssclass;
            ViewBag.enable = enable;
            ViewBag.validatedyn = validatedyn;


            return PartialView("_DropDown");
        }

        [AllowAnonymous]
        public PartialViewResult LoadTreeViewUnit(string txtid)
        {


            ViewBag.txtid = string.IsNullOrEmpty(txtid) ? "txtUsers" : txtid;
            //ViewBag.minchar = string.IsNullOrEmpty(minchar) ? "1" : minchar; ;
            //ViewBag.maxlength = string.IsNullOrEmpty(maxlength) ? "100" : maxlength;
            //ViewBag.hintText = string.IsNullOrEmpty(hintText) ? "Search User" : hintText;
            //ViewBag.hasCallback = hasCallback;
            //ViewBag.preloaded = preloaded;
            //ViewBag.isReadonly = isReadOnly;
            //ViewBag.hasCheckLoadedItem = hasCheckLoadedItem;

            return PartialView("_Unit_Tree");
        }
        [AllowAnonymous]
        public PartialViewResult LoadTreeViewCivilJob(string txtid)
        {


            ViewBag.txtid = string.IsNullOrEmpty(txtid) ? "txtUsers" : txtid;
            //ViewBag.minchar = string.IsNullOrEmpty(minchar) ? "1" : minchar; ;
            //ViewBag.maxlength = string.IsNullOrEmpty(maxlength) ? "100" : maxlength;
            //ViewBag.hintText = string.IsNullOrEmpty(hintText) ? "Search User" : hintText;
            //ViewBag.hasCallback = hasCallback;
            //ViewBag.preloaded = preloaded;
            //ViewBag.isReadonly = isReadOnly;
            //ViewBag.hasCheckLoadedItem = hasCheckLoadedItem;

            return PartialView("_CivilJob_Tree");
        }

        [AllowAnonymous]
        public PartialViewResult LoadTreeViewCivilWorkPlaces(string txtid)
        {

            ViewBag.txtid = string.IsNullOrEmpty(txtid) ? "txtUsers" : txtid;

            return PartialView("_CivilWorkPlaces_Tree");
        }
        [AllowAnonymous]
        public PartialViewResult LoadTreeViewMillJob(string txtid)
        {


            ViewBag.txtid = string.IsNullOrEmpty(txtid) ? "txtUsers" : txtid;
            //ViewBag.minchar = string.IsNullOrEmpty(minchar) ? "1" : minchar; ;
            //ViewBag.maxlength = string.IsNullOrEmpty(maxlength) ? "100" : maxlength;
            //ViewBag.hintText = string.IsNullOrEmpty(hintText) ? "Search User" : hintText;
            //ViewBag.hasCallback = hasCallback;
            //ViewBag.preloaded = preloaded;
            //ViewBag.isReadonly = isReadOnly;
            //ViewBag.hasCheckLoadedItem = hasCheckLoadedItem;

            return PartialView("_MillJob_Tree");
        }
        [AllowAnonymous]
        public PartialViewResult LoadTreeViewGovCity(string txtid)
        {


            ViewBag.txtid = string.IsNullOrEmpty(txtid) ? "txtUsers" : txtid;
            //ViewBag.minchar = string.IsNullOrEmpty(minchar) ? "1" : minchar; ;
            //ViewBag.maxlength = string.IsNullOrEmpty(maxlength) ? "100" : maxlength;
            //ViewBag.hintText = string.IsNullOrEmpty(hintText) ? "Search User" : hintText;
            //ViewBag.hasCallback = hasCallback;
            //ViewBag.preloaded = preloaded;
            //ViewBag.isReadonly = isReadOnly;
            //ViewBag.hasCheckLoadedItem = hasCheckLoadedItem;

            return PartialView("_GovCity_Tree");
        }
        [AllowAnonymous]
        public PartialViewResult LoadSearchUser(string txtid, string minchar, string maxlength, string hintText, string preloaded, bool isReadOnly = false, bool hasCallback = false, bool hasCheckLoadedItem = false)
        {


            ViewBag.txtid = string.IsNullOrEmpty(txtid) ? "txtUsers" : txtid;
            ViewBag.minchar = string.IsNullOrEmpty(minchar) ? "1" : minchar; ;
            ViewBag.maxlength = string.IsNullOrEmpty(maxlength) ? "100" : maxlength;
            ViewBag.hintText = string.IsNullOrEmpty(hintText) ? "Search User" : hintText;
            ViewBag.hasCallback = hasCallback;
            ViewBag.preloaded = preloaded;
            ViewBag.isReadonly = isReadOnly;
            ViewBag.hasCheckLoadedItem = hasCheckLoadedItem;

            return PartialView("_SearchUsers");
        }
        [AllowAnonymous]
        public PartialViewResult LoadSearchUnit(string txtid, string minchar, string maxlength, string hintText, string preloaded, bool isReadOnly = false)
        {


            ViewBag.txtid = string.IsNullOrEmpty(txtid) ? "txtUsers" : txtid;
            ViewBag.minchar = string.IsNullOrEmpty(minchar) ? "1" : minchar; ;
            ViewBag.maxlength = string.IsNullOrEmpty(maxlength) ? "100" : maxlength;
            ViewBag.hintText = string.IsNullOrEmpty(hintText) ? "Search Unit" : hintText;
            ViewBag.preloaded = preloaded;
            ViewBag.isReadonly = isReadOnly;
            return PartialView("_SearchUnit");
        }
        [AllowAnonymous]
        public PartialViewResult LoadFileUploader()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetUnit(stp_organizationentityEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<stp_organizationentityEntity> objUnitList = new List<stp_organizationentityEntity>();
                    objUnitList = KAF.FacadeCreatorObjects.stp_organizationentityFCC.GetFacadeCreate().GetAll(new stp_organizationentityEntity()
                    {
                        parentkey = input.parentkey == null ? -99 : input.parentkey
                    }).ToList();

                    if (objUnitList != null && objUnitList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objUnitList, redirectUrl = "", totalrows = objUnitList.Count, responsetext = "Unit found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objUnitList.Count, redirectUrl = "", responsetext = "No Unit Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetReplacementListByReplacementID(KAF_GetReplacementListByREplacementIDEntity input)
        {

            if (input != null)
            {
                try
                {
                    List<KAF_GetReplacementListByREplacementIDEntity> objList = new List<KAF_GetReplacementListByREplacementIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().Get_KAF_GetReplacementListByREplacementID(input ).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetNewDemandListPassportByDemandID(hr_demanddetlpassportEntity input)
        {

            if (input != null)
            {
                try
                {
                    List<hr_demanddetlpassportEntity> objList = new List<hr_demanddetlpassportEntity>();
                    objList = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetAll_Ext(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetVisaIssueListByVisaIssueID(KAF_GetVisaIssueListByVisaIssueIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetVisaIssueListByVisaIssueIDEntity> objList = new List<KAF_GetVisaIssueListByVisaIssueIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetVisaIssueListByVisaIssueID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetPTADemandListByPTADemandID(KAF_GetPTADemandListByPTADemandIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetPTADemandListByPTADemandIDEntity> objList = new List<KAF_GetPTADemandListByPTADemandIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetPTADemandListByPTADemandID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetFlightListByFlightID(KAF_GetFlightListByFlightIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetFlightListByFlightIDEntity> objList = new List<KAF_GetFlightListByFlightIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetFlightListByFlightID (input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }


        [AllowAnonymous]
        public async Task<JsonResult> GetVisaSentListByVisaSentID(KAF_GetVisaSentListByVisaSentIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetVisaSentListByVisaSentIDEntity> objList = new List<KAF_GetVisaSentListByVisaSentIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetVisaSentListByVisaSentID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetPTAReceivedListByPTAReceiveID(KAF_GetPTAReceivedListByPTAReceiveIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetPTAReceivedListByPTAReceiveIDEntity> objList = new List<KAF_GetPTAReceivedListByPTAReceiveIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetPTAReceivedListByPTAReceiveID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }


        [AllowAnonymous]
        public async Task<JsonResult> GetVisaDemandListByDemandID(KAF_GetDemandListByDemandIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetDemandListByDemandIDEntity> objList = new List<KAF_GetDemandListByDemandIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetDemandListByDemandID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetRepPassportListByRepPassportID(KAF_GetRepPassportListByRepPassportIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetRepPassportListByRepPassportIDEntity> objList = new List<KAF_GetRepPassportListByRepPassportIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetRepPassportListByRepPassportID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public async Task<JsonResult> GetVisaDemandListByVisaDemandID(KAF_GetVisaDemandListByVisaDemandIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetVisaDemandListByVisaDemandIDEntity> objList = new List<KAF_GetVisaDemandListByVisaDemandIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetVisaDemandListByVisaDemandID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }


        [AllowAnonymous]
        public async Task<JsonResult> GetReplacementPassportListByRepPassportID(KAF_GetReplacementPassportListByRepPassportIDEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<KAF_GetReplacementPassportListByRepPassportIDEntity> objList = new List<KAF_GetReplacementPassportListByRepPassportIDEntity>();
                    objList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_KAF_GetReplacementPassportListByRepPassportID(input).ToList();

                    if (objList != null && objList.Count > 0)
                    {
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objList, redirectUrl = "", totalrows = objList.Count, responsetext = "Data found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objList.Count, redirectUrl = "", responsetext = "No Data Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }


        #region DropDown Cahnge

        #endregion


        [AllowAnonymous]
        public async Task<JsonResult> GetCity(gen_govcityEntity input)
        {

            if (input != null)
            {
                try
                {

                    List<gen_govcityEntity> objCityList = new List<gen_govcityEntity>();
                    objCityList = KAF.FacadeCreatorObjects.gen_govcityFCC.GetFacadeCreate().GetAll(new gen_govcityEntity()
                    {
                        parentid = input.cityid == null ? -99 : input.cityid
                    }).ToList();

                    if (objCityList != null && objCityList.Count > 0)
                    {

                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, data = objCityList, redirectUrl = "", totalrows = objCityList.Count, responsetext = "Files found." });
                    }
                    else
                        return Json(new { status = KAF.MsgContainer._Status._statusSuccess, title = KAF.MsgContainer._Status._titleInformation, totalrows = objCityList.Count, redirectUrl = "", responsetext = "No City Found" }, JsonRequestBehavior.AllowGet);
                }
                catch (Exception ex)
                {
                    return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message }, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }

      
        //[HttpPost]
        //[ValidateInput(true)]
        //[AllowCrossSiteJsonAttribute]
        //[RequestValidationAttribute]
        //[LoggingFilterAttribute]
        //[ValidateAntiForgeryToken]
        //[SecurityFillerAttribute]
        //[AuthorizeFilterAttribute]
        //[ExceptionFilterAttribute]
        [HttpGet]
        public async Task<JsonResult> SearchUser(string q)
        {
            object jsonResult = null;
            if (q.Length > 0)
            {
                try
                {

                    List<owin_userEntity> objUserList = new List<owin_userEntity>();
                    objUserList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.owin_userFCC.GetFacadeCreate().SearchUser(new owin_userEntity()
                    {
                        username = q
                    }).ToList();

                    jsonResult = objUserList.Select(results => new { id = results.userid, name = results.username });

                    return Json(jsonResult, JsonRequestBehavior.AllowGet);

                }
                catch (Exception ex)
                {
                    return Json(jsonResult, JsonRequestBehavior.AllowGet);
                }
            }
            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }
        //[HttpPost]
        //[ValidateInput(true)]
        //[AllowCrossSiteJsonAttribute]
        //[RequestValidationAttribute]
        //[LoggingFilterAttribute]
        //[ValidateAntiForgeryToken]
        //[SecurityFillerAttribute]
        //[AuthorizeFilterAttribute]
        //[ExceptionFilterAttribute]
        [HttpGet]
        public async Task<JsonResult> SearchUnit(string q)
        {
            object jsonResult = null;

            if (q.Length > 0)
            {
                try
                {

                    List<stp_organizationentityEntity> objUnitList = new List<stp_organizationentityEntity>();
                    objUnitList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.stp_organizationentityFCC.GetFacadeCreate().SearchUnit(new stp_organizationentityEntity()
                    {
                        entityname = q
                    }).ToList();

                    jsonResult = objUnitList.Select(results => new { id = results.entitykey, name = results.entityname });

                    return Json(jsonResult, JsonRequestBehavior.AllowGet);

                }
                catch (Exception ex)
                {
                    return Json(jsonResult, JsonRequestBehavior.AllowGet);
                }
            }

            return Json(jsonResult, JsonRequestBehavior.AllowGet);
            // return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = "Invalid data." }, JsonRequestBehavior.AllowGet);
        }
        private SelectListItem GetPropertyValues(Object obj, string textcolumn, string valuecolumn, string selectedvalue)
        {
            SelectListItem objitem = new SelectListItem();

            Type t = obj.GetType();

            PropertyInfo[] props = t.GetProperties();

            int i = 0;
            foreach (var prop in props)
            {
                if (prop.GetIndexParameters().Length == 0)
                {
                    if (prop.Name.ToLower() == textcolumn.ToLower())
                    {
                        objitem.Text = prop.GetValue(obj).ToString();
                        i++;
                    }
                    if (prop.Name.ToLower() == valuecolumn.ToLower())
                    {
                        objitem.Value = prop.GetValue(obj).ToString();

                        if (objitem.Value == selectedvalue)
                        {
                            objitem.Selected = true;
                        }
                        i++;
                    }
                }

                if (i == 2) break;

            }

            return objitem;

        }
        

        
        public static string RenderRazorViewToString(ControllerContext controllerContext, string viewName, object model)
        {
            controllerContext.Controller.ViewData.Model = model;
            using (var stringWriter = new StringWriter())
            {
                var viewResult = ViewEngines.Engines.FindPartialView(controllerContext, viewName);
                var viewContext = new ViewContext(controllerContext, viewResult.View, controllerContext.Controller.ViewData, controllerContext.Controller.TempData, stringWriter);
                viewResult.View.Render(viewContext, stringWriter);
                viewResult.ViewEngine.ReleaseView(controllerContext, viewResult.View);
                return stringWriter.GetStringBuilder().ToString();

            }
        }





        #region UC partial

        public PartialViewResult LoadUnitSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            return PartialView("_Select2UnitSearch");
        }

        public PartialViewResult LoadCountrySearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2CountrySearch");
        }
        public PartialViewResult LoadNationalitySearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2NationalitySearch");
        }

        public PartialViewResult LoadGovCitySearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2GovCitySearch");
        }

        public PartialViewResult LoadAirlinesSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2AirlinesSearch");
        }

        public PartialViewResult LoadGen_BatchSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2Gen_BatchSearch");
        }

        public PartialViewResult LoadGen_PlatoonSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2Gen_PlatoonSearch");
        }

        public PartialViewResult LoadGovCityCascadeSearch(string selectidForGov, int minimumInputLengthForGov, string preloadedGovData,
                                                          string selectidForCity, int minimumInputLengthForCity, string preloadedCityData,
                                                          bool? isReadOnlyForGov = false, bool? multipleForGov = false, bool? isRequiredForGov = false,
                                                          bool? isReadOnlyForCity = false, bool? multipleForCity = false, bool? isRequiredForCity = false)
        {
            ViewBag.selectidForGov = selectidForGov;
            ViewBag.minimumInputLengthForGov = minimumInputLengthForGov;
            ViewBag.preloadedGovData = preloadedGovData;
            ViewBag.isReadOnlyForGov = isReadOnlyForGov;
            ViewBag.multipleForGov = multipleForGov;
            ViewBag.isRequiredForGov = isRequiredForGov;

            ViewBag.selectidForCity = selectidForCity;
            ViewBag.minimumInputLengthForCity = minimumInputLengthForCity;
            ViewBag.preloadedCityData = preloadedCityData;
            ViewBag.isReadOnlyForCity = isReadOnlyForCity;
            ViewBag.multipleForCity = multipleForCity;
            ViewBag.isRequiredForCity = isRequiredForCity;

            ViewBag.delay = 250;


            return PartialView("_Select2GovCityCascadeSearch");
        }

        public PartialViewResult LoadCountryGovCityCascadeSearch(string selectidForCountry, int minimumInputLengthForCountry, string preloadedCountryData,
                                                                string selectidForGov, int minimumInputLengthForGov, string preloadedGovData,
                                                                 string selectidForCity, int minimumInputLengthForCity, string preloadedCityData,
                                                                  bool? isReadOnlyForCountry = false, bool? multipleForCountry = false, bool? isRequiredForCountry = false,
                                                                 bool? isReadOnlyForGov = false, bool? multipleForGov = false, bool? isRequiredForGov = false,
                                                                 bool? isReadOnlyForCity = false, bool? multipleForCity = false, bool? isRequiredForCity = false)
        {
            ViewBag.selectidForCountry = selectidForCountry;
            ViewBag.minimumInputLengthForCountry = minimumInputLengthForCountry;
            ViewBag.preloadedCountryData = preloadedCountryData;
            ViewBag.isReadOnlyForCountry = isReadOnlyForCountry;
            ViewBag.multipleForCountry = multipleForCountry;
            ViewBag.isRequiredForCountry = isRequiredForCountry;

            ViewBag.selectidForGov = selectidForGov;
            ViewBag.minimumInputLengthForGov = minimumInputLengthForGov;
            ViewBag.preloadedGovData = preloadedGovData;
            ViewBag.isReadOnlyForGov = isReadOnlyForGov;
            ViewBag.multipleForGov = multipleForGov;
            ViewBag.isRequiredForGov = isRequiredForGov;

            ViewBag.selectidForCity = selectidForCity;
            ViewBag.minimumInputLengthForCity = minimumInputLengthForCity;
            ViewBag.preloadedCityData = preloadedCityData;
            ViewBag.isReadOnlyForCity = isReadOnlyForCity;
            ViewBag.multipleForCity = multipleForCity;
            ViewBag.isRequiredForCity = isRequiredForCity;

            ViewBag.delay = 250;


            return PartialView("_Select2CountryGovCityCascadeSearch");
        }


        public PartialViewResult LoadDivisionSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            return PartialView("_Select2DivisionSearch");
        }
        public PartialViewResult LoadDistrictSearch(string selectid, string divisionid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            ViewBag.divisionid = divisionid;
            return PartialView("_Select2DistrictSearch");
        }


        public PartialViewResult LoadThanaSearch(string selectid, string districtid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            ViewBag.districtid = districtid;
            return PartialView("_Select2ThanaSearch");
        }


        public PartialViewResult LoadOrganizationSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            return PartialView("_Select2OrganizationSearch");
        }

        public PartialViewResult LoadRankKWSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            return PartialView("_Select2RankKWSearch");
        }

        public PartialViewResult LoadLeaveTypeSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false,int isActive=1)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            ViewBag.isActive = isActive;
            return PartialView("_Select2LeaveTypeSearch");
        }
        public PartialViewResult LoadRankBDSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            return PartialView("_Select2RankBDSearch");
        }

        public PartialViewResult LoadTradeKWSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            return PartialView("_Select2TradeKWSearch");
        }

        public PartialViewResult LoadTradeBDSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            return PartialView("_Select2TradeBDSearch");
        }
        #endregion



        #region User
        public PartialViewResult LoadUserSearch(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2UserSearch");
        }
        #endregion

        public PartialViewResult LoadArrivalLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2ArrivalLetterNoSearch");
        }

        public PartialViewResult LoadArrivalLetterNoNewDemand(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2ArrivalLetterNoSearchNewDemand");
        }

        public PartialViewResult LoadArrivalLetterNoReplacement(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2ArrivalLetterNoSearchReplacement");
        }

        public PartialViewResult LoadArrivalLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2ArrivalLetterNoSearch");
        }

        public PartialViewResult LoadDemandLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2DemandLetterNoSearch");
        }
        public PartialViewResult LoadDemandPassportLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2DemandPassportLetterNoSearch");
        }

        public PartialViewResult LoadDemandPassportLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2DemandPassportLetterNoByDate");
        }


        public PartialViewResult LoadReplacementLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2RepLetterNoSearch");
        }

        public PartialViewResult LoadReplacementLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2RepLetterNoSearchByDate");
        }

        public PartialViewResult LoadRepPassportLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2RepPassportLetterNoSearch");
        }

        public PartialViewResult LoadPTADemandLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2PTADemandLetterNoSearch");
        }

        public PartialViewResult LoadPTADemandLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2PTADemandLetterNoSearchByDate");
        }

        public PartialViewResult LoadPTAReceivedLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2PTAReceivedLetterNoSearch");
        }

        public PartialViewResult LoadPTAReceivedLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2PTAReceivedLetterNoSearchByDate");
        }

        public PartialViewResult LoadFlightLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2FlightInfoLetterNoSearch");
        }

        public PartialViewResult LoadFlightLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false,bool IsCancel=false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            ViewBag.IsCancel = IsCancel;

            return PartialView("_Select2FlightInfoLetterNoSearchByDate");
        }

        public PartialViewResult LoadFlightCancelLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false, bool IsCancel = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
          

            return PartialView("_Select2FlightCancelLetterNoSearchByDate");
        }

        public PartialViewResult LoadRepPassportLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2RepPassportLetterNoByDate");
        }


        public PartialViewResult LoadVisaDemandLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false, int IsReplacement = 1)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            ViewBag.IsReplacement = IsReplacement;

            return PartialView("_Select2VisaDemandLetterNoSearch");
        }

      

        public PartialViewResult LoadVisaDemandLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2VisaDemandLetterNoSearchByDate");
        }
        public PartialViewResult LoadVisaIssueLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            

            return PartialView("_Select2VisaIssueLetterNoSearch");
        }
        public PartialViewResult LoadVisaIssueLetterNoNewDemand(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;


            return PartialView("_Select2VisaIssueLetterNoSearchNewDemand");
        }
        public PartialViewResult LoadVisaIssueLetterNoReplacement(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;


            return PartialView("_Select2VisaIssueLetterNoSearchReplacement");
        }

        public PartialViewResult LoadVisaIssueLetterNoByDate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2VisaIssueLetterNoSearchByDate");
        }
        

        public PartialViewResult LoadVisaSentLetterNo(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2VisaSentLetterNoSearch");
        }

        public PartialViewResult LoadVisaSentLetterNoBydate(string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;

            return PartialView("_Select2VisaSentLetterNoSearchByDate");
        }



        public PartialViewResult LoadPassportInfoByBasicId(string selectid, int delay, int minimumInputLength, string preloaded, long? basicId, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            ViewBag.selectid = selectid;
            ViewBag.delay = delay;
            ViewBag.minimumInputLength = minimumInputLength;
            ViewBag.data = preloaded;
            ViewBag.isReadOnly = isReadOnly;
            ViewBag.multiple = multiple;
            ViewBag.isRequired = isRequired;
            ViewBag.basicId = basicId;

            return PartialView("_Select2PassportInfoByBasicIdSearch");
        }

    }
}