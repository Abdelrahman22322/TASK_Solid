
using Infra.Entities;

namespace ServiceContracts;

public interface IOrderGetterServices
{
    public Task<Order> GetOrder(int? id);
    public Task<List<Order>> GetAllOrders();

}