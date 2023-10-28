using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAF.WebAPICommon.HelperClass;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;

namespace KAF.WebAPICommon.Provider
{
    public class CustomOAuthProvider : OAuthAuthorizationServerProvider
    {
        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            clsMongoLog objLog = new clsMongoLog();
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            KAF_GetUserInfoByCredentialEntity objUser = new KAF_GetUserInfoByCredentialEntity();
            objUser = KAF.FacadeCreatorObjects.FacadeCreatorObjectsPartial.FCCKAFUserSecurity.GetFacadeCreate().
                ValidateInfoByUserNameAndPassword(context.UserName, context.Password, "");

            if (objUser != null)
            {
                DateTime dot = DateTime.Now;
                KAF.AppConfiguration.Configuration.transactioncodeGen objTranIDGen = new KAF.AppConfiguration.Configuration.transactioncodeGen();
                string privateToken = objTranIDGen.GetRandomAlphaNumericStringForTransactionActivity("API", dot);

                var identity = new ClaimsIdentity("JWT");
                identity.AddClaim(new Claim(ClaimTypes.Name, objUser.username));
                identity.AddClaim(new Claim(ClaimTypes.Email, objUser.emailaddress));
                identity.AddClaim(new Claim(ClaimTypes.StreetAddress, objUser.masteruserid.GetValueOrDefault().ToString()));
                identity.AddClaim(new Claim(ClaimTypes.MobilePhone, objUser.mobilenumber));
                identity.AddClaim(new Claim(ClaimTypes.Gender, objUser.userid.GetValueOrDefault().ToString()));
                identity.AddClaim(new Claim(ClaimTypes.Country, privateToken));
                identity.AddClaim(new Claim(ClaimTypes.Uri, ((Microsoft.Owin.OwinRequest)context.Request).Uri.AbsoluteUri));
                identity.AddClaim(new Claim(ClaimTypes.OtherPhone, ((Microsoft.Owin.OwinRequest)context.Request).LocalIpAddress));
                identity.AddClaim(new Claim(ClaimTypes.Upn, context.Request.QueryString.Value));
                identity.AddClaim(new Claim(ClaimTypes.StateOrProvince, objUser.userorganizationkey.GetValueOrDefault().ToString()));
                identity.AddClaim(new Claim(ClaimTypes.PostalCode, objUser.userentitykey.GetValueOrDefault().ToString()));

                var props = new AuthenticationProperties(new Dictionary<string, string>
                            {
                                {
                                    "userdisplayname", context.UserName
                                },
                                {
                                     "role", "admin"
                                }
                             });


                var ticket = new AuthenticationTicket(identity, props);
                context.Validated(ticket);

                string msg = "User: " + objUser.username + " Logged: " + dot.ToString("dd/mm/yyyy hh:mm:ss") + " TrainsID: " + privateToken;
                objLog.SetLog(FillSec(identity, ticket.ToString()), new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), msg, LOGLevel.Info);
                return Task.FromResult<object>(null);
            }
            else
            {
                context.SetError("invalid_grant", "The user name or password is incorrect");
                context.Rejected();
                return Task.FromResult<object>(null);
            }

        }


        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
            return Task.FromResult<object>(null);
        }


        private SecurityCapsule FillSec(ClaimsIdentity identity,
                string ticket)
        {
            SecurityCapsule _securityCapsule = new SecurityCapsule();

            try
            {
                _securityCapsule.username = identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").FirstOrDefault().Value;
                _securityCapsule.usernumber = identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone").FirstOrDefault().Value;
                _securityCapsule.userorganizationkey = long.Parse(identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince").FirstOrDefault().Value);
                _securityCapsule.userentitykey = long.Parse(identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode").FirstOrDefault().Value);

                _securityCapsule.pageurl = identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri").FirstOrDefault().Value;
                _securityCapsule.ipaddress = identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone").FirstOrDefault().Value;
                _securityCapsule.controllername = "GetToken";
                _securityCapsule.actioname = "Tickets";

                _securityCapsule.createdby = long.Parse(identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress").FirstOrDefault().Value);
                _securityCapsule.updatedby = _securityCapsule.createdby;
                _securityCapsule.createdbyusername = _securityCapsule.username;
                _securityCapsule.updatedbyusername = _securityCapsule.username;
                _securityCapsule.userid = new Guid(identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);

                _securityCapsule.fullname = _securityCapsule.username;
                _securityCapsule.email = identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;
                _securityCapsule.hitfrom = KAF.ConstantTypes.clsSystemConstantTypes.LoggedModeWeb;
                _securityCapsule.actiondate = DateTime.Now;
                _securityCapsule.usertoken = ticket;

                _securityCapsule.sessionid = _securityCapsule.username;
                _securityCapsule.transid = identity.Claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country").FirstOrDefault().Value; ;
                _securityCapsule.raisingevent = "token";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _securityCapsule;
        }

    }
}
