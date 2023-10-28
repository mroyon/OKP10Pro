using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace KAFWebAPIServices.HelperClass
{
    //public interface IUserInfo
    //{
    //    string username { get; }
    //    string email { get; }
    //    string trantoken { get; }
    //    bool IsAuthenticated { get; }
    //}

    public class WebUserInfo //: IUserInfo
    {
        public SecurityCapsule _securityCapsule { get; set; }

        public WebUserInfo(ClaimsIdentity claims, HttpContext httpContext)
        {
            _securityCapsule = new SecurityCapsule();
            try
            {
                _securityCapsule.isauthenticated = httpContext.User.Identity.IsAuthenticated;
                if (claims != null)
                {
                    _securityCapsule.username = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").FirstOrDefault().Value;
                    _securityCapsule.usernumber = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone").FirstOrDefault().Value;
                    _securityCapsule.userorganizationkey = long.Parse(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince").FirstOrDefault().Value);
                    _securityCapsule.userentitykey = long.Parse(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode").FirstOrDefault().Value);

                    _securityCapsule.pageurl = httpContext.Request.FilePath;// claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri").FirstOrDefault().Value;
                    _securityCapsule.ipaddress = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone").FirstOrDefault().Value;

                    _securityCapsule.controllername = httpContext.Request.FilePath;
                    _securityCapsule.actioname = httpContext.Request.HttpMethod;

                    _securityCapsule.createdby = long.Parse(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress").FirstOrDefault().Value);
                    _securityCapsule.updatedby = _securityCapsule.createdby;
                    _securityCapsule.createdbyusername = _securityCapsule.username;
                    _securityCapsule.updatedbyusername = _securityCapsule.username;
                    _securityCapsule.userid = new Guid(claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);

                    _securityCapsule.fullname = _securityCapsule.username;
                    _securityCapsule.email = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;
                    _securityCapsule.hitfrom = KAF.ConstantTypes.clsSystemConstantTypes.LoggedModeWeb;
                    _securityCapsule.actiondate = DateTime.Now;
                    //_securityCapsule.usertoken = ticket;

                    _securityCapsule.sessionid = _securityCapsule.username;
                    _securityCapsule.transid = claims.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country").FirstOrDefault().Value;
                    _securityCapsule.raisingevent = "token";
                }
            }
            catch (Exception ex)
            {
                _securityCapsule.isauthenticated = false;
                _securityCapsule.username = string.Empty;
            }
        }
    }
}