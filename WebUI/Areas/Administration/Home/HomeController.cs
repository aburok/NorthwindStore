using System.Web.Mvc;

namespace NorthwindStore.WebUI.Areas.Administration.Home
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}