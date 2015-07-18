using System.Collections.Generic;

namespace NorthwindStore.Services.Order.GetOrderList
{
    public class GetOrderListResponse
    {
        public IEnumerable<OrderApiDto> OrderList { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}