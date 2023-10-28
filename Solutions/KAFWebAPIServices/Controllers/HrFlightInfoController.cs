using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
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
    public class HrFlightInfoController : ApiController
    {
        //[CacheOutput(ServerTimeSpan = 120)]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrFlightInfo/getFlightInfoLetterNoData")]
        public async Task<IHttpActionResult> getFlightInfoLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param, int? ptademandid, DateTime? flightletterdate,bool? iscancel)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

                hr_flightinfoEntity input = new hr_flightinfoEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);

                if (ptademandid.HasValue)
                {
                    input.ptademandid = ptademandid;
                }
                else if (flightletterdate.HasValue)
                {
                    input.flightletterdate = flightletterdate;
                }
                else if (iscancel.HasValue)
                {
                    input.iscancel = true;
                }
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;
                }

                var itemList = new List<hr_flightinfoEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_flightinfoFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);

                var data = (from t in itemList
                            select new
                            {
                                Id = t.flightid,
                                Text = t.flightletterno,
                                flightletterdate = t.flightletterdate.Value.ToString("dd-MM-yyyy"),
                                flightdate = t.flightdate.Value.ToString("dd-MM-yyyy"),
                                airlinesid=t.airlinesid.Value
                                
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

        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrFlightInfo/getFlightCancelLetterNoData")]
        public async Task<IHttpActionResult> getFlightCancelLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param,  DateTime? cancelletterdate)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

                hr_flightcancelinfo_GAPgListView_ExtEntity input = new hr_flightcancelinfo_GAPgListView_ExtEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);

                 if (cancelletterdate.HasValue)
                {
                    input.FlightDate = cancelletterdate;
                }
               
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;
                }

                var itemList = new List<hr_flightcancelinfo_GAPgListView_ExtEntity>();
                itemList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCReportExtension.GetFacadeCreate().GET_hr_flightcancelinfo_GAPgListView_Ext(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);

                var data = (from t in itemList
                            select new
                            {
                                Id = t.FlightID,
                                Text = t.FlightLetterNo,
                               
                                flightdate= t.FlightDate.Value.ToString("dd-MM-yyyy"),
                                flightletterdate=t.FlightLetterDate.Value.ToString("dd-MM-yyyy"),
                                flightletterno=t.FlightLetterNo

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
