using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.DataAccess.Product;

namespace NorthwindStore.DataAccess
{
    public class DataAcessModuleInitialization :IModuleInitialization
    {
        public static void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<IProductRepository, ProductRepository>();
        }

        void IModuleInitialization.Initialize(IServiceLocator serviceLocator)
        {
            Initialize(serviceLocator);
        }
    }
}