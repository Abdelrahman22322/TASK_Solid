
using Infra.Entities;

namespace ServiceContracts;

public interface IProductsDeleterServices
{
    public Task<bool> DeleteProduct(int? product);
}