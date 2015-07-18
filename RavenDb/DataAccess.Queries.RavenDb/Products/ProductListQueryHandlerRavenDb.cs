using System.Linq;
using NorthwindStore.Common.Queries;
using NorthwindStore.DataAccess.Queries.Products;
using NorthwindStore.Infrastructure.RavenDb.Configuration;
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
                .Query<NorthwindStore.Domain.Product>()
                .ToList();

            return new ProductListResult(items);
        }
    }
}