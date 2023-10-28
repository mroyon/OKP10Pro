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
    public class HrPTADemandController : ApiController
    {
        //[CacheOutput(ServerTimeSpan = 120)]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrPTADemand/getHrPTADemandLetterNoData")]
        public async Task<IHttpActionResult> getHrPTADemandLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param, int? visasentid, DateTime? ptiletterdate)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

                hr_ptademandEntity input = new hr_ptademandEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);

                if (visasentid.HasValue)
                {
                    input.visasentid = visasentid;
                }
                else if (ptiletterdate.HasValue)
                {
                    input.ptiletterdate = ptiletterdate;
                }
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;

                }


                var itemList = new List<hr_ptademandEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_ptademandFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.ptademandid,
                                Text = t.ptiletterno,
                                ptiletterdate = t.ptiletterdate.Value.ToString("dd-MM-yyyy"),
                                ptidate = t.ptidate.Value.ToString("dd-MM-yyyy")
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
