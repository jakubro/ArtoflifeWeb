namespace Internetz.Artoflife.Web
{ // ReSharper disable ClassNeverInstantiated.Global
   using System.Web.Mvc;
   using System.Web.Routing;

   public class RouteConfig
   {
      public static void RegisterRoutes(RouteCollection routes)
      {
         routes.MapRoute("Default", "{anything}",
                         new { controller = "Default", action = "Index", anything = UrlParameter.Optional }
            );
      }
   }
}