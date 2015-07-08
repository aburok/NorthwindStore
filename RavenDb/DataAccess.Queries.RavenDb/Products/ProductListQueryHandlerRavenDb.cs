using System.Linq;
using Common.Queries;
using Infrastructure.RavenDb.Configuration;
using Northwind.DataAccess.Queries.Products;
using Northwind.Domain;
using Raven.Client;

namespace DataAccess.Queries.RavenDb.Products
{
    public class ProductListQueryHandlerRavenDb :
        QueryHandlerRavenDbBase<ProductListQuery, ProductListResult>,
        IQueryHandler<ProductListQuery, ProductListResult>
    {
        public ProductListQueryHandlerRavenDb(IRavenConfiguration configuration)
            : base(configuration)
        {
        }

        public ProductListResult Handle(ProductListQuery tQuery)
        {
            Query = tQuery;
            return ExecuteQuery();
        }

        protected override ProductListResult GetQuery(IDocumentSession session)
        {
            var items = session
                .Query<Product>()
                .ToList();

            return new ProductListResult(items);
        }
    }
}