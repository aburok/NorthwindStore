using System.Collections.Generic;

namespace DataAccess.Order
{
    public interface IOrderRepository
    {
        IEnumerable<Northwind.Domain.Order> GetOrders();

        Northwind.Domain.Order GetOrder(string id);
    }
}