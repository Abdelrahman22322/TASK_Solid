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
     public class CustomerAdderServices(ApplicationContext context) : ICustomerAdderServices
     {
         private readonly ApplicationContext _context = context;

         public async Task<Customer?> AddCustomer(Customer? customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            if (string.IsNullOrWhiteSpace(customer.Name))
            {
                throw new ArgumentException("Customer name cannot be empty", nameof(customer.Name));
            }

            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                throw new ArgumentException("Customer email cannot be empty", nameof(customer.Email));
            }

            if (_context.Customers.Any(c => c != null && c.Email == customer.Email))
            {
                throw new InvalidOperationException("Customer with this email already exists");
            }

            await _context.Customers.AddAsync(customer);
            return customer;


        }

    }
}
