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
    public class HrArrivalInfoController : ApiController
    {
        //[CacheOutput(ServerTimeSpan = 120)]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrArrivalInfo/getArrivalInfoLetterNoData")]
        public async Task<IHttpActionResult> getArrivalInfoLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param, int? flightid,DateTime? arrivalletterdate,int demandtype)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

                hr_arrivalinfoEntity input = new hr_arrivalinfoEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);

                if (flightid.HasValue)
                {
                    input.flightid = flightid;
                }
                else if (arrivalletterdate.HasValue)
                {
                    input.arrivalletterdate = arrivalletterdate;
                }
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;
                }


                var itemList = new List<hr_arrivalinfoEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_arrivalinfoFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);


                if (demandtype == 1)
                {
                    itemList = itemList.Where(p => p.ex_bigint1 == 1).ToList();
                    totalRecords = itemList.Count();
                }
                else if (demandtype == 2)
                {
                    itemList = itemList.Where(p => p.ex_bigint1 == 2).ToList();
                    totalRecords = itemList.Count();
                }

                var data = (from t in itemList
                            select new
                            {
                                Id = t.arrivalld,
                                Text = t.arrivalletterno,
                                arrivaldate=t.arrivaldate.Value.ToString("dd-MM-yyyy"),
                                arrivalletterdate=t.arrivalletterdate.Value.ToString("dd-MM-yyyy"),
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
