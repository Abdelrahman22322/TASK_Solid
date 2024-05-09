
using Infra.Entities;

namespace ServiceContracts;

public interface IProductAddersServices
{
    public Task<Product> AddProduct(Product product);

}