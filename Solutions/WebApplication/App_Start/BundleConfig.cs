using System.Web;
using System.Web.Optimization;

namespace WebApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/LocalScript").Include(
                      "~/LocalDesignsAndScripts/Scripts/jquery/jquery.min.js",
                       "~/LocalDesignsAndScripts/Scripts/bootstrap/js/bootstrap.min.js",
                        "~/LocalDesignsAndScripts/Scripts/owlcarousel/owl.carousel.min.js",
                         "~/LocalDesignsAndScripts/Scripts/venobox/venobox.min.js",
                       "~/LocalDesignsAndScripts/Scripts/knob/jquery.knob.js",
                        "~/LocalDesignsAndScripts/Scripts/wow/wow.min.js",
                        "~/LocalDesignsAndScripts/Scripts/parallax/parallax.js",
                       "~/LocalDesignsAndScripts/Scripts/easing/easing.min.js",
                        "~/LocalDesignsAndScripts/Scripts/nivo-slider/js/jquery.nivo.slider.js",
                        "~/LocalDesignsAndScripts/Scripts/appear/jquery.appear.js",
                         "~/LocalDesignsAndScripts/Scripts/contactform.js",
                          "~/LocalDesignsAndScripts/Scripts/main.js",
                        "~/LocalDesignsAndScripts/Scripts/isotope/isotope.pkgd.min.js"
                      ));

                         bundles.Add(new StyleBundle("~/Content/Localcss").Include(
                      "~/LocalDesignsAndScripts/Scripts/bootstrap/css/bootstrap.css",
                      "~/LocalDesignsAndScripts/Scripts/nivo-slider/css/nivo-slider.css",
                      "~/LocalDesignsAndScripts/Scripts/owlcarousel/owl.carousel.css",
                      "~/LocalDesignsAndScripts/Scripts/owlcarousel/owl.transitions.css",
                      "~/LocalDesignsAndScripts/Scripts/font-awesome/css/font-awesome.min.css",
                      "~/LocalDesignsAndScripts/Scripts/animate/animate.min.css",
                       "~/LocalDesignsAndScripts/Scripts/venobox/venobox.css",
                      "~/LocalDesignsAndScripts/Content/nivo-slider-theme.css",
                      "~/LocalDesignsAndScripts/Content/style.css",
                      "~/LocalDesignsAndScripts/Content/responsive.css"));

        }
    }
}
