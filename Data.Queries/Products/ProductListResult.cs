﻿using System.Collections.Generic;
using Common.Queries;
using Northwind.Domain;

namespace Northwind.Data.Queries.Products
{
    public class ProductListResult : CollectionQueryResult<Product>
    {
        public ProductListResult(IEnumerable<Product> items)
        {
            Items = items;
        }
    }
}