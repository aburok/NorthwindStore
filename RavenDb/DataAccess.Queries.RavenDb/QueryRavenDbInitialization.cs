using DataAccess.Queries.RavenDb.Products;
using NorthwindStore.Common.Queries;
using NorthwindStore.Common.ServiceLocation;
using NorthwindStore.DataAccess.Queries.Products;

namespace DataAccess.Queries.RavenDb
{
    public class QueryRavenDbInitialization :IModuleInitialization
    {
        void IModuleInitialization.Initialize(IServiceLocator serviceLocator)
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
