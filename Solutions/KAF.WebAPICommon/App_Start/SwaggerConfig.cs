using System.Web.Http;
using WebActivatorEx;
using KAF.WebAPICommon;
using Swashbuckle.Application;
using KAF.WebAPICommon.Filter;

//[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace KAF.WebAPICommon
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration httpConfig)
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            httpConfig.EnableSwagger
                (c =>
                {
                    //c.MultipleApiVersions(
                    //(apiDesc, version) =>
                    //{
                    //    var path = apiDesc.RelativePath.Split('/');
                    //    var pathVersion = path[1];
                    //    return CultureInfo.InvariantCulture.CompareInfo.IndexOf(pathVersion, version, CompareOptions.IgnoreCase) >= 0;
                    //},
                    //vc =>
                    //{
                    //    vc.Version("v2", "API info")
                    //       .Description("A sample API for testing and prototyping Swashbuckle features")
                    //       .TermsOfService("Some terms")
                    //       .Contact(cc => cc
                    //            .Name("Some contact")
                    //            .Url("http://tempuri.org/contact")
                    //            .Email("api@careeronestop.org"))
                    //        .License(lc => lc
                    //            .Name("Some License")
                    //            .Url("http://tempuri.org/license"));

                    //    vc.Version("v1", "API info");
                    //});

                    c.SingleApiVersion("v1", "KAFWebAPIServices");
                    c.ApiKey("Token").Description("bearer token").Name("Authorization").In("header");
                    c.DocumentFilter<AuthTokenDocFilter>();
                    c.OperationFilter<AuthHeaderParamOptFilter>();

                })
                .EnableSwaggerUi(c =>
                {
                    c.EnableApiKeySupport("Authorization", "header");
                });
        }
    }
}
