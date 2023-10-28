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
    public class HrVisaDemandInfoController : ApiController
    {
        //[CacheOutput(ServerTimeSpan = 120)]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrVisaDemandInfo/getVisaDemandLetterNoData")]
        public async Task<IHttpActionResult> getVisaDemandLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param, int? passportinfoid, DateTime? visademandletterdate,int? isreplacement)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

      
                hr_visademandinfoEntity input = new hr_visademandinfoEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);

                if (passportinfoid.HasValue)
                {
                    input.passportinfoid = passportinfoid;
                }
                else if (visademandletterdate.HasValue)
                {
                    input.visademandletterdate = visademandletterdate;
                }
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;

                }

                var itemList = new List<hr_visademandinfoEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_visademandinfoFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.visademandid,
                                Text = t.visademandletterno,
                                visademanddate = t.visademanddate.Value.ToString("dd-MM-yyyy"),
                                visademandletterdate = t.visademandletterdate.Value.ToString("dd-MM-yyyy")
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
