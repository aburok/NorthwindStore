using Common.ServiceLocation;
using Infrastructure.RavenDb.Configuration;

namespace Infrastructure.RavenDb
{
    public static class RavenDbInitialization
    {
        public static void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<IRavenConfiguration, InCodeRavenConfiguration>();
            serviceLocator.ForUse<IDocumentStoreProvider, RequestDocumentStoreProvider>();
        }
    }
}
