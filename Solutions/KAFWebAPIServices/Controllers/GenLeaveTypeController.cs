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
using WebApi.OutputCache.V2;

namespace KAFWebAPIServices.Controllers
{
    //[AutoInvalidateCacheOutput]
    //[CacheOutput(ClientTimeSpan = 60, ServerTimeSpan = 60)]
    public class GenLeaveTypeController : ApiController
    {
        
        // GET api/cache         
       
        //[CacheOutput(ServerTimeSpan = 120)]
        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/GenLeaveType/getGenLeaveTypeData")]
        public async Task<IHttpActionResult> getGenLeaveTypeData(string searchTerm, int? pageSize, int? pageNum, string param)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;

                gen_leavetypeEntity input = new gen_leavetypeEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";
                input.isactive = string.IsNullOrEmpty(param) || param == "0" ? false : true;
               

                var itemList = new List<gen_leavetypeEntity>();
                itemList = KAF.FacadeCreatorObjects.gen_leavetypeFCC.GetFacadeCreate().GetAllByPages(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.leavetypeid,
                                Text = t.leavetype
                            }).ToList();

                var result = new
                {
                    Total = totalRecords,
                    Results = data
                };
                return Json(new { result });
            }
            catch (Exception ex)
            {
                //string=ex.TosTring();
                return Json(new { status = KAF.MsgContainer._Status._statusFailed, title = KAF.MsgContainer._Status._titleGenericError, redirectUrl = "", responsetext = ex.Message });
            }
        }



    }
}
