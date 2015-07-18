using NorthwindStore.BusinessLogic.Commands.Order;
using NorthwindStore.Common.Commands;
using NorthwindStore.Services.Order.GetOrder;
using NorthwindStore.Services.Order.GetOrderList;
using NorthwindStore.Services.Order.MakeOrder;

namespace NorthwindStore.Services.Order
{
    public class OrderApiService : IOrderApiService
    {
        private readonly ICommandHandler<MakeOrderCommand> _commmHandler;

        public OrderApiService(
            ICommandHandler<MakeOrderCommand>  commmHandler)
        {
            _commmHandler = commmHandler;
        }

        public GetOrderResponse GetOrder(GetOrderRequest request)
        {
            //var order = _repository.GetOrder(request.Id);
            var order = new Domain.Order();

            var response = new GetOrderResponse()
            {
                Order = OrderApiDto.FromDomain(order)
            };

            return response;
        }

        public MakeOrderRespone MakeOrder(MakeOrderRequest request)
        {
            var makeOrderRespone = new MakeOrderRespone();

            var command = new MakeOrderCommand();
            return makeOrderRespone;
        }

        public GetOrderListResponse GetOrderList(GetOrderListRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}