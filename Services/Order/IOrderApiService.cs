using Services.Order.GetOrder;
using Services.Order.MakeOrder;

namespace Services.Order
{
    public interface IOrderApiService
    {
        GetOrderResponse GetOrder(GetOrderRequest request);

        MakeOrderRespone MakeOrder(MakeOrderRequest request);
    }
}