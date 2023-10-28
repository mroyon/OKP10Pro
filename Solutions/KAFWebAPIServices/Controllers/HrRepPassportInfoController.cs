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
    public class HrRepPassportInfoController : ApiController
    {
        //[CacheOutput(ServerTimeSpan = 120)]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrRepPassportInfo/getRepPassportLetterNoData")]
        public async Task<IHttpActionResult> getRepPassportLetterNoData(string searchTerm, int? pageSize, int? pageNum, string param,int? replacementid, DateTime? passportletterdate)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

      
                hr_reppassportinfoEntity input = new hr_reppassportinfoEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
               
              
                if (replacementid.HasValue)
                {
                    input.replacementid = replacementid;
                }
                else if (passportletterdate.HasValue)
                {
                    input.passportletterdate = passportletterdate;
                }
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;

                }


                var itemList = new List<hr_reppassportinfoEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_reppassportinfoFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.reppassportid,
                                Text = t.passportletterno,
                                passportrecvdate=t.passportrecvdate.Value.ToString("dd-MM-yyyy"),
                                passportletterdate=t.passportletterdate.Value.ToString("dd-MM-yyyy")
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
