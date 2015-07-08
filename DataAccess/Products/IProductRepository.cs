using System.Collections.Generic;
using Northwind.Domain;

namespace DataAccess.Products
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProductList();

        Product GetProductById(string id);

        void Save(Product product);
    }
}
