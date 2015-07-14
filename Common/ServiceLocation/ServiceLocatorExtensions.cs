using System.Runtime.Remoting.Services;

namespace Common.ServiceLocation
{
    public static class ServiceLocatorExtensions
    {
        public static void ForUse<TFor, TUse>(this IServiceLocator serviceLocator)
        {
            var forType = typeof (TFor);
            var useType = typeof (TUse);

            serviceLocator.ForUse(forType, useType);
        }

        public static TService GetInstance<TService>(this IServiceLocator serviceLocator) 
            where TService : class
        {
            return serviceLocator.GetInstance(typeof (TService)) as TService;
        }
    }
}