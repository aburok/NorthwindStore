using NorthwindStore.Common.Cache;
using NorthwindStore.Common.ServiceLocation;

namespace Common.Cache.HttpContext
{
    public class CommonWebInitialization
    {
        public static void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<ICache, HttpRuntimeCache>();
        }
    }
}