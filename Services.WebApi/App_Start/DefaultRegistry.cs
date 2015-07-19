using System;
using System.Web.Http;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.Pipeline;
using StructureMap.TypeRules;

namespace NorthwindStore.Services.WebApi
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.With(new ApiControllerConvention());
                });
        }

        class ApiControllerConvention : IRegistrationConvention
        {
            public void Process(Type type, Registry registry)
            {
                if (type.CanBeCastTo<ApiController>() && !type.IsAbstract)
                {
                    registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
                }
            }
        }


    }
}