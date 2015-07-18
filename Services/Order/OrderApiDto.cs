using System;

namespace Services.Order
{
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