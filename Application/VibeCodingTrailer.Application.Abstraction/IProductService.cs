using VibeCodingTrailer.Domain;

namespace VibeCodingTrailer.Application.Abstraction;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
}