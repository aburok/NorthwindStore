using NorthwindStore.Services.Order.GetOrder;
using NorthwindStore.Services.Order.GetOrderList;
using NorthwindStore.Services.Order.MakeOrder;

namespace NorthwindStore.Services.Order
{
    public interface IOrderApiService
    {
        GetOrderResponse GetOrder(GetOrderRequest request);

        MakeOrderRespone MakeOrder(MakeOrderRequest request);

        GetOrderListResponse GetOrderList(GetOrderListRequest request);
    }
}