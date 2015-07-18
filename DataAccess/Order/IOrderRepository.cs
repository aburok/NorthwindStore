using System.Collections.Generic;

namespace NorthwindStore.DataAccess.Order
{
    public interface IOrderRepository
    {
        NorthwindStore.Domain.Order GetOrder(string id);

        IEnumerable<NorthwindStore.Domain.Order> GetOrderListById(IEnumerable<string> id);

        IEnumerable<NorthwindStore.Domain.Order> GetOrderList();
    }
}