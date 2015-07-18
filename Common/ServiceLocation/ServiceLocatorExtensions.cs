using System;
using System.Linq;
using NorthwindStore.Common.Extensions;

namespace NorthwindStore.Common.ServiceLocation
{
    public static class ServiceLocatorExtensions
    {
        public static void ForUse<TFor, TUse>(this IServiceLocator serviceLocator)
        {
            var forType = typeof(TFor);
            var useType = typeof(TUse);

            serviceLocator.ForUse(forType, useType);
        }

        public static TService GetInstance<TService>(this IServiceLocator serviceLocator)
            where TService : class
        {
            return serviceLocator.GetInstance(typeof(TService)) as TService;
        }

        public static void InitializeModules(this IServiceLocator serviceLocator)
        {
            var moduleType = typeof(IModuleInitialization);

            var initializators = AppDomain.CurrentDomain.GetAssemblies()
                .ToList()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsAssignableFrom(moduleType));

            var methodName = ReflectionExtensions
                .GetMethodInfo<IModuleInitialization>(m => m.Initialize(null))
                .Name;

            foreach (var initializator in initializators)
            {
                var constructorInfo = initializator.GetConstructor(new Type[0]);
                if (constructorInfo == null)
                {
                    throw new ArgumentException("Module initialization needs to have parameterless constructor.");
                }

                var instance = constructorInfo.Invoke(null);
                    initializator
                        .GetMethod(methodName)
                        .Invoke(instance, new[] { serviceLocator });
            }
        }
    }
}