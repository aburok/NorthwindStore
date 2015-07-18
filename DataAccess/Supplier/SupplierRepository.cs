using System.Collections.Generic;

namespace NorthwindStore.DataAccess.Supplier
{
    public interface ISupplierRepository
    {
        IEnumerable<NorthwindStore.Domain.Supplier> GetSuppliers();
    }
}