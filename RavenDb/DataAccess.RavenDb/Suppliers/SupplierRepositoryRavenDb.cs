using System.Collections.Generic;
using System.Linq;
using DataAccess.Supplier;
using Infrastructure.RavenDb;
using Infrastructure.RavenDb.Configuration;
using Raven.Client;
using Raven.Client.Document;

namespace DataAccess.RavenDb.Suppliers
{
    public class SupplierRepositoryRavenDb : ISupplierRepository
    {
        private readonly IDocumentStoreProvider _documentStoreProvider;

        public SupplierRepositoryRavenDb(
           IDocumentStoreProvider documentStoreProvider)
        {
            _documentStoreProvider = documentStoreProvider;
        }

        public IEnumerable<Northwind.Domain.Supplier> GetSuppliers()
        {
            using (IDocumentStore store = _documentStoreProvider.GetDocumentStore())
            {
                using (var session = store.OpenSession())
                {
                    return session.Query<Northwind.Domain.Supplier>()
                        .ToList();
                }
            }
        }
    }
}