using System.Security;
using DataAccess.Order;
using Services.Order.GetOrder;
using Services.Order.MakeOrder;

namespace Services.Order
{
    public class OrderApiService : IOrderApiService
    {
        private readonly IOrderRepository _repository;

        public OrderApiService(IOrderRepository repository )
        {
            _repository = repository;
        }

        public GetOrderResponse GetOrder(GetOrderRequest request)
        {
            var order = _repository.GetOrder(request.Id);

            var response = new GetOrderResponse()
            {
                Order = OrderApiDto.FromDomain(order)
            };

            return response;
        }

        public MakeOrderRespone MakeOrder(MakeOrderRequest request)
        {
            var response = new MakeOrderRespone();
            return response;
        }
    }
}