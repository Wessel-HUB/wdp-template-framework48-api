using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using __ProjectName__.Application.DependencyInjection;
using __ProjectName__.Infrastructure.DependencyInjection;

namespace __ProjectName__.API.App_Start
{
    public static class AutofacConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            // Register Web API controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // Register application dependencies
            builder.RegisterModule<ApplicationModule>();

            // Register infrastructure dependencies
            builder.RegisterModule<InfrastructureModule>();

            // Build the container
            var container = builder.Build();

            // Tell Web API to use Autofac
            config.DependencyResolver =
                new AutofacWebApiDependencyResolver(container);
        }
    }
}