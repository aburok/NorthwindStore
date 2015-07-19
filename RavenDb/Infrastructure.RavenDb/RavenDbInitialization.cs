using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.Infrastructure.RavenDb.Configuration;

namespace NorthwindStore.Infrastructure.RavenDb
{
    public class RavenDbInitialization :IModuleInitialization
    {
        public static void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<IRavenConfiguration, InCodeRavenConfiguration>();
            serviceLocator.ForUse<IDocumentStoreProvider, RequestDocumentStoreProvider>();
        }

        void IModuleInitialization.Initialize(IServiceLocator serviceLocator)
        {
            Initialize(serviceLocator);
        }
    }
}
