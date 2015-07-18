namespace Services.Order.MakeOrder
{
    public class MakeOrderRequest
    {
        public string[] ProductIdList { get; set; }

        public string CompanyId { get; set; }
    }
}