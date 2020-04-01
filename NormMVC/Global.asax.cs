using System.Web.Mvc;
using System.Web.Routing;

namespace NormMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            NormMVC.App_Start.IOCConfig.RegisterComponents();
        }
    }
}
