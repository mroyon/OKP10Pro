using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.WebAPICommon.Filter;
using KAFWebAPIServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
//using WebApi.OutputCache.V2;

namespace KAFWebAPIServices.Controllers
{
    public class GovCityController : ApiController
    {
        /// <summary>
        /// getGovCityData: Get all data including gov and city by paged.
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNum"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        //[CacheOutput(ServerTimeSpan = 120)]
        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/GovCity/getGovCityData")]
        public async Task<IHttpActionResult> getGovCityData(string searchTerm, int? pageSize, int? pageNum, string param)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

       
                gen_govcityEntity input = new gen_govcityEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";
                input.isgov = true;

                var itemList = new List<gen_govcityEntity>();
                itemList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCSelectTwo.GetFacadeCreate().GetPaged_Gen_GovCity(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.cityid,
                                Text = t.cityname
                            }).ToList();

                var result = new
                {
                    Total = totalRecords,
                    Results = data
                };
                return Json(new { result }); // Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// getGovData - Get only gov data paged
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNum"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        //[CacheOutput(ServerTimeSpan = 120)]
        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/GovCity/getGovData")]
        public async Task<IHttpActionResult> getGovData(string searchTerm, int? pageSize, int? pageNum, string param)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;


                gen_govcityEntity input = new gen_govcityEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";
                input.isgov = true;


                var itemList = new List<gen_govcityEntity>();
                itemList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCSelectTwo.GetFacadeCreate().GetPaged_Gen_GovCity(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.cityid,
                                Text = t.cityname
                            }).ToList();

                var result = new
                {
                    Total = totalRecords,
                    Results = data
                };
                return Json(new { result }); // Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        /// <summary>
        /// geCityByGovData - get city data by gov ID, paged. the gov Id should be send using the param "param".
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNum"></param>
        /// <param name="param">send the selected gov id to load the city under this government.</param>
        /// <returns></returns>
        //[CacheOutput(ServerTimeSpan = 120)]
        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/GovCity/geCityByGovData")]
        public async Task<IHttpActionResult> geCityByGovData(string searchTerm, int? pageSize, int? pageNum, string param)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;


                gen_govcityEntity input = new gen_govcityEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";
                input.isgov = false;
                input.parentid = string.IsNullOrEmpty(param) ? (long?)null : long.Parse(param);


                var itemList = new List<gen_govcityEntity>();
                itemList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCSelectTwo.GetFacadeCreate().GetPaged_Gen_GovCity(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.cityid,
                                Text = t.cityname
                            }).ToList();

                var result = new
                {
                    Total = totalRecords,
                    Results = data
                };
                return Json(new { result }); // Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //[CacheOutput(ServerTimeSpan = 120)]
        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/GovCity/getGovDataByCountry")]
        public async Task<IHttpActionResult> getGovDataByCountry(string searchTerm, int? pageSize, int? pageNum, string param)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;


                gen_govcityEntity input = new gen_govcityEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";
                input.isgov = false;
                input.countryid = string.IsNullOrEmpty(param) ? (long?)null : long.Parse(param);


                var itemList = new List<gen_govcityEntity>();
                itemList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCSelectTwo.GetFacadeCreate().GetPaged_Gen_GovCity(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.cityid,
                                Text = t.cityname
                            }).ToList();

                var result = new
                {
                    Total = totalRecords,
                    Results = data
                };
                return Json(new { result }); // Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
