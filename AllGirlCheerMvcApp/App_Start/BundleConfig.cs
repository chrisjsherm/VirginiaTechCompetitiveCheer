using System;
using System.Web;
using System.Web.Optimization;

namespace AllGirlCheerMvcApp
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

            bundles.Add(
              new StyleBundle("~/Content/css").Include(
              "~/Content/Site.css")
              );

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include(
                    "~/Scripts/modernizr-*"));

            bundles.Add(
                  new ScriptBundle("~/Scripts/vendor").Include(
                      "~/Scripts/jquery-{version}.js",
                      "~/Scripts/foundation/foundation.js",
                      "~/Scripts/foundation/foundation.interchange.js",
                      "~/Scripts/foundation/foundation.orbit.js",
                      "~/Scripts/foundation/foundation.topbar.js")
                  );
        }

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
            {
                throw new ArgumentNullException("ignoreList");
            }

            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }
    }
}