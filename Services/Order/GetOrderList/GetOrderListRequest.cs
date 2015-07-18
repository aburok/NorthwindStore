namespace NorthwindStore.Services.Order.GetOrderList
{
    public class GetOrderListRequest
    {
        public string[] IdList { get; set; }

        public int Page { get; set; }

        public int PageSize { get; set; }
    }
}