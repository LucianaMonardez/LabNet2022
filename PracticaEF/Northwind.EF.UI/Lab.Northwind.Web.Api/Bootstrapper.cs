using System.Web.Mvc;
using Lab.Northwind.Service;
using Microsoft.Practices.Unity;
using Northwind.EF.Logic;
using Unity.Mvc3;

namespace Lab.Northwind.Web.Api
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IShippersService, ShippersService>();
            //container.RegisterType<IGenericRepository, GenericRepository>();
            //container.RegisterType<IABMLogic<T>, ABMLogic<T>>();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}