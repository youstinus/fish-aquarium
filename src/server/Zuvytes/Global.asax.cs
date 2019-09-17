using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Zuvytes
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }

    public static class Globals
    {
        public static string dbPrefix { get { return "pavyzdys_"; } }
    }
}
