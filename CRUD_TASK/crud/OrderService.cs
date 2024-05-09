using AggregratorContracts.AggregatorServices;
using Infra.Entities;

namespace crud;

public class OrderService(IOrderAggregatorServices orderAggregatorServices)
{
     private readonly IOrderAggregatorServices _orderAggregatorServices = orderAggregatorServices;

     public async Task<Order?> GetOrder(int? id)
     {
         try
         {
             var order = await _orderAggregatorServices.OrderGetterServices.GetOrder(id);
             return order;
         }
         catch (ArgumentNullException ex)
         {
             Console.WriteLine($"Argument error: {ex.Message}");
             throw;
         }
         catch (ArgumentOutOfRangeException ex)
         {
             Console.WriteLine($"Argument out of range error: {ex.Message}");
             throw;
         }
         catch (Exception ex)
         {
              Console.WriteLine($"An error occurred: {ex.Message}");
              throw;
         }
     }

     public async Task<List<Order?>> GetOrders()
     {
         try
         {
             var orders = await _orderAggregatorServices.OrderGetterServices.GetAllOrders();
             return orders;
         }
         catch (ArgumentNullException ex)
         {
             Console.WriteLine($"Argument error: {ex.Message}");
             throw;
         }
         catch (ArgumentOutOfRangeException ex)
         {
             Console.WriteLine($"Argument out of range error: {ex.Message}");
             throw;
         }
         catch (Exception ex)
         {
             Console.WriteLine($"An error occurred: {ex.Message}");
             throw;
         }
     }

     //public async Task<Order?> GetOrderByCustomerId(int? id)
     //{
     //    try
     //    {
     //        var order = await _orderAggregatorServices.OrderGetterServices.GetOrderByCustomerId(id);
     //        return order;
     //    }
     //    catch (ArgumentNullException ex)
     //    {
     //        Console.WriteLine($"Argument error: {ex.Message}");
     //        throw;
     //    }
     //    catch (ArgumentOutOfRangeException ex)
     //    {
     //        Console.WriteLine($"Argument out of range error: {ex.Message}");
     //        throw;
     //    }
     //    catch (Exception ex)
     //    {
     //        Console.WriteLine($"An error occurred: {ex.Message}");
     //        throw;
     //    }
     //}

     public async Task<bool> AddOrder(Order? order)
     {
         try
         {
             var result = await _orderAggregatorServices.OrderAdderServices.AddOrder(order);
             return true;
         }
         catch (ArgumentNullException ex)
         {
             Console.WriteLine($"Argument error: {ex.Message}");
             throw;
         }
         catch (ArgumentOutOfRangeException ex)
         {
             Console.WriteLine($"Argument out of range error: {ex.Message}");
             throw;
         }
         catch (Exception ex)
         {
             Console.WriteLine($"An error occurred: {ex.Message}");
             throw;
         }
     }

     public async Task<bool?> UpdateOrder(Order order)
     {
         try
         {
             var updatedOrder =
                 await _orderAggregatorServices.OrderUpdaterServices.UpdateOrder(order);
             return true;
         }
         catch (ArgumentNullException ex)
         {
             Console.WriteLine($"Argument error: {ex.Message}");
             throw;
         }
         catch (ArgumentOutOfRangeException ex)
         {
             Console.WriteLine($"Argument out of range error: {ex.Message}");
             throw;
         }
         catch (Exception ex)
         {
             Console.WriteLine($"An error occurred: {ex.Message}");
             throw;
         }
     }

     
}