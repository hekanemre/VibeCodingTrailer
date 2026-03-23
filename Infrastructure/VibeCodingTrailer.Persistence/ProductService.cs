using VibeCodingTrailer.Application.Abstraction;
using VibeCodingTrailer.Domain;

namespace VibeCodingTrailer.Persistence;

public class ProductService : IProductService
{
    public IEnumerable<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product(Guid.NewGuid(), "Product A", 9.99m),
            new Product(Guid.NewGuid(), "Product B", 19.99m),
            new Product(Guid.NewGuid(), "Product C", 29.99m),
        };
    }
}