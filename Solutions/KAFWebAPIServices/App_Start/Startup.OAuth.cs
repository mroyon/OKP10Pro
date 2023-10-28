using System;
using System.Configuration;
using System.Text;
using System.Web.Http;
using KAF.WebAPICommon.Provider;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Security.OAuth;
using Owin;

namespace KAFWebAPIServices
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app, HttpConfiguration config)
        {
            var issuer = ConfigurationManager.AppSettings["issuer"];
            var secret = TextEncodings.Base64Url.Decode(ConfigurationManager.AppSettings["secret"]);

            KAF.AppConfiguration.Configuration.EncryptionHelper obj = new KAF.AppConfiguration.Configuration.EncryptionHelper();




            var str1 = TextEncodings.Base64Url.Encode(Encoding.ASCII.GetBytes("This is KAF IMS.API Key"));
            // .Decode(ConfigurationManager.AppSettings["secret"]);
            var str = obj.encryptSimple("This is KAF IMS.API Key");// .Encrypt("This is KAF IMS.API Key", true, "35VkiSLfPV9t51/omcCEqg==");
            //app.CreatePerOwinContext(() => new BooksContext());
            //app.CreatePerOwinContext(() => new BookUserManager());

            app.UseJwtBearerAuthentication(
            new JwtBearerAuthenticationOptions
            {
                AuthenticationMode = AuthenticationMode.Active,
                AllowedAudiences = new[] { "Any" },
                IssuerSecurityKeyProviders = new IIssuerSecurityKeyProvider[] {
                    new SymmetricKeyIssuerSecurityKeyProvider(issuer, secret)
                }
            });


            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/oauth2/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new CustomOAuthProvider(),
                AccessTokenFormat = new CustomJwtFormat(issuer)
            });
        }
    }
}