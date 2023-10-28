using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace KAFWebAdmin
{
    public sealed class AsIsBundleOrderer : IBundleOrderer
    {
        public IEnumerable<BundleFile> OrderFiles(BundleContext context, IEnumerable<BundleFile> files)
        {
            return files;
        }
    }

    public class OrderedScriptBundle : ScriptBundle
    {
        public OrderedScriptBundle(string virtualPath) : this(virtualPath, null)
        {
        }

        public OrderedScriptBundle(string virtualPath, string cdnPath) : base(virtualPath, cdnPath)
        {
            Orderer = new AsIsBundleOrderer();
        }
    }

    public class OrderedStyleBundle : StyleBundle
    {
        public OrderedStyleBundle(string virtualPath) : this(virtualPath, null)
        {
        }

        public OrderedStyleBundle(string virtualPath, string cdnPath) : base(virtualPath, cdnPath)
        {
            Orderer = new AsIsBundleOrderer();
        }
    }
    public static class BundleExtensions
    {
        public static Bundle IncludeWithRewrite(this Bundle bundle, string virtualPath)
        {
            bundle.Include(virtualPath, new CssRewriteUrlTransform());

            return bundle;
        }
    }
}