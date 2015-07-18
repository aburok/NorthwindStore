using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.Infrastructure.RavenDb.Configuration;

namespace NorthwindStore.Infrastructure.RavenDb
{
    public class RavenDbInitialization :IModuleInitialization
    {
        void IModuleInitialization.Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<IRavenConfiguration, InCodeRavenConfiguration>();
            serviceLocator.ForUse<IDocumentStoreProvider, RequestDocumentStoreProvider>();
        }
    }
}
