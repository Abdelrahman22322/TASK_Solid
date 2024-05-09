using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using crud.Data.Config;

using Infra.Entities;
using Microsoft.EntityFrameworkCore;
using ServiceContracts;

namespace Services
{
     public class OrderGetterServices(ApplicationContext context) : IOrderGetterServices
     {
        private readonly ApplicationContext _context = context;

        public async Task<Order> GetOrder(int? id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id cannot be less than or equal to zero", nameof(id));
            }

            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                throw new InvalidOperationException("Order with this id does not exist");
            }

            return order;
        }

        public async Task<List<Order>> GetAllOrders()
        {
           return await _context.Orders.ToListAsync();
        }
    }
}
