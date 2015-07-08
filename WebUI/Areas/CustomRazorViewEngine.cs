using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace NorthwindStore.WebUI.Areas
{
    public class CustomRazorViewEngine : RazorViewEngine
    {
        public CustomRazorViewEngine()
        {
            var formats = this.ViewLocationFormats.ToList();
            formats.Add("~/{1}/Views/{0}.cshtml");

            this.ViewLocationFormats = formats.ToArray();

            var areaFormats = AreaViewLocationFormats.ToList();
            areaFormats.Add("~/Areas/{2}/{1}/Views/{0}.cshtml");

            this.AreaViewLocationFormats = areaFormats.ToArray();
        }

        public override ViewEngineResult FindView(
            ControllerContext controllerContext,
            string viewName,
            string masterName,
            bool useCache)
        {
            var viewPath = GetViewPath(controllerContext, viewName);
            //if (FileExists(controllerContext, viewPath))
            //{
            //    var view = CreateView(controllerContext, viewPath, "~/Views/Shared/_Layout.cshtml");
            //    return new ViewEngineResult(view, this);
            //}

            return base.FindView(controllerContext, viewName, masterName, useCache);
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