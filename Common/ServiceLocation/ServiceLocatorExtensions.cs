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
    }
}