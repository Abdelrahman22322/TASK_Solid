
using Infra.Entities;

namespace ServiceContracts;

public interface ICustomerAdderServices
{
    public Task<Customer?> AddCustomer(Customer? customer);
}