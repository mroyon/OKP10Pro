
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
using System.ComponentModel;
using System.Data;

namespace KAF.MVC.Common
{
    public class DataCacheController : BaseController
    {
        public clsPrivateKeys objClsPrivate = new clsPrivateKeys();
        public clsModelStateValidation objModelVal = new clsModelStateValidation();

        #region Dropdown partial
        public PartialViewResult LoadComboBox(string EntityName, string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false, bool isStatic = false, string selectedvalue = "")
        {
            try
            {
                ViewBag.selectid = selectid;
                ViewBag.delay = delay;
                ViewBag.minimumInputLength = minimumInputLength;
                ViewBag.data = preloaded;
                ViewBag.isReadOnly = isReadOnly;
                ViewBag.multiple = multiple;
                ViewBag.isRequired = isRequired;
                ViewBag.EntityName = EntityName;
                ViewBag.isStatic = isStatic;
                ViewBag.selectedvalue = selectedvalue;
                if (isStatic == true)
                {
                    EntityName = EntityName.Substring(0, EntityName.Length - 6);
                    EntityName = "set_" + EntityName.ToLower();
                    ICache cacheManagerCache = new CacheManagerProvider();
                    IList<KAFGenericComboEntity> list = cacheManagerCache.Get<IList<KAFGenericComboEntity>>(EntityName);
                    ViewBag.staticData = new JavaScriptSerializer().Serialize(list);
                    //ViewBag.data = new JavaScriptSerializer().Serialize(list);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return PartialView("_GenericCombo");
        }
        public PartialViewResult LoadComboBoxWithException(string EntityName, string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false, bool isStatic = false, string selectedvalue = "", string exceptionIds = "")
        {
            try
            {
                ViewBag.selectid = selectid;
                ViewBag.delay = delay;
                ViewBag.minimumInputLength = minimumInputLength;
                ViewBag.data = preloaded;
                ViewBag.isReadOnly = isReadOnly;
                ViewBag.multiple = multiple;
                ViewBag.isRequired = isRequired;
                ViewBag.EntityName = EntityName;
                ViewBag.isStatic = isStatic;
                ViewBag.selectedvalue = selectedvalue;
                if (isStatic == true)
                {
                    EntityName = EntityName.Substring(0, EntityName.Length - 6);
                    EntityName = "set_" + EntityName.ToLower();
                    ICache cacheManagerCache = new CacheManagerProvider();
                    IList<KAFGenericComboEntity> list = cacheManagerCache.Get<IList<KAFGenericComboEntity>>(EntityName);

                    int[] listException = Array.ConvertAll<string, int>(exceptionIds.Split(','), Convert.ToInt32).ToArray();
                    List<long> listExceptionIds = new List<long>(exceptionIds.Split(',').Select(long.Parse));

                    var query = list
                        .Select(x => new { x.comId, x.comText })
                        .Where(y => !listExceptionIds.Contains(y.comId)).ToList();

                    ViewBag.staticData = new JavaScriptSerializer().Serialize(query);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return PartialView("_GenericCombo");
        }

        public PartialViewResult LoadComboBoxWithCascadeOption(string EntityName, string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false, bool isStatic = false, string selectedvalue = "", string cascadewith = null)
        {
            try
            {
                ViewBag.selectid = selectid;
                ViewBag.delay = delay;
                ViewBag.minimumInputLength = minimumInputLength;
                ViewBag.data = preloaded;
                ViewBag.isReadOnly = isReadOnly;
                ViewBag.multiple = multiple;
                ViewBag.isRequired = isRequired;
                ViewBag.EntityName = EntityName;
                ViewBag.isStatic = isStatic;
                ViewBag.selectedvalue = selectedvalue;
                if (isStatic == true)
                {
                    EntityName = EntityName.Substring(0, EntityName.Length - 6);
                    EntityName = "set_" + EntityName.ToLower();
                    ICache cacheManagerCache = new CacheManagerProvider();
                    IList<KAFGenericComboEntity> list = cacheManagerCache.Get<IList<KAFGenericComboEntity>>(EntityName);



                    var query = list
                        .Where(t => t.comText2 == cascadewith)
                        .Select(x => new { x.comId, x.comText }).ToList();

                    ViewBag.staticData = new JavaScriptSerializer().Serialize(query);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return PartialView("_GenericCombo");
        }

        public PartialViewResult LoadComboBoxWithCascadeOptionAndException(string EntityName, string selectid, int delay, int minimumInputLength, string preloaded, bool isReadOnly = false, bool multiple = false, bool isRequired = false, bool isStatic = false, string selectedvalue = "", string cascadewith = null, string exceptionIds = "")
        {
            try
            {
                ViewBag.selectid = selectid;
                ViewBag.delay = delay;
                ViewBag.minimumInputLength = minimumInputLength;
                ViewBag.data = preloaded;
                ViewBag.isReadOnly = isReadOnly;
                ViewBag.multiple = multiple;
                ViewBag.isRequired = isRequired;
                ViewBag.EntityName = EntityName;
                ViewBag.isStatic = isStatic;
                ViewBag.selectedvalue = selectedvalue;
                if (isStatic == true)
                {
                    EntityName = EntityName.Substring(0, EntityName.Length - 6);
                    EntityName = "set_" + EntityName.ToLower();
                    ICache cacheManagerCache = new CacheManagerProvider();
                    IList<KAFGenericComboEntity> list = cacheManagerCache.Get<IList<KAFGenericComboEntity>>(EntityName);

                    int[] listException = Array.ConvertAll<string, int>(exceptionIds.Split(','), Convert.ToInt32).ToArray();
                    List<long> listExceptionIds = new List<long>(exceptionIds.Split(',').Select(long.Parse));

                    var query = list
                        .Where(t => t.comText2 == cascadewith)
                        .Select(x => new { x.comId, x.comText }).ToList();

                     query = query
                       .Select(x => new { x.comId, x.comText })
                       .Where(y => !listExceptionIds.Contains(y.comId)).ToList();

                    ViewBag.staticData = new JavaScriptSerializer().Serialize(query);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return PartialView("_GenericCombo");
        }

        public PartialViewResult LoadCascadeCourse(string coursegroupid, string milcoursetypeid, string courseid,
            string preloadedCoursegroup, string preloadedMilcoursetype, string preloadedCourse,
            int delay, int minimumInputLength, bool isReadOnly = false, bool multiple = false, bool isRequired = false)
        {
            try
            {
                ViewBag.coursegroupid = coursegroupid;
                ViewBag.milcoursetypeid = milcoursetypeid;
                ViewBag.courseid = courseid;

                ViewBag.delay = delay;
                ViewBag.minimumInputLength = minimumInputLength;
                ViewBag.isReadOnly = isReadOnly;
                ViewBag.multiple = multiple;
                ViewBag.isRequired = isRequired;

                ViewBag.selectedValCoursegroup = preloadedCoursegroup;
                ViewBag.selectedValmilcoursetype = preloadedMilcoursetype;
                ViewBag.selectedValCourse = preloadedCourse;

                ICache cacheManagerCache = new CacheManagerProvider();

                IList<KAFGenericComboEntity> listCourseGroup = cacheManagerCache.Get<IList<KAFGenericComboEntity>>("set_gen_coursegroup");
                ViewBag.staticDataForCourseGroup = new JavaScriptSerializer().Serialize(listCourseGroup);

                IList<KAFGenericComboEntity> listcoursetype = cacheManagerCache.Get<IList<KAFGenericComboEntity>>("set_gen_millcoursetype");
                ViewBag.staticDataForCourseType = new JavaScriptSerializer().Serialize(listcoursetype);

                //IList<KAFGenericComboEntity> listcourse = cacheManagerCache.Get<IList<KAFGenericComboEntity>>("set_gen_courseentity");
                //ViewBag.staticDataForCourse = new JavaScriptSerializer().Serialize(listcourse);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView("_Select2CacheableMilitaryCourseCascade");
        }
        #endregion

        #region Generic Combo Load

        [HttpGet]
        public ActionResult GetGenericComboData(string searchTerm, int pageSize, int pageNum, string EntityName)
        {
            try
            {
                //Type typet = Type.GetType("KAF.BusinessDataObjects."+ EntityName + ", KAF.BusinessDataObjects");
                //object calcInstance = Activator.CreateInstance(typet);

                EntityName = EntityName.Substring(0, EntityName.Length - 6);
                EntityName = "set_" + EntityName.ToLower();
                ICache cacheManagerCache = new CacheManagerProvider();
                IList<KAFGenericComboEntity> list = cacheManagerCache.Get<IList<KAFGenericComboEntity>>(EntityName);

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    return new JsonResult
                    {
                        Data = list.Where(p => p.comText.ToLower().Contains(searchTerm.ToLower())).ToList(),
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };
                }
                else
                    return new JsonResult
                    {
                        Data = list,
                        JsonRequestBehavior = JsonRequestBehavior.AllowGet
                    };

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        public IList<KAFGenericComboEntity> GetCacheData(string EntityName)
        {
            try
            {
                EntityName = EntityName.Substring(0, EntityName.Length - 6);
                EntityName = "set_" + EntityName.ToLower();
                ICache cacheManagerCache = new CacheManagerProvider();
                IList<KAFGenericComboEntity> list = cacheManagerCache.Get<IList<KAFGenericComboEntity>>(EntityName);
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult GetCacheDataWithCascadeOption(string EntityName, long? cascadewith = null)
        {
            try
            {
                List<KAFGenericComboEntity> selectitem = new List<KAFGenericComboEntity>() {
                    new KAFGenericComboEntity{
                        comId=0,
                        comText="Plase Select"
                    }
                };

                EntityName = EntityName.Substring(0, EntityName.Length - 6);
                EntityName = "set_" + EntityName.ToLower();
                ICache cacheManagerCache = new CacheManagerProvider();
                IList<KAFGenericComboEntity> list = cacheManagerCache.Get<IList<KAFGenericComboEntity>>(EntityName);

                List<KAFGenericComboEntity> query = list
                      .Where(t => t.comText2 == cascadewith.ToString())
                      .Select(x => new KAFGenericComboEntity { comId = x.comId, comText = x.comText }).ToList();

                //selectitem.AddRange(query);

                return Json(query.Select(x => new { id = x.comId, text = x.comText }).ToList());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}