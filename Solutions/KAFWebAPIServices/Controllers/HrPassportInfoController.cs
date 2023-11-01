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
    public class HrPassportInfoController : ApiController
    {
        //[CacheOutput(ServerTimeSpan = 120)]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrPassportInfo/getPassportInfo")]
        public async Task<IHttpActionResult> getPassportInfo(string searchTerm, int? pageSize, int? pageNum, string param,long? hrbasicId)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

      
                hr_passportinfoEntity input = new hr_passportinfoEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
               
              
                if (hrbasicId.HasValue)
                {
                    input.hrbasicid = hrbasicId;
                }
                else
                {
                    input.strCommonSerachParam = common.searchTerm != null && common.searchTerm.Length > 0 ? "%" + common.searchTerm + "%" : null;

                }
                input.iscurrent = true;

                var itemList = new List<hr_passportinfoEntity>();
                itemList = KAF.FacadeCreatorObjects.hr_passportinfoFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.passportid,
                                Text = t.passportno,
                                passportrecvdate = t.passportissuedate.HasValue ? t.passportissuedate.Value.ToString("dd-MM-yyyy") : null,
                                passportletterdate = t.passportexpirydate.HasValue ? t.passportexpirydate.Value.ToString("dd-MM-yyyy") : null
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
