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
    public class OrderUpdaterServices(ApplicationContext context) : IOrderUpdaterServices


    {

        private readonly ApplicationContext _context = context;

        public async Task<bool> UpdateOrder(Order order)
        {
            if(order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            if(order.OrderItems != null)
            {
                foreach(var orderItem in order.OrderItems)
                {
                    orderItem.Product = _context.Products.Find(orderItem.ProductId);
                    if(orderItem.Product == null)
                    {
                        throw new ArgumentException($"Product with id {orderItem.ProductId} not found");
                    }
                    else
                    {
                        _context.OrderItems.Update(orderItem);
                        await _context.SaveChangesAsync();
                    }
                }
                
            }
            if (order.OrderItems.Count == 0)
            {
                throw new ArgumentException("Order must have at least one order item");
            }
            if (order.Customer == null)
            {
                throw new ArgumentException("Order must have a customer");
            }
            order.OrderDate = DateTime.Now;
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
            if(order == null)
            {
                return false;
            }
            return true;
        }
    }
}
