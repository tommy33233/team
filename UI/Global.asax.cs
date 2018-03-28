using Ninject.Modules;
using System.Web.Mvc;
using System.Web.Routing;
using BLL.Infrastructure;
using Ninject;
using Ninject.Web.Mvc;
using UI.Util;

namespace UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            NinjectModule orderModule = new AppModule();
            NinjectModule serviceModule = new ServiceModule("BLDB");
            var kernel = new StandardKernel(orderModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
