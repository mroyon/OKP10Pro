using KAF.WebAPICommon.Filter;
using KAF.WebAPICommon.HelperClass;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.OutputCache.V2;

namespace KAFWebAPIServices
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Filters.Add(new AuthorizeAttribute());
            config.Filters.Add(new ClaimsUserFilter());

            config.MessageHandlers.Add(new PreflightRequestsHandler());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.CacheOutputConfiguration().RegisterCacheOutputProvider(() => new CustomCacheProvider());
            config.CacheOutputConfiguration().RegisterDefaultCacheKeyGeneratorProvider(() => new CustomCacheKeyGenerator());

        }
    }

    public class PreflightRequestsHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.Headers.Contains("Origin") && request.Method.Method == "OPTIONS")
            {
                var response = new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
                response.Headers.Add("Access-Control-Allow-Origin", "*");
                response.Headers.Add("Access-Control-Allow-Headers", "Origin, Content-Type, Accept, Authorization");
                response.Headers.Add("Access-Control-Allow-Methods", "*");
                var tsc = new TaskCompletionSource<HttpResponseMessage>();
                tsc.SetResult(response);
                return tsc.Task;
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}
