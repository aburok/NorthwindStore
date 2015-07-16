using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;

namespace NorthwindStore.WebUI.Extensions
{
    public static class AreaRegistrationContextExtensions
    {
        public static void MapRouteWithNamespaces<TRootType>(this AreaRegistrationContext context,
            string routeName,
            string format,
            object defaults)
            where TRootType : class 
        {
            var namespaces = GetControllersNamespace<TRootType>().ToArray();
            context.MapRoute(routeName, format, defaults, namespaces);
        }

        private static IEnumerable<string> GetControllersNamespace<TRootType>()
        {
            var type = typeof (TRootType);
            var @namespace = type.Namespace;

            var q = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass
                    && t.Namespace != null
                    && t.Namespace.StartsWith(@namespace)
                    && typeof(Controller).IsAssignableFrom(t))
                .Select(c => c.Namespace)
                .ToList();
            return q;
        }
    }
}