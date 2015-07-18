namespace NorthwindStore.Services.Product
{
    public interface IProductApiService
    {
        GetProductResponse GetProduct(GetProductRequest request);
    }

    public class GetProductResponse
    {
    }

    public class ProductApiDto
    {
    }

    public class GetProductRequest
    {
    }
}