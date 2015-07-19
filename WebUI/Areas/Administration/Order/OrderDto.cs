using System;
using Microsoft.Owin.BuilderProperties;
using TypeLite;

namespace NorthwindStore.WebUI.Areas.Administration.Order
{
    [TsClass(Module = "NorthwindStore.Admin.Order")]
    public class OrderDto
    {
        public int Id { get; set; }

        public string Company { get; set; }

        public DateTime OrderedAt { get; set; }

        public string ShipToCity { get; set; }

        public string ShipToLine1 { get; set; }

        public string ShipToLine2 { get; set; }

        public string Country { get; set; }

        public static OrderDto FromModel(Domain.Order order)
        {
            return new OrderDto()
            {
                Id = order.Id,
                Company = order.Company,
                Country = order.ShipTo.Country,
                ShipToLine1 = order.ShipTo.Line1,
                ShipToLine2 = order.ShipTo.Line2,
                OrderedAt = order.OrderedAt
            };
        }
    }
}