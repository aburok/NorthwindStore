using System.Linq;
using System.Web.Mvc;

namespace NorthwindStore.WebUI.RazorEngine
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public CustomRazorViewEngine()
        {
            var formats = this.ViewLocationFormats.ToList();
            formats.Add("~/{1}/Views/{0}.cshtml");
            this.ViewLocationFormats = formats.ToArray();

            var partials = this.PartialViewLocationFormats.ToList();
            partials.Add("~/{1}/Views/{0}.cshtml");
            partials.Add("~/{1}/Views/Partial/{0}.cshtml");
            this.PartialViewLocationFormats = partials.ToArray();


            var areaPartials = this.AreaPartialViewLocationFormats.ToList();
            areaPartials.Add("~/Areas/{2}/{1}/Views/{0}.cshtml");
            areaPartials.Add("~/Areas/{2}/{1}/Views/Partials/{0}.cshtml");
            this.AreaPartialViewLocationFormats = areaPartials.ToArray();

            var areaFormats = AreaViewLocationFormats.ToList();
            areaFormats.Add("~/Areas/{2}/{1}/Views/{0}.cshtml");
            this.AreaViewLocationFormats = areaFormats.ToArray();
        }

        private static string GetViewPath(ControllerContext controllerContext, string viewName)
        {
            var controllerType = controllerContext.Controller.GetType();

            var fullName = controllerType.FullName;
            var name = controllerType.Name;
            var assemblyName = controllerType.Assembly.GetName().Name;

            var controllerPath = fullName
                .Replace(name, "")
                .Replace(assemblyName, "")
                .Trim('.')
                .Replace(".", "/");

            var viewPath = string.Format("~/{0}/Views/{1}.cshtml", controllerPath, viewName);
            return viewPath;
        }

        public static void Register()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomRazorViewEngine());
        }
    }

}