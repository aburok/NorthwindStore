using System.Collections.Generic;

namespace DataAccess.Supplier
{
    public interface ISupplierRepository
    {
        IEnumerable<Northwind.Domain.Supplier> GetSuppliers();
    }
}