namespace Northwind.BusinessLogic.Order
{
    public class OrderManagment : IOrderManagment
    {
        public NorthwindStore.Domain.Order MakeOrder(string[] productIds)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IOrderManagment
    {
        NorthwindStore.Domain.Order MakeOrder(string[] productIds);
    }
}