using System.Web.Mvc;
using System.Web.Optimization;
using NorthwindStore.WebUI.Extensions;

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
            context.MapRouteWithNamespaces<AdministrationAreaRegistration>(
                Name + "_default",
                Name + "/{controller}/{action}/{id}",
                new
                {
                    action = "Index",
                    id = UrlParameter.Optional,
                });

            Config.BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}