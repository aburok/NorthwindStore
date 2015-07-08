using Common.Queries;
using Common.ServiceLocation;
using DataAccess.Queries.RavenDb.Products;
using Northwind.DataAccess.Queries.Products;

namespace DataAccess.Queries.RavenDb
{
    public static class QueryRavenDbInitialization
    {
        public static void Initialize(IServiceLocator serviceLocator)
        {
            serviceLocator.ForUse<
                IQueryHandler<ProductListQuery, ProductListResult>,
                ProductListQueryHandlerRavenDb>();

            serviceLocator.ForUse<
                IQueryHandler<ProductQuery, ProductQueryResult>,
                ProductQueryHandlerRavenDb>();
        }
    }
}
