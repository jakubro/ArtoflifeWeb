namespace Internetz.Artoflife.Web
{
   using System.Web.Optimization;

   public class BundleConfig
   {
      // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
      public static void RegisterBundles(BundleCollection bundles)
      {
         bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Assets/Vendor/jQuery/jquery-2.1.1.min.js"));
         bundles.Add(new ScriptBundle("~/bundles/skrollr").Include("~/Assets/Vendor/skrollr/skrollr.min.js",
                                                                   "~/Assets/Vendor/skrollr/skrollr.menu.min.js"));
         bundles.Add(new ScriptBundle("~/bundles/application").Include("~/Assets/App/js/app.js"));

         // stylesheets
         bundles.Add(new StyleBundle("~/bundles/reset").Include("~/Assets/Vendor/reset/reset.css"));
         bundles.Add(new StyleBundle("~/bundles/stylesheet").Include("~/Assets/App/css/custom/fonts.css",
                                                                     "~/Assets/App/css/base/common.css",
                                                                     "~/Assets/App/css/base/font.css",
                                                                     "~/Assets/App/css/base/text.css",
                                                                     "~/Assets/App/css/base/hyperlinks.css",
                                                                     "~/Assets/App/css/base/lists.css",
                                                                     "~/Assets/App/css/base/layout.css",
                                                                     "~/Assets/App/css/custom/theme.css",
                                                                     "~/Assets/App/css/custom/style.css",
                                                                     "~/Assets/App/css/modules/timeline.css",
                                                                     "~/Assets/App/css/modules/map.css"));
      }
   }
}