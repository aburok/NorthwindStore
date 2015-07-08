using System.Collections.Generic;
using Northwind.Data.Queries.Products;
using Northwind.Domain;

namespace Northwind.BusinessLogic.Products
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductList();

        Product GetProductById(string id);

        void Save(Product product);
    }
}
