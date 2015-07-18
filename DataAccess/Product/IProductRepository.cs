using System.Collections.Generic;

namespace NorthwindStore.DataAccess.Product
{
    public interface IProductRepository
    {
        IEnumerable<NorthwindStore.Domain.Product> GetProductList();

        NorthwindStore.Domain.Product GetProductById(string id);

        void Save(NorthwindStore.Domain.Product product);
    }
}
