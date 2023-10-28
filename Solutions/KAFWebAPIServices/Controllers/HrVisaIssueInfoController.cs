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
    public class HrVisaIssueInfoController : ApiController
    {
        //[CacheOutput(ServerTimeSpan = 120)]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrVisaIssueInfo/getVisaIssueLetterNoData")]
        public async Task<IHttpActionResult> getVisaIssueLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param, int? visademandid,DateTime? visaissueletterdate,int? demandtype)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

                hr_visaissueinfoEntity input = new hr_visaissueinfoEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);

                if (visademandid.HasValue)
                {
                    input.visademandid = visademandid;
                }
                else if (visaissueletterdate.HasValue)
                {
                    input.visaissueletterdate = visaissueletterdate;
                }
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;

                }

                var itemList = new List<hr_visaissueinfoEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_visaissueinfoFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }

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

                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.visaissueid,
                                Text = t.visaissueletterno,
                                visaissuedate = t.visaissuedate.Value.ToString("dd-MM-yyyy"),
                                visaissueletterdate = t.visaissueletterdate.Value.ToString("dd-MM-yyyy")
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
