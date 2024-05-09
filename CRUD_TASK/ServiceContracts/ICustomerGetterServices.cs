
using Infra.Entities;

namespace ServiceContracts;

public interface ICustomerGetterServices
{
    public Task<Customer?> GetCustomer(int? id);
    public Task<List<Customer?>> GetAll();
}