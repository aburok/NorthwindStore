using TypeLite;

namespace NorthwindStore.WebUI.Areas.Administration.Product
{
    [TsClass(Module = "NorthwindStore.Admin.Products")]
    public class ProductDto
    {
        public string Name { get; set; }

        public int Units { get; set; }

        public static ProductDto From(Northwind.Domain.Product product)
        {
            return new ProductDto()
            {
                Name = product.Name,
                Units = product.UnitsInStock
            };
        }

        public Northwind.Domain.Product ToProduct()
        {
            return new Northwind.Domain.Product()
            {
                Name= this.Name,
                UnitsInStock = this.Units
            };
        }
    }
}