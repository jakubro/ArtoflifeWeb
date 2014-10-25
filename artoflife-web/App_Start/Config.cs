namespace Internetz.Artoflife.Web
{
   using System.Configuration;

   public static class Config
   {
      public static class Google
      {
         public static class Analytics
         {
            private static readonly string key = ConfigurationManager.AppSettings["google.analytics.key"];

            public static string Key
            {
               get
               {
                  return key;
               }
            }
         }

         public static class Api
         {
            private static readonly string key = ConfigurationManager.AppSettings["google.api.key"];

            public static string Key
            {
               get
               {
                  return key;
               }
            }
         }
      }
   }
}