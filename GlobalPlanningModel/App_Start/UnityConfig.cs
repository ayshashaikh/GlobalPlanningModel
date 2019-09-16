using System.Web.Mvc;
using GlobalPlanningModel.Models;
using GlobalPlanningModel.Models.Interfaces;
using Unity;
using Unity.Mvc5;

namespace GlobalPlanningModel
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IXmlReaderService, XmlFileReaderService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}