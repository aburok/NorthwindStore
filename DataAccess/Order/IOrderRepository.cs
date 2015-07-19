using System.Collections.Generic;
using System.Linq;
using NorthwindStore.Common.Cache;

namespace NorthwindStore.DataAccess.Order
{
    public interface IOrderRepository
    {
        Domain.Order GetOrder(int id);

        IEnumerable<Domain.Order> GetOrderListById(IEnumerable<int> id);

        IEnumerable<Domain.Order> GetOrderList();
    }

    public class OrderRepositoryCacheProxy:IOrderRepository
    {
        private readonly IOrderRepository _innerRepository;
        private readonly ICache _cache;

        public OrderRepositoryCacheProxy(
            IOrderRepository innerRepository,
            ICache cache)
        {
            _innerRepository = innerRepository;
            _cache = cache;
        }

        public Domain.Order GetOrder(int id)
        {
            return _innerRepository.GetOrder(id);
        }

        public IEnumerable<Domain.Order> GetOrderListById(IEnumerable<int> id)
        {
            return _innerRepository.GetOrderListById(id);
        }

        private static readonly string GetOrderListKey = "GetOrderListKey";

        public IEnumerable<Domain.Order> GetOrderList()
        {
            if (_cache.IsInCache(GetOrderListKey))
            {
                return _cache.Get<IEnumerable<Domain.Order>>(GetOrderListKey);
            }

            var fromDataSorce = _innerRepository.GetOrderList().ToList();

            _cache.Put(GetOrderListKey, fromDataSorce);

            return fromDataSorce;
        }
    } 
}