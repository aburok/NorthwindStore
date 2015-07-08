using System.Collections.Generic;
using DataAccess.Suppliers;
using Northwind.Domain;

namespace DataAccess.Queries.RavenDb.Suppliers
{
    public class SupplierRepositoryRavenDb : ISupplierRepository
    {
        public IEnumerable<Supplier> GetSuppliers()
        {
            throw new System.NotImplementedException();
        }
    }
}