using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Northwind.BusinessLogic.Products;
using NorthwindStore.WebUI.Products.ViewModels;

namespace NorthwindStore.WebUI.Products
{
    public class ProductApiController : ApiController
    {
        private readonly IProductRepository _productRepository;

        public ProductApiController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<ProductViewModel> GetProductList()
        {
            var data = _productRepository.GetProductList();

            var viewModel = data
                .Select(ProductViewModel.ToViewModel);

            return viewModel;
        }
    }
}
