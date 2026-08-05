using __ProjectName__.Domain.Repositories;
using __ProjectName__.Infrastructure.Repositories;
using Autofac;

namespace __ProjectName__.Infrastructure.DependencyInjection
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HealthRepository>()
                   .As<IHealthRepository>()
                   .InstancePerRequest();
        }
    }
}