
using Infra.Entities;

namespace ServiceContracts;

public interface ICustomerUpdaterServices
{
    public Task<bool> UpdateCustomer(Customer customer);
}