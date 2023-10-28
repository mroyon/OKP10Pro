using System;
using System.Web.Compilation;
using System.Globalization;
using System.ComponentModel;
using System.Web.UI;
using System.CodeDom;
using System.Web;
using System.Threading;
using System.Diagnostics;
using KAF.WebFramework;

namespace CustomResourceProviders
{

    /// <summary>
    /// Custom expression builder support for $ExternalResources expressions.
    /// </summary>
    public class ExternalResourceExpressionBuilder : ExpressionBuilder
    {
        private static ResourceProviderFactory s_resourceProviderFactory;

        public ExternalResourceExpressionBuilder()
        {
            Debug.WriteLine("ExternalResourceExpressionBuilder");

        }

        /// <summary>   Gets global resource object. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetGlobalResourceObject" type="static object"> GetGlobalResourceObject. </method>
        /// <param name="classKey" type="string">     The class key. </param>
        /// <param name="resourceKey" type="string">  The resource key. </param>
        /// <returns>   The global resource object. </returns>

        public static object GetGlobalResourceObject(string classKey, string resourceKey)
        {
            Debug.WriteLine(String.Format(CultureInfo.InvariantCulture, "ExternalResourceExpressionBuilder.GetGlobalResourceObject({0}, {1})", classKey, resourceKey));

            return ExternalResourceExpressionBuilder.GetGlobalResourceObject(classKey, resourceKey, null);
        }

        /// <summary>   Gets global resource object. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetGlobalResourceObject" type="object"> GetGlobalResourceObject. </method>
        /// <param name="classKey" type="string">     The class key. </param>
        /// <param name="resourceKey" type="string">  The resource key. </param>
        /// <param name="culture" type="CultureInfo">      The culture. </param>
        /// <returns>   The global resource object. </returns>

        public static object GetGlobalResourceObject(string classKey, string resourceKey, CultureInfo culture)
        {
            Debug.WriteLine(String.Format(CultureInfo.InvariantCulture, "ExternalResourceExpressionBuilder.GetGlobalResourceObject({0}, {1}, {2})", classKey, resourceKey, culture));

            ExternalResourceExpressionBuilder.EnsureResourceProviderFactory();
            IResourceProvider provider = ExternalResourceExpressionBuilder.s_resourceProviderFactory.CreateGlobalResourceProvider(classKey);
            return provider.GetObject(resourceKey, culture);
        }

        /// <summary>
        /// When overridden in a derived class, returns an object that represents an evaluated expression.
        /// </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="EvaluateExpression" type="object">  EvaluateExpression. </method>
        /// <param name="target" type="object">       The object containing the expression. </param>
        /// <param name="entry" type="BoundPropertyEntry">        The object that represents information about the property bound
        ///                             to by the expression. </param>
        /// <param name="parsedData" type="object">   The object containing parsed data as returned by
        ///                             <see cref="M:System.Web.Compilation.ExpressionBuilder.ParseExpression(System.String,System.Type,System.Web.Compilation.ExpressionBuilderContext)" />
        ///                             . </param>
        /// <param name="context" type="ExpressionBuilderContext">      Contextual information for the evaluation of the expression. </param>
        /// <returns>
        /// An object that represents the evaluated expression; otherwise, null if the inheritor does not
        /// implement
        /// <see cref="M:System.Web.Compilation.ExpressionBuilder.EvaluateExpression(System.Object,System.Web.UI.BoundPropertyEntry,System.Object,System.Web.Compilation.ExpressionBuilderContext)" />
        /// .
        /// </returns>

        public override object EvaluateExpression(object target, BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context)
        {
            Debug.WriteLine(String.Format(CultureInfo.InvariantCulture, "ExternalResourceExpressionBuilder.EvaluateExpression({0}, {1}, {2}, {3})", target, entry, parsedData, context));

            ExternalResourceExpressionFields fields = parsedData as ExternalResourceExpressionFields;

            ExternalResourceExpressionBuilder.EnsureResourceProviderFactory();
            IResourceProvider provider = ExternalResourceExpressionBuilder.s_resourceProviderFactory.CreateGlobalResourceProvider(fields.ClassKey);

            return provider.GetObject(fields.ResourceKey, null);
        }

        /// <summary>
        /// When overridden in a derived class, returns code that is used during page execution to obtain
        /// the evaluated expression.
        /// </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="GetCodeExpression" type="CodeExpression">   GetCodeExpression. </method>
        /// <param name="entry" type="BoundPropertyEntry">        The object that represents information about the property bound
        ///                             to by the expression. </param>
        /// <param name="parsedData" type="object">   The object containing parsed data as returned by
        ///                             <see cref="M:System.Web.Compilation.ExpressionBuilder.ParseExpression(System.String,System.Type,System.Web.Compilation.ExpressionBuilderContext)" />
        ///                             . </param>
        /// <param name="context" type="ExpressionBuilderContext">      Contextual information for the evaluation of the expression. </param>
        /// <returns>
        /// A <see cref="T:System.CodeDom.CodeExpression" />
        ///  that is used for property assignment.
        /// </returns>

        public override System.CodeDom.CodeExpression GetCodeExpression(BoundPropertyEntry entry, object parsedData, ExpressionBuilderContext context)
        {
            Debug.WriteLine(String.Format(CultureInfo.InvariantCulture, "ExternalResourceExpressionBuilder.GetCodeExpression({0}, {1}, {2})", entry, parsedData, context));

            ExternalResourceExpressionFields fields = parsedData as ExternalResourceExpressionFields;

            CodeMethodInvokeExpression exp = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression(typeof(ExternalResourceExpressionBuilder)), "GetGlobalResourceObject", new CodePrimitiveExpression(fields.ClassKey), new CodePrimitiveExpression(fields.ResourceKey));

            return exp;
        }

        /// <summary>
        /// When overridden in a derived class, returns an object that represents the parsed expression.
        /// </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="ParseExpression" type="object"> ParseExpression. </method>
        /// <exception cref="ArgumentException">    Thrown when one or more arguments have unsupported or
        ///                                         illegal values. </exception>
        /// <param name="expression" type="string">   The value of the declarative expression. </param>
        /// <param name="propertyType" type="Type"> The type of the property bound to by the expression. </param>
        /// <param name="context" type="ExpressionBuilderContext">      Contextual information for the evaluation of the expression. </param>
        /// <returns>
        /// An <see cref="T:System.Object" />
        ///  containing the parsed representation of the expression; otherwise, null if
        ///  <see cref="M:System.Web.Compilation.ExpressionBuilder.ParseExpression(System.String,System.Type,System.Web.Compilation.ExpressionBuilderContext)" />
        ///  is not implemented.
        /// </returns>

        public override object ParseExpression(string expression, Type propertyType, ExpressionBuilderContext context)
        {
            Debug.WriteLine(String.Format(CultureInfo.InvariantCulture, "ExternalResourceExpressionBuilder.ParseExpression({0}, {1}, {2})", expression, propertyType, context));

            if (string.IsNullOrEmpty(expression))
            {
                throw new ArgumentException(String.Format(Thread.CurrentThread.CurrentUICulture, KAF.WebFramework.Properties.Resources.Expression_TooFewParameters, expression));
            }

            ExternalResourceExpressionFields fields = null;
            string classKey = null;
            string resourceKey = null;

            string[] expParams = expression.Split(new char[] { ',' });
            if (expParams.Length > 2)
            {
                throw new ArgumentException(String.Format(Thread.CurrentThread.CurrentUICulture, KAF.WebFramework.Properties.Resources.Expression_TooManyParameters, expression));
            }
            if (expParams.Length == 1)
            {
                throw new ArgumentException(String.Format(Thread.CurrentThread.CurrentUICulture, KAF.WebFramework.Properties.Resources.Expression_TooFewParameters, expression));
            }
            else
            {
                classKey = expParams[0].Trim();
                resourceKey = expParams[1].Trim();
            }

            fields = new ExternalResourceExpressionFields(classKey, resourceKey);

            ExternalResourceExpressionBuilder.EnsureResourceProviderFactory();
            IResourceProvider rp = ExternalResourceExpressionBuilder.s_resourceProviderFactory.CreateGlobalResourceProvider(fields.ClassKey);

            object res = rp.GetObject(fields.ResourceKey, CultureInfo.InvariantCulture);
            if (res == null)
            {
                throw new ArgumentException(String.Format(Thread.CurrentThread.CurrentUICulture, KAF.WebFramework.Properties.Resources.RM_ResourceNotFound, fields.ResourceKey));
            }
            return fields;
        }

        /// <summary>   Ensures that resource provider factory. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <method name="EnsureResourceProviderFactory">   EnsureResourceProviderFactory. </method>

        private static void EnsureResourceProviderFactory()
        {
            if (ExternalResourceExpressionBuilder.s_resourceProviderFactory == null)
            {
                ExternalResourceExpressionBuilder.s_resourceProviderFactory = new ExternalResourceProviderFactory();
            }
        }

        /// <summary>
        /// When overridden in a derived class, returns a value indicating whether the current
        /// <see cref="T:System.Web.Compilation.ExpressionBuilder" />
        ///  object supports no-compile pages.
        /// </summary>
        /// <value>
        /// true if the <see cref="T:System.Web.Compilation.ExpressionBuilder" />
        ///  supports expression evaluation; otherwise, false.
        /// </value>

        public override bool SupportsEvaluate
        {
            get
            {
                Debug.WriteLine("ExternalResourceExpressionBuilder.SupportsEvaluate");
                return true;
            }
        }
    }

    public class ExternalResourceExpressionFields
    {
        /// <summary>   Constructor. </summary>
        /// <remarks>   2/6/2017. </remarks>
        /// <param name="classKey">     The class key. </param>
        /// <param name="resourceKey">  The resource key. </param>

        internal ExternalResourceExpressionFields(string classKey, string resourceKey)
        {
            this.m_classKey = classKey;
            this.m_resourceKey = resourceKey;
        }

        /// <summary>   Gets the class key. </summary>
        /// <value> The class key. </value>

        public string ClassKey
        {
            get
            {
                return this.m_classKey;
            }
        }

        /// <summary>   Gets the resource key. </summary>
        /// <value> The resource key. </value>

        public string ResourceKey
        {
            get
            {
                return this.m_resourceKey;
            }
        }

        private string m_classKey;  ///< The class key
        private string m_resourceKey;


    }


}