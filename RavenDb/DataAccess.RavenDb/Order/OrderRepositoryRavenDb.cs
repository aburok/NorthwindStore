using System.Collections.Generic;
using System.Linq;
using DataAccess.Order;
using Infrastructure.RavenDb;

namespace DataAccess.RavenDb.Order
{
    public class OrderRepositoryRavenDb : IOrderRepository
    {
        private readonly IDocumentStoreProvider _documentStoreProvider;

        public OrderRepositoryRavenDb(IDocumentStoreProvider documentStoreProvider)
        {
            _documentStoreProvider = documentStoreProvider;
        }

        public IEnumerable<Northwind.Domain.Order> GetOrders()
        {
            var store = _documentStoreProvider.GetDocumentStore();

            using (var session = store.OpenSession())
            {
                var result = session
                    .Query<Northwind.Domain.Order>()
                    .ToList();
                return result;
            }
        }

        public Northwind.Domain.Order GetOrder(string id)
        {
            var store = _documentStoreProvider.GetDocumentStore();

            using (var session = store.OpenSession())
            {
                var result = session
                    .Load<Northwind.Domain.Order>(id);

                return result;
            }
        }
    }
}