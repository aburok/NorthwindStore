using System;
using System.Linq;
using System.Web.Mvc;
using DataAccess.Order;

namespace NorthwindStore.WebUI.Areas.Api.Order
{
    public class OrderApiController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderApiController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public JsonResult GetOrderList()
        {
            var orderList = _orderRepository.GetOrders()
                .Select(OrderApiDto.FromDomain)
                .ToList();

            return Json(orderList, JsonRequestBehavior.AllowGet);
        }
    }

    [Serializable]
    public class OrderApiDto
    {
        public string Id { get; set; }

        public DateTime OrderedAt { get; set; }


        public static OrderApiDto FromDomain(Northwind.Domain.Order order)
        {
            return new OrderApiDto()
            {
                Id = order.Id,
                OrderedAt = order.OrderedAt
            };
        }
    }
}