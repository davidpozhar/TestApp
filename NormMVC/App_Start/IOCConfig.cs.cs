using NormMVC.Abstract;
using System.Data.Entity;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace NormMVC.App_Start
{
    public static class IOCConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterSingleton<DbContext, NormMVCContext>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}