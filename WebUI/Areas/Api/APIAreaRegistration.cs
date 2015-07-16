using System.Web.Mvc;
using NorthwindStore.WebUI.Extensions;

namespace NorthwindStore.WebUI.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get { return "Api"; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRouteWithNamespaces<ApiAreaRegistration>(
                AreaName + "_default",
                AreaName + "/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}