using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud.Data.Config;

using Infra.Entities;
using ServiceContracts;

namespace Services
{
    public class OrderAdderServices(ApplicationContext context) : IOrderAdderServices
    {
        private readonly ApplicationContext _context = context;

        public async Task<Order> AddOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            order.OrderDate = DateTime.Now;

            if (order.OrderItems != null)
            {
                foreach (var orderItem in order.OrderItems)
                {
                    orderItem.Product = _context.Products.Find(orderItem.ProductId);
                    if (orderItem.Product == null)
                    {
                        throw new ArgumentException($"Product with id {orderItem.ProductId} not found");
                    }
                    else
                    {
                       await _context.OrderItems.AddAsync(orderItem);
                       await _context.SaveChangesAsync();
                    }
                    
                }
            }
                  var orders = _context.Orders.Add(order);
                 await _context.SaveChangesAsync();
                 return orders.Entity;



        }
    }
}
     