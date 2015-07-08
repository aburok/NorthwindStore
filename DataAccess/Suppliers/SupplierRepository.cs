using System.Collections.Generic;
using Northwind.Domain;

namespace DataAccess.Suppliers
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
    }
}