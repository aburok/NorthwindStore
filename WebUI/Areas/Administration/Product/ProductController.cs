using System.Linq;
using System.Web.Mvc;
using NorthwindStore.DataAccess.Product;

namespace NorthwindStore.WebUI.Areas.Administration.Product
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        #region API

    
        [HttpGet]
        public ActionResult GetProducts()
        {
            var data = _productRepository
                .GetProductList()
                .Select(ProductDto.From)
                .ToArray();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetById(string id)
        {
            var data = _productRepository
                .GetProductById(id);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpPut]
        public ActionResult Add(ProductDto productDto)
        {
            _productRepository.Save(productDto.ToProduct());

            return new EmptyResult();
        }

        #endregion
    }
}