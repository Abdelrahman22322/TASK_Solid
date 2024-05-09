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
   public class CustomerUpdaterServices(ApplicationContext context) : ICustomerUpdaterServices
   {
        private readonly ApplicationContext _context = context;

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            if (customer.Id == 0)
            {
                throw new ArgumentException("Customer Id cannot be 0");
            }

            if (string.IsNullOrEmpty(customer.Name))
            {
                throw new ArgumentException("Customer Name cannot be null or empty");
            }

            if (string.IsNullOrEmpty(customer.Email))
            {
                throw new ArgumentException("Customer Email cannot be null or empty");
            }

            if (_context.Customers.Any(c => c.Id == customer.Id))
            {
                _context.Customers.Update(customer);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                throw new ArgumentException("Customer does not exist");
            }
        }
    }
}
