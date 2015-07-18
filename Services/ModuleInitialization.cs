using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.Services.Order;

namespace NorthwindStore.Services
{
    public class ModuleInitialization : IModuleInitialization
    {
        public void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<IOrderApiService, OrderApiService>();
        }
    }
}