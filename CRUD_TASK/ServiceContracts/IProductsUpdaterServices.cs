
using Infra.Entities;

namespace ServiceContracts;

public interface IProductsUpdaterServices
{
    public Task<Product> UpdateProduct(Product product);
}