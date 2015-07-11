using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using NorthwindStore.WebUI.Areas.Administration.Company;
using NorthwindStore.WebUI.Areas.Administration.Product;
using NorthwindStore.WebUI.Controllers;

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

            context.MapRoute(
                Name + "_default",
                Name + "/{controller}/{action}/{id}",
                new
                {
                    action = "Index",
                    id = UrlParameter.Optional,
                    area = Name
                },
                namespaces: new[] { 
                    typeof(HomeController).Namespace,
                    typeof(ProductController).Namespace,
                    typeof(CompanyController).Namespace
                }
            );

            Config.BundleConfig.RegisterBundles(BundleTable.Bundles);

            //GlobalConfiguration.Configure(ConfigureHttpRoutes);
        }

        //private void ConfigureHttpRoutes(HttpConfiguration c)
        //{
        //    c.Routes.MapHttpRoute(
        //        "Administration_API",
        //        "Administration/api/{controller}/{id}",
        //        new { id = UrlParameter.Optional });
        //}
    }
}