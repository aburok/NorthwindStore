using System.Collections.Generic;
using System.Linq;
using Common.Queries;
using Infrastructure.RavenDb.Configuration;
using Northwind.DataAccess.Queries.Products;
using Northwind.Domain;
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
                .Load<Northwind.Domain.Product>(new List<string> {Query.ID})
                .FirstOrDefault();

            return new ProductQueryResult()
            {
                Data = item
            };
        }
    }
}