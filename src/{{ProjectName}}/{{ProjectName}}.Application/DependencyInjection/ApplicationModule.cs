using __ProjectName__.Application.Interfaces;
using __ProjectName__.Application.Services;
using Autofac;

namespace __ProjectName__.Application.DependencyInjection
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HealthService>()
                   .As<IHealthService>()
                   .InstancePerRequest();
        }
    }
}