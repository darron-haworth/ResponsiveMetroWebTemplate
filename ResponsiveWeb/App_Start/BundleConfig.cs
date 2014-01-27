using System.Web;
using System.Web.Optimization;

namespace ResponsiveWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.cslider.js",
                        "~/Scripts/jquery.flexslider-min.js",
                         "~/Scripts/jquery.isotope.js",
                          "~/Scripts/jquery.prettyPhoto.js"

                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap3").Include(
                         "~/Scripts/custom.js",
                          "~/Scripts/cycle.js",
                           "~/Scripts/easing.js",
                            "~/Scripts/filter.js"

                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/blue.css",
                        "~/Content/bootstrap.css",
                        "~/Content/flexslider.css",
                        "~/Content/font-awesome.css",
                        "~/Content/green.css",
                        "~/Content/lblue.css",
                        "~/Content/orange.css",
                        "~/Content/prettyPhoto.css",
                        "~/Content/purple.css",
                        "~/Content/red.css",
                        "~/Content/Site.css",
                        "~/Content/slider.css",
                        "~/Content/style.css"));

        }
    }
}
