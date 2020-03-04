using System.Web;
using System.Web.Optimization;

namespace eLeave
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/fontawesome").Include(
                      "~/Content/css/all.min.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/adminlte.min.css",
                      "~/Content/css/dataTables.bootstrap4.css"
                      ));

            bundles.Add(new StyleBundle("~/Scripts/js").Include(
                      "~/Scripts/Layout/adminlte.js",
                      "~/Scripts/Layout/bootstrap.bundle.min.js",
                      "~/Scripts/Layout/dataTables.bootstrap4.js",
                      "~/Scripts/Layout/demo.js",
                      "~/Scripts/Layout/jquery.dataTables.js",
                      "~/Scripts/Layout/jquery.min.js"));
        }
    }
}
