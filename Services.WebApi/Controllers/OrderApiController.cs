using System.Web.Http;
using Services.Order;
using Services.Order.GetOrder;
using Services.Order.MakeOrder;

namespace Services.WebApi.Controllers
{
    public class OrderApiController : ApiController
    {
        private readonly IOrderApiService _apiService;

        public OrderApiController(IOrderApiService apiService )
        {
            _apiService = apiService;
        }

        public ActionResult GetOrderList()
        {
            var orderList = _orderRepository.GetOrders()
                .Select(OrderApiDto.FromDomain)
                .ToList();

            return Json(orderList, JsonRequestBehavior.AllowGet);
        }

        public GetOrderResponse GetOrder(GetOrderRequest request)
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