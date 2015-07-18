using System.Collections.Generic;
using NorthwindStore.Common.Queries;
using NorthwindStore.Domain;

namespace NorthwindStore.DataAccess.Queries.Products
{
    public class ProductListResult : CollectionQueryResult<Product>
    {
        public ProductListResult(IEnumerable<Product> items)
        {
            Items = items;
        }
    }
}