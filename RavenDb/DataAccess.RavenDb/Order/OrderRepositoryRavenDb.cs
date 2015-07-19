using System.Collections.Generic;
using System.Linq;
using NorthwindStore.DataAccess.Order;
using NorthwindStore.Infrastructure.RavenDb;

namespace NorthwindStore.DataAccess.RavenDb.Order
{
    public class OrderRepositoryRavenDb : IOrderRepository
    {
        private readonly IDocumentStoreProvider _documentStoreProvider;

        public OrderRepositoryRavenDb(IDocumentStoreProvider documentStoreProvider)
        {
            _documentStoreProvider = documentStoreProvider;
        }

        public IEnumerable<Domain.Order> GetOrderListById(IEnumerable<int> id)
        {
            var store = _documentStoreProvider.GetDocumentStore();

            using (var session = store.OpenSession())
            {
                IQueryable<Domain.Order> query = session
                    .Query<Domain.Order>();

                if (id != null && id.Any())
                {
                    query = query.Where(o => id.Contains(o.Id));
                }

                var result = query.ToList();
                return result;
            }
        }

        public IEnumerable<Domain.Order> GetOrderList()
        {
            return GetOrderListById(null);
        }

        public Domain.Order GetOrder(int id)
        {
            var store = _documentStoreProvider.GetDocumentStore();

            using (var session = store.OpenSession())
            {
                var result = session
                    .Load<Domain.Order>(id);

                return result;
            }
        }
    }
}