using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace KAFWebAPIServices.Filter
{
    public class AuthHeaderParamOptFilter : IOperationFilter
    {
        /// <summary>
        /// Applies the operation filter.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters != null)
            {
                operation.parameters.Add(new Parameter
                {
                    name = "Authorization",
                    @in = "header",
                    description = "bearer token",
                    required = true,
                    type = "string"
                });
            }
        }
    }
}