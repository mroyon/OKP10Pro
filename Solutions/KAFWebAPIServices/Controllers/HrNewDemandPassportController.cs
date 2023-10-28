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
    public class HrNewDemandPassportController : ApiController
    {
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrNewDemandPassport/getNewDemandPassportLetterNoData")]
        public async Task<IHttpActionResult> getNewDemandPassportLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param, int? newdemandid)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;


                hr_demanddetlpassportEntity input = new hr_demanddetlpassportEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";
                input.newdemandid = newdemandid;

                var itemList = new List<hr_demanddetlpassportEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_demanddetlpassportFCC.GetFacadeCreate().GetDemandPassportLetterNoByNewDemandID(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.letterno.Trim(),
                                Text = t.letterno.Trim(),
                                demandletterdate=t.demandletterdate,
                                demandletterno=t.demandletterno
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
        [Route("api/HrNewDemandPassport/getNewDemandPassportLetterNoByLetterDateData")]
        public async Task<IHttpActionResult> getNewDemandPassportLetterNoByLetterDateData(string searchTerm, int? pageSize, int? pageNum, string param, DateTime? letterdate)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;


                hr_newdemandEntity input = new hr_newdemandEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";
                //input.newdemandid = newdemandid;
                input.demandletterdate = letterdate;

                var itemList = new List<hr_newdemandEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_newdemandFCC.GetFacadeCreate().GetAll(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.newdemandid.Value,
                                Text = t.demandletterno.Trim(),
                                demandletterdate=t.demandletterdate.Value.ToString("dd-MM-yyyy")
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
