using System.Web.Http;
using NorthwindStore.Services.Order;
using NorthwindStore.Services.Order.GetOrder;
using NorthwindStore.Services.Order.GetOrderList;
using NorthwindStore.Services.Order.MakeOrder;

namespace NorthwindStore.Services.WebApi.Controllers
{
    public class OrderApiController : ApiController
    {
        private readonly IOrderApiService _apiService;

        public OrderApiController(IOrderApiService apiService)
        {
            _apiService = apiService;
        }

        public GetOrderListResponse GetOrderList(GetOrderListRequest request)
        {
            return _apiService.GetOrderList(request);
        }

        public GetOrderResponse GetOrder([FromUri] GetOrderRequest request)
        {
            return _apiService.GetOrder(request);
        }

        public MakeOrderRespone MakeOrder(MakeOrderRequest request)
        {
            var response = _apiService.MakeOrder(request);
            return response;
        }
    }
}