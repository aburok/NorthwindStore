using System;

namespace NorthwindStore.Services.Order
{
    public class OrderApiDto
    {
        public OrderApiDto()
        { }

        public int Id { get; set; }

        public DateTime OrderedAt { get; set; }


        public static OrderApiDto FromDomain(Domain.Order order)
        {
            return new OrderApiDto()
            {
                Id = order.Id,
                OrderedAt = order.OrderedAt
            };
        }
    }
}