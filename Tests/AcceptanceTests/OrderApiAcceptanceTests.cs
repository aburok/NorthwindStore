using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindStore.WebUI.Areas.Api.Order;
using NUnit.Framework;
using RestSharp;

namespace AcceptanceTests
{
    [TestFixture]
    public class OrderApiAcceptanceTests
    {

        [Test]
        public void GetOrders_Test()
        {
            var client = new RestClient("http://localhost:8081/");

            var request = new RestRequest("Api/OrderApi/GetOrderList", Method.GET);

            IRestResponse response = client.Execute(request);

            var content = response.Content;

            var order = client.Execute<List<OrderApiDto>>(request);

            Assert.AreEqual(90, order.Data.Count);
        }
    }
}
