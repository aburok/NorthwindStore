using System.Collections.Generic;

namespace DataAccess.Product
{
    public interface IProductRepository
    {
        IEnumerable<Northwind.Domain.Product> GetProductList();

        Northwind.Domain.Product GetProductById(string id);

        void Save(Northwind.Domain.Product product);
    }
}
