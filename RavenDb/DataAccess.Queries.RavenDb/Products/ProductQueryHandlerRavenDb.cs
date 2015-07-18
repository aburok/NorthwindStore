using System.Collections.Generic;
using System.Linq;
using NorthwindStore.Common.Queries;
using NorthwindStore.DataAccess.Queries.Products;
using NorthwindStore.Infrastructure.RavenDb.Configuration;
using Raven.Client;

namespace DataAccess.Queries.RavenDb.Products
{
    public class ProductQueryHandlerRavenDb :
        QueryHandlerRavenDbBase<ProductQuery, ProductQueryResult>,
    IQueryHandler<ProductQuery, ProductQueryResult>
    {
        public ProductQueryResult Handle(ProductQuery tQuery)
        {
            Query = tQuery;
            return ExecuteQuery();
        }

        public ProductQueryHandlerRavenDb(IRavenConfiguration configuration) : base(configuration)
        {
        }

        protected override ProductQueryResult GetQuery(IDocumentSession session)
        {
            var item = session
                .Load<NorthwindStore.Domain.Product>(new List<string> {Query.ID})
                .FirstOrDefault();

            return new ProductQueryResult()
            {
                Data = item
            };
        }
    }
}