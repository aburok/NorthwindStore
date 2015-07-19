using System;
using System.Collections.Generic;

namespace NorthwindStore.Domain
{
    public class Order
    {
        public int Id { get; set; }

        public string Company { get; set; }

        public string Employee { get; set; }

        public DateTime OrderedAt { get; set; }

        public DateTime RequireAt { get; set; }

        public DateTime? ShippedAt { get; set; }

        public Address ShipTo { get; set; }

        public string ShipVia { get; set; }

        public decimal Freight { get; set; }

        public List<OrderLine> Lines { get; set; }
    }
}