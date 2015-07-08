using System.Web.Mvc;
using DataAccess.Suppliers;

namespace NorthwindStore.WebUI.Areas.Administration.Supplier
{
    public class SupplierController:Controller
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetSuppliers()
        {
            var result = _supplierRepository.GetSuppliers();

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}