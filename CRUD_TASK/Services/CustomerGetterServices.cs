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
     public class CustomerGetterServices(ApplicationContext context) : ICustomerGetterServices
     {

        private readonly ApplicationContext _context = context;

        public async Task<Customer?> GetCustomer(int? id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            if (id < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id));
            }

            if ( await _context.Customers.FindAsync(id) == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return await _context.Customers.FindAsync(id);
            
        }

        public async Task<List<Customer?>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
