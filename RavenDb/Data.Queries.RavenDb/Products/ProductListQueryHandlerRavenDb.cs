using System.Collections.Generic;
using System.Linq;
using Common.Queries;
using Infrastructure.RavenDb.Configuration;
using Northwind.Data.Queries.Products;
using Northwind.Domain;
using Raven.Client;

namespace Data.Queries.RavenDb.Products
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