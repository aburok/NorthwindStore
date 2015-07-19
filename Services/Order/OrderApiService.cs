using System.Linq;
using NorthwindStore.BusinessLogic.Commands.Order;
using NorthwindStore.Common.Commands;
using NorthwindStore.DataAccess.Order;
using NorthwindStore.Services.Order.GetOrder;
using NorthwindStore.Services.Order.GetOrderList;
using NorthwindStore.Services.Order.MakeOrder;

namespace NorthwindStore.Services.Order
{
    public class OrderApiService : IOrderApiService
    {
        private readonly ICommandHandler<MakeOrderCommand> _commmHandler;
        private readonly IOrderRepository _repository;

        public OrderApiService(
            ICommandHandler<MakeOrderCommand> commmHandler,
            IOrderRepository repository)
        {
            _commmHandler = commmHandler;
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
            var makeOrderRespone = new MakeOrderRespone();

            //var command = new MakeOrderCommand();
            return makeOrderRespone;
        }

        public GetOrderListResponse GetOrderList(GetOrderListRequest request)
        {
            var orders = _repository.GetOrderList()
                .Select(OrderApiDto.FromDomain)
                .ToList();

            var response = new GetOrderListResponse()
            {
                OrderList = orders
            };

            return response;
        }
    }
}