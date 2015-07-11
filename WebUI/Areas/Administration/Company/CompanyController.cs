using System.Web.Mvc;
using DataAccess.Company;

namespace NorthwindStore.WebUI.Areas.Administration.Company
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetCompanyList()
        {
            var result = _companyRepository.GetCompanyCollection();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}