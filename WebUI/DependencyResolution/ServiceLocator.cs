using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.Common.Translations;
using NorthwindStore.DataAccess;
using NorthwindStore.DataAccess.Product;
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
            Current.ForUse<IProductRepository, ProductRepository>();

            Current.ForUse<ITranslationService, InMemoryTranslationService>();

            //Current.InitializeModules();

            DataAcessModuleInitialization.Initialize(Current);
        }
    }
}
