using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DataAccess.Order;
using WebGrease.Css.Extensions;

namespace NorthwindStore.WebUI.Areas.Administration.Order
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return PartialView();
        }

        public ActionResult Details()
        {
            return PartialView();
        }

        [HttpGet]
        public JsonResult GetOrderList()
        {
            var orderList = _orderRepository
                .GetOrders()
                .Select(OrderDto.FromModel);

            return Json(orderList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetOrder(string id)
        {
            var domainId = OrderDto.TranslateIdFromDto(id);
            var order = _orderRepository
                .GetOrder(domainId);

            return Json(OrderDto.FromModel(order), JsonRequestBehavior.AllowGet);
        }
    }
}