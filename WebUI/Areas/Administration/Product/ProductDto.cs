using TypeLite;

namespace NorthwindStore.WebUI.Areas.Administration.Product
{
    [TsClass(Module = "NorthwindStore.Admin.Products")]
    public class ProductDto
    {
        public string Name { get; set; }

        public int Units { get; set; }

        public static ProductDto From(Domain.Product product)
        {
            return new ProductDto()
            {
                Name = product.Name,
                Units = product.UnitsInStock
            };
        }

        public Domain.Product ToProduct()
        {
            return new Domain.Product()
            {
                Name= this.Name,
                UnitsInStock = this.Units
            };
        }
    }
}