using System.Collections.Generic;

namespace DataAccess.Company
{
    using Northwind.Domain;

    public interface ICompanyRepository
    {
        IEnumerable<Company> GetCompanyCollection();
    }
}