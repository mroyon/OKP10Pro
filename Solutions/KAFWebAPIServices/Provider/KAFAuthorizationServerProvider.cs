using KAF.BusinessDataObjects.BusinessDataObjectsBase;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using KAFWebAPIServices.Filter;
using KAFWebAPIServices.HelperClass;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KAFWebAPIServices.Provider
{
    public class KAFAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); // 
        }

        //[KAFCorsPolicyAttribute]
        [ExceptionFilter]
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
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

                //var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, objUser.username));
                claims.Add(new Claim(ClaimTypes.Email, objUser.emailaddress));
                claims.Add(new Claim(ClaimTypes.StreetAddress, objUser.masteruserid.GetValueOrDefault().ToString()));
                claims.Add(new Claim(ClaimTypes.MobilePhone, objUser.mobilenumber));
                claims.Add(new Claim(ClaimTypes.Gender, objUser.userid.GetValueOrDefault().ToString()));
                claims.Add(new Claim(ClaimTypes.Country, privateToken));
                claims.Add(new Claim(ClaimTypes.Uri, ((Microsoft.Owin.OwinRequest)context.Request).Uri.AbsoluteUri));
                claims.Add(new Claim(ClaimTypes.OtherPhone, ((Microsoft.Owin.OwinRequest)context.Request).LocalIpAddress));
                claims.Add(new Claim(ClaimTypes.Upn, context.Request.QueryString.Value));
                claims.Add(new Claim(ClaimTypes.StateOrProvince, objUser.userorganizationkey.GetValueOrDefault().ToString()));
                claims.Add(new Claim(ClaimTypes.PostalCode, objUser.userentitykey.GetValueOrDefault().ToString()));
                ClaimsIdentity claimPack = new ClaimsIdentity(claims, context.Options.AuthenticationType);

                var props = new AuthenticationProperties(new Dictionary<string, string>
                            {
                                {
                                    "userdisplayname", context.UserName
                                },
                                {
                                     "role", "admin"
                                }
                             });

                var ticket = new AuthenticationTicket(claimPack, props);
                context.Validated(ticket);
                string msg = "User: " + objUser.username + " Logged: " + dot.ToString("dd/mm/yyyy hh:mm:ss") + " TrainsID: " + privateToken;
                objLog.SetLog(FillSec(claims, ticket.ToString()), new KAF.BusinessDataObjects.BusinessDataObjectsPartials.KAF_TransCodesEntity(), msg, LOGLevel.Info);
            }
            else
            {
                context.SetError("invalid_grant", "Provided credential is incorrect");
                context.Rejected();
            }
            return;
        }

        private SecurityCapsule FillSec(List<Claim> claims,
                string ticket)
        {
            SecurityCapsule _securityCapsule = new SecurityCapsule();

            try
            {
                _securityCapsule.username = claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name").FirstOrDefault().Value;
                _securityCapsule.usernumber = claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone").FirstOrDefault().Value;
                _securityCapsule.userorganizationkey = long.Parse(claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/stateorprovince").FirstOrDefault().Value);
                _securityCapsule.userentitykey = long.Parse(claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/postalcode").FirstOrDefault().Value);

                _securityCapsule.pageurl = claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/uri").FirstOrDefault().Value;
                _securityCapsule.ipaddress = claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/otherphone").FirstOrDefault().Value;
                _securityCapsule.controllername = "GetToken";
                _securityCapsule.actioname = "Tickets";

                _securityCapsule.createdby = long.Parse(claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress").FirstOrDefault().Value);
                _securityCapsule.updatedby = _securityCapsule.createdby;
                _securityCapsule.createdbyusername = _securityCapsule.username;
                _securityCapsule.updatedbyusername = _securityCapsule.username;
                _securityCapsule.userid = new Guid(claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender").FirstOrDefault().Value);

                _securityCapsule.fullname = _securityCapsule.username;
                _securityCapsule.email = claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress").FirstOrDefault().Value;
                _securityCapsule.hitfrom = KAF.ConstantTypes.clsSystemConstantTypes.LoggedModeWeb;
                _securityCapsule.actiondate = DateTime.Now;
                _securityCapsule.usertoken = ticket;

                _securityCapsule.sessionid = _securityCapsule.username;
                _securityCapsule.transid = claims.Where(p => p.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/country").FirstOrDefault().Value; ;
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