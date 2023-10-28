using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
namespace KAFWebAdmin
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
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
                       "~/LocalDesignsAndScripts/Scripts/isotope/isotope.pkgd.min.js",
                       "~/DesignsAndScripts/Scripts/plugins/jquery/jquery_validate.js",
                       "~/DesignsAndScripts/Scripts/plugins/jquery/jquery_validate_unobtrusive.js",
                        "~/DesignsAndScripts/Scripts/plugins/jquery/jquery_blockUI.js",
                        "~/DesignsAndScripts/Scripts/plugins/jquery/jquery_confirm.js",
                        "~/DesignsAndScripts/Scripts/plugins/jquery/jquery-ui.js",
                        "~/DesignsAndScripts/Scripts/plugins/moment/moment.js",
                        "~/DesignsAndScripts/Scripts/plugins/customs/customConfirmation.js",
                        "~/DesignsAndScripts/Scripts/plugins/customs/customUIBlock.js",
                        "~/DesignsAndScripts/Scripts/plugins/crypto/crypto_js.js",
                         "~/DesignsAndScripts/LandingPage/vendor/aos/aos.js"


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

            var css = new StyleBundle("~/Bundles/css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/bootstrap_min.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/bootstrap_datetimepicker/bootstrap_datetimepicker.css")

                .IncludeWithRewrite("~/DesignsAndScripts/Styles/font_awesome_min.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/AdminLTE.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/chatHUB.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/ProfileSearchPanel.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery_confirm.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-ui.css")
                //.IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-ui-timepicker-addon.css")

                .IncludeWithRewrite("~/DesignsAndScripts/Styles/bootstrap-tagsinput.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/bootstrap-tagsinput-typeahead.css")
                //.IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/datatables/Responsive/css/dataTables_bootstrap.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/datatables/Updated/datatables.min.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/datatables/Responsive/css/dataTables_responsive.css")

                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/datatables/Updated/dataTables.checkboxes.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/dropzone/dropzone.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-tokeninput/token-input.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-tokeninput/token-input-facebook.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/skins/slimscrollstyle.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/skins/skin-blue.css")
                 .IncludeWithRewrite("~/DesignsAndScripts/Styles/jstree_style.min.css")
                //.IncludeWithRewrite("~/DesignsAndScripts/Styles/landingpage.css")

                //.IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/footable/css/footable.bootstrap.min.css")

                .IncludeWithRewrite("~/DesignsAndScripts/Styles/custom-nav-tabs.css");
            css.Orderer = new AsIsBundleOrderer();


            bundles.Add(css);

            var cssRTL = new StyleBundle("~/Bundles/cssRTL")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/rtl/bootstrap_minRTL.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/bootstrap_datetimepicker/bootstrap_datetimepicker.css")

                .IncludeWithRewrite("~/DesignsAndScripts/Styles/font_awesome_min.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/rtl/font_awesome_minRTL.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/rtl/AdminLTERTL.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/chatHUB.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/ProfileSearchPanel.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/rtl/jquery_confirmRTL.css")
                //.IncludeWithRewrite("~/DesignsAndScripts/Scripts/rtl/dataTables_bootstrapRTL.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/datatables/Updated/datatables.min.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/datatables/Responsive/css/dataTables_responsive.css")

                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/datatables/Updated/dataTables.checkboxes.css")

                .IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/dropzone/dropzone.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/skins/slimscrollstyle.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/skins/skin-blue.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-tokeninput/token-input.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-tokeninput/token-input-facebook.css")
                 .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-ui.css")
                 .IncludeWithRewrite("~/DesignsAndScripts/Styles/jquery-ui-timepicker-addon.css")
                .IncludeWithRewrite("~/DesignsAndScripts/Styles/custom-nav-tabs.css")


               //.IncludeWithRewrite("~/DesignsAndScripts/Scripts/plugins/footable/css/footable.bootstrap.min.css")

               .IncludeWithRewrite("~/DesignsAndScripts/Styles/jstree_style.min.css");
            cssRTL.Orderer = new AsIsBundleOrderer();
            bundles.Add(cssRTL);


            var js = new OrderedScriptBundle("~/Bundles/js")
                //.Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery.js")
                //.Include("~/DesignsAndScripts/Scripts/plugins/moment/moment.js")
                //.Include("~/DesignsAndScripts/Scripts/plugins/bootstrap/bootstrap.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/fastclick/fastclick.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/slimscroll/jquery.slimscroll.js")
                .Include("~/DesignsAndScripts/Scripts/adminlte.js")
                //.Include("~/DesignsAndScripts/Scripts/plugins/datatables/jquery_dataTables.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/datatables/Updated/datatables.min.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/datatables/dataTables_bootstrap.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/datatables/Responsive/js/dataTables_responsive.js")

                 .Include("~/DesignsAndScripts/Scripts/plugins/datatables/Updated/dataTables.checkboxes.min.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/dropzone/dropzone.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_unobtrusive_ajax.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_validate.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_validate_unobtrusive.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_blockUI.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_confirm.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery-ui.js")
                //.Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery-ui-timepicker-addon.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/bootstrap_datetimepicker/bootstrap_datetimepicker.js")
                .Include("~/DesignsAndScripts/Scripts/util.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery-tokeninput/jquery.tokeninput.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/combodate/combodate.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/customs/customConfirmation.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/customs/customUIBlock.js")
                .Include("~/DesignsAndScripts/Scripts/demo.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/crypto/crypto_js.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/crypto/aes.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jstree/jstree.min.js")

                .Include("~/DesignsAndScripts/Scripts/customFileUpload.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/printthis/printThis.js")

                .Include("~/DesignsAndScripts/Scripts/plugins/exportToExcel/table2excel.js")


                .Include("~/DesignsAndScripts/Scripts/plugins/slimscroll/jquery.slimscroll.min.js");

            bundles.Add(js);
            //customFileUpload

            var loginjs = new OrderedScriptBundle("~/Bundles/loginjs")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery.js")
                .Include("~/DesignsAndScripts/LandingPage/vendor/bootstrap/js/bootstrap.bundle.min.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/moment/moment.js")

                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_unobtrusive_ajax.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_validate.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_validate_unobtrusive.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_blockUI.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/jquery/jquery_confirm.js")

                .Include("~/DesignsAndScripts/Scripts/plugins/customs/customConfirmation.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/customs/customUIBlock.js")

                .Include("~/DesignsAndScripts/Scripts/plugins/crypto/crypto_js.js")
                .Include("~/DesignsAndScripts/Scripts/plugins/crypto/crypto_js.js")

                .Include("~/DesignsAndScripts/LandingPage/vendor/aos/aos.js")
                .Include("~/DesignsAndScripts/LandingPage/js/main.js")
                 .Include("~/DesignsAndScripts/PageWise/Login/LandingPage.js")

                ;



            //            <script src="~/DesignsAndScripts/LandingPage/vendor/jquery/jquery.min.js"></script>
            //<script src="~/DesignsAndScripts/LandingPage/vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
            //<script src="~/DesignsAndScripts/LandingPage/vendor/aos/aos.js"></script>
            //<script src="~/DesignsAndScripts/LandingPage/js/main.js"></script>
            //<script src="~/DesignsAndScripts/PageWise/Login/LandingPage.js"></script>


            bundles.Add(loginjs);



            #region PAGE WISE

            #region RolePermission
            bundles.Add(new ScriptBundle("~/DesignsAndScripts/PageWise/RolePermission").Include(
                        "~/DesignsAndScripts/PageWise/RolePermission/RolePermission.js"));
            #endregion

            #endregion

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/DesignsAndScripts/Scripts/plugins/modernizr-*"));




#if DEBUG
            BundleTable.EnableOptimizations = false;
#else
            BundleTable.EnableOptimizations = true;
#endif
        }
    }
}