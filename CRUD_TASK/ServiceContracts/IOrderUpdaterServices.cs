
using Infra.Entities;

namespace ServiceContracts;

public interface IOrderUpdaterServices
{
    public Task<bool> UpdateOrder(Order order);

}