using System.Collections.Generic;
using Common.Queries;
using Northwind.DataAccess.Queries.Products;
using Northwind.Domain;

namespace DataAccess.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly IQueryHandler<ProductListQuery, ProductListResult> _queryHandler;
        private readonly IQueryHandler<ProductQuery, ProductQueryResult> _productQueryHandler;

        public ProductRepository(
            IQueryHandler<ProductListQuery, ProductListResult> queryHandler,
            IQueryHandler<ProductQuery, ProductQueryResult> productQueryHandler )
        {
            _queryHandler = queryHandler;
            _productQueryHandler = productQueryHandler;
        }

        public IEnumerable<Product> GetProductList()
        {
            var query = new ProductListQuery();

            var result = _queryHandler.Handle(query);

            return result.Items;
        }

        public Product GetProductById(string id)
        {
            var query = new ProductQuery()
            {
                ID = "products/55"
            };

            var result = _productQueryHandler.Handle(query);

            return result.Data;
        }

        public void Save(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}