using NorthwindStore.Domain;

namespace NorthwindStore.WebUI.Products.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }

        public decimal PricePerUnit { get; set; }

        public int UnitsInStock { get; set; }

        public string SupplierName { get; set; }

        public static ProductViewModel ToViewModel(Product product)
        {
            return new ProductViewModel()
            {
                Name = product.Name,
                PricePerUnit = product.PricePerUnit,
                UnitsInStock = product.UnitsInStock,
                SupplierName = product.Supplier
            };
        }
    }
}