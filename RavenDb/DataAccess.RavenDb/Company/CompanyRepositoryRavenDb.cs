using System.Collections.Generic;
using System.Linq;
using NorthwindStore.DataAccess.Company;
using NorthwindStore.Infrastructure.RavenDb;

namespace NorthwindStore.DataAccess.RavenDb.Company
{
    public class CompanyRepositoryRavenDb : ICompanyRepository
    {
        private readonly IDocumentStoreProvider _documentStoreProvider;

        public CompanyRepositoryRavenDb(IDocumentStoreProvider documentStoreProvider)
        {
            _documentStoreProvider = documentStoreProvider;
        }

        public IEnumerable<NorthwindStore.Domain.Company> GetCompanyCollection()
        {
            var store = _documentStoreProvider.GetDocumentStore();

            using (var session = store.OpenSession())
            {
                var result = session.Query<NorthwindStore.Domain.Company>()
                    .ToList();
                return result;
            }
        }
    }
}