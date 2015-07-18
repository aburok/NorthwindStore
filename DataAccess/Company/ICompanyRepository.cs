using System.Collections.Generic;

namespace NorthwindStore.DataAccess.Company
{
    public interface ICompanyRepository
    {
        IEnumerable<NorthwindStore.Domain.Company> GetCompanyCollection();
    }
}