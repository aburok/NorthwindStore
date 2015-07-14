using System;
using Microsoft.Owin.BuilderProperties;
using TypeLite;

namespace NorthwindStore.WebUI.Areas.Administration.Order
{
    [TsClass(Module = "NorthwindStore.Admin.Order")]
    public class OrderDto
    {
        public string Id { get; set; }

        public string Company { get; set; }

        public DateTime OrderedAt { get; set; }

        public string ShipToCity { get; set; }

        public string ShipToLine1 { get; set; }

        public string ShipToLine2 { get; set; }

        public string Country { get; set; }

        public static OrderDto FromModel(Northwind.Domain.Order order)
        {
            return new OrderDto()
            {
                Id = TranslateIdFromDomain(order.Id),
                Company = order.Company,
                Country = order.ShipTo.Country,
                ShipToLine1 = order.ShipTo.Line1,
                ShipToLine2 = order.ShipTo.Line2,
                OrderedAt = order.OrderedAt
            };
        }

        private static string TranslateIdFromDomain(string id)
        {
            return id.Replace("/", "__");
        }

        public static string TranslateIdFromDto(string id)
        {
            return id.Replace("__", "/");
        }
    }
}