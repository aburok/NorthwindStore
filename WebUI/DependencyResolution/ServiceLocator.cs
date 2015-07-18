using DataAccess.Queries.RavenDb;
using DataAccess.RavenDb;
using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.Common.Translations;
using NorthwindStore.DataAccess.Product;
using NorthwindStore.DataAccess.RavenDb;
using NorthwindStore.Infrastructure.RavenDb;
using NorthwindStore.WebUI.DependencyResolution.StructureMap;

namespace NorthwindStore.WebUI.DependencyResolution
{
    public static class ServiceLocator
    {
        public static IServiceLocator Current
        {
            get { return StructuremapMvc.StructureMapDependencyScope; }
        }

        public static void Register()
        {
            DataAccessRavenDbInitialization.Init(Current);

            Current.ForUse<IProductRepository, ProductRepository>();

            Current.ForUse<ITranslationService, InMemoryTranslationService>();

            Current.InitializeModules();
        }
    }
}
