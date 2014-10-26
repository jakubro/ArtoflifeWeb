namespace Internetz.Artoflife.Web
{ // ReSharper disable ClassNeverInstantiated.Global
   using System.Web.Mvc;

   public class FilterConfig
   {
      public static void RegisterGlobalFilters(GlobalFilterCollection filters)
      {
         filters.Add(new HandleErrorAttribute());
      }
   }
}