using System.Web.Mvc;
using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.Common.Translations;
using NorthwindStore.WebUI.DependencyResolution;

namespace NorthwindStore.WebUI.Extensions
{
    public static class HtmlExtensions
    {
        public static string Translate(this HtmlHelper htmlHelper, string path)
        {
            var translationService = ServiceLocator.Current.GetInstance<ITranslationService>();

            return translationService.Translate(path);
        }
    }
}