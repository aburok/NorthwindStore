using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.Initialization;
using Common.Queries;
using Common.ServiceLocation;
using Data.Queries.RavenDb.Products;
using Northwind.Data.Queries.Products;

namespace Data.Queries.RavenDb
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
