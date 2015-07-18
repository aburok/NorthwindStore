using System.Collections.Generic;
using System.Linq;
using NorthwindStore.DataAccess.Supplier;
using NorthwindStore.Infrastructure.RavenDb;
using Raven.Client;

namespace NorthwindStore.DataAccess.RavenDb.Suppliers
{
    public class SupplierRepositoryRavenDb : ISupplierRepository
    {
        private readonly IDocumentStoreProvider _documentStoreProvider;

        public SupplierRepositoryRavenDb(
           IDocumentStoreProvider documentStoreProvider)
        {
            _documentStoreProvider = documentStoreProvider;
        }

        public IEnumerable<NorthwindStore.Domain.Supplier> GetSuppliers()
        {
            using (IDocumentStore store = _documentStoreProvider.GetDocumentStore())
            {
                using (var session = store.OpenSession())
                {
                    return session.Query<NorthwindStore.Domain.Supplier>()
                        .ToList();
                }
            }
        }
    }
}