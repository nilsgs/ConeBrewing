using System.Web.Http;
using System.Web.Mvc;
using StructureMap;
using ConeBrewing.MVC.DependencyResolution;

[assembly: WebActivator.PreApplicationStartMethod(typeof(ConeBrewing.MVC.App_Start.StructuremapMvc), "Start")]

namespace ConeBrewing.MVC.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
			IContainer container = IoC.Initialize();
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new StructureMapDependencyResolver(container);
        }
    }
}