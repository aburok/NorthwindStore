using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using DataAccess.Company;
using Infrastructure.RavenDb;
using Raven.Client;

namespace DataAccess.RavenDb.Company
{
    public class CompanyRepositoryRavenDb : ICompanyRepository
    {
        private readonly IDocumentStoreProvider _documentStoreProvider;

        public CompanyRepositoryRavenDb(IDocumentStoreProvider documentStoreProvider)
        {
            _documentStoreProvider = documentStoreProvider;
        }

        public IEnumerable<Northwind.Domain.Company> GetCompanyCollection()
        {
            var store = _documentStoreProvider.GetDocumentStore();

            using (var session = store.OpenSession())
            {
                var result = session.Query<Northwind.Domain.Company>()
                    .ToList();
                return result;
            }
        }
    }
}