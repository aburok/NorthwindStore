using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using NorthwindStore.WebUI.Areas.Administration.Company;
using NorthwindStore.WebUI.Areas.Administration.Home;
using NorthwindStore.WebUI.Areas.Administration.Order;
using NorthwindStore.WebUI.Areas.Administration.Product;

namespace NorthwindStore.WebUI.Areas.Administration
{
    public class AdministrationAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return Name; }
        }

        public static string Name = "Administration";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            var ns = this.GetType().Namespace;

            var namespaces = GetControllersNamespace().ToArray();

            context.MapRoute(
                Name + "_default",
                Name + "/{controller}/{action}/{id}",
                new
                {
                    action = "Index",
                    id = UrlParameter.Optional,
                    area = Name
                },
                namespaces: namespaces);

            Config.BundleConfig.RegisterBundles(BundleTable.Bundles);

        }

        private IEnumerable<string> GetControllersNamespace()
        {
            var @namespace = typeof(AdministrationAreaRegistration).Namespace;

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