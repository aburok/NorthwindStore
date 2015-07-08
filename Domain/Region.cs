using System.Collections.Generic;

namespace Northwind.Domain
{
    public class Region
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<Territory> Territories { get; set; }
    }
}