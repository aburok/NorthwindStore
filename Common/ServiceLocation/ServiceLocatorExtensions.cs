using System;
using System.Collections.Generic;
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

        [Obsolete("This method cannot be used. Some projects are not explicite referenced be the project (WebApi).The dll's are not loaded into AppDomain. ModuleInitializators for this dll's are not loaded.", true)]
        public static void InitializeModules(this IServiceLocator serviceLocator)
        {
            var methodName = GetMethodName();

            var types = GetAllOfType<IModuleInitialization>();

            foreach (var initializator in types)
            {
                InitClassAndExecuteMethod(serviceLocator, initializator, methodName);
            }
        }

        private static string GetMethodName()
        {
            // TODO : this doesnt work should try to find another way.
            //var methodName = ReflectionExtensions
            //    .GetMethodInfo<IModuleInitialization>(m => m.Initialize(null))
            //    .Name;
            return "Initialize";
        }

        private static void InitClassAndExecuteMethod(IServiceLocator serviceLocator, Type @type, string methodName)
        {
            var constructorInfo = type.GetConstructor(new Type[0]);

            if (constructorInfo == null)
            {
                throw new ArgumentException("Module initialization needs to have parameterless constructor.");
            }

            var instance = constructorInfo.Invoke(null);
            var method = type.GetMethod(methodName);

            if (method != null)
            {
                method.Invoke(instance, new[] { serviceLocator });
            }
        }

        public static IEnumerable<Type> GetAllOfType<T>()
        {
            var moduleType = typeof(IModuleInitialization);

            return GetAllOfType(t =>
                t.IsInterface == false
                && moduleType.IsAssignableFrom(t));
        }

        public static IEnumerable<Type> GetAllOfType(Func<Type, bool> predicate)
        {
            var initializators = AppDomain.CurrentDomain.GetAssemblies()
                .ToList()
                .SelectMany(a => a.GetTypes())
                .Where(predicate);

            return initializators;
        }
    }
}