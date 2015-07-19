using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindStore.Services.Order.GetOrderList;
using NUnit.Framework;
using RestSharp;

namespace AcceptanceTests
{
    [TestFixture()]
    public class OrderApiAcceptanceTests
    {
        [Test]
        public void GetOrders_Test()
        {
            var client = new RestClient("http://localhost:8082/");

            var request = new RestRequest("Api/OrderApi/GetOrderList", Method.GET);

            IRestResponse response = client.Execute(request);

            var content = response.Content;

            var order = client.Execute<GetOrderListResponse>(request);

            Assert.AreEqual(128, order.Data.OrderList.Count());
        }

        [Test]
        public void GetOrder_Test()
        {
            var client = new RestClient("http://localhost:8082/");

            var request = new RestRequest("Api/OrderApi/GetOrder", Method.GET);

            IRestResponse response = client.Execute(request);

            var content = response.Content;

            var order = client.Execute<GetOrderListResponse>(request);

            Assert.AreEqual(128, order.Data.OrderList.Count());
        }
    }
}
