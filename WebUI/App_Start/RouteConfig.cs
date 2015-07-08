using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Ajax.Utilities;
using NorthwindStore.WebUI.Areas.Administration.Home;
using NorthwindStore.WebUI.Areas.Administration.Product;

namespace NorthwindStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var ns = typeof (RouteConfig).Namespace;

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional,
                    area = ""
                }
                , namespaces: new[]
                {
                    typeof(HomeController).Namespace,
                    typeof(ProductController).Namespace
                }
            );
        }
    }
}
