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
    public class HrMilitaryProfileController : ApiController
    {
        [Authorize]
        [ClaimsUserFilter]
        [LoggingFilter]
        [ExceptionFilter]
        [Route("api/HrMilitaryProfile/GetMilitaryInfoData")]
        public async Task<IHttpActionResult> GetMilitaryInfoData(string civilid, string passportno)
        {
            try
            {
                hr_basicprofileEntity objloader = new hr_basicprofileEntity();
                
                if (!string.IsNullOrEmpty(civilid))
                    objloader.civilid = long.Parse(civilid.Trim());

                if (!string.IsNullOrEmpty(passportno))
                    objloader.passportno = passportno.Trim();


                List<hr_basicprofileEntity> obj = new List<hr_basicprofileEntity>();

                obj = KAF.FacadeCreatorObjects.hr_basicprofileFCC.GetFacadeCreate().GetAll_Ext(objloader).ToList();

                await Task.Delay(1).ConfigureAwait(true);

                if (obj != null && obj.Count > 0)
                    return Ok(obj);
                else
                    return NotFound();
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
        [Route("api/HrMilitaryProfile/GetMilitaryServiceInfoData")]
        public async Task<IHttpActionResult> GetMilitaryServiceInfoData(string militarynokw, string militarynobd)
        {
            try
            {
                hr_svcinfoEntity objloader = new hr_svcinfoEntity();
                List<hr_svcinfoEntity> obj = new List<hr_svcinfoEntity>();

                if (!string.IsNullOrEmpty(militarynokw))
                {
                    objloader.militarynokw = long.Parse(militarynokw.Trim());
                    objloader.status = 3;

                    obj = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objloader).ToList();
                    await Task.Delay(1).ConfigureAwait(true);

                    if (obj != null && obj.Count > 0)
                        return Ok(obj);
                    else
                        return NotFound();
                }

                if (!string.IsNullOrEmpty(militarynobd) &&  militarynobd.All(char.IsNumber))
                {
                    objloader.militarynobd = militarynobd.Trim();
                    objloader.status = 3;

                    obj = KAF.FacadeCreatorObjects.hr_svcinfoFCC.GetFacadeCreate().GetAll_Ext(objloader).ToList();

                    await Task.Delay(1).ConfigureAwait(true);

                    if (obj != null && obj.Count > 0)
                        return Ok(obj);
                    else
                        return NotFound();
                }


                return NotFound();



            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
