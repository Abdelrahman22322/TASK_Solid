
using Infra.Entities;

namespace ServiceContracts;

public interface IOrderAdderServices
{

    public Task<Order> AddOrder(Order order);
    
}