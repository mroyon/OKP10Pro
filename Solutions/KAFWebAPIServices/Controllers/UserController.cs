using KAF.BusinessDataObjects;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.WebAPICommon.Filter;
using KAFWebAPIServices.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace KAFWebAPIServices.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/User/{namechar}")]
        public async Task<IHttpActionResult> GetUserByNameLike(string namechar)
        {
            List<owin_userEntity> obj = new List<owin_userEntity>();
            var userList = obj;
            try
            {
                //int i = 0;
                //int j = 10;
                //decimal k = j / i;
                var objList = await GetUserList();
                await CreateJob();
                //await Task.Delay(1).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(new { result = userList });
        }


        private async Task CreateJob()
        {
            var config = (NameValueCollection)ConfigurationManager.GetSection("quartz");

            //StdSchedulerFactory factory = new StdSchedulerFactory(config);
            //IScheduler sched = await factory.GetScheduler();

            //var startTime = DateTimeOffset.Now.AddSeconds(50);

            //var job = JobBuilder.Create<EmailJob>()
            //           .WithIdentity("job1", "group1")
            //           .Build();

            ////ITrigger trigger = TriggerBuilder.Create()
            ////  .WithIdentity($"Trigger at {DateTime.Now}", "group1")
            ////  .StartAt(startTime)
            ////  .WithSimpleSchedule(x => x
            ////    .WithIntervalInSeconds(10)
            ////    .RepeatForever())
            ////  .Build();

            //ITrigger trigger = TriggerBuilder.Create()
            //  .WithIdentity($"Trigger at {DateTime.Now}", "group1")
            //  .StartAt(startTime)
            //  .ForJob("job1", "group1")
            //  .Build();

            //await sched.ScheduleJob(job, trigger);
        }

        public async Task<List<owin_userEntity>> GetUserList()
        {
            List<owin_userEntity> obj = new List<owin_userEntity>();
            try
            {
                obj = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GetAll(new owin_userEntity()).ToList();
                await Task.Delay(1).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
            return obj;
        }



        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        public async Task<IHttpActionResult> GetUserByNameLike()
        {
            List<owin_userEntity> obj = new List<owin_userEntity>();
            var userList = obj;
            try
            {
                //int i = 0;
                //int j = 10;
                //decimal k = j / i;

                await Task.Delay(1).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(new { result = userList });
        }


        [HttpGet]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/User/{usernamechar}/{usernamechar2}")]
        public async Task<IHttpActionResult> GetUserByNameLike(string usernamechar, string usernamechar2)
        {
            List<owin_userEntity> obj = new List<owin_userEntity>();
            var userList = obj;
            try
            {
                //int i = 0;
                //int j = 10;
                //decimal k = j / i;

                await Task.Delay(1).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(new { result = userList });
        }

        [HttpPost]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("GetUserNameListByObject")]
        public async Task<IHttpActionResult> GetUserByNameLike(KAF.BusinessDataObjects.owin_userEntity userObject)
        {
            List<owin_userEntity> obj = new List<owin_userEntity>();
            var userList = obj;
            try
            {
                //int i = 0;
                //int j = 10;
                //decimal k = j / i;

                await Task.Delay(1).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(new { result = userList });
        }


        [HttpPost]
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/User/SearchUserList")]
        public async Task<HttpResponseMessage> SearchUserList([FromBody] string searchparam)
        {
            object jsonResult = null;
            try
            {
                if (searchparam.Length > 0)
                {
                    List<owin_userEntity> objUserList = new List<owin_userEntity>();
                    objUserList = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.owin_userFCC.GetFacadeCreate().SearchUser(new owin_userEntity()
                    {
                        username = searchparam
                    }).OrderBy(p=>p.username) .ToList();
                    await Task.Delay(1).ConfigureAwait(true);
                    jsonResult = objUserList.Select(results => new { id = results.userid, name = results.username });

                    //await CreateJob();
                    //return Json(jsonResult);
                    return Request.CreateResponse(HttpStatusCode.OK, jsonResult);
                }
            }
            catch (Exception)
            {

                throw;
            }
            //return Json(jsonResult);
            return Request.CreateResponse(HttpStatusCode.OK, jsonResult);
        }

        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/User/getUserData")]
        public async Task<IHttpActionResult> getUserData(string searchTerm, int? pageSize, int? pageNum, string param)
        {
            try
            {
                CommonDTO common = new CommonDTO();
                common.searchTerm = searchTerm;
                common.pageNum = pageNum;
                common.pageSize = pageSize;
                common.param = param;


                owin_userEntity input = new owin_userEntity();

                input.BaseSecurityParam = new SecurityCapsule();
                input.CurrentPage = common.pageNum.GetValueOrDefault(0);
                input.PageSize = common.pageSize.GetValueOrDefault(0);
                input.strCommonSerachParam = "%" + common.searchTerm + "%";


                var itemList = new List<owin_userEntity>();
                itemList = KAF.FacadeCreatorObjects.owin_userFCC.GetFacadeCreate().GAPgListView(input).ToList();

                long totalRecords = 0;

                if (itemList.Count > 0)
                {
                    totalRecords = itemList.FirstOrDefault().RETURN_KEY;
                }
                await Task.Delay(1).ConfigureAwait(true);
                var data = (from t in itemList
                            select new
                            {
                                Id = t.masteruserid,
                                Text = t.username+"( " + t.loweredusername + " )"
                            }).ToList().OrderBy(p=>p.Text);

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
