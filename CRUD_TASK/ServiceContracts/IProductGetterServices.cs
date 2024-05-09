
using Infra.Entities;

namespace ServiceContracts;

public interface IProductGetterServices
{
    public Task<Product> GetProduct(int? id);
    public Task<List<Product>> GetAllProducts();
}