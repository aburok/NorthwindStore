using System.Web.Mvc;
using DataAccess.Products;

namespace NorthwindStore.WebUI.Products
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Product
        public ActionResult Index()
        {
            var data = _productRepository.GetProductList();
            return View(data);
        }
    }
}